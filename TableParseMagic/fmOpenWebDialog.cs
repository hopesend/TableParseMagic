using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableParseMagic
{
    public partial class fmOpenWebDialog : Form
    {
        public string web = string.Empty;

        public fmOpenWebDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fmOpenWebDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!textBox1.Text.Equals(string.Empty))
                web = textBox1.Text;
        }
    }
}
