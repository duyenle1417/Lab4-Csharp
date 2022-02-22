using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Lab4_Source : Form
    {
        public Lab4_Source()
        {
            InitializeComponent();
            richTextBoxSource.Text = Lab4_Bai3.SourceCode;
        }

        private void Lab4_Source_Load(object sender, EventArgs e)
        {
            richTextBoxSource.Text = Lab4_Bai3.SourceCode;
            this.Text = Lab4_Bai3.TitleWeb + " - Source Code Preview";
        }
    }
}
