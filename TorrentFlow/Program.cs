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
        private static System.Threading.Timer timer;
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

        public static void Initialize()
        {
            ftp = new FTPClient(Properties.Settings.Default.FTPAddress, Properties.Settings.Default.FTPUsername, StringCipher.Decrypt(Properties.Settings.Default.FTPPassword, "TorrentFlow"));

            if (!Utilites.IsNullOrEmpty(Properties.Settings.Default.WatchDirectory)){
                var directoryWatcher = new DirectoryWatcher(Properties.Settings.Default.WatchDirectory, NewTorrentFileDetected, NotifyFilters.FileName | NotifyFilters.LastWrite);
                directoryWatcher.SetFilter("*.torrent");
                directoryWatcher.Start();
            } else {
                pi.Notify("Not Watching", "TorrentFlow is not watching for torrent files.", 5000);
            }


            if (!Utilites.IsNullOrEmpty(Properties.Settings.Default.DownloadDirectory))
            {
                timer = new System.Threading.Timer((e) =>
                {
                    DownloadNewFiles();
                }, null, new TimeSpan(0, 2, 0), new TimeSpan(0, 5, 0));
            } else {
                pi.Notify("Not Downloading", "Torrentflow will not download any files.", 5000);
            }
        }

        private static void DownloadNewFiles()
        {
            var downloadSuccess = ftp.DownloadContents(Properties.Settings.Default.FTPDownloadPath, Properties.Settings.Default.DownloadDirectory);
            if (downloadSuccess)
            {
                if (Properties.Settings.Default.FTPDeleteAfterDL)
                {
                    ftp.DeleteContents(Properties.Settings.Default.FTPDownloadPath);
                }
            }
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
