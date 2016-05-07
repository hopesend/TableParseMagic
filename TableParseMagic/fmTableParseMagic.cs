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
            byte cont = 0;
            foreach(HtmlNode nodo in doc.DocumentNode.SelectSingleNode("//table").Descendants("tr").First().Elements("td"))
            {
                if (nodo.InnerText.Trim().Equals(string.Empty))
                    cbHeaders.Items.Add(cont + " - EMPTY HEADER");
                else
                    cbHeaders.Items.Add(cont + " - " + nodo.InnerText.Trim());

                cont++;
            }
            cbHeaders.SelectedIndex = 0;

            table = doc.DocumentNode.SelectSingleNode("//table")
                        .Descendants("tr")
                        .Skip(1)
                        .Where(tr => tr.Elements("td").Count() > 1)
                        .Select(tr => tr.Elements("td").Select(td => td.InnerText.Trim()).ToList())
                        .ToList();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (lvHeadersCollection.FindItemWithText(cbHeaders.SelectedItem.ToString()) == null)
            {
                lvHeadersCollection.Items.Add(new ListViewItem(cbHeaders.SelectedItem.ToString()));
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (lvHeadersCollection.FindItemWithText(cbHeaders.SelectedItem.ToString()) != null)
            {
                lvHeadersCollection.Items.Remove(lvHeadersCollection.FindItemWithText(cbHeaders.SelectedItem.ToString()));
            }
        }

        private void cbRemoveDuplicate_CheckedChanged(object sender, EventArgs e)
        {
            tbNDuplicate.Enabled = cbRemoveDuplicate.Checked;
        }

        private void btToTXT_Click(object sender, EventArgs e)
        {
            List<List<string>> tableParse = new List<List<string>>();

            if(cbWithHeader.Checked)
            {
                List<string> aux = new List<string>();

                //With Header
                if (lvHeadersCollection.Items.Count > 0)
                {
                    foreach (ListViewItem item in lvHeadersCollection.Items)
                    {
                        aux.Add(doc.DocumentNode.SelectSingleNode("//table").Descendants("tr").First().Elements("td").ToArray()[Convert.ToInt32(item.Text.Split()[0])].InnerText.ToString());
                    }

                    tableParse.Add(aux);
                }
                else
                {
                    foreach (HtmlNode nodo in doc.DocumentNode.SelectSingleNode("//table").Descendants("tr").First().Elements("td"))
                    {
                        aux.Add(nodo.InnerText.Trim());
                    }

                    tableParse.Add(aux);
                }
            }

            //Remove Duplicate
            if (cbRemoveDuplicate.Checked)
            {
                if (!tbNDuplicate.Text.Equals(string.Empty))
                {

                }
            }
        }

        private void btToCSV_Click(object sender, EventArgs e)
        {

        }
    }
}
