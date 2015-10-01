using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
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
                    using (WebClient client = new WebClient())
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
    }
}
