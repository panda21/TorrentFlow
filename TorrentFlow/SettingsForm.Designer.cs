namespace TorrentFlow
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.autoStart_ChkBox = new System.Windows.Forms.CheckBox();
            this.watchDirectory_dlg = new System.Windows.Forms.FolderBrowserDialog();
            this.watchDirectory_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.watchDirectoryBrowse_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ftpDownloadPath_txtBox = new System.Windows.Forms.TextBox();
            this.ftpUploadPath_txtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.displayPassword_chkBox = new System.Windows.Forms.CheckBox();
            this.ftpPassword_txtBox = new System.Windows.Forms.TextBox();
            this.ftpUsername_txtBox = new System.Windows.Forms.TextBox();
            this.ftpAddress_txtBox = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoStart_ChkBox
            // 
            this.autoStart_ChkBox.AutoSize = true;
            this.autoStart_ChkBox.Checked = true;
            this.autoStart_ChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoStart_ChkBox.Location = new System.Drawing.Point(12, 54);
            this.autoStart_ChkBox.Name = "autoStart_ChkBox";
            this.autoStart_ChkBox.Size = new System.Drawing.Size(147, 17);
            this.autoStart_ChkBox.TabIndex = 0;
            this.autoStart_ChkBox.Text = "Start TorrentFlow on login";
            this.autoStart_ChkBox.UseVisualStyleBackColor = true;
            // 
            // watchDirectory_lbl
            // 
            this.watchDirectory_lbl.AutoSize = true;
            this.watchDirectory_lbl.Location = new System.Drawing.Point(102, 9);
            this.watchDirectory_lbl.MaximumSize = new System.Drawing.Size(175, 0);
            this.watchDirectory_lbl.Name = "watchDirectory_lbl";
            this.watchDirectory_lbl.Size = new System.Drawing.Size(35, 13);
            this.watchDirectory_lbl.TabIndex = 1;
            this.watchDirectory_lbl.Text = "empty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Watch Directory:";
            // 
            // watchDirectoryBrowse_btn
            // 
            this.watchDirectoryBrowse_btn.Location = new System.Drawing.Point(12, 25);
            this.watchDirectoryBrowse_btn.Name = "watchDirectoryBrowse_btn";
            this.watchDirectoryBrowse_btn.Size = new System.Drawing.Size(75, 23);
            this.watchDirectoryBrowse_btn.TabIndex = 3;
            this.watchDirectoryBrowse_btn.Text = "Browse";
            this.watchDirectoryBrowse_btn.UseVisualStyleBackColor = true;
            this.watchDirectoryBrowse_btn.Click += new System.EventHandler(this.watchDirectoryBrowse_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(197, 228);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ftpDownloadPath_txtBox);
            this.groupBox1.Controls.Add(this.ftpUploadPath_txtBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.displayPassword_chkBox);
            this.groupBox1.Controls.Add(this.ftpPassword_txtBox);
            this.groupBox1.Controls.Add(this.ftpUsername_txtBox);
            this.groupBox1.Controls.Add(this.ftpAddress_txtBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 145);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FTP Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Download Path";
            // 
            // ftpDownloadPath_txtBox
            // 
            this.ftpDownloadPath_txtBox.Location = new System.Drawing.Point(92, 117);
            this.ftpDownloadPath_txtBox.Name = "ftpDownloadPath_txtBox";
            this.ftpDownloadPath_txtBox.Size = new System.Drawing.Size(162, 20);
            this.ftpDownloadPath_txtBox.TabIndex = 13;
            // 
            // ftpUploadPath_txtBox
            // 
            this.ftpUploadPath_txtBox.Location = new System.Drawing.Point(92, 91);
            this.ftpUploadPath_txtBox.Name = "ftpUploadPath_txtBox";
            this.ftpUploadPath_txtBox.Size = new System.Drawing.Size(162, 20);
            this.ftpUploadPath_txtBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Upload Path";
            // 
            // displayPassword_chkBox
            // 
            this.displayPassword_chkBox.AutoSize = true;
            this.displayPassword_chkBox.Location = new System.Drawing.Point(194, 67);
            this.displayPassword_chkBox.Name = "displayPassword_chkBox";
            this.displayPassword_chkBox.Size = new System.Drawing.Size(60, 17);
            this.displayPassword_chkBox.TabIndex = 9;
            this.displayPassword_chkBox.Text = "Display";
            this.displayPassword_chkBox.UseVisualStyleBackColor = true;
            this.displayPassword_chkBox.CheckedChanged += new System.EventHandler(this.displayPassword_chkBox_CheckedChanged);
            // 
            // ftpPassword_txtBox
            // 
            this.ftpPassword_txtBox.Location = new System.Drawing.Point(92, 65);
            this.ftpPassword_txtBox.Name = "ftpPassword_txtBox";
            this.ftpPassword_txtBox.Size = new System.Drawing.Size(96, 20);
            this.ftpPassword_txtBox.TabIndex = 10;
            this.ftpPassword_txtBox.UseSystemPasswordChar = true;
            // 
            // ftpUsername_txtBox
            // 
            this.ftpUsername_txtBox.Location = new System.Drawing.Point(92, 39);
            this.ftpUsername_txtBox.Name = "ftpUsername_txtBox";
            this.ftpUsername_txtBox.Size = new System.Drawing.Size(162, 20);
            this.ftpUsername_txtBox.TabIndex = 9;
            // 
            // ftpAddress_txtBox
            // 
            this.ftpAddress_txtBox.Location = new System.Drawing.Point(92, 13);
            this.ftpAddress_txtBox.Name = "ftpAddress_txtBox";
            this.ftpAddress_txtBox.Size = new System.Drawing.Size(162, 20);
            this.ftpAddress_txtBox.TabIndex = 8;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(116, 227);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 9;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.watchDirectoryBrowse_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.watchDirectory_lbl);
            this.Controls.Add(this.autoStart_ChkBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "TorrentFlow Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox autoStart_ChkBox;
        private System.Windows.Forms.FolderBrowserDialog watchDirectory_dlg;
        private System.Windows.Forms.Label watchDirectory_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button watchDirectoryBrowse_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ftpPassword_txtBox;
        private System.Windows.Forms.TextBox ftpUsername_txtBox;
        private System.Windows.Forms.TextBox ftpAddress_txtBox;
        private System.Windows.Forms.CheckBox displayPassword_chkBox;
        private System.Windows.Forms.TextBox ftpUploadPath_txtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ftpDownloadPath_txtBox;
        private System.Windows.Forms.Button cancel_btn;
    }
}

