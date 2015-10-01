using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorrentFlow
{
    public partial class SettingsForm : Form
    {
        private readonly RegistryKey regKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void autoStart_ChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (autoStart_ChkBox.Checked)
            {
                //RegisterStartWithWindows();
            }
            else
            {
                //UnregisterStartWithWindows();
            }
        }

        private void RegisterStartWithWindows()
        {
            regKey.SetValue("TorrentFlow", Application.ExecutablePath.ToString());
        }

        private void UnregisterStartWithWindows()
        {
            regKey.DeleteValue("TorrentFlow", false);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            watchDirectory_dlg.SelectedPath = Properties.Settings.Default.WatchDirectory;
            watchDirectory_lbl.Text = Properties.Settings.Default.WatchDirectory;
            autoStart_ChkBox.Checked = (regKey.GetValue("TorrentFlow") != null);
        }

        private void watchDirectoryBrowse_btn_Click(object sender, EventArgs e)
        {
            watchDirectory_dlg.ShowDialog();
            watchDirectory_lbl.Text = watchDirectory_dlg.SelectedPath;
        }
    }
}
