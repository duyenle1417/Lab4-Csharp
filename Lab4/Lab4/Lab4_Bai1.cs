using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Lab4
{
    public partial class Lab4_Bai1 : Form
    {
        public Lab4_Bai1()
        {
            InitializeComponent();
            //gan URL san
            textBoxURL.Text = "https://daa.uit.edu.vn/";
            
        }

        WebRequest request;
        WebResponse respone;

        //nut
        private void btn_Get_Click(object sender, EventArgs e)
        {
            try
            {
                //yeu cau den trang web
                request = WebRequest.Create(textBoxURL.Text);
                //respone luu gia tri gui ve tu request
                respone = request.GetResponse();
                //doc noi dung html gui ve
                Stream data = respone.GetResponseStream();
                StreamReader sr = new StreamReader(data);
                string responeFromServer = sr.ReadToEnd();
                //hien thi noi dung html len man hinh
                richTextBoxScreen.Text = responeFromServer;
                //dong respone
                respone.Close();
            }
            catch
            {
                //Loi URL khong xac dinh
                MessageBox.Show("URL Invalid!", "ERROR");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
