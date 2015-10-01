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
            this.SuspendLayout();
            // 
            // autoStart_ChkBox
            // 
            this.autoStart_ChkBox.AutoSize = true;
            this.autoStart_ChkBox.Checked = true;
            this.autoStart_ChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoStart_ChkBox.Location = new System.Drawing.Point(12, 12);
            this.autoStart_ChkBox.Name = "autoStart_ChkBox";
            this.autoStart_ChkBox.Size = new System.Drawing.Size(147, 17);
            this.autoStart_ChkBox.TabIndex = 0;
            this.autoStart_ChkBox.Text = "Start TorrentFlow on login";
            this.autoStart_ChkBox.UseVisualStyleBackColor = true;
            this.autoStart_ChkBox.CheckedChanged += new System.EventHandler(this.autoStart_ChkBox_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.autoStart_ChkBox);
            this.Name = "SettingsForm";
            this.Text = "TorrentFlow Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox autoStart_ChkBox;
    }
}

