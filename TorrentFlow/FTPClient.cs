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

        public bool DownloadContents(string ftpDirectory, string localDirectory)
        {
            var success = true;
            var responseString = SendFTPRequest(ftpDirectory, WebRequestMethods.Ftp.ListDirectoryDetails);

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
                            var result = DownloadContents(ftpDirectory + "/" + file.filename, newDirectory.FullName);
                            success = success && result;
                        }
                        else
                        {
                            var result = DownloadFile(ftpDirectory + "/" + file.filename, localDirectory);
                            success = success && result;
                        }
                    }
                }
            }

            return success;
        }

        public bool DeleteContents(string ftpDirectory)
        {
            var success = true;

            var responseString = SendFTPRequest(ftpDirectory, WebRequestMethods.Ftp.ListDirectoryDetails);
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
                            var result = DeleteDirectory(ftpDirectory + "/" + file.filename);
                            success = success && result;
                        }
                        else
                        {
                            var result = DeleteFile(ftpDirectory + "/" + file.filename);
                            success = success && result;
                        }
                    }
                }
            }

            return success;
        }

        private bool DownloadFile(string filePath, string localDirectory)
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
            }
            catch (Exception e)
            {
                //TODO log this
                return false;
            }

            return true;
        }

        private bool DeleteFile(string filePath)
        {
            try
            {
                SendFTPRequest(filePath, WebRequestMethods.Ftp.DeleteFile);
            }
            catch (Exception ex)
            {
                //TODO log this
                return false;
            }

            return true;
        }

        private bool DeleteDirectory(string directoryPath)
        {
            try
            {
                SendFTPRequest(directoryPath, WebRequestMethods.Ftp.RemoveDirectory);
            }
            catch (Exception ex)
            {
                //TODO log this
                return false;
            }

            return true;
        }

        private string SendFTPRequest(string path, string method)
        {
            var ftpAddress = String.Format("ftp://{0}/{1}", address, path);

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpAddress);
            request.Method = method;

            request.Credentials = credentials;

            var response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            var responseString = reader.ReadToEnd();

            reader.Close();
            response.Close();

            return responseString;
        }
    }
}
