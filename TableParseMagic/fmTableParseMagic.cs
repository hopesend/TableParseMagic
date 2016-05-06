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
using HtmlAgilityPack;
using System.IO;

namespace TableParseMagic
{
    public enum FromInfo
    {
        Disk,
        Web,
        Clipboard
    }

    public partial class fmTableParseMagic : Form
    {
        public HtmlAgilityPack.HtmlDocument doc;
        public List<List<string>> table;
        public string info
        {
            set 
            {
                if (value.Equals(string.Empty))
                    Deactive_Buttons_To();
                else
                {
                    if (Get_Info())
                    {
                        Active_Buttons_To();
                        Get_Tables();
                    }
                    else
                        Deactive_Buttons_To();
                }
            }
        }

        public FromInfo EnumFrom;

        public fmTableParseMagic()
        {
            InitializeComponent();
        }

        private void fmTableParseMagic_Load(object sender, EventArgs e)
        {
            doc = new HtmlAgilityPack.HtmlDocument();
        }

        public void Active_Buttons_To()
        {
            btToCSV.Enabled = true;
            btToTXT.Enabled = true;
        }

        public void Deactive_Buttons_To()
        {
            btToCSV.Enabled = false;
            btToTXT.Enabled = false;
        }

        private void btFromWeb_Click(object sender, EventArgs e)
        {
            EnumFrom = FromInfo.Web;
            fmOpenWebDialog fmWeb = new fmOpenWebDialog();
            fmWeb.ShowDialog();
            info = fmWeb.web;
        }

        private bool Get_Info()
        {
            switch (EnumFrom)
            {
                case FromInfo.Web:
                    {
                        WebClient webClient = new WebClient();
                        string tables = webClient.DownloadString("http://www.phenoelit.org/dpl/dpl.html");

                        if (tables.Equals(string.Empty))
                            return false;

                        doc.LoadHtml(tables);

                        break;
                    }

                case FromInfo.Disk:
                    {
                        doc.Load(ofdOpenText.FileName);
                        break;
                    }

                case FromInfo.Clipboard:
                    {
                        break;
                    }
            }
            
            return true;
        }

        private void Get_Tables()
        {
            table = doc.DocumentNode.SelectSingleNode("//table")
                        .Descendants("tr")
                        .Skip(1)
                        .Where(tr => tr.Elements("td").Count() > 1)
                        .Select(tr => tr.Elements("td").Select(td => td.InnerText.Trim()).ToList())
                        .ToList();
        }

        private void btFromDisk_Click(object sender, EventArgs e)
        {
            if (ofdOpenText.ShowDialog() == DialogResult.OK)
                info = ofdOpenText.FileName;
        }
    }
}
