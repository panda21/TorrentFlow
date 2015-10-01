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
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void autoStart_ChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (autoStart_ChkBox.Checked)
            {
                RegisterStartWithWindows();
            }
            else
            {
                UnregisterStartWithWindows();
            }
        }

        private void RegisterStartWithWindows()
        {
            var path = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
            RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);
            key.SetValue("TorrentFlow", Application.ExecutablePath.ToString());
        }

        private void UnregisterStartWithWindows()
        {
            var path = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
            RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);
            key.DeleteValue("TorrentFlow", false);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            var path = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
            RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);
            autoStart_ChkBox.Checked = (key.GetValue("TorrentFlow") != null);
        }
    }
}
