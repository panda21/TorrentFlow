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
            downloadDirectory_dlg.SelectedPath = Properties.Settings.Default.DownloadDirectory;
            downloadDirectory_lbl.Text = Properties.Settings.Default.DownloadDirectory;
            autoStart_ChkBox.Checked = (regKey.GetValue("TorrentFlow") != null);
            ftpAddress_txtBox.Text = Properties.Settings.Default.FTPAddress;
            ftpUsername_txtBox.Text = Properties.Settings.Default.FTPUsername;
            ftpPassword_txtBox.Text = StringCipher.Decrypt(Properties.Settings.Default.FTPPassword, "TorrentFlow");
            ftpUploadPath_txtBox.Text = Properties.Settings.Default.FTPUploadPath;
            ftpDownloadPath_txtBox.Text = Properties.Settings.Default.FTPDownloadPath;
            ftpDeleteAfterDL_chkBox.Checked = Properties.Settings.Default.FTPDeleteAfterDL;
        }

        private void watchDirectoryBrowse_btn_Click(object sender, EventArgs e)
        {
            watchDirectory_dlg.ShowDialog();
            watchDirectory_lbl.Text = watchDirectory_dlg.SelectedPath;
        }

        private void downloadDirectoryBrowse_btn_Click(object sender, EventArgs e)
        {
            downloadDirectory_dlg.ShowDialog();
            downloadDirectory_lbl.Text = downloadDirectory_dlg.SelectedPath;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.WatchDirectory = watchDirectory_dlg.SelectedPath;
            Properties.Settings.Default.DownloadDirectory = downloadDirectory_dlg.SelectedPath;
            Properties.Settings.Default.FTPAddress = ftpAddress_txtBox.Text;
            Properties.Settings.Default.FTPUsername = ftpUsername_txtBox.Text;
            Properties.Settings.Default.FTPPassword = StringCipher.Encrypt(ftpPassword_txtBox.Text, "TorrentFlow");
            Properties.Settings.Default.FTPUploadPath = ftpUploadPath_txtBox.Text;
            Properties.Settings.Default.FTPDownloadPath = ftpDownloadPath_txtBox.Text;
            Properties.Settings.Default.FTPDeleteAfterDL = ftpDeleteAfterDL_chkBox.Checked;

            Properties.Settings.Default.Save();

            if (autoStart_ChkBox.Checked)
            {
                RegisterStartWithWindows();
            }
            else
            {
                UnregisterStartWithWindows();
            }

            TorrentFlow.Initialize();
            this.Close();
        }

        private void displayPassword_chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (displayPassword_chkBox.Checked)
            {
                ftpPassword_txtBox.UseSystemPasswordChar = false;
            }
            else
            {
                ftpPassword_txtBox.UseSystemPasswordChar = true;
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
