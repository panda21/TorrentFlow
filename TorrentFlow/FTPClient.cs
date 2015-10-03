using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TorrentFlow
{
    class FTPClient
    {
        private string address;
        private ICredentials credentials;
        public FTPClient(string address, string username, string password)
        {
            if (address.EndsWith("/"))
            {
                address = address.Substring(0, address.Length - 1);
            }
            this.address = address;
            credentials = new NetworkCredential(username, password);
        }
        public bool UploadFile(string filePath, string destinationDirectory)
        {
                try
                {
                    var fileInfo = new FileInfo(filePath);
                    using (var client = new WebClient())
                    {
                        client.Credentials = credentials;
                        var ftpAddress = String.Format("ftp://{0}/{1}/{2}", address, destinationDirectory, fileInfo.Name);
                        client.UploadFile(ftpAddress, fileInfo.FullName);
                    }
                }
                catch (Exception e)
                {
                    //TODO log this
                    return false;
                }

            return true;
        }

        private bool DownloadFile(string filePath, string localDirectory)
        {
            try
            {
                var fileName = filePath.Substring(filePath.LastIndexOf("/") + 1);
                using (var client = new WebClient())
                {
                    client.Credentials = credentials;
                    var ftpAddress = String.Format("ftp://{0}/{1}", address, filePath);
                    client.DownloadFile(ftpAddress, localDirectory + "/" + fileName);
                }
            }
            catch (Exception e)
            {
                //TODO log this
                return false;
            }

            return true;
        }

        public void DownloadContents(string ftpDirectory, string localDirectory)
        {
            var request = (FtpWebRequest)WebRequest.Create(String.Format("ftp://{0}/{1}", address, ftpDirectory));
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            request.Credentials = credentials;

            var response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            var responseString = reader.ReadToEnd();

            reader.Close();
            response.Close();

            if (responseString != "")
            {
                var fileStrings = Regex.Split(responseString, "\r\n");
                foreach (var fileString in fileStrings)
                {
                    if (!Utilites.IsNullOrEmpty(fileString))
                    {
                        var file = Utilites.GetFileNameFromUnixFormat(fileString);
                        if (file.isDirectory)
                        {
                            var newDirectory = Directory.CreateDirectory(localDirectory + "/" + file.filename);
                            DownloadContents(ftpDirectory + "/" + file.filename, newDirectory.FullName);
                        }
                        else
                        {
                            DownloadFile(ftpDirectory + "/" + file.filename, localDirectory);
                        }
                    }
                }
            }
        }
    }
}
