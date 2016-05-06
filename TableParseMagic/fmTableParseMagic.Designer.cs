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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTableParseMagic));
            this.btFromDisk = new System.Windows.Forms.Button();
            this.btFromWeb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btToCSV = new System.Windows.Forms.Button();
            this.btToTXT = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btFromClipboard = new System.Windows.Forms.Button();
            this.ofdOpenText = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btFromDisk
            // 
            this.btFromDisk.Image = ((System.Drawing.Image)(resources.GetObject("btFromDisk.Image")));
            this.btFromDisk.Location = new System.Drawing.Point(58, 12);
            this.btFromDisk.Name = "btFromDisk";
            this.btFromDisk.Size = new System.Drawing.Size(40, 40);
            this.btFromDisk.TabIndex = 0;
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
            this.btToCSV.UseVisualStyleBackColor = true;
            // 
            // btToTXT
            // 
            this.btToTXT.Enabled = false;
            this.btToTXT.Image = ((System.Drawing.Image)(resources.GetObject("btToTXT.Image")));
            this.btToTXT.Location = new System.Drawing.Point(178, 12);
            this.btToTXT.Name = "btToTXT";
            this.btToTXT.Size = new System.Drawing.Size(40, 40);
            this.btToTXT.TabIndex = 3;
            this.btToTXT.UseVisualStyleBackColor = true;
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
            this.btFromClipboard.UseVisualStyleBackColor = true;
            this.btFromClipboard.Click += new System.EventHandler(this.btFromClipboard_Click);
            // 
            // fmTableParseMagic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 182);
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
    }
}

