using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //Auto-generated stuff
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());

            using (var pi = new ProcessIcon("TorrentFlow"))
            {
                pi.SetContextMenuStrip(GetSettingsMenu());
                
                pi.Display();

                Application.Run();
            }
        }
        private static ContextMenuStrip GetSettingsMenu()
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem exitItem = new ToolStripMenuItem();
            exitItem.Text = "Exit";
            exitItem.Click += new EventHandler(ExitClick);
            menu.Items.Add(exitItem);
            return menu;
        }

        private static void ExitClick(object send, EventArgs e)
        {
            Application.Exit();
        }
    }
}
