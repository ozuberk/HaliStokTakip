namespace HaliStokTakipUI
{
    partial class FormMusteriler
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
            this.dgvMüsteriler = new System.Windows.Forms.DataGridView();
            this.rbHayir = new System.Windows.Forms.RadioButton();
            this.rbEvet = new System.Windows.Forms.RadioButton();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAktifMi = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.btnGuncelle = new System.Windows.Forms.ToolStripButton();
            this.btnKaydet = new System.Windows.Forms.ToolStripButton();
            this.grbMusteriler = new System.Windows.Forms.GroupBox();
            this.grbMusteriBilgi = new System.Windows.Forms.GroupBox();
            this.mskdVergiNo = new System.Windows.Forms.MaskedTextBox();
            this.mskdTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblVergiNo = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMüsteriler)).BeginInit();
            this.grbMusteriler.SuspendLayout();
            this.grbMusteriBilgi.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMüsteriler
            // 
            this.dgvMüsteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMüsteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMüsteriler.Location = new System.Drawing.Point(3, 18);
            this.dgvMüsteriler.Name = "dgvMüsteriler";
            this.dgvMüsteriler.RowHeadersWidth = 51;
            this.dgvMüsteriler.RowTemplate.Height = 24;
            this.dgvMüsteriler.Size = new System.Drawing.Size(1245, 399);
            this.dgvMüsteriler.TabIndex = 0;
            this.dgvMüsteriler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMüsteriler_CellDoubleClick);
            this.dgvMüsteriler.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMüsteriler_CellFormatting);
            // 
            // rbHayir
            // 
            this.rbHayir.AutoSize = true;
            this.rbHayir.Location = new System.Drawing.Point(913, 63);
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
            this.rbEvet.Location = new System.Drawing.Point(791, 63);
            this.rbEvet.Name = "rbEvet";
            this.rbEvet.Size = new System.Drawing.Size(55, 20);
            this.rbEvet.TabIndex = 9;
            this.rbEvet.TabStop = true;
            this.rbEvet.Text = "Evet";
            this.rbEvet.UseVisualStyleBackColor = true;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(484, 100);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(182, 58);
            this.txtAciklama.TabIndex = 6;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(93, 27);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(182, 22);
            this.txtMusteriAdi.TabIndex = 5;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(6, 61);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(52, 16);
            this.lblAdres.TabIndex = 4;
            this.lblAdres.Text = "Adresi :";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(6, 103);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(59, 16);
            this.lblTelefon.TabIndex = 3;
            this.lblTelefon.Text = "Telefon :";
            // 
            // lblAktifMi
            // 
            this.lblAktifMi.AutoSize = true;
            this.lblAktifMi.Location = new System.Drawing.Point(852, 30);
            this.lblAktifMi.Name = "lblAktifMi";
            this.lblAktifMi.Size = new System.Drawing.Size(55, 16);
            this.lblAktifMi.TabIndex = 2;
            this.lblAktifMi.Text = "Aktif Mi :";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(398, 103);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(69, 16);
            this.lblAciklama.TabIndex = 1;
            this.lblAciklama.Text = "Açıklama :";
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Location = new System.Drawing.Point(6, 30);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(79, 16);
            this.lblMusteriAdi.TabIndex = 0;
            this.lblMusteriAdi.Text = "Müşteri Adı :";
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
            // btnGuncelle
            // 
            this.btnGuncelle.Image = global::HaliStokTakipUI.Properties.Resources.Guncelle;
            this.btnGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(90, 24);
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
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
            // grbMusteriler
            // 
            this.grbMusteriler.Controls.Add(this.dgvMüsteriler);
            this.grbMusteriler.Location = new System.Drawing.Point(6, 203);
            this.grbMusteriler.Name = "grbMusteriler";
            this.grbMusteriler.Size = new System.Drawing.Size(1251, 420);
            this.grbMusteriler.TabIndex = 5;
            this.grbMusteriler.TabStop = false;
            this.grbMusteriler.Text = "Müşteriler";
            // 
            // grbMusteriBilgi
            // 
            this.grbMusteriBilgi.Controls.Add(this.mskdVergiNo);
            this.grbMusteriBilgi.Controls.Add(this.mskdTelefon);
            this.grbMusteriBilgi.Controls.Add(this.txtEMail);
            this.grbMusteriBilgi.Controls.Add(this.lblEmail);
            this.grbMusteriBilgi.Controls.Add(this.lblVergiNo);
            this.grbMusteriBilgi.Controls.Add(this.txtAdres);
            this.grbMusteriBilgi.Controls.Add(this.rbHayir);
            this.grbMusteriBilgi.Controls.Add(this.rbEvet);
            this.grbMusteriBilgi.Controls.Add(this.txtAciklama);
            this.grbMusteriBilgi.Controls.Add(this.txtMusteriAdi);
            this.grbMusteriBilgi.Controls.Add(this.lblAdres);
            this.grbMusteriBilgi.Controls.Add(this.lblTelefon);
            this.grbMusteriBilgi.Controls.Add(this.lblAktifMi);
            this.grbMusteriBilgi.Controls.Add(this.lblAciklama);
            this.grbMusteriBilgi.Controls.Add(this.lblMusteriAdi);
            this.grbMusteriBilgi.Location = new System.Drawing.Point(6, 33);
            this.grbMusteriBilgi.Name = "grbMusteriBilgi";
            this.grbMusteriBilgi.Size = new System.Drawing.Size(1245, 164);
            this.grbMusteriBilgi.TabIndex = 4;
            this.grbMusteriBilgi.TabStop = false;
            this.grbMusteriBilgi.Text = "Müşteri Bilgileri";
            // 
            // mskdVergiNo
            // 
            this.mskdVergiNo.Location = new System.Drawing.Point(484, 61);
            this.mskdVergiNo.Mask = "0000000";
            this.mskdVergiNo.Name = "mskdVergiNo";
            this.mskdVergiNo.Size = new System.Drawing.Size(182, 22);
            this.mskdVergiNo.TabIndex = 18;
            this.mskdVergiNo.ValidatingType = typeof(int);
            // 
            // mskdTelefon
            // 
            this.mskdTelefon.Location = new System.Drawing.Point(93, 100);
            this.mskdTelefon.Mask = "(999) 000-0000";
            this.mskdTelefon.Name = "mskdTelefon";
            this.mskdTelefon.Size = new System.Drawing.Size(182, 22);
            this.mskdTelefon.TabIndex = 17;
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(484, 27);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(182, 22);
            this.txtEMail.TabIndex = 16;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(397, 30);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 16);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "E-Mail :";
            // 
            // lblVergiNo
            // 
            this.lblVergiNo.AutoSize = true;
            this.lblVergiNo.Location = new System.Drawing.Point(397, 61);
            this.lblVergiNo.Name = "lblVergiNo";
            this.lblVergiNo.Size = new System.Drawing.Size(66, 16);
            this.lblVergiNo.TabIndex = 13;
            this.lblVergiNo.Text = "Vergi No :";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(93, 61);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(182, 22);
            this.txtAdres.TabIndex = 11;
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
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FormMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 625);
            this.Controls.Add(this.grbMusteriler);
            this.Controls.Add(this.grbMusteriBilgi);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMusteriler";
            this.Text = "FormMusteriler";
            this.Load += new System.EventHandler(this.FormMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMüsteriler)).EndInit();
            this.grbMusteriler.ResumeLayout(false);
            this.grbMusteriBilgi.ResumeLayout(false);
            this.grbMusteriBilgi.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMüsteriler;
        private System.Windows.Forms.RadioButton rbHayir;
        private System.Windows.Forms.RadioButton rbEvet;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAktifMi;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.ToolStripButton btnSil;
        private System.Windows.Forms.ToolStripButton btnGuncelle;
        private System.Windows.Forms.ToolStripButton btnKaydet;
        private System.Windows.Forms.GroupBox grbMusteriler;
        private System.Windows.Forms.GroupBox grbMusteriBilgi;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblVergiNo;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.MaskedTextBox mskdVergiNo;
        private System.Windows.Forms.MaskedTextBox mskdTelefon;
    }
}