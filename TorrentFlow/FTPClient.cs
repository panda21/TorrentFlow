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

        private bool DownloadFile(string filePath, string localDirectory, bool deleteOriginal)
        {
            try
            {
                var fileName = filePath.Substring(filePath.LastIndexOf("/") + 1);
                var ftpAddress = String.Format("ftp://{0}/{1}", address, filePath);
                using (var client = new WebClient())
                {
                    client.Credentials = credentials;
                    client.DownloadFile(ftpAddress, localDirectory + "/" + fileName);
                }

                if (deleteOriginal)
                {
                    DeleteFile(filePath);
                }
            }
            catch (Exception e)
            {
                //TODO log this
                return false;
            }

            return true;
        }

        private void DeleteFile(string filePath)
        {
            var ftpAddress = String.Format("ftp://{0}/{1}", address, filePath);

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpAddress);
            request.Method = WebRequestMethods.Ftp.DeleteFile;

            request.Credentials = credentials;

            var response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            var responseString = reader.ReadToEnd();

            reader.Close();
            response.Close();
        }

        private void DeleteDirectory(string directoryPath)
        {
            var ftpAddress = String.Format("ftp://{0}/{1}", address, directoryPath);

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpAddress);
            request.Method = WebRequestMethods.Ftp.RemoveDirectory;

            request.Credentials = credentials;

            var response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            var responseString = reader.ReadToEnd();

            reader.Close();
            response.Close();
        }

        public void DownloadContents(string ftpDirectory, string localDirectory, bool deleteOriginal)
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
                            DownloadContents(ftpDirectory + "/" + file.filename, newDirectory.FullName, deleteOriginal);
                            
                            if (deleteOriginal)
                            {
                                DeleteDirectory(ftpDirectory + "/" + file.filename);
                            }
                        }
                        else
                        {
                            DownloadFile(ftpDirectory + "/" + file.filename, localDirectory, deleteOriginal);
                        }
                    }
                }
            }
        }
    }
}
