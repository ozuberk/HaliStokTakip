namespace HaliStokTakipUI
{
    partial class FormKargoTakip
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
            this.grbKargoBilgileri = new System.Windows.Forms.GroupBox();
            this.dtpTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblTeslimTarihi = new System.Windows.Forms.Label();
            this.mskdTakipKodu = new System.Windows.Forms.MaskedTextBox();
            this.lblTakipKodu = new System.Windows.Forms.Label();
            this.lblFirmaAdi = new System.Windows.Forms.Label();
            this.cbSiparisAdi = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.rbHayir = new System.Windows.Forms.RadioButton();
            this.rbEvet = new System.Windows.Forms.RadioButton();
            this.dtpTahTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblAktifMi = new System.Windows.Forms.Label();
            this.lblTahTeslimTarihi = new System.Windows.Forms.Label();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.lblSiparisAdi = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnKaydet = new System.Windows.Forms.ToolStripButton();
            this.btnGuncelle = new System.Windows.Forms.ToolStripButton();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.grbKargolar = new System.Windows.Forms.GroupBox();
            this.dgvKargolar = new System.Windows.Forms.DataGridView();
            this.grbKargoBilgileri.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grbKargolar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKargolar)).BeginInit();
            this.SuspendLayout();
            // 
            // grbKargoBilgileri
            // 
            this.grbKargoBilgileri.Controls.Add(this.dtpTeslimTarihi);
            this.grbKargoBilgileri.Controls.Add(this.lblTeslimTarihi);
            this.grbKargoBilgileri.Controls.Add(this.mskdTakipKodu);
            this.grbKargoBilgileri.Controls.Add(this.lblTakipKodu);
            this.grbKargoBilgileri.Controls.Add(this.lblFirmaAdi);
            this.grbKargoBilgileri.Controls.Add(this.cbSiparisAdi);
            this.grbKargoBilgileri.Controls.Add(this.txtAciklama);
            this.grbKargoBilgileri.Controls.Add(this.lblAciklama);
            this.grbKargoBilgileri.Controls.Add(this.rbHayir);
            this.grbKargoBilgileri.Controls.Add(this.rbEvet);
            this.grbKargoBilgileri.Controls.Add(this.dtpTahTeslimTarihi);
            this.grbKargoBilgileri.Controls.Add(this.lblAktifMi);
            this.grbKargoBilgileri.Controls.Add(this.lblTahTeslimTarihi);
            this.grbKargoBilgileri.Controls.Add(this.txtFirmaAdi);
            this.grbKargoBilgileri.Controls.Add(this.lblSiparisAdi);
            this.grbKargoBilgileri.Location = new System.Drawing.Point(9, 31);
            this.grbKargoBilgileri.Name = "grbKargoBilgileri";
            this.grbKargoBilgileri.Size = new System.Drawing.Size(416, 561);
            this.grbKargoBilgileri.TabIndex = 12;
            this.grbKargoBilgileri.TabStop = false;
            this.grbKargoBilgileri.Text = "Kargo Bilgileri";
            // 
            // dtpTeslimTarihi
            // 
            this.dtpTeslimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTeslimTarihi.Location = new System.Drawing.Point(155, 198);
            this.dtpTeslimTarihi.Name = "dtpTeslimTarihi";
            this.dtpTeslimTarihi.Size = new System.Drawing.Size(187, 22);
            this.dtpTeslimTarihi.TabIndex = 50;
            // 
            // lblTeslimTarihi
            // 
            this.lblTeslimTarihi.AutoSize = true;
            this.lblTeslimTarihi.Location = new System.Drawing.Point(6, 203);
            this.lblTeslimTarihi.Name = "lblTeslimTarihi";
            this.lblTeslimTarihi.Size = new System.Drawing.Size(91, 16);
            this.lblTeslimTarihi.TabIndex = 49;
            this.lblTeslimTarihi.Text = "Teslim Tarihi :";
            // 
            // mskdTakipKodu
            // 
            this.mskdTakipKodu.Location = new System.Drawing.Point(155, 115);
            this.mskdTakipKodu.Mask = "0000000";
            this.mskdTakipKodu.Name = "mskdTakipKodu";
            this.mskdTakipKodu.Size = new System.Drawing.Size(188, 22);
            this.mskdTakipKodu.TabIndex = 48;
            // 
            // lblTakipKodu
            // 
            this.lblTakipKodu.AutoSize = true;
            this.lblTakipKodu.Location = new System.Drawing.Point(6, 116);
            this.lblTakipKodu.Name = "lblTakipKodu";
            this.lblTakipKodu.Size = new System.Drawing.Size(82, 16);
            this.lblTakipKodu.TabIndex = 47;
            this.lblTakipKodu.Text = "Takip Kodu :";
            // 
            // lblFirmaAdi
            // 
            this.lblFirmaAdi.AutoSize = true;
            this.lblFirmaAdi.Location = new System.Drawing.Point(6, 71);
            this.lblFirmaAdi.Name = "lblFirmaAdi";
            this.lblFirmaAdi.Size = new System.Drawing.Size(67, 16);
            this.lblFirmaAdi.TabIndex = 46;
            this.lblFirmaAdi.Text = "Firma Adı:";
            // 
            // cbSiparisAdi
            // 
            this.cbSiparisAdi.BackColor = System.Drawing.Color.White;
            this.cbSiparisAdi.FormattingEnabled = true;
            this.cbSiparisAdi.Location = new System.Drawing.Point(155, 31);
            this.cbSiparisAdi.Name = "cbSiparisAdi";
            this.cbSiparisAdi.Size = new System.Drawing.Size(188, 24);
            this.cbSiparisAdi.TabIndex = 45;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(111, 305);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(188, 80);
            this.txtAciklama.TabIndex = 44;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(6, 305);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(69, 16);
            this.lblAciklama.TabIndex = 43;
            this.lblAciklama.Text = "Açıklama :";
            // 
            // rbHayir
            // 
            this.rbHayir.AutoSize = true;
            this.rbHayir.Location = new System.Drawing.Point(167, 267);
            this.rbHayir.Name = "rbHayir";
            this.rbHayir.Size = new System.Drawing.Size(60, 20);
            this.rbHayir.TabIndex = 42;
            this.rbHayir.TabStop = true;
            this.rbHayir.Text = "Hayır";
            this.rbHayir.UseVisualStyleBackColor = true;
            // 
            // rbEvet
            // 
            this.rbEvet.AutoSize = true;
            this.rbEvet.Location = new System.Drawing.Point(72, 267);
            this.rbEvet.Name = "rbEvet";
            this.rbEvet.Size = new System.Drawing.Size(55, 20);
            this.rbEvet.TabIndex = 41;
            this.rbEvet.TabStop = true;
            this.rbEvet.Text = "Evet";
            this.rbEvet.UseVisualStyleBackColor = true;
            // 
            // dtpTahTeslimTarihi
            // 
            this.dtpTahTeslimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTahTeslimTarihi.Location = new System.Drawing.Point(155, 153);
            this.dtpTahTeslimTarihi.Name = "dtpTahTeslimTarihi";
            this.dtpTahTeslimTarihi.Size = new System.Drawing.Size(188, 22);
            this.dtpTahTeslimTarihi.TabIndex = 40;
            // 
            // lblAktifMi
            // 
            this.lblAktifMi.AutoSize = true;
            this.lblAktifMi.Location = new System.Drawing.Point(125, 239);
            this.lblAktifMi.Name = "lblAktifMi";
            this.lblAktifMi.Size = new System.Drawing.Size(55, 16);
            this.lblAktifMi.TabIndex = 39;
            this.lblAktifMi.Text = "Aktif Mi :";
            // 
            // lblTahTeslimTarihi
            // 
            this.lblTahTeslimTarihi.AutoSize = true;
            this.lblTahTeslimTarihi.Location = new System.Drawing.Point(6, 153);
            this.lblTahTeslimTarihi.Name = "lblTahTeslimTarihi";
            this.lblTahTeslimTarihi.Size = new System.Drawing.Size(142, 16);
            this.lblTahTeslimTarihi.TabIndex = 38;
            this.lblTahTeslimTarihi.Text = "Tahmini Teslim Tarihi :";
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Location = new System.Drawing.Point(155, 71);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(188, 22);
            this.txtFirmaAdi.TabIndex = 37;
            // 
            // lblSiparisAdi
            // 
            this.lblSiparisAdi.AutoSize = true;
            this.lblSiparisAdi.Location = new System.Drawing.Point(6, 33);
            this.lblSiparisAdi.Name = "lblSiparisAdi";
            this.lblSiparisAdi.Size = new System.Drawing.Size(75, 16);
            this.lblSiparisAdi.TabIndex = 36;
            this.lblSiparisAdi.Text = "Sipariş Adı:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKaydet,
            this.btnGuncelle,
            this.btnSil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1257, 27);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::HaliStokTakipUI.Properties.Resources.Kaydet;
            this.btnKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(79, 24);
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = global::HaliStokTakipUI.Properties.Resources.Guncelle;
            this.btnGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(90, 24);
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = global::HaliStokTakipUI.Properties.Resources.Sil;
            this.btnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(49, 24);
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // grbKargolar
            // 
            this.grbKargolar.Controls.Add(this.dgvKargolar);
            this.grbKargolar.Location = new System.Drawing.Point(431, 31);
            this.grbKargolar.Name = "grbKargolar";
            this.grbKargolar.Size = new System.Drawing.Size(826, 561);
            this.grbKargolar.TabIndex = 14;
            this.grbKargolar.TabStop = false;
            this.grbKargolar.Text = "Kargolar";
            // 
            // dgvKargolar
            // 
            this.dgvKargolar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKargolar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKargolar.Location = new System.Drawing.Point(3, 18);
            this.dgvKargolar.Name = "dgvKargolar";
            this.dgvKargolar.RowHeadersWidth = 51;
            this.dgvKargolar.RowTemplate.Height = 24;
            this.dgvKargolar.Size = new System.Drawing.Size(820, 540);
            this.dgvKargolar.TabIndex = 0;
            this.dgvKargolar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKargolar_CellDoubleClick_1);
            this.dgvKargolar.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvKargolar_CellFormatting_1);
            // 
            // FormKargoTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 597);
            this.Controls.Add(this.grbKargolar);
            this.Controls.Add(this.grbKargoBilgileri);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKargoTakip";
            this.Text = "FormKargoTakip";
            this.Load += new System.EventHandler(this.FormKargoTakip_Load);
            this.grbKargoBilgileri.ResumeLayout(false);
            this.grbKargoBilgileri.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbKargolar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKargolar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKargoBilgileri;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.RadioButton rbHayir;
        private System.Windows.Forms.RadioButton rbEvet;
        private System.Windows.Forms.DateTimePicker dtpTahTeslimTarihi;
        private System.Windows.Forms.Label lblAktifMi;
        private System.Windows.Forms.Label lblTahTeslimTarihi;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.Label lblSiparisAdi;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnKaydet;
        private System.Windows.Forms.ToolStripButton btnGuncelle;
        private System.Windows.Forms.ToolStripButton btnSil;
        private System.Windows.Forms.ComboBox cbSiparisAdi;
        private System.Windows.Forms.Label lblFirmaAdi;
        private System.Windows.Forms.Label lblTakipKodu;
        private System.Windows.Forms.MaskedTextBox mskdTakipKodu;
        private System.Windows.Forms.DateTimePicker dtpTeslimTarihi;
        private System.Windows.Forms.Label lblTeslimTarihi;
        private System.Windows.Forms.GroupBox grbKargolar;
        private System.Windows.Forms.DataGridView dgvKargolar;
    }
}