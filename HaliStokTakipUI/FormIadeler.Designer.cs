namespace HaliStokTakipUI
{
    partial class FormIadeler
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
            this.btnKaydet = new System.Windows.Forms.ToolStripButton();
            this.btnGuncelle = new System.Windows.Forms.ToolStripButton();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.grbIadeBilgileri = new System.Windows.Forms.GroupBox();
            this.cbSiparisAdi = new System.Windows.Forms.ComboBox();
            this.txtıadeNedeni = new System.Windows.Forms.TextBox();
            this.lblIadeNedeni = new System.Windows.Forms.Label();
            this.rbHayir = new System.Windows.Forms.RadioButton();
            this.rbEvet = new System.Windows.Forms.RadioButton();
            this.dtpIadeTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblIadeDurumu = new System.Windows.Forms.Label();
            this.lblIadeTarihi = new System.Windows.Forms.Label();
            this.lblSiparisAdi = new System.Windows.Forms.Label();
            this.grbIadeler = new System.Windows.Forms.GroupBox();
            this.dgvIadeler = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.grbIadeBilgileri.SuspendLayout();
            this.grbIadeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIadeler)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.TabIndex = 5;
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
            // grbIadeBilgileri
            // 
            this.grbIadeBilgileri.Controls.Add(this.cbSiparisAdi);
            this.grbIadeBilgileri.Controls.Add(this.txtıadeNedeni);
            this.grbIadeBilgileri.Controls.Add(this.lblIadeNedeni);
            this.grbIadeBilgileri.Controls.Add(this.rbHayir);
            this.grbIadeBilgileri.Controls.Add(this.rbEvet);
            this.grbIadeBilgileri.Controls.Add(this.dtpIadeTarihi);
            this.grbIadeBilgileri.Controls.Add(this.lblIadeDurumu);
            this.grbIadeBilgileri.Controls.Add(this.lblIadeTarihi);
            this.grbIadeBilgileri.Controls.Add(this.lblSiparisAdi);
            this.grbIadeBilgileri.Location = new System.Drawing.Point(9, 30);
            this.grbIadeBilgileri.Name = "grbIadeBilgileri";
            this.grbIadeBilgileri.Size = new System.Drawing.Size(481, 567);
            this.grbIadeBilgileri.TabIndex = 6;
            this.grbIadeBilgileri.TabStop = false;
            this.grbIadeBilgileri.Text = "İade Bilgileri";
            // 
            // cbSiparisAdi
            // 
            this.cbSiparisAdi.FormattingEnabled = true;
            this.cbSiparisAdi.Location = new System.Drawing.Point(116, 25);
            this.cbSiparisAdi.Name = "cbSiparisAdi";
            this.cbSiparisAdi.Size = new System.Drawing.Size(188, 24);
            this.cbSiparisAdi.TabIndex = 45;
            // 
            // txtıadeNedeni
            // 
            this.txtıadeNedeni.Location = new System.Drawing.Point(116, 114);
            this.txtıadeNedeni.Multiline = true;
            this.txtıadeNedeni.Name = "txtıadeNedeni";
            this.txtıadeNedeni.Size = new System.Drawing.Size(188, 80);
            this.txtıadeNedeni.TabIndex = 44;
            // 
            // lblIadeNedeni
            // 
            this.lblIadeNedeni.AutoSize = true;
            this.lblIadeNedeni.Location = new System.Drawing.Point(6, 117);
            this.lblIadeNedeni.Name = "lblIadeNedeni";
            this.lblIadeNedeni.Size = new System.Drawing.Size(87, 16);
            this.lblIadeNedeni.TabIndex = 43;
            this.lblIadeNedeni.Text = "İade Nedeni :";
            // 
            // rbHayir
            // 
            this.rbHayir.AutoSize = true;
            this.rbHayir.Location = new System.Drawing.Point(179, 262);
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
            this.rbEvet.Location = new System.Drawing.Point(86, 262);
            this.rbEvet.Name = "rbEvet";
            this.rbEvet.Size = new System.Drawing.Size(55, 20);
            this.rbEvet.TabIndex = 41;
            this.rbEvet.TabStop = true;
            this.rbEvet.Text = "Evet";
            this.rbEvet.UseVisualStyleBackColor = true;
            // 
            // dtpIadeTarihi
            // 
            this.dtpIadeTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIadeTarihi.Location = new System.Drawing.Point(116, 69);
            this.dtpIadeTarihi.Name = "dtpIadeTarihi";
            this.dtpIadeTarihi.Size = new System.Drawing.Size(188, 22);
            this.dtpIadeTarihi.TabIndex = 40;
            // 
            // lblIadeDurumu
            // 
            this.lblIadeDurumu.AutoSize = true;
            this.lblIadeDurumu.Location = new System.Drawing.Point(113, 228);
            this.lblIadeDurumu.Name = "lblIadeDurumu";
            this.lblIadeDurumu.Size = new System.Drawing.Size(89, 16);
            this.lblIadeDurumu.TabIndex = 39;
            this.lblIadeDurumu.Text = "İade Durumu :";
            // 
            // lblIadeTarihi
            // 
            this.lblIadeTarihi.AutoSize = true;
            this.lblIadeTarihi.Location = new System.Drawing.Point(6, 72);
            this.lblIadeTarihi.Name = "lblIadeTarihi";
            this.lblIadeTarihi.Size = new System.Drawing.Size(77, 16);
            this.lblIadeTarihi.TabIndex = 38;
            this.lblIadeTarihi.Text = "İade Tarihi :";
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
            // grbIadeler
            // 
            this.grbIadeler.Controls.Add(this.dgvIadeler);
            this.grbIadeler.Location = new System.Drawing.Point(496, 30);
            this.grbIadeler.Name = "grbIadeler";
            this.grbIadeler.Size = new System.Drawing.Size(756, 567);
            this.grbIadeler.TabIndex = 8;
            this.grbIadeler.TabStop = false;
            this.grbIadeler.Text = "İadeler";
            // 
            // dgvIadeler
            // 
            this.dgvIadeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIadeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIadeler.Location = new System.Drawing.Point(3, 18);
            this.dgvIadeler.Name = "dgvIadeler";
            this.dgvIadeler.RowHeadersWidth = 51;
            this.dgvIadeler.RowTemplate.Height = 24;
            this.dgvIadeler.Size = new System.Drawing.Size(750, 546);
            this.dgvIadeler.TabIndex = 0;
            this.dgvIadeler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIadeler_CellDoubleClick_1);
            this.dgvIadeler.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvIadeler_CellFormatting_1);
            // 
            // FormIadeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 597);
            this.Controls.Add(this.grbIadeler);
            this.Controls.Add(this.grbIadeBilgileri);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIadeler";
            this.Text = "FormIadeler";
            this.Load += new System.EventHandler(this.FormIadeler_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbIadeBilgileri.ResumeLayout(false);
            this.grbIadeBilgileri.PerformLayout();
            this.grbIadeler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIadeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox grbIadeBilgileri;
        private System.Windows.Forms.RadioButton rbHayir;
        private System.Windows.Forms.RadioButton rbEvet;
        private System.Windows.Forms.DateTimePicker dtpIadeTarihi;
        private System.Windows.Forms.Label lblIadeDurumu;
        private System.Windows.Forms.Label lblIadeTarihi;
        private System.Windows.Forms.Label lblSiparisAdi;
        private System.Windows.Forms.Label lblIadeNedeni;
        private System.Windows.Forms.TextBox txtıadeNedeni;
        private System.Windows.Forms.ToolStripButton btnKaydet;
        private System.Windows.Forms.ToolStripButton btnGuncelle;
        private System.Windows.Forms.ToolStripButton btnSil;
        private System.Windows.Forms.ComboBox cbSiparisAdi;
        private System.Windows.Forms.GroupBox grbIadeler;
        private System.Windows.Forms.DataGridView dgvIadeler;
    }
}