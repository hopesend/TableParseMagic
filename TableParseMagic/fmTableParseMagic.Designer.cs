namespace TableParseMagic
{
    partial class fmTableParseMagic
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTableParseMagic));
            this.btFromDisk = new System.Windows.Forms.Button();
            this.btFromWeb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btToCSV = new System.Windows.Forms.Button();
            this.btToTXT = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btFromClipboard = new System.Windows.Forms.Button();
            this.ofdOpenText = new System.Windows.Forms.OpenFileDialog();
            this.cbHeaders = new System.Windows.Forms.ComboBox();
            this.btRemove = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.lvHeadersCollection = new System.Windows.Forms.ListView();
            this.cbWithHeader = new System.Windows.Forms.CheckBox();
            this.cbRemoveDuplicate = new System.Windows.Forms.CheckBox();
            this.tbNDuplicate = new System.Windows.Forms.TextBox();
            this.cbRemoveEmpty = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btFromDisk
            // 
            this.btFromDisk.Image = ((System.Drawing.Image)(resources.GetObject("btFromDisk.Image")));
            this.btFromDisk.Location = new System.Drawing.Point(58, 12);
            this.btFromDisk.Name = "btFromDisk";
            this.btFromDisk.Size = new System.Drawing.Size(40, 40);
            this.btFromDisk.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btFromDisk, "From Text File or Html File");
            this.btFromDisk.UseVisualStyleBackColor = true;
            this.btFromDisk.Click += new System.EventHandler(this.btFromDisk_Click);
            // 
            // btFromWeb
            // 
            this.btFromWeb.Image = ((System.Drawing.Image)(resources.GetObject("btFromWeb.Image")));
            this.btFromWeb.Location = new System.Drawing.Point(104, 12);
            this.btFromWeb.Name = "btFromWeb";
            this.btFromWeb.Size = new System.Drawing.Size(40, 40);
            this.btFromWeb.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btFromWeb, "From Web");
            this.btFromWeb.UseVisualStyleBackColor = true;
            this.btFromWeb.Click += new System.EventHandler(this.btFromWeb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TO";
            // 
            // btToCSV
            // 
            this.btToCSV.Enabled = false;
            this.btToCSV.Image = ((System.Drawing.Image)(resources.GetObject("btToCSV.Image")));
            this.btToCSV.Location = new System.Drawing.Point(224, 12);
            this.btToCSV.Name = "btToCSV";
            this.btToCSV.Size = new System.Drawing.Size(40, 40);
            this.btToCSV.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btToCSV, "To Excel File");
            this.btToCSV.UseVisualStyleBackColor = true;
            this.btToCSV.Click += new System.EventHandler(this.btToCSV_Click);
            // 
            // btToTXT
            // 
            this.btToTXT.Enabled = false;
            this.btToTXT.Image = ((System.Drawing.Image)(resources.GetObject("btToTXT.Image")));
            this.btToTXT.Location = new System.Drawing.Point(178, 12);
            this.btToTXT.Name = "btToTXT";
            this.btToTXT.Size = new System.Drawing.Size(40, 40);
            this.btToTXT.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btToTXT, "To Text File");
            this.btToTXT.UseVisualStyleBackColor = true;
            this.btToTXT.Click += new System.EventHandler(this.btToTXT_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 58);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(252, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // btFromClipboard
            // 
            this.btFromClipboard.Image = ((System.Drawing.Image)(resources.GetObject("btFromClipboard.Image")));
            this.btFromClipboard.Location = new System.Drawing.Point(12, 12);
            this.btFromClipboard.Name = "btFromClipboard";
            this.btFromClipboard.Size = new System.Drawing.Size(40, 40);
            this.btFromClipboard.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btFromClipboard, "From Clipboard");
            this.btFromClipboard.UseVisualStyleBackColor = true;
            this.btFromClipboard.Click += new System.EventHandler(this.btFromClipboard_Click);
            // 
            // cbHeaders
            // 
            this.cbHeaders.FormattingEnabled = true;
            this.cbHeaders.Location = new System.Drawing.Point(12, 87);
            this.cbHeaders.Name = "cbHeaders";
            this.cbHeaders.Size = new System.Drawing.Size(197, 21);
            this.cbHeaders.TabIndex = 7;
            this.toolTip1.SetToolTip(this.cbHeaders, "Header\'s Table");
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(241, 87);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(23, 23);
            this.btRemove.TabIndex = 8;
            this.btRemove.Text = "-";
            this.toolTip1.SetToolTip(this.btRemove, "Remove Headers to Show");
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(215, 87);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(23, 23);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "+";
            this.toolTip1.SetToolTip(this.btAdd, "Add Headers to show");
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lvHeadersCollection
            // 
            this.lvHeadersCollection.Location = new System.Drawing.Point(12, 114);
            this.lvHeadersCollection.Name = "lvHeadersCollection";
            this.lvHeadersCollection.Size = new System.Drawing.Size(144, 125);
            this.lvHeadersCollection.TabIndex = 10;
            this.toolTip1.SetToolTip(this.lvHeadersCollection, "Headers to show");
            this.lvHeadersCollection.UseCompatibleStateImageBehavior = false;
            this.lvHeadersCollection.View = System.Windows.Forms.View.List;
            // 
            // cbWithHeader
            // 
            this.cbWithHeader.AutoSize = true;
            this.cbWithHeader.Location = new System.Drawing.Point(162, 116);
            this.cbWithHeader.Name = "cbWithHeader";
            this.cbWithHeader.Size = new System.Drawing.Size(86, 17);
            this.cbWithHeader.TabIndex = 11;
            this.cbWithHeader.Text = "With Header";
            this.cbWithHeader.UseVisualStyleBackColor = true;
            // 
            // cbRemoveDuplicate
            // 
            this.cbRemoveDuplicate.AutoSize = true;
            this.cbRemoveDuplicate.Location = new System.Drawing.Point(162, 139);
            this.cbRemoveDuplicate.Name = "cbRemoveDuplicate";
            this.cbRemoveDuplicate.Size = new System.Drawing.Size(114, 17);
            this.cbRemoveDuplicate.TabIndex = 12;
            this.cbRemoveDuplicate.Text = "Remove Duplicate";
            this.cbRemoveDuplicate.UseVisualStyleBackColor = true;
            this.cbRemoveDuplicate.CheckedChanged += new System.EventHandler(this.cbRemoveDuplicate_CheckedChanged);
            // 
            // tbNDuplicate
            // 
            this.tbNDuplicate.Enabled = false;
            this.tbNDuplicate.Location = new System.Drawing.Point(162, 162);
            this.tbNDuplicate.Name = "tbNDuplicate";
            this.tbNDuplicate.Size = new System.Drawing.Size(47, 20);
            this.tbNDuplicate.TabIndex = 13;
            // 
            // cbRemoveEmpty
            // 
            this.cbRemoveEmpty.AutoSize = true;
            this.cbRemoveEmpty.Location = new System.Drawing.Point(162, 188);
            this.cbRemoveEmpty.Name = "cbRemoveEmpty";
            this.cbRemoveEmpty.Size = new System.Drawing.Size(98, 17);
            this.cbRemoveEmpty.TabIndex = 14;
            this.cbRemoveEmpty.Text = "Remove Empty";
            this.cbRemoveEmpty.UseVisualStyleBackColor = true;
            // 
            // fmTableParseMagic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(274, 251);
            this.Controls.Add(this.cbRemoveEmpty);
            this.Controls.Add(this.tbNDuplicate);
            this.Controls.Add(this.cbRemoveDuplicate);
            this.Controls.Add(this.cbWithHeader);
            this.Controls.Add(this.lvHeadersCollection);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.cbHeaders);
            this.Controls.Add(this.btFromClipboard);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btToCSV);
            this.Controls.Add(this.btToTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btFromWeb);
            this.Controls.Add(this.btFromDisk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmTableParseMagic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Parse Magic";
            this.Load += new System.EventHandler(this.fmTableParseMagic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFromDisk;
        private System.Windows.Forms.Button btFromWeb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btToCSV;
        private System.Windows.Forms.Button btToTXT;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btFromClipboard;
        private System.Windows.Forms.OpenFileDialog ofdOpenText;
        private System.Windows.Forms.ComboBox cbHeaders;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ListView lvHeadersCollection;
        private System.Windows.Forms.CheckBox cbWithHeader;
        private System.Windows.Forms.CheckBox cbRemoveDuplicate;
        private System.Windows.Forms.TextBox tbNDuplicate;
        private System.Windows.Forms.CheckBox cbRemoveEmpty;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

