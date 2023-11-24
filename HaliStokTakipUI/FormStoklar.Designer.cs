namespace HaliStokTakipUI
{
    partial class FormStoklar
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
            this.grbStokBilgileri = new System.Windows.Forms.GroupBox();
            this.rbHayir = new System.Windows.Forms.RadioButton();
            this.rbEvet = new System.Windows.Forms.RadioButton();
            this.mskdStokMik = new System.Windows.Forms.MaskedTextBox();
            this.cbHaliAdi = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtStokAdi = new System.Windows.Forms.TextBox();
            this.lblHaliAdi = new System.Windows.Forms.Label();
            this.lblStokMiktari = new System.Windows.Forms.Label();
            this.lblAktifMi = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblStokAdi = new System.Windows.Forms.Label();
            this.grbStoklar = new System.Windows.Forms.GroupBox();
            this.dgvStoklar = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.grbStokBilgileri.SuspendLayout();
            this.grbStoklar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoklar)).BeginInit();
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
            this.toolStrip1.TabIndex = 0;
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
            // grbStokBilgileri
            // 
            this.grbStokBilgileri.Controls.Add(this.rbHayir);
            this.grbStokBilgileri.Controls.Add(this.rbEvet);
            this.grbStokBilgileri.Controls.Add(this.mskdStokMik);
            this.grbStokBilgileri.Controls.Add(this.cbHaliAdi);
            this.grbStokBilgileri.Controls.Add(this.txtAciklama);
            this.grbStokBilgileri.Controls.Add(this.txtStokAdi);
            this.grbStokBilgileri.Controls.Add(this.lblHaliAdi);
            this.grbStokBilgileri.Controls.Add(this.lblStokMiktari);
            this.grbStokBilgileri.Controls.Add(this.lblAktifMi);
            this.grbStokBilgileri.Controls.Add(this.lblAciklama);
            this.grbStokBilgileri.Controls.Add(this.lblStokAdi);
            this.grbStokBilgileri.Location = new System.Drawing.Point(6, 32);
            this.grbStokBilgileri.Name = "grbStokBilgileri";
            this.grbStokBilgileri.Size = new System.Drawing.Size(410, 581);
            this.grbStokBilgileri.TabIndex = 1;
            this.grbStokBilgileri.TabStop = false;
            this.grbStokBilgileri.Text = "Stok Bilgileri";
            // 
            // rbHayir
            // 
            this.rbHayir.AutoSize = true;
            this.rbHayir.Location = new System.Drawing.Point(199, 162);
            this.rbHayir.Name = "rbHayir";
            this.rbHayir.Size = new System.Drawing.Size(60, 20);
            this.rbHayir.TabIndex = 10;
            this.rbHayir.TabStop = true;
            this.rbHayir.Text = "Hayır";
            this.rbHayir.UseVisualStyleBackColor = true;
            // 
            // rbEvet
            // 
            this.rbEvet.AutoSize = true;
            this.rbEvet.Location = new System.Drawing.Point(90, 164);
            this.rbEvet.Name = "rbEvet";
            this.rbEvet.Size = new System.Drawing.Size(55, 20);
            this.rbEvet.TabIndex = 9;
            this.rbEvet.TabStop = true;
            this.rbEvet.Text = "Evet";
            this.rbEvet.UseVisualStyleBackColor = true;
            // 
            // mskdStokMik
            // 
            this.mskdStokMik.Location = new System.Drawing.Point(94, 100);
            this.mskdStokMik.Mask = "00000";
            this.mskdStokMik.Name = "mskdStokMik";
            this.mskdStokMik.Size = new System.Drawing.Size(181, 22);
            this.mskdStokMik.TabIndex = 8;
            this.mskdStokMik.ValidatingType = typeof(int);
            // 
            // cbHaliAdi
            // 
            this.cbHaliAdi.FormattingEnabled = true;
            this.cbHaliAdi.Location = new System.Drawing.Point(93, 58);
            this.cbHaliAdi.Name = "cbHaliAdi";
            this.cbHaliAdi.Size = new System.Drawing.Size(182, 24);
            this.cbHaliAdi.TabIndex = 7;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(103, 234);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(171, 58);
            this.txtAciklama.TabIndex = 6;
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(93, 27);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(182, 22);
            this.txtStokAdi.TabIndex = 5;
            // 
            // lblHaliAdi
            // 
            this.lblHaliAdi.AutoSize = true;
            this.lblHaliAdi.Location = new System.Drawing.Point(6, 61);
            this.lblHaliAdi.Name = "lblHaliAdi";
            this.lblHaliAdi.Size = new System.Drawing.Size(60, 16);
            this.lblHaliAdi.TabIndex = 4;
            this.lblHaliAdi.Text = "Halı Adı :";
            // 
            // lblStokMiktari
            // 
            this.lblStokMiktari.AutoSize = true;
            this.lblStokMiktari.Location = new System.Drawing.Point(6, 103);
            this.lblStokMiktari.Name = "lblStokMiktari";
            this.lblStokMiktari.Size = new System.Drawing.Size(82, 16);
            this.lblStokMiktari.TabIndex = 3;
            this.lblStokMiktari.Text = "Stok Miktarı :";
            // 
            // lblAktifMi
            // 
            this.lblAktifMi.AutoSize = true;
            this.lblAktifMi.Location = new System.Drawing.Point(6, 164);
            this.lblAktifMi.Name = "lblAktifMi";
            this.lblAktifMi.Size = new System.Drawing.Size(55, 16);
            this.lblAktifMi.TabIndex = 2;
            this.lblAktifMi.Text = "Aktif Mi :";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(6, 237);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(69, 16);
            this.lblAciklama.TabIndex = 1;
            this.lblAciklama.Text = "Açıklama :";
            // 
            // lblStokAdi
            // 
            this.lblStokAdi.AutoSize = true;
            this.lblStokAdi.Location = new System.Drawing.Point(6, 30);
            this.lblStokAdi.Name = "lblStokAdi";
            this.lblStokAdi.Size = new System.Drawing.Size(63, 16);
            this.lblStokAdi.TabIndex = 0;
            this.lblStokAdi.Text = "Stok Adı :";
            // 
            // grbStoklar
            // 
            this.grbStoklar.Controls.Add(this.dgvStoklar);
            this.grbStoklar.Location = new System.Drawing.Point(431, 32);
            this.grbStoklar.Name = "grbStoklar";
            this.grbStoklar.Size = new System.Drawing.Size(826, 592);
            this.grbStoklar.TabIndex = 3;
            this.grbStoklar.TabStop = false;
            this.grbStoklar.Text = "Stoklar";
            // 
            // dgvStoklar
            // 
            this.dgvStoklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStoklar.Location = new System.Drawing.Point(3, 18);
            this.dgvStoklar.Name = "dgvStoklar";
            this.dgvStoklar.RowHeadersWidth = 51;
            this.dgvStoklar.RowTemplate.Height = 24;
            this.dgvStoklar.Size = new System.Drawing.Size(820, 571);
            this.dgvStoklar.TabIndex = 0;
            this.dgvStoklar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStoklar_CellDoubleClick_1);
            this.dgvStoklar.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStoklar_CellFormatting_1);
            // 
            // FormStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 625);
            this.Controls.Add(this.grbStoklar);
            this.Controls.Add(this.grbStokBilgileri);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStoklar";
            this.Text = "FormStoklar";
            this.Load += new System.EventHandler(this.FormStoklar_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbStokBilgileri.ResumeLayout(false);
            this.grbStokBilgileri.PerformLayout();
            this.grbStoklar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoklar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnKaydet;
        private System.Windows.Forms.ToolStripButton btnGuncelle;
        private System.Windows.Forms.ToolStripButton btnSil;
        private System.Windows.Forms.GroupBox grbStokBilgileri;
        private System.Windows.Forms.RadioButton rbHayir;
        private System.Windows.Forms.RadioButton rbEvet;
        private System.Windows.Forms.MaskedTextBox mskdStokMik;
        private System.Windows.Forms.ComboBox cbHaliAdi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtStokAdi;
        private System.Windows.Forms.Label lblHaliAdi;
        private System.Windows.Forms.Label lblStokMiktari;
        private System.Windows.Forms.Label lblAktifMi;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblStokAdi;
        private System.Windows.Forms.GroupBox grbStoklar;
        private System.Windows.Forms.DataGridView dgvStoklar;
    }
}