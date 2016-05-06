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
        public string info;
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

            Get_Info();
        }

        private void btFromDisk_Click(object sender, EventArgs e)
        {
            EnumFrom = FromInfo.Disk;
            if (ofdOpenText.ShowDialog() == DialogResult.OK)
                info = ofdOpenText.FileName;

            Get_Info();
        }

        private void btFromClipboard_Click(object sender, EventArgs e)
        {
            EnumFrom = FromInfo.Clipboard;
            if (Clipboard.ContainsText(TextDataFormat.Html))
                info = "clipboard";

            Get_Info();
        }

        private void Get_Info()
        {
            if (!info.Equals(string.Empty))
            {
                Active_Buttons_To();
                switch (EnumFrom)
                {
                case FromInfo.Web:
                    {
                        doc.LoadHtml(new WebClient().DownloadString(info));
                        break;
                    }

                case FromInfo.Disk:
                    {
                        doc.LoadHtml(File.ReadAllText(info));
                        break;
                    }

                case FromInfo.Clipboard:
                    {
                        doc.LoadHtml(Clipboard.GetText(TextDataFormat.Html));
                        break;
                    }
                }

                Get_Tables();
            }
            else
                Deactive_Buttons_To();
                
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


    }
}
