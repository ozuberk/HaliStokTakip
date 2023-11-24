namespace HaliStokTakipUI
{
    partial class FormSiparisOdemeleri
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
            this.grbOdemeBilgileri = new System.Windows.Forms.GroupBox();
            this.cbSiparisAdi = new System.Windows.Forms.ComboBox();
            this.txtOdemeYontemi = new System.Windows.Forms.TextBox();
            this.lblOdemeYontemi = new System.Windows.Forms.Label();
            this.rbHayir = new System.Windows.Forms.RadioButton();
            this.rbEvet = new System.Windows.Forms.RadioButton();
            this.dtpOdemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblAktifMi = new System.Windows.Forms.Label();
            this.lblOdemeTarihi = new System.Windows.Forms.Label();
            this.lblSiparisAdi = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnKaydet = new System.Windows.Forms.ToolStripButton();
            this.btnGuncelle = new System.Windows.Forms.ToolStripButton();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.grbOdemeler = new System.Windows.Forms.GroupBox();
            this.dgvOdemeler = new System.Windows.Forms.DataGridView();
            this.grbOdemeBilgileri.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grbOdemeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).BeginInit();
            this.SuspendLayout();
            // 
            // grbOdemeBilgileri
            // 
            this.grbOdemeBilgileri.Controls.Add(this.cbSiparisAdi);
            this.grbOdemeBilgileri.Controls.Add(this.txtOdemeYontemi);
            this.grbOdemeBilgileri.Controls.Add(this.lblOdemeYontemi);
            this.grbOdemeBilgileri.Controls.Add(this.rbHayir);
            this.grbOdemeBilgileri.Controls.Add(this.rbEvet);
            this.grbOdemeBilgileri.Controls.Add(this.dtpOdemeTarihi);
            this.grbOdemeBilgileri.Controls.Add(this.lblAktifMi);
            this.grbOdemeBilgileri.Controls.Add(this.lblOdemeTarihi);
            this.grbOdemeBilgileri.Controls.Add(this.lblSiparisAdi);
            this.grbOdemeBilgileri.Location = new System.Drawing.Point(9, 31);
            this.grbOdemeBilgileri.Name = "grbOdemeBilgileri";
            this.grbOdemeBilgileri.Size = new System.Drawing.Size(548, 587);
            this.grbOdemeBilgileri.TabIndex = 9;
            this.grbOdemeBilgileri.TabStop = false;
            this.grbOdemeBilgileri.Text = "Ödeme Bilgileri";
            // 
            // cbSiparisAdi
            // 
            this.cbSiparisAdi.FormattingEnabled = true;
            this.cbSiparisAdi.Location = new System.Drawing.Point(116, 25);
            this.cbSiparisAdi.Name = "cbSiparisAdi";
            this.cbSiparisAdi.Size = new System.Drawing.Size(188, 24);
            this.cbSiparisAdi.TabIndex = 45;
            // 
            // txtOdemeYontemi
            // 
            this.txtOdemeYontemi.Location = new System.Drawing.Point(116, 114);
            this.txtOdemeYontemi.Multiline = true;
            this.txtOdemeYontemi.Name = "txtOdemeYontemi";
            this.txtOdemeYontemi.Size = new System.Drawing.Size(188, 80);
            this.txtOdemeYontemi.TabIndex = 44;
            // 
            // lblOdemeYontemi
            // 
            this.lblOdemeYontemi.AutoSize = true;
            this.lblOdemeYontemi.Location = new System.Drawing.Point(6, 117);
            this.lblOdemeYontemi.Name = "lblOdemeYontemi";
            this.lblOdemeYontemi.Size = new System.Drawing.Size(110, 16);
            this.lblOdemeYontemi.TabIndex = 43;
            this.lblOdemeYontemi.Text = "Ödeme Yöntemi :";
            // 
            // rbHayir
            // 
            this.rbHayir.AutoSize = true;
            this.rbHayir.Location = new System.Drawing.Point(156, 280);
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
            this.rbEvet.Location = new System.Drawing.Point(61, 280);
            this.rbEvet.Name = "rbEvet";
            this.rbEvet.Size = new System.Drawing.Size(55, 20);
            this.rbEvet.TabIndex = 41;
            this.rbEvet.TabStop = true;
            this.rbEvet.Text = "Evet";
            this.rbEvet.UseVisualStyleBackColor = true;
            // 
            // dtpOdemeTarihi
            // 
            this.dtpOdemeTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOdemeTarihi.Location = new System.Drawing.Point(116, 69);
            this.dtpOdemeTarihi.Name = "dtpOdemeTarihi";
            this.dtpOdemeTarihi.Size = new System.Drawing.Size(188, 22);
            this.dtpOdemeTarihi.TabIndex = 40;
            // 
            // lblAktifMi
            // 
            this.lblAktifMi.AutoSize = true;
            this.lblAktifMi.Location = new System.Drawing.Point(112, 246);
            this.lblAktifMi.Name = "lblAktifMi";
            this.lblAktifMi.Size = new System.Drawing.Size(55, 16);
            this.lblAktifMi.TabIndex = 39;
            this.lblAktifMi.Text = "Aktif Mi :";
            // 
            // lblOdemeTarihi
            // 
            this.lblOdemeTarihi.AutoSize = true;
            this.lblOdemeTarihi.Location = new System.Drawing.Point(6, 72);
            this.lblOdemeTarihi.Name = "lblOdemeTarihi";
            this.lblOdemeTarihi.Size = new System.Drawing.Size(95, 16);
            this.lblOdemeTarihi.TabIndex = 38;
            this.lblOdemeTarihi.Text = "Ödeme Tarihi :";
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
            this.toolStrip1.Size = new System.Drawing.Size(1256, 27);
            this.toolStrip1.TabIndex = 8;
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
            // grbOdemeler
            // 
            this.grbOdemeler.Controls.Add(this.dgvOdemeler);
            this.grbOdemeler.Location = new System.Drawing.Point(563, 31);
            this.grbOdemeler.Name = "grbOdemeler";
            this.grbOdemeler.Size = new System.Drawing.Size(693, 587);
            this.grbOdemeler.TabIndex = 11;
            this.grbOdemeler.TabStop = false;
            this.grbOdemeler.Text = "Ödemeler";
            // 
            // dgvOdemeler
            // 
            this.dgvOdemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdemeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOdemeler.Location = new System.Drawing.Point(3, 18);
            this.dgvOdemeler.Name = "dgvOdemeler";
            this.dgvOdemeler.RowHeadersWidth = 51;
            this.dgvOdemeler.RowTemplate.Height = 24;
            this.dgvOdemeler.Size = new System.Drawing.Size(687, 566);
            this.dgvOdemeler.TabIndex = 0;
            this.dgvOdemeler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOdemeler_CellDoubleClick_1);
            this.dgvOdemeler.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOdemeler_CellFormatting_1);
            // 
            // FormSiparisOdemeleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 596);
            this.Controls.Add(this.grbOdemeler);
            this.Controls.Add(this.grbOdemeBilgileri);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSiparisOdemeleri";
            this.Text = "FormSiparisOdemeleri";
            this.Load += new System.EventHandler(this.FormSiparisOdemeleri_Load);
            this.grbOdemeBilgileri.ResumeLayout(false);
            this.grbOdemeBilgileri.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbOdemeler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOdemeBilgileri;
        private System.Windows.Forms.TextBox txtOdemeYontemi;
        private System.Windows.Forms.Label lblOdemeYontemi;
        private System.Windows.Forms.RadioButton rbHayir;
        private System.Windows.Forms.RadioButton rbEvet;
        private System.Windows.Forms.DateTimePicker dtpOdemeTarihi;
        private System.Windows.Forms.Label lblAktifMi;
        private System.Windows.Forms.Label lblOdemeTarihi;
        private System.Windows.Forms.Label lblSiparisAdi;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnKaydet;
        private System.Windows.Forms.ToolStripButton btnGuncelle;
        private System.Windows.Forms.ToolStripButton btnSil;
        private System.Windows.Forms.ComboBox cbSiparisAdi;
        private System.Windows.Forms.GroupBox grbOdemeler;
        private System.Windows.Forms.DataGridView dgvOdemeler;
    }
}