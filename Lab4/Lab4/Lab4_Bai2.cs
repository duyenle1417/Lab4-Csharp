using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Lab4_Bai2 : Form
    {
        public Lab4_Bai2()
        {
            InitializeComponent();
            btnDownload.Enabled = false;
            textBoxURL.Text = "https://daa.uit.edu.vn/";
        }

        //chon folder luu
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxFolder.Text = fbd.SelectedPath;
                btnDownload.Enabled = true;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            //Get html
            try
            {
                //yeu cau den trang web
                WebRequest request = WebRequest.Create(textBoxURL.Text);
                //respone luu gia tri gui ve tu request
                WebResponse respone = request.GetResponse();
                //doc noi dung html gui ve
                Stream data = respone.GetResponseStream();
                StreamReader sr = new StreamReader(data);
                string responeFromServer = sr.ReadToEnd();
                //dong respone
                respone.Close();

                //luu file
                File.WriteAllText(textBoxFolder.Text + "\\output.html", responeFromServer);
                MessageBox.Show("DONE!");
                richTextBoxScreen.Text = responeFromServer;
            }
            catch
            {
                //Loi URL khong xac dinh
                MessageBox.Show("URL Invalid!", "ERROR");
            }
        }
    }
}