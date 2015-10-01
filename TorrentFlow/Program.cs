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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var pi = new ProcessIcon("TorrentFlow"))
            {
                pi.Display();

                var directoryWatcher = new DirectoryWatcher(Properties.Settings.Default.WatchDirectory, NewTorrentFileDetected, NotifyFilters.FileName | NotifyFilters.LastWrite);
                directoryWatcher.SetFilter("*.torrent");
                directoryWatcher.Start();

                Application.Run();
            }
        }

        public static void NewTorrentFileDetected(object source, FileSystemEventArgs e)
        {
            
        }
    }
}
