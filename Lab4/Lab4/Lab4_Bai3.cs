using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using HtmlAgilityPack;

namespace Lab4
{
    public partial class Lab4_Bai3 : Form
    {
        //pass data sang form khac
        public static string SourceCode = "";
        public static string TitleWeb = "";

        public Lab4_Bai3()
        {
            InitializeComponent();
        }

        //quay lai trang cu
        private void toolStripBtnBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        //quay ve trang chu
        private void toolStripBtnHome_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome();
        }

        //quay ve trang ke tiep
        private void toolStripBtnForward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        //truy cap trang
        private void toolStripBtnGo_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(toolStripTextBoxUrl.Text);//load web
        }

        //Update ProgressBar
        private void webBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            toolStripProgressBar.Maximum = (int)e.MaximumProgress;
            toolStripProgressBar.Value = ((int)e.CurrentProgress < 0 || (int)e.MaximumProgress < (int)e.CurrentProgress)
                                        ? (int)e.MaximumProgress : (int)e.CurrentProgress;
        }

        //update URL
        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            toolStripTextBoxUrl.Text = webBrowser.Url.ToString();
            //Bonus back & forward mo neu co lich su
            if (webBrowser.CanGoBack)
            {
                toolStripBtnBack.Enabled = true;
            }
            else
            {
                toolStripBtnBack.Enabled = false;
            }
            if (webBrowser.CanGoForward)
            {
                toolStripBtnForward.Enabled = true;
            }
            else
            {
                toolStripBtnForward.Enabled = false;
            }
        }

        //ten trang web => ten form (khi co thay doi)
        private void UpdateTitle(object sender, EventArgs e)
        {
            Text = webBrowser.DocumentTitle.ToString();
        }

        //tai ve source trang web
        private void toolStripBtnDownload_Click(object sender, EventArgs e)
        {
            //chi luu file html cua web
            WebClient client = new WebClient();
            try
            {
                client.DownloadFile(toolStripTextBoxUrl.Text, SavePath());
            }
            catch
            {
                //thoat luu file
            }
        }

        //chon duong dan luu file
        private string SavePath()
        {
            string path = "";
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                sfd.Filter = "*.txt|*.html";
                path = sfd.FileName;
            }
            return path;
        }

        private void toolStripBtnViewSource_Click(object sender, EventArgs e)
        {
            //lay noi dung html
            HttpWebRequest request = WebRequest.CreateHttp(toolStripTextBoxUrl.Text);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            SourceCode = sr.ReadToEnd();//bien luu source
            TitleWeb = webBrowser.DocumentTitle.ToString();//bien luu title
;            sr.Close();
            //mo form va pass data
            Lab4_Source ViewSource = new Lab4_Source();
            ViewSource.Show();
        }

        bool select = false;//kiem tra da boi den url hay chua
        //chon url khi click 1 lan vao bar
        private void toolStripTextBoxUrl_Click(object sender, EventArgs e)
        {
            if (!select)
            {
                toolStripTextBoxUrl.SelectAll();
                toolStripTextBoxUrl.Focus();
                select = true;
            }
            else
                select = false;
        }
    }
}