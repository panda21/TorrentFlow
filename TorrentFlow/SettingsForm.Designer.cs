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
            this.autoStart_ChkBox = new System.Windows.Forms.CheckBox();
            this.watchDirectory_dlg = new System.Windows.Forms.FolderBrowserDialog();
            this.watchDirectory_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.watchDirectoryBrowse_btn = new System.Windows.Forms.Button();
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
            this.autoStart_ChkBox.CheckedChanged += new System.EventHandler(this.autoStart_ChkBox_CheckedChanged);
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.watchDirectoryBrowse_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.watchDirectory_lbl);
            this.Controls.Add(this.autoStart_ChkBox);
            this.Name = "SettingsForm";
            this.Text = "TorrentFlow Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox autoStart_ChkBox;
        private System.Windows.Forms.FolderBrowserDialog watchDirectory_dlg;
        private System.Windows.Forms.Label watchDirectory_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button watchDirectoryBrowse_btn;
    }
}

