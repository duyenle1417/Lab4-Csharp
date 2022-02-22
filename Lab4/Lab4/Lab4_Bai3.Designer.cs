using System;

namespace Lab4
{
    partial class Lab4_Bai3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab4_Bai3));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.toolStripBtnBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxUrl = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripBtnGo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnDownload = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnViewSource = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(2, 38);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(980, 516);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            this.webBrowser.DocumentTitleChanged += new System.EventHandler(this.UpdateTitle);
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
            this.webBrowser.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser_ProgressChanged);
            // 
            // toolStripBtnBack
            // 
            this.toolStripBtnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnBack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnBack.Image")));
            this.toolStripBtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBack.Margin = new System.Windows.Forms.Padding(2, 2, 5, 2);
            this.toolStripBtnBack.Name = "toolStripBtnBack";
            this.toolStripBtnBack.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnBack.Text = "Back";
            this.toolStripBtnBack.Click += new System.EventHandler(this.toolStripBtnBack_Click);
            // 
            // toolStripBtnHome
            // 
            this.toolStripBtnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnHome.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnHome.Image")));
            this.toolStripBtnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnHome.Margin = new System.Windows.Forms.Padding(0, 2, 5, 2);
            this.toolStripBtnHome.Name = "toolStripBtnHome";
            this.toolStripBtnHome.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnHome.Text = "Home";
            this.toolStripBtnHome.Click += new System.EventHandler(this.toolStripBtnHome_Click);
            // 
            // toolStripBtnForward
            // 
            this.toolStripBtnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnForward.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnForward.Image")));
            this.toolStripBtnForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnForward.Margin = new System.Windows.Forms.Padding(0, 2, 5, 2);
            this.toolStripBtnForward.Name = "toolStripBtnForward";
            this.toolStripBtnForward.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnForward.Text = "Forward";
            this.toolStripBtnForward.Click += new System.EventHandler(this.toolStripBtnForward_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripTextBoxUrl
            // 
            this.toolStripTextBoxUrl.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.toolStripTextBoxUrl.Name = "toolStripTextBoxUrl";
            this.toolStripTextBoxUrl.Size = new System.Drawing.Size(600, 27);
            this.toolStripTextBoxUrl.Click += new System.EventHandler(this.toolStripTextBoxUrl_Click);
            // 
            // toolStripBtnGo
            // 
            this.toolStripBtnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnGo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnGo.Image")));
            this.toolStripBtnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnGo.Margin = new System.Windows.Forms.Padding(0, 2, 5, 2);
            this.toolStripBtnGo.Name = "toolStripBtnGo";
            this.toolStripBtnGo.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnGo.Text = "Go";
            this.toolStripBtnGo.Click += new System.EventHandler(this.toolStripBtnGo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripBtnDownload
            // 
            this.toolStripBtnDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnDownload.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnDownload.Image")));
            this.toolStripBtnDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnDownload.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.toolStripBtnDownload.Name = "toolStripBtnDownload";
            this.toolStripBtnDownload.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnDownload.Text = "Download";
            this.toolStripBtnDownload.Click += new System.EventHandler(this.toolStripBtnDownload_Click);
            // 
            // toolStripBtnViewSource
            // 
            this.toolStripBtnViewSource.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnViewSource.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnViewSource.Image")));
            this.toolStripBtnViewSource.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnViewSource.Margin = new System.Windows.Forms.Padding(0, 2, 5, 2);
            this.toolStripBtnViewSource.Name = "toolStripBtnViewSource";
            this.toolStripBtnViewSource.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnViewSource.Text = "Source";
            this.toolStripBtnViewSource.Click += new System.EventHandler(this.toolStripBtnViewSource_Click);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.White;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnBack,
            this.toolStripBtnHome,
            this.toolStripBtnForward,
            this.toolStripSeparator1,
            this.toolStripTextBoxUrl,
            this.toolStripBtnGo,
            this.toolStripSeparator2,
            this.toolStripProgressBar,
            this.toolStripSeparator3,
            this.toolStripBtnDownload,
            this.toolStripBtnViewSource});
            this.toolStripMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.MinimumSize = new System.Drawing.Size(500, 35);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMenu.Size = new System.Drawing.Size(982, 35);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "toolStripMenu";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.BackColor = System.Drawing.Color.Blue;
            this.toolStripProgressBar.ForeColor = System.Drawing.Color.Red;
            this.toolStripProgressBar.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 24);
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar.ToolTipText = "Progress Bar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // Lab4_Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.webBrowser);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Lab4_Bai3";
            this.Text = "Web Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ToolStripButton toolStripBtnBack;
        private System.Windows.Forms.ToolStripButton toolStripBtnHome;
        private System.Windows.Forms.ToolStripButton toolStripBtnForward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxUrl;
        private System.Windows.Forms.ToolStripButton toolStripBtnGo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtnDownload;
        private System.Windows.Forms.ToolStripButton toolStripBtnViewSource;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}