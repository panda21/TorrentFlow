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
        public void Upload()
        {
            using (WebClient client = new WebClient())
            {
                client.Credentials = new NetworkCredential("DildoMachine", "");
            }
        }
    }
}
