namespace OtoparkOtomasyon.Forms
{
    partial class frmOtoparkLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtoparkLeave));
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.cmbParkAreaSearch = new System.Windows.Forms.ComboBox();
            this.cmbPlakaSearch = new System.Windows.Forms.ComboBox();
            this.txtNameSurnameSearch = new System.Windows.Forms.TextBox();
            this.txtCustomerIDSearch = new System.Windows.Forms.TextBox();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlIslem = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnParkAreaUpdate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCarLeave = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblLeaveTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblEntre = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.cmbPerHourPrice = new System.Windows.Forms.ComboBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cmbParkArea = new System.Windows.Forms.ComboBox();
            this.cmbSerie = new System.Windows.Forms.ComboBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlSearch.SuspendLayout();
            this.pnlIslem.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.cmbParkAreaSearch);
            this.pnlSearch.Controls.Add(this.cmbPlakaSearch);
            this.pnlSearch.Controls.Add(this.txtNameSurnameSearch);
            this.pnlSearch.Controls.Add(this.txtCustomerIDSearch);
            this.pnlSearch.Controls.Add(this.txtIDSearch);
            this.pnlSearch.Controls.Add(this.label5);
            this.pnlSearch.Controls.Add(this.label4);
            this.pnlSearch.Controls.Add(this.label3);
            this.pnlSearch.Controls.Add(this.label2);
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(719, 61);
            this.pnlSearch.TabIndex = 0;
            // 
            // cmbParkAreaSearch
            // 
            this.cmbParkAreaSearch.FormattingEnabled = true;
            this.cmbParkAreaSearch.Location = new System.Drawing.Point(574, 23);
            this.cmbParkAreaSearch.Name = "cmbParkAreaSearch";
            this.cmbParkAreaSearch.Size = new System.Drawing.Size(138, 21);
            this.cmbParkAreaSearch.TabIndex = 5;
            this.cmbParkAreaSearch.SelectedIndexChanged += new System.EventHandler(this.cmbParkAreaSearch_SelectedIndexChanged);
            this.cmbParkAreaSearch.TextChanged += new System.EventHandler(this.cmbParkAreaSearch_TextChanged);
            // 
            // cmbPlakaSearch
            // 
            this.cmbPlakaSearch.FormattingEnabled = true;
            this.cmbPlakaSearch.Location = new System.Drawing.Point(435, 23);
            this.cmbPlakaSearch.Name = "cmbPlakaSearch";
            this.cmbPlakaSearch.Size = new System.Drawing.Size(133, 21);
            this.cmbPlakaSearch.TabIndex = 4;
            this.cmbPlakaSearch.SelectedIndexChanged += new System.EventHandler(this.cmbPlakaSearch_SelectedIndexChanged);
            this.cmbPlakaSearch.TextChanged += new System.EventHandler(this.cmbPlakaSearch_TextChanged);
            // 
            // txtNameSurnameSearch
            // 
            this.txtNameSurnameSearch.Location = new System.Drawing.Point(304, 24);
            this.txtNameSurnameSearch.Multiline = true;
            this.txtNameSurnameSearch.Name = "txtNameSurnameSearch";
            this.txtNameSurnameSearch.Size = new System.Drawing.Size(125, 20);
            this.txtNameSurnameSearch.TabIndex = 3;
            this.txtNameSurnameSearch.TextChanged += new System.EventHandler(this.txNameSurnameSearch_TextChanged);
            // 
            // txtCustomerIDSearch
            // 
            this.txtCustomerIDSearch.Location = new System.Drawing.Point(161, 24);
            this.txtCustomerIDSearch.Multiline = true;
            this.txtCustomerIDSearch.Name = "txtCustomerIDSearch";
            this.txtCustomerIDSearch.Size = new System.Drawing.Size(137, 20);
            this.txtCustomerIDSearch.TabIndex = 2;
            this.txtCustomerIDSearch.TextChanged += new System.EventHandler(this.txtCustomerIDSearch_TextChanged);
            // 
            // txtIDSearch
            // 
            this.txtIDSearch.Location = new System.Drawing.Point(24, 25);
            this.txtIDSearch.Multiline = true;
            this.txtIDSearch.Name = "txtIDSearch";
            this.txtIDSearch.Size = new System.Drawing.Size(131, 20);
            this.txtIDSearch.TabIndex = 1;
            this.txtIDSearch.TextChanged += new System.EventHandler(this.txtIDSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Park Yeri Ara";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Plaka Ara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad-Soyada Göre Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri ID Arama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Arama";
            // 
            // pnlIslem
            // 
            this.pnlIslem.Controls.Add(this.btnExit);
            this.pnlIslem.Controls.Add(this.btnClear);
            this.pnlIslem.Controls.Add(this.btnDelete);
            this.pnlIslem.Controls.Add(this.btnParkAreaUpdate);
            this.pnlIslem.Controls.Add(this.btnUpdate);
            this.pnlIslem.Controls.Add(this.btnCarLeave);
            this.pnlIslem.Controls.Add(this.label25);
            this.pnlIslem.Controls.Add(this.lblTotalPrice);
            this.pnlIslem.Controls.Add(this.lblLeaveTime);
            this.pnlIslem.Controls.Add(this.lblTime);
            this.pnlIslem.Controls.Add(this.lblEntre);
            this.pnlIslem.Controls.Add(this.label21);
            this.pnlIslem.Controls.Add(this.label23);
            this.pnlIslem.Controls.Add(this.label19);
            this.pnlIslem.Controls.Add(this.label17);
            this.pnlIslem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlIslem.Location = new System.Drawing.Point(0, 203);
            this.pnlIslem.Name = "pnlIslem";
            this.pnlIslem.Size = new System.Drawing.Size(719, 247);
            this.pnlIslem.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(587, 133);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 51);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Formu Kapat";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(489, 133);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 51);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Formu Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(391, 133);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 51);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnParkAreaUpdate
            // 
            this.btnParkAreaUpdate.Location = new System.Drawing.Point(293, 133);
            this.btnParkAreaUpdate.Name = "btnParkAreaUpdate";
            this.btnParkAreaUpdate.Size = new System.Drawing.Size(75, 51);
            this.btnParkAreaUpdate.TabIndex = 3;
            this.btnParkAreaUpdate.Text = "Park Yeri Güncelle";
            this.btnParkAreaUpdate.UseVisualStyleBackColor = true;
            this.btnParkAreaUpdate.Click += new System.EventHandler(this.btnParkAreaUpdate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(195, 133);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 51);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Bilgileri Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCarLeave
            // 
            this.btnCarLeave.Location = new System.Drawing.Point(97, 133);
            this.btnCarLeave.Name = "btnCarLeave";
            this.btnCarLeave.Size = new System.Drawing.Size(75, 51);
            this.btnCarLeave.TabIndex = 1;
            this.btnCarLeave.Text = "Araç Çıkışı";
            this.btnCarLeave.UseVisualStyleBackColor = true;
            this.btnCarLeave.Click += new System.EventHandler(this.btnCarLeave_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(672, 65);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 20);
            this.label25.TabIndex = 9;
            this.label25.Text = "TL";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPrice.Location = new System.Drawing.Point(607, 62);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(59, 23);
            this.lblTotalPrice.TabIndex = 8;
            this.lblTotalPrice.Text = "30,65";
            // 
            // lblLeaveTime
            // 
            this.lblLeaveTime.AutoSize = true;
            this.lblLeaveTime.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLeaveTime.ForeColor = System.Drawing.Color.Red;
            this.lblLeaveTime.Location = new System.Drawing.Point(203, 62);
            this.lblLeaveTime.Name = "lblLeaveTime";
            this.lblLeaveTime.Size = new System.Drawing.Size(189, 23);
            this.lblLeaveTime.TabIndex = 8;
            this.lblLeaveTime.Text = "05.01.2020 01:58:34";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(455, 62);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(59, 23);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "25,55";
            // 
            // lblEntre
            // 
            this.lblEntre.AutoSize = true;
            this.lblEntre.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEntre.ForeColor = System.Drawing.Color.Red;
            this.lblEntre.Location = new System.Drawing.Point(3, 62);
            this.lblEntre.Name = "lblEntre";
            this.lblEntre.Size = new System.Drawing.Size(189, 23);
            this.lblEntre.TabIndex = 8;
            this.lblEntre.Text = "05.01.2020 00:58:34";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(578, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(129, 23);
            this.label21.TabIndex = 8;
            this.label21.Text = "Toplam Ücret";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(227, 27);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(108, 23);
            this.label23.TabIndex = 8;
            this.label23.Text = "Çıkış Tarihi";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(421, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(123, 23);
            this.label19.TabIndex = 8;
            this.label19.Text = "Kalınan Süre";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(52, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 23);
            this.label17.TabIndex = 8;
            this.label17.Text = "Giriş Tarihi";
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.cmbPerHourPrice);
            this.pnlInfo.Controls.Add(this.txtDesc);
            this.pnlInfo.Controls.Add(this.cmbParkArea);
            this.pnlInfo.Controls.Add(this.cmbSerie);
            this.pnlInfo.Controls.Add(this.cmbBrand);
            this.pnlInfo.Controls.Add(this.txtPhone);
            this.pnlInfo.Controls.Add(this.txtPlaka);
            this.pnlInfo.Controls.Add(this.txtNameSurname);
            this.pnlInfo.Controls.Add(this.txtCustomerId);
            this.pnlInfo.Controls.Add(this.txtColor);
            this.pnlInfo.Controls.Add(this.label13);
            this.pnlInfo.Controls.Add(this.label16);
            this.pnlInfo.Controls.Add(this.txtId);
            this.pnlInfo.Controls.Add(this.label12);
            this.pnlInfo.Controls.Add(this.label15);
            this.pnlInfo.Controls.Add(this.label9);
            this.pnlInfo.Controls.Add(this.label11);
            this.pnlInfo.Controls.Add(this.label14);
            this.pnlInfo.Controls.Add(this.label8);
            this.pnlInfo.Controls.Add(this.label10);
            this.pnlInfo.Controls.Add(this.label7);
            this.pnlInfo.Controls.Add(this.label6);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfo.Location = new System.Drawing.Point(0, 61);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(719, 142);
            this.pnlInfo.TabIndex = 1;
            // 
            // cmbPerHourPrice
            // 
            this.cmbPerHourPrice.FormattingEnabled = true;
            this.cmbPerHourPrice.Items.AddRange(new object[] {
            "1,25",
            "1,00"});
            this.cmbPerHourPrice.Location = new System.Drawing.Point(315, 98);
            this.cmbPerHourPrice.Name = "cmbPerHourPrice";
            this.cmbPerHourPrice.Size = new System.Drawing.Size(160, 21);
            this.cmbPerHourPrice.TabIndex = 7;
            this.cmbPerHourPrice.SelectedIndexChanged += new System.EventHandler(this.cmbPerHourPrice_SelectedIndexChanged);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(555, 75);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(157, 42);
            this.txtDesc.TabIndex = 10;
            // 
            // cmbParkArea
            // 
            this.cmbParkArea.FormattingEnabled = true;
            this.cmbParkArea.Location = new System.Drawing.Point(555, 44);
            this.cmbParkArea.Name = "cmbParkArea";
            this.cmbParkArea.Size = new System.Drawing.Size(157, 21);
            this.cmbParkArea.TabIndex = 9;
            // 
            // cmbSerie
            // 
            this.cmbSerie.FormattingEnabled = true;
            this.cmbSerie.Location = new System.Drawing.Point(315, 44);
            this.cmbSerie.Name = "cmbSerie";
            this.cmbSerie.Size = new System.Drawing.Size(160, 21);
            this.cmbSerie.TabIndex = 5;
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(315, 17);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(160, 21);
            this.cmbBrand.TabIndex = 4;
            this.cmbBrand.SelectedIndexChanged += new System.EventHandler(this.cmbBrand_SelectedIndexChanged);
            this.cmbBrand.ValueMemberChanged += new System.EventHandler(this.cmbBrand_ValueMemberChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(75, 96);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(160, 20);
            this.txtPhone.TabIndex = 3;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(315, 71);
            this.txtPlaka.Multiline = true;
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(160, 20);
            this.txtPlaka.TabIndex = 6;
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Location = new System.Drawing.Point(75, 70);
            this.txtNameSurname.Multiline = true;
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(160, 20);
            this.txtNameSurname.TabIndex = 2;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(75, 44);
            this.txtCustomerId.Multiline = true;
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(160, 20);
            this.txtCustomerId.TabIndex = 1;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(555, 17);
            this.txtColor.Multiline = true;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(157, 20);
            this.txtColor.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(249, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Saat Ücreti";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(499, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Açıklama";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(75, 18);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(160, 20);
            this.txtId.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(264, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Plaka";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(499, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Park Yeri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Telefon No:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Seri";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(499, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Renk";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ad-Soyad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Marka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Müşteri ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "ID";
            // 
            // frmOtoparkLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlIslem);
            this.Controls.Add(this.pnlSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOtoparkLeave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Otopark Çıkış İşlemleri";
            this.Load += new System.EventHandler(this.frmOtoparkLeave_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlIslem.ResumeLayout(false);
            this.pnlIslem.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.ComboBox cmbParkAreaSearch;
        private System.Windows.Forms.ComboBox cmbPlakaSearch;
        private System.Windows.Forms.TextBox txtNameSurnameSearch;
        private System.Windows.Forms.TextBox txtCustomerIDSearch;
        private System.Windows.Forms.TextBox txtIDSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlIslem;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSerie;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.ComboBox cmbParkArea;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblEntre;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbPerHourPrice;
        private System.Windows.Forms.Label lblLeaveTime;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnParkAreaUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCarLeave;
        private System.Windows.Forms.Button btnClear;
    }
}