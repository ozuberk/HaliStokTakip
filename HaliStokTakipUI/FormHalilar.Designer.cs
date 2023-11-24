namespace HaliStokTakipUI
{
    partial class FormHalilar
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
            this.groupBoxHaliBilgileri = new System.Windows.Forms.GroupBox();
            this.mskdFiyat = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxBoyut = new System.Windows.Forms.ComboBox();
            this.labelBoyutID = new System.Windows.Forms.Label();
            this.textBoxHaliAdi = new System.Windows.Forms.TextBox();
            this.labelAdi = new System.Windows.Forms.Label();
            this.dateTimePickerUretimTarihi = new System.Windows.Forms.DateTimePicker();
            this.textBoxAciklama = new System.Windows.Forms.TextBox();
            this.maskedTextBoxBarkod = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxMarka = new System.Windows.Forms.ComboBox();
            this.comboBoxRenk = new System.Windows.Forms.ComboBox();
            this.comboBoxDesen = new System.Windows.Forms.ComboBox();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.labeluretimTarihi = new System.Windows.Forms.Label();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.labelBarkodNo = new System.Windows.Forms.Label();
            this.labelDesenID = new System.Windows.Forms.Label();
            this.labelRenkID = new System.Windows.Forms.Label();
            this.labelMarkaID = new System.Windows.Forms.Label();
            this.labelKategoriID = new System.Windows.Forms.Label();
            this.radioButtonHayir = new System.Windows.Forms.RadioButton();
            this.radioButtonEvet = new System.Windows.Forms.RadioButton();
            this.labelAktifMi = new System.Windows.Forms.Label();
            this.labelAciklama = new System.Windows.Forms.Label();
            this.groupBoxHalilar = new System.Windows.Forms.GroupBox();
            this.dataGridViewHalilar = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.groupBoxHaliBilgileri.SuspendLayout();
            this.groupBoxHalilar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHalilar)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonKaydet,
            this.toolStripButtonGuncelle,
            this.toolStripButtonSil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1257, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonKaydet
            // 
            this.toolStripButtonKaydet.Image = global::HaliStokTakipUI.Properties.Resources.Kaydet;
            this.toolStripButtonKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonKaydet.Name = "toolStripButtonKaydet";
            this.toolStripButtonKaydet.Size = new System.Drawing.Size(79, 24);
            this.toolStripButtonKaydet.Text = "Kaydet";
            this.toolStripButtonKaydet.Click += new System.EventHandler(this.toolStripButtonKaydet_Click);
            // 
            // toolStripButtonGuncelle
            // 
            this.toolStripButtonGuncelle.Image = global::HaliStokTakipUI.Properties.Resources.Guncelle;
            this.toolStripButtonGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuncelle.Name = "toolStripButtonGuncelle";
            this.toolStripButtonGuncelle.Size = new System.Drawing.Size(90, 24);
            this.toolStripButtonGuncelle.Text = "Güncelle";
            this.toolStripButtonGuncelle.Click += new System.EventHandler(this.toolStripButtonGuncelle_Click);
            // 
            // toolStripButtonSil
            // 
            this.toolStripButtonSil.Image = global::HaliStokTakipUI.Properties.Resources.Sil;
            this.toolStripButtonSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSil.Name = "toolStripButtonSil";
            this.toolStripButtonSil.Size = new System.Drawing.Size(49, 24);
            this.toolStripButtonSil.Text = "Sil";
            this.toolStripButtonSil.Click += new System.EventHandler(this.toolStripButtonSil_Click);
            // 
            // groupBoxHaliBilgileri
            // 
            this.groupBoxHaliBilgileri.Controls.Add(this.mskdFiyat);
            this.groupBoxHaliBilgileri.Controls.Add(this.comboBoxBoyut);
            this.groupBoxHaliBilgileri.Controls.Add(this.labelBoyutID);
            this.groupBoxHaliBilgileri.Controls.Add(this.textBoxHaliAdi);
            this.groupBoxHaliBilgileri.Controls.Add(this.labelAdi);
            this.groupBoxHaliBilgileri.Controls.Add(this.dateTimePickerUretimTarihi);
            this.groupBoxHaliBilgileri.Controls.Add(this.textBoxAciklama);
            this.groupBoxHaliBilgileri.Controls.Add(this.maskedTextBoxBarkod);
            this.groupBoxHaliBilgileri.Controls.Add(this.comboBoxMarka);
            this.groupBoxHaliBilgileri.Controls.Add(this.comboBoxRenk);
            this.groupBoxHaliBilgileri.Controls.Add(this.comboBoxDesen);
            this.groupBoxHaliBilgileri.Controls.Add(this.comboBoxKategori);
            this.groupBoxHaliBilgileri.Controls.Add(this.labeluretimTarihi);
            this.groupBoxHaliBilgileri.Controls.Add(this.labelFiyat);
            this.groupBoxHaliBilgileri.Controls.Add(this.labelBarkodNo);
            this.groupBoxHaliBilgileri.Controls.Add(this.labelDesenID);
            this.groupBoxHaliBilgileri.Controls.Add(this.labelRenkID);
            this.groupBoxHaliBilgileri.Controls.Add(this.labelMarkaID);
            this.groupBoxHaliBilgileri.Controls.Add(this.labelKategoriID);
            this.groupBoxHaliBilgileri.Controls.Add(this.radioButtonHayir);
            this.groupBoxHaliBilgileri.Controls.Add(this.radioButtonEvet);
            this.groupBoxHaliBilgileri.Controls.Add(this.labelAktifMi);
            this.groupBoxHaliBilgileri.Controls.Add(this.labelAciklama);
            this.groupBoxHaliBilgileri.Location = new System.Drawing.Point(-4, 32);
            this.groupBoxHaliBilgileri.Name = "groupBoxHaliBilgileri";
            this.groupBoxHaliBilgileri.Size = new System.Drawing.Size(1257, 225);
            this.groupBoxHaliBilgileri.TabIndex = 2;
            this.groupBoxHaliBilgileri.TabStop = false;
            this.groupBoxHaliBilgileri.Text = "Halı Bilgileri";
            // 
            // mskdFiyat
            // 
            this.mskdFiyat.Location = new System.Drawing.Point(588, 63);
            this.mskdFiyat.Mask = "000000000000";
            this.mskdFiyat.Name = "mskdFiyat";
            this.mskdFiyat.Size = new System.Drawing.Size(224, 22);
            this.mskdFiyat.TabIndex = 29;
            // 
            // comboBoxBoyut
            // 
            this.comboBoxBoyut.FormattingEnabled = true;
            this.comboBoxBoyut.Location = new System.Drawing.Point(145, 163);
            this.comboBoxBoyut.Name = "comboBoxBoyut";
            this.comboBoxBoyut.Size = new System.Drawing.Size(188, 24);
            this.comboBoxBoyut.TabIndex = 28;
            // 
            // labelBoyutID
            // 
            this.labelBoyutID.AutoSize = true;
            this.labelBoyutID.Location = new System.Drawing.Point(42, 166);
            this.labelBoyutID.Name = "labelBoyutID";
            this.labelBoyutID.Size = new System.Drawing.Size(67, 16);
            this.labelBoyutID.TabIndex = 27;
            this.labelBoyutID.Text = "Boyut Adı:";
            // 
            // textBoxHaliAdi
            // 
            this.textBoxHaliAdi.Location = new System.Drawing.Point(588, 29);
            this.textBoxHaliAdi.Name = "textBoxHaliAdi";
            this.textBoxHaliAdi.Size = new System.Drawing.Size(224, 22);
            this.textBoxHaliAdi.TabIndex = 26;
            // 
            // labelAdi
            // 
            this.labelAdi.AutoSize = true;
            this.labelAdi.Location = new System.Drawing.Point(493, 30);
            this.labelAdi.Name = "labelAdi";
            this.labelAdi.Size = new System.Drawing.Size(57, 16);
            this.labelAdi.TabIndex = 25;
            this.labelAdi.Text = "Halı Adı:";
            // 
            // dateTimePickerUretimTarihi
            // 
            this.dateTimePickerUretimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerUretimTarihi.Location = new System.Drawing.Point(588, 199);
            this.dateTimePickerUretimTarihi.Name = "dateTimePickerUretimTarihi";
            this.dateTimePickerUretimTarihi.Size = new System.Drawing.Size(224, 22);
            this.dateTimePickerUretimTarihi.TabIndex = 23;
            // 
            // textBoxAciklama
            // 
            this.textBoxAciklama.Location = new System.Drawing.Point(588, 98);
            this.textBoxAciklama.Multiline = true;
            this.textBoxAciklama.Name = "textBoxAciklama";
            this.textBoxAciklama.Size = new System.Drawing.Size(224, 89);
            this.textBoxAciklama.TabIndex = 22;
            // 
            // maskedTextBoxBarkod
            // 
            this.maskedTextBoxBarkod.Location = new System.Drawing.Point(145, 197);
            this.maskedTextBoxBarkod.Mask = "000000000000";
            this.maskedTextBoxBarkod.Name = "maskedTextBoxBarkod";
            this.maskedTextBoxBarkod.Size = new System.Drawing.Size(188, 22);
            this.maskedTextBoxBarkod.TabIndex = 20;
            // 
            // comboBoxMarka
            // 
            this.comboBoxMarka.FormattingEnabled = true;
            this.comboBoxMarka.Location = new System.Drawing.Point(145, 60);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(188, 24);
            this.comboBoxMarka.TabIndex = 19;
            // 
            // comboBoxRenk
            // 
            this.comboBoxRenk.FormattingEnabled = true;
            this.comboBoxRenk.Location = new System.Drawing.Point(145, 95);
            this.comboBoxRenk.Name = "comboBoxRenk";
            this.comboBoxRenk.Size = new System.Drawing.Size(188, 24);
            this.comboBoxRenk.TabIndex = 18;
            // 
            // comboBoxDesen
            // 
            this.comboBoxDesen.FormattingEnabled = true;
            this.comboBoxDesen.Location = new System.Drawing.Point(145, 129);
            this.comboBoxDesen.Name = "comboBoxDesen";
            this.comboBoxDesen.Size = new System.Drawing.Size(188, 24);
            this.comboBoxDesen.TabIndex = 17;
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(145, 27);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(188, 24);
            this.comboBoxKategori.TabIndex = 14;
            // 
            // labeluretimTarihi
            // 
            this.labeluretimTarihi.AutoSize = true;
            this.labeluretimTarihi.Location = new System.Drawing.Point(493, 200);
            this.labeluretimTarihi.Name = "labeluretimTarihi";
            this.labeluretimTarihi.Size = new System.Drawing.Size(89, 16);
            this.labeluretimTarihi.TabIndex = 13;
            this.labeluretimTarihi.Text = "Üretim Tarihi: ";
            // 
            // labelFiyat
            // 
            this.labelFiyat.AutoSize = true;
            this.labelFiyat.Location = new System.Drawing.Point(493, 66);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(36, 16);
            this.labelFiyat.TabIndex = 12;
            this.labelFiyat.Text = "Fiyat";
            // 
            // labelBarkodNo
            // 
            this.labelBarkodNo.AutoSize = true;
            this.labelBarkodNo.Location = new System.Drawing.Point(42, 199);
            this.labelBarkodNo.Name = "labelBarkodNo";
            this.labelBarkodNo.Size = new System.Drawing.Size(78, 16);
            this.labelBarkodNo.TabIndex = 11;
            this.labelBarkodNo.Text = "Barkod No: ";
            // 
            // labelDesenID
            // 
            this.labelDesenID.AutoSize = true;
            this.labelDesenID.Location = new System.Drawing.Point(42, 132);
            this.labelDesenID.Name = "labelDesenID";
            this.labelDesenID.Size = new System.Drawing.Size(73, 16);
            this.labelDesenID.TabIndex = 10;
            this.labelDesenID.Text = "Desen Adı:";
            // 
            // labelRenkID
            // 
            this.labelRenkID.AutoSize = true;
            this.labelRenkID.Location = new System.Drawing.Point(42, 98);
            this.labelRenkID.Name = "labelRenkID";
            this.labelRenkID.Size = new System.Drawing.Size(65, 16);
            this.labelRenkID.TabIndex = 9;
            this.labelRenkID.Text = "Renk Adı:";
            // 
            // labelMarkaID
            // 
            this.labelMarkaID.AutoSize = true;
            this.labelMarkaID.Location = new System.Drawing.Point(42, 64);
            this.labelMarkaID.Name = "labelMarkaID";
            this.labelMarkaID.Size = new System.Drawing.Size(71, 16);
            this.labelMarkaID.TabIndex = 8;
            this.labelMarkaID.Text = "Marka Adı:";
            // 
            // labelKategoriID
            // 
            this.labelKategoriID.AutoSize = true;
            this.labelKategoriID.Location = new System.Drawing.Point(42, 30);
            this.labelKategoriID.Name = "labelKategoriID";
            this.labelKategoriID.Size = new System.Drawing.Size(83, 16);
            this.labelKategoriID.TabIndex = 7;
            this.labelKategoriID.Text = "Kategori Adı:";
            // 
            // radioButtonHayir
            // 
            this.radioButtonHayir.AutoSize = true;
            this.radioButtonHayir.Location = new System.Drawing.Point(1009, 66);
            this.radioButtonHayir.Name = "radioButtonHayir";
            this.radioButtonHayir.Size = new System.Drawing.Size(60, 20);
            this.radioButtonHayir.TabIndex = 5;
            this.radioButtonHayir.TabStop = true;
            this.radioButtonHayir.Text = "Hayır";
            this.radioButtonHayir.UseVisualStyleBackColor = true;
            // 
            // radioButtonEvet
            // 
            this.radioButtonEvet.AutoSize = true;
            this.radioButtonEvet.Location = new System.Drawing.Point(911, 66);
            this.radioButtonEvet.Name = "radioButtonEvet";
            this.radioButtonEvet.Size = new System.Drawing.Size(55, 20);
            this.radioButtonEvet.TabIndex = 4;
            this.radioButtonEvet.TabStop = true;
            this.radioButtonEvet.Text = "Evet";
            this.radioButtonEvet.UseVisualStyleBackColor = true;
            // 
            // labelAktifMi
            // 
            this.labelAktifMi.AutoSize = true;
            this.labelAktifMi.Location = new System.Drawing.Point(960, 32);
            this.labelAktifMi.Name = "labelAktifMi";
            this.labelAktifMi.Size = new System.Drawing.Size(49, 16);
            this.labelAktifMi.TabIndex = 2;
            this.labelAktifMi.Text = "Aktif Mi";
            // 
            // labelAciklama
            // 
            this.labelAciklama.AutoSize = true;
            this.labelAciklama.Location = new System.Drawing.Point(493, 98);
            this.labelAciklama.Name = "labelAciklama";
            this.labelAciklama.Size = new System.Drawing.Size(69, 16);
            this.labelAciklama.TabIndex = 1;
            this.labelAciklama.Text = "Açıklama :";
            // 
            // groupBoxHalilar
            // 
            this.groupBoxHalilar.Controls.Add(this.dataGridViewHalilar);
            this.groupBoxHalilar.Location = new System.Drawing.Point(2, 263);
            this.groupBoxHalilar.Name = "groupBoxHalilar";
            this.groupBoxHalilar.Size = new System.Drawing.Size(1257, 364);
            this.groupBoxHalilar.TabIndex = 3;
            this.groupBoxHalilar.TabStop = false;
            this.groupBoxHalilar.Text = "Halılar";
            // 
            // dataGridViewHalilar
            // 
            this.dataGridViewHalilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHalilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHalilar.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewHalilar.Name = "dataGridViewHalilar";
            this.dataGridViewHalilar.RowHeadersWidth = 51;
            this.dataGridViewHalilar.RowTemplate.Height = 24;
            this.dataGridViewHalilar.Size = new System.Drawing.Size(1251, 343);
            this.dataGridViewHalilar.TabIndex = 0;
            this.dataGridViewHalilar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHalilar_CellDoubleClick);
            this.dataGridViewHalilar.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewHalilar_CellFormatting);
            // 
            // FormHalilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 625);
            this.Controls.Add(this.groupBoxHalilar);
            this.Controls.Add(this.groupBoxHaliBilgileri);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHalilar";
            this.Text = "FormHalilar";
            this.Load += new System.EventHandler(this.FormHalilar_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxHaliBilgileri.ResumeLayout(false);
            this.groupBoxHaliBilgileri.PerformLayout();
            this.groupBoxHalilar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHalilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSil;
        private System.Windows.Forms.GroupBox groupBoxHaliBilgileri;
        private System.Windows.Forms.RadioButton radioButtonHayir;
        private System.Windows.Forms.RadioButton radioButtonEvet;
        private System.Windows.Forms.Label labelAktifMi;
        private System.Windows.Forms.Label labelAciklama;
        private System.Windows.Forms.Label labeluretimTarihi;
        private System.Windows.Forms.Label labelFiyat;
        private System.Windows.Forms.Label labelBarkodNo;
        private System.Windows.Forms.Label labelDesenID;
        private System.Windows.Forms.Label labelRenkID;
        private System.Windows.Forms.Label labelMarkaID;
        private System.Windows.Forms.Label labelKategoriID;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBarkod;
        private System.Windows.Forms.ComboBox comboBoxMarka;
        private System.Windows.Forms.ComboBox comboBoxRenk;
        private System.Windows.Forms.ComboBox comboBoxDesen;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.DateTimePicker dateTimePickerUretimTarihi;
        private System.Windows.Forms.TextBox textBoxAciklama;
        private System.Windows.Forms.GroupBox groupBoxHalilar;
        private System.Windows.Forms.DataGridView dataGridViewHalilar;
        private System.Windows.Forms.TextBox textBoxHaliAdi;
        private System.Windows.Forms.Label labelAdi;
        private System.Windows.Forms.ComboBox comboBoxBoyut;
        private System.Windows.Forms.Label labelBoyutID;
        private System.Windows.Forms.MaskedTextBox mskdFiyat;
    }
}