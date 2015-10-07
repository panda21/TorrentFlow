using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorrentFlow
{
    class ContextMenuBuilder
    {
        public ContextMenuStrip GetDefaultMenu()
        {
            ContextMenuStrip menu = new ContextMenuStrip();

            ToolStripMenuItem openSettingsItem = new ToolStripMenuItem();
            openSettingsItem.Text = "Settings...";
            openSettingsItem.Click += SettingsClick;
            menu.Items.Add(openSettingsItem);

            ToolStripMenuItem pauseItem = new ToolStripMenuItem();
            pauseItem.Text = "Pause";
            pauseItem.Click += PauseProgram;
            menu.Items.Add(pauseItem);

            ToolStripMenuItem resumeItem = new ToolStripMenuItem();
            resumeItem.Text = "Resume";
            resumeItem.Click += ResumeProgram;
            menu.Items.Add(resumeItem);

            menu.Items.Add("-");

            ToolStripMenuItem exitItem = new ToolStripMenuItem();
            exitItem.Text = "Exit";
            exitItem.Click += new EventHandler(ExitClick);
            menu.Items.Add(exitItem);

            return menu;
        }

        private static void PauseProgram(object send, EventArgs e)
        {
            TorrentFlow.Pause();
        }

        private static void ResumeProgram(object send, EventArgs e)
        {
            TorrentFlow.Resume();
        }

        private static void ExitClick(object send, EventArgs e)
        {
            Application.Exit();
        }

        private static void SettingsClick(object send, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.Show();
        }
    }
}
