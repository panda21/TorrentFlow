using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace TorrentFlow
{
    static class Program
    {
        private static FTPClient ftp;
        private static ProcessIcon pi;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (pi = new ProcessIcon("TorrentFlow"))
            {
                Initialize();
                pi.Display();
                Application.Run();
            }
        }

        private static void Initialize()
        {
            ftp = new FTPClient(Properties.Settings.Default.FTPAddress, Properties.Settings.Default.FTPUsername, StringCipher.Decrypt(Properties.Settings.Default.FTPPassword, "TorrentFlow"));

            var directoryWatcher = new DirectoryWatcher(Properties.Settings.Default.WatchDirectory, NewTorrentFileDetected, NotifyFilters.FileName | NotifyFilters.LastWrite);
            directoryWatcher.SetFilter("*.torrent");
            directoryWatcher.Start();
        }

        private static void NewTorrentFileDetected(object source, FileSystemEventArgs e)
        {
            if (!(Utilites.IsNullOrEmpty(Properties.Settings.Default.FTPUploadPath) ||
                Utilites.IsNullOrEmpty(Properties.Settings.Default.FTPAddress) ||
                Utilites.IsNullOrEmpty(Properties.Settings.Default.FTPUsername)))
            {

                if (ftp.UploadFile(e.FullPath, Properties.Settings.Default.FTPUploadPath))
                {
                    pi.Notify("Upload Success", e.Name + " was uploaded successfully.", 1000);
                }
                else
                {
                    pi.Notify("Upload Failed", e.Name + " failed to upload.", 3000);
                }
            }
            else
            {
                pi.Notify("Upload Failed", "Please enter upload settings in the TorrentFlow settings.", 5000);
            }
        }
    }
}
