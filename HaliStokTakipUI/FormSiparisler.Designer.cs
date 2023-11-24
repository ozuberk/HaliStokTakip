namespace HaliStokTakipUI
{
    partial class FormSiparisler
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
            this.toolSiparisKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolSiparisGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolSiparisSil = new System.Windows.Forms.ToolStripButton();
            this.grbSiparisBilgileri = new System.Windows.Forms.GroupBox();
            this.btnHaliEkle = new System.Windows.Forms.Button();
            this.chbHalilar = new System.Windows.Forms.CheckedListBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHalilar = new System.Windows.Forms.Label();
            this.mskdSiparisTotal = new System.Windows.Forms.MaskedTextBox();
            this.rbSiparisHayir = new System.Windows.Forms.RadioButton();
            this.rbSiparisEvet = new System.Windows.Forms.RadioButton();
            this.dtpSiparisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpTeslimatTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblTeslimatTarihi = new System.Windows.Forms.Label();
            this.lblSiparisToplamTutar = new System.Windows.Forms.Label();
            this.lblSiparisDurumu = new System.Windows.Forms.Label();
            this.lblSiparisTarihi = new System.Windows.Forms.Label();
            this.cbSiparisMusteriAdi = new System.Windows.Forms.ComboBox();
            this.txtSiparisAdi = new System.Windows.Forms.TextBox();
            this.lblSiparisAdi = new System.Windows.Forms.Label();
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.groupBoxSiparisler = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.grbSiparisBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.groupBoxSiparisler.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSiparisKaydet,
            this.toolSiparisGuncelle,
            this.toolSiparisSil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1257, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolSiparisKaydet
            // 
            this.toolSiparisKaydet.Image = global::HaliStokTakipUI.Properties.Resources.Kaydet;
            this.toolSiparisKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSiparisKaydet.Name = "toolSiparisKaydet";
            this.toolSiparisKaydet.Size = new System.Drawing.Size(79, 24);
            this.toolSiparisKaydet.Text = "Kaydet";
            this.toolSiparisKaydet.Click += new System.EventHandler(this.toolSiparisKaydet_Click);
            // 
            // toolSiparisGuncelle
            // 
            this.toolSiparisGuncelle.Image = global::HaliStokTakipUI.Properties.Resources.Guncelle;
            this.toolSiparisGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSiparisGuncelle.Name = "toolSiparisGuncelle";
            this.toolSiparisGuncelle.Size = new System.Drawing.Size(90, 24);
            this.toolSiparisGuncelle.Text = "Güncelle";
            this.toolSiparisGuncelle.Click += new System.EventHandler(this.toolSiparisGuncelle_Click);
            // 
            // toolSiparisSil
            // 
            this.toolSiparisSil.Image = global::HaliStokTakipUI.Properties.Resources.Sil;
            this.toolSiparisSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSiparisSil.Name = "toolSiparisSil";
            this.toolSiparisSil.Size = new System.Drawing.Size(49, 24);
            this.toolSiparisSil.Text = "Sil";
            this.toolSiparisSil.Click += new System.EventHandler(this.toolSiparisSil_Click);
            // 
            // grbSiparisBilgileri
            // 
            this.grbSiparisBilgileri.Controls.Add(this.btnHaliEkle);
            this.grbSiparisBilgileri.Controls.Add(this.chbHalilar);
            this.grbSiparisBilgileri.Controls.Add(this.txtAciklama);
            this.grbSiparisBilgileri.Controls.Add(this.label2);
            this.grbSiparisBilgileri.Controls.Add(this.lblHalilar);
            this.grbSiparisBilgileri.Controls.Add(this.mskdSiparisTotal);
            this.grbSiparisBilgileri.Controls.Add(this.rbSiparisHayir);
            this.grbSiparisBilgileri.Controls.Add(this.rbSiparisEvet);
            this.grbSiparisBilgileri.Controls.Add(this.dtpSiparisTarihi);
            this.grbSiparisBilgileri.Controls.Add(this.dtpTeslimatTarihi);
            this.grbSiparisBilgileri.Controls.Add(this.lblTeslimatTarihi);
            this.grbSiparisBilgileri.Controls.Add(this.lblSiparisToplamTutar);
            this.grbSiparisBilgileri.Controls.Add(this.lblSiparisDurumu);
            this.grbSiparisBilgileri.Controls.Add(this.lblSiparisTarihi);
            this.grbSiparisBilgileri.Controls.Add(this.cbSiparisMusteriAdi);
            this.grbSiparisBilgileri.Controls.Add(this.txtSiparisAdi);
            this.grbSiparisBilgileri.Controls.Add(this.lblSiparisAdi);
            this.grbSiparisBilgileri.Controls.Add(this.lblMusteriAdi);
            this.grbSiparisBilgileri.Location = new System.Drawing.Point(2, 32);
            this.grbSiparisBilgileri.Name = "grbSiparisBilgileri";
            this.grbSiparisBilgileri.Size = new System.Drawing.Size(1253, 215);
            this.grbSiparisBilgileri.TabIndex = 8;
            this.grbSiparisBilgileri.TabStop = false;
            this.grbSiparisBilgileri.Text = "Sipariş Bilgileri";
            // 
            // btnHaliEkle
            // 
            this.btnHaliEkle.Location = new System.Drawing.Point(814, 55);
            this.btnHaliEkle.Name = "btnHaliEkle";
            this.btnHaliEkle.Size = new System.Drawing.Size(75, 23);
            this.btnHaliEkle.TabIndex = 43;
            this.btnHaliEkle.Text = "EKLE";
            this.btnHaliEkle.UseVisualStyleBackColor = true;
            this.btnHaliEkle.Click += new System.EventHandler(this.btnHaliEkle_Click);
            // 
            // chbHalilar
            // 
            this.chbHalilar.FormattingEnabled = true;
            this.chbHalilar.Location = new System.Drawing.Point(908, 18);
            this.chbHalilar.Name = "chbHalilar";
            this.chbHalilar.Size = new System.Drawing.Size(270, 191);
            this.chbHalilar.TabIndex = 42;
            this.chbHalilar.SelectedIndexChanged += new System.EventHandler(this.chbHalilar_SelectedIndexChanged);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(462, 124);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(203, 73);
            this.txtAciklama.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Açıklama: ";
            // 
            // lblHalilar
            // 
            this.lblHalilar.AutoSize = true;
            this.lblHalilar.Location = new System.Drawing.Point(788, 18);
            this.lblHalilar.Name = "lblHalilar";
            this.lblHalilar.Size = new System.Drawing.Size(101, 16);
            this.lblHalilar.TabIndex = 37;
            this.lblHalilar.Text = "Halıları Seçiniz :";
            // 
            // mskdSiparisTotal
            // 
            this.mskdSiparisTotal.Location = new System.Drawing.Point(123, 95);
            this.mskdSiparisTotal.Mask = "00000";
            this.mskdSiparisTotal.Name = "mskdSiparisTotal";
            this.mskdSiparisTotal.ReadOnly = true;
            this.mskdSiparisTotal.Size = new System.Drawing.Size(188, 22);
            this.mskdSiparisTotal.TabIndex = 36;
            this.mskdSiparisTotal.ValidatingType = typeof(int);
            // 
            // rbSiparisHayir
            // 
            this.rbSiparisHayir.AutoSize = true;
            this.rbSiparisHayir.Location = new System.Drawing.Point(577, 74);
            this.rbSiparisHayir.Name = "rbSiparisHayir";
            this.rbSiparisHayir.Size = new System.Drawing.Size(60, 20);
            this.rbSiparisHayir.TabIndex = 35;
            this.rbSiparisHayir.TabStop = true;
            this.rbSiparisHayir.Text = "Hayır";
            this.rbSiparisHayir.UseVisualStyleBackColor = true;
            // 
            // rbSiparisEvet
            // 
            this.rbSiparisEvet.AutoSize = true;
            this.rbSiparisEvet.Location = new System.Drawing.Point(473, 74);
            this.rbSiparisEvet.Name = "rbSiparisEvet";
            this.rbSiparisEvet.Size = new System.Drawing.Size(55, 20);
            this.rbSiparisEvet.TabIndex = 34;
            this.rbSiparisEvet.TabStop = true;
            this.rbSiparisEvet.Text = "Evet";
            this.rbSiparisEvet.UseVisualStyleBackColor = true;
            // 
            // dtpSiparisTarihi
            // 
            this.dtpSiparisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSiparisTarihi.Location = new System.Drawing.Point(123, 128);
            this.dtpSiparisTarihi.Name = "dtpSiparisTarihi";
            this.dtpSiparisTarihi.Size = new System.Drawing.Size(188, 22);
            this.dtpSiparisTarihi.TabIndex = 33;
            // 
            // dtpTeslimatTarihi
            // 
            this.dtpTeslimatTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTeslimatTarihi.Location = new System.Drawing.Point(121, 161);
            this.dtpTeslimatTarihi.Name = "dtpTeslimatTarihi";
            this.dtpTeslimatTarihi.Size = new System.Drawing.Size(190, 22);
            this.dtpTeslimatTarihi.TabIndex = 32;
            // 
            // lblTeslimatTarihi
            // 
            this.lblTeslimatTarihi.AutoSize = true;
            this.lblTeslimatTarihi.Location = new System.Drawing.Point(13, 166);
            this.lblTeslimatTarihi.Name = "lblTeslimatTarihi";
            this.lblTeslimatTarihi.Size = new System.Drawing.Size(102, 16);
            this.lblTeslimatTarihi.TabIndex = 31;
            this.lblTeslimatTarihi.Text = "Teslimat Tarihi :";
            // 
            // lblSiparisToplamTutar
            // 
            this.lblSiparisToplamTutar.AutoSize = true;
            this.lblSiparisToplamTutar.Location = new System.Drawing.Point(13, 95);
            this.lblSiparisToplamTutar.Name = "lblSiparisToplamTutar";
            this.lblSiparisToplamTutar.Size = new System.Drawing.Size(94, 16);
            this.lblSiparisToplamTutar.TabIndex = 30;
            this.lblSiparisToplamTutar.Text = "Toplam Tutar :";
            // 
            // lblSiparisDurumu
            // 
            this.lblSiparisDurumu.AutoSize = true;
            this.lblSiparisDurumu.Location = new System.Drawing.Point(503, 43);
            this.lblSiparisDurumu.Name = "lblSiparisDurumu";
            this.lblSiparisDurumu.Size = new System.Drawing.Size(104, 16);
            this.lblSiparisDurumu.TabIndex = 29;
            this.lblSiparisDurumu.Text = "Sipariş Durumu :";
            // 
            // lblSiparisTarihi
            // 
            this.lblSiparisTarihi.AutoSize = true;
            this.lblSiparisTarihi.Location = new System.Drawing.Point(13, 133);
            this.lblSiparisTarihi.Name = "lblSiparisTarihi";
            this.lblSiparisTarihi.Size = new System.Drawing.Size(92, 16);
            this.lblSiparisTarihi.TabIndex = 28;
            this.lblSiparisTarihi.Text = "Sipariş Tarihi :";
            // 
            // cbSiparisMusteriAdi
            // 
            this.cbSiparisMusteriAdi.FormattingEnabled = true;
            this.cbSiparisMusteriAdi.Location = new System.Drawing.Point(123, 59);
            this.cbSiparisMusteriAdi.Name = "cbSiparisMusteriAdi";
            this.cbSiparisMusteriAdi.Size = new System.Drawing.Size(188, 24);
            this.cbSiparisMusteriAdi.TabIndex = 27;
            // 
            // txtSiparisAdi
            // 
            this.txtSiparisAdi.Location = new System.Drawing.Point(123, 27);
            this.txtSiparisAdi.Name = "txtSiparisAdi";
            this.txtSiparisAdi.Size = new System.Drawing.Size(188, 22);
            this.txtSiparisAdi.TabIndex = 26;
            // 
            // lblSiparisAdi
            // 
            this.lblSiparisAdi.AutoSize = true;
            this.lblSiparisAdi.Location = new System.Drawing.Point(13, 31);
            this.lblSiparisAdi.Name = "lblSiparisAdi";
            this.lblSiparisAdi.Size = new System.Drawing.Size(75, 16);
            this.lblSiparisAdi.TabIndex = 25;
            this.lblSiparisAdi.Text = "Sipariş Adı:";
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Location = new System.Drawing.Point(13, 62);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(79, 16);
            this.lblMusteriAdi.TabIndex = 1;
            this.lblMusteriAdi.Text = "Müşteri Adı :";
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSiparisler.Location = new System.Drawing.Point(3, 18);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.RowHeadersWidth = 51;
            this.dgvSiparisler.RowTemplate.Height = 24;
            this.dgvSiparisler.Size = new System.Drawing.Size(1247, 344);
            this.dgvSiparisler.TabIndex = 0;
            this.dgvSiparisler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSiparisler_CellDoubleClick);
            this.dgvSiparisler.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSiparisler_CellFormatting);
            // 
            // groupBoxSiparisler
            // 
            this.groupBoxSiparisler.Controls.Add(this.dgvSiparisler);
            this.groupBoxSiparisler.Location = new System.Drawing.Point(2, 253);
            this.groupBoxSiparisler.Name = "groupBoxSiparisler";
            this.groupBoxSiparisler.Size = new System.Drawing.Size(1253, 365);
            this.groupBoxSiparisler.TabIndex = 9;
            this.groupBoxSiparisler.TabStop = false;
            this.groupBoxSiparisler.Text = "Siparişler";
            // 
            // FormSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 625);
            this.Controls.Add(this.grbSiparisBilgileri);
            this.Controls.Add(this.groupBoxSiparisler);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSiparisler";
            this.Text = "FormSiparisler";
            this.Load += new System.EventHandler(this.FormSiparisler_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbSiparisBilgileri.ResumeLayout(false);
            this.grbSiparisBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.groupBoxSiparisler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSiparisKaydet;
        private System.Windows.Forms.ToolStripButton toolSiparisGuncelle;
        private System.Windows.Forms.ToolStripButton toolSiparisSil;
        private System.Windows.Forms.GroupBox grbSiparisBilgileri;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHalilar;
        private System.Windows.Forms.MaskedTextBox mskdSiparisTotal;
        private System.Windows.Forms.RadioButton rbSiparisHayir;
        private System.Windows.Forms.RadioButton rbSiparisEvet;
        private System.Windows.Forms.DateTimePicker dtpSiparisTarihi;
        private System.Windows.Forms.DateTimePicker dtpTeslimatTarihi;
        private System.Windows.Forms.Label lblTeslimatTarihi;
        private System.Windows.Forms.Label lblSiparisToplamTutar;
        private System.Windows.Forms.Label lblSiparisDurumu;
        private System.Windows.Forms.Label lblSiparisTarihi;
        private System.Windows.Forms.ComboBox cbSiparisMusteriAdi;
        private System.Windows.Forms.TextBox txtSiparisAdi;
        private System.Windows.Forms.Label lblSiparisAdi;
        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.GroupBox groupBoxSiparisler;
        private System.Windows.Forms.CheckedListBox chbHalilar;
        private System.Windows.Forms.Button btnHaliEkle;
    }
}