namespace OtoparkOtomasyon.Forms
{
    partial class frmSell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSell));
            this.txtNameSurnameSearch = new System.Windows.Forms.TextBox();
            this.txtCustomerIDSearch = new System.Windows.Forms.TextBox();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.txtPlakaSearch = new System.Windows.Forms.TextBox();
            this.txtParkAreaSearch = new System.Windows.Forms.TextBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblKayit = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameSurnameSearch
            // 
            this.txtNameSurnameSearch.Location = new System.Drawing.Point(298, 24);
            this.txtNameSurnameSearch.Multiline = true;
            this.txtNameSurnameSearch.Name = "txtNameSurnameSearch";
            this.txtNameSurnameSearch.Size = new System.Drawing.Size(125, 20);
            this.txtNameSurnameSearch.TabIndex = 3;
            this.txtNameSurnameSearch.TextChanged += new System.EventHandler(this.txtNameSurnameSearch_TextChanged);
            // 
            // txtCustomerIDSearch
            // 
            this.txtCustomerIDSearch.Location = new System.Drawing.Point(155, 24);
            this.txtCustomerIDSearch.Multiline = true;
            this.txtCustomerIDSearch.Name = "txtCustomerIDSearch";
            this.txtCustomerIDSearch.Size = new System.Drawing.Size(137, 20);
            this.txtCustomerIDSearch.TabIndex = 2;
            this.txtCustomerIDSearch.TextChanged += new System.EventHandler(this.txtCustomerIDSearch_TextChanged);
            // 
            // txtIDSearch
            // 
            this.txtIDSearch.Location = new System.Drawing.Point(18, 24);
            this.txtIDSearch.Multiline = true;
            this.txtIDSearch.Name = "txtIDSearch";
            this.txtIDSearch.Size = new System.Drawing.Size(131, 20);
            this.txtIDSearch.TabIndex = 1;
            this.txtIDSearch.TextChanged += new System.EventHandler(this.txtIDSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Park Yeri Ara";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Plaka Ara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ad-Soyada Göre Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Müşteri ID Arama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID Arama";
            // 
            // dtGridView
            // 
            this.dtGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(12, 52);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.Size = new System.Drawing.Size(878, 229);
            this.dtGridView.TabIndex = 16;
            // 
            // txtPlakaSearch
            // 
            this.txtPlakaSearch.Location = new System.Drawing.Point(429, 24);
            this.txtPlakaSearch.Multiline = true;
            this.txtPlakaSearch.Name = "txtPlakaSearch";
            this.txtPlakaSearch.Size = new System.Drawing.Size(125, 20);
            this.txtPlakaSearch.TabIndex = 4;
            this.txtPlakaSearch.TextChanged += new System.EventHandler(this.txtPlakaSearch_TextChanged);
            // 
            // txtParkAreaSearch
            // 
            this.txtParkAreaSearch.Location = new System.Drawing.Point(560, 24);
            this.txtParkAreaSearch.Multiline = true;
            this.txtParkAreaSearch.Name = "txtParkAreaSearch";
            this.txtParkAreaSearch.Size = new System.Drawing.Size(125, 20);
            this.txtParkAreaSearch.TabIndex = 5;
            this.txtParkAreaSearch.TextChanged += new System.EventHandler(this.txtParkAreaSearch_TextChanged);
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(15, 308);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(35, 13);
            this.lblTutar.TabIndex = 17;
            this.lblTutar.Text = "label6";
            // 
            // lblKayit
            // 
            this.lblKayit.AutoSize = true;
            this.lblKayit.Location = new System.Drawing.Point(15, 340);
            this.lblKayit.Name = "lblKayit";
            this.lblKayit.Size = new System.Drawing.Size(35, 13);
            this.lblKayit.TabIndex = 17;
            this.lblKayit.Text = "label6";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(15, 371);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(35, 13);
            this.lblOrtalama.TabIndex = 17;
            this.lblOrtalama.Text = "label6";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(388, 308);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(35, 13);
            this.lblMax.TabIndex = 17;
            this.lblMax.Text = "label6";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(388, 340);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(35, 13);
            this.lblMin.TabIndex = 17;
            this.lblMin.Text = "label6";
            // 
            // frmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 406);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblKayit);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.txtPlakaSearch);
            this.Controls.Add(this.txtParkAreaSearch);
            this.Controls.Add(this.txtNameSurnameSearch);
            this.Controls.Add(this.txtCustomerIDSearch);
            this.Controls.Add(this.txtIDSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış İşlemi";
            this.Load += new System.EventHandler(this.frmSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNameSurnameSearch;
        private System.Windows.Forms.TextBox txtCustomerIDSearch;
        private System.Windows.Forms.TextBox txtIDSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.TextBox txtPlakaSearch;
        private System.Windows.Forms.TextBox txtParkAreaSearch;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblKayit;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
    }
}