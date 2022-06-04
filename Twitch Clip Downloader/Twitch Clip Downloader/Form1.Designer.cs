namespace Twitch_Clip_Downloader
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.PB = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.LB = new System.Windows.Forms.Label();
            this.TB = new System.Windows.Forms.TextBox();
            this.LL = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(367, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Download Clips";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PB
            // 
            this.PB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB.Location = new System.Drawing.Point(12, 224);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(349, 23);
            this.PB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Download 0%";
            // 
            // LB
            // 
            this.LB.AutoSize = true;
            this.LB.Location = new System.Drawing.Point(12, 9);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(92, 13);
            this.LB.TabIndex = 3;
            this.LB.Text = "Twitch UserName";
            // 
            // TB
            // 
            this.TB.Location = new System.Drawing.Point(12, 25);
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(100, 20);
            this.TB.TabIndex = 4;
            // 
            // LL
            // 
            this.LL.AutoSize = true;
            this.LL.Location = new System.Drawing.Point(396, 9);
            this.LL.Name = "LL";
            this.LL.Size = new System.Drawing.Size(63, 13);
            this.LL.TabIndex = 5;
            this.LL.TabStop = true;
            this.LL.Text = "Twitch clips";
            this.LL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 259);
            this.Controls.Add(this.LL);
            this.Controls.Add(this.TB);
            this.Controls.Add(this.LB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Twitch Clip Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar PB;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB;
        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.LinkLabel LL;
    }
}

