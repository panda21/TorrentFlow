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
            this.ftpAddress_txtBox = new System.Windows.Forms.TextBox();
            this.ftpUsername_txtBox = new System.Windows.Forms.TextBox();
            this.ftpPassword_txtBox = new System.Windows.Forms.TextBox();
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
            this.save_btn.Location = new System.Drawing.Point(197, 226);
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
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ftpPassword_txtBox);
            this.groupBox1.Controls.Add(this.ftpUsername_txtBox);
            this.groupBox1.Controls.Add(this.ftpAddress_txtBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FTP Settings";
            // 
            // ftpAddress_txtBox
            // 
            this.ftpAddress_txtBox.Location = new System.Drawing.Point(69, 13);
            this.ftpAddress_txtBox.Name = "ftpAddress_txtBox";
            this.ftpAddress_txtBox.Size = new System.Drawing.Size(185, 20);
            this.ftpAddress_txtBox.TabIndex = 8;
            // 
            // ftpUsername_txtBox
            // 
            this.ftpUsername_txtBox.Location = new System.Drawing.Point(69, 40);
            this.ftpUsername_txtBox.Name = "ftpUsername_txtBox";
            this.ftpUsername_txtBox.Size = new System.Drawing.Size(185, 20);
            this.ftpUsername_txtBox.TabIndex = 9;
            // 
            // ftpPassword_txtBox
            // 
            this.ftpPassword_txtBox.Location = new System.Drawing.Point(69, 70);
            this.ftpPassword_txtBox.Name = "ftpPassword_txtBox";
            this.ftpPassword_txtBox.Size = new System.Drawing.Size(185, 20);
            this.ftpPassword_txtBox.TabIndex = 10;
            this.ftpPassword_txtBox.UseSystemPasswordChar = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
    }
}

