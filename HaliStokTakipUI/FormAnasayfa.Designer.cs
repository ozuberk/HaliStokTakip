namespace HaliStokTakipUI
{
    partial class FormAnasayfa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.halilarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haliBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparislerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisOdemeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.iadelerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.kargoTakipMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.musterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stoklarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanicilarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbKullaniciKutusu = new System.Windows.Forms.GroupBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbKullaniciKutusu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.halilarToolStripMenuItem,
            this.haliBilgileriToolStripMenuItem,
            this.siparislerToolStripMenuItem,
            this.musterilerToolStripMenuItem,
            this.stoklarToolStripMenuItem,
            this.kullanicilarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1257, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // halilarToolStripMenuItem
            // 
            this.halilarToolStripMenuItem.Name = "halilarToolStripMenuItem";
            this.halilarToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.halilarToolStripMenuItem.Text = "Halılar";
            this.halilarToolStripMenuItem.Click += new System.EventHandler(this.halilarToolStripMenuItem_Click);
            // 
            // haliBilgileriToolStripMenuItem
            // 
            this.haliBilgileriToolStripMenuItem.Name = "haliBilgileriToolStripMenuItem";
            this.haliBilgileriToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.haliBilgileriToolStripMenuItem.Text = "Halı Bilgileri";
            this.haliBilgileriToolStripMenuItem.Click += new System.EventHandler(this.haliBilgileriToolStripMenuItem_Click);
            // 
            // siparislerToolStripMenuItem
            // 
            this.siparislerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparisOdemeMenu,
            this.iadelerMenu,
            this.kargoTakipMenu});
            this.siparislerToolStripMenuItem.Name = "siparislerToolStripMenuItem";
            this.siparislerToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.siparislerToolStripMenuItem.Text = "Siparişler";
            this.siparislerToolStripMenuItem.Click += new System.EventHandler(this.siparislerToolStripMenuItem_Click);
            // 
            // siparisOdemeMenu
            // 
            this.siparisOdemeMenu.Name = "siparisOdemeMenu";
            this.siparisOdemeMenu.Size = new System.Drawing.Size(210, 26);
            this.siparisOdemeMenu.Text = "Sipariş Ödemeleri";
            this.siparisOdemeMenu.Click += new System.EventHandler(this.siparisOdemeMenu_Click);
            // 
            // iadelerMenu
            // 
            this.iadelerMenu.Name = "iadelerMenu";
            this.iadelerMenu.Size = new System.Drawing.Size(210, 26);
            this.iadelerMenu.Text = "İadeler";
            this.iadelerMenu.Click += new System.EventHandler(this.iadelerMenu_Click);
            // 
            // kargoTakipMenu
            // 
            this.kargoTakipMenu.Name = "kargoTakipMenu";
            this.kargoTakipMenu.Size = new System.Drawing.Size(210, 26);
            this.kargoTakipMenu.Text = "KargoTakip";
            this.kargoTakipMenu.Click += new System.EventHandler(this.kargoTakipMenu_Click);
            // 
            // musterilerToolStripMenuItem
            // 
            this.musterilerToolStripMenuItem.Name = "musterilerToolStripMenuItem";
            this.musterilerToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.musterilerToolStripMenuItem.Text = "Müşteriler";
            this.musterilerToolStripMenuItem.Click += new System.EventHandler(this.musterilerToolStripMenuItem_Click);
            // 
            // stoklarToolStripMenuItem
            // 
            this.stoklarToolStripMenuItem.Name = "stoklarToolStripMenuItem";
            this.stoklarToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.stoklarToolStripMenuItem.Text = "Stoklar";
            this.stoklarToolStripMenuItem.Click += new System.EventHandler(this.stoklarToolStripMenuItem_Click);
            // 
            // kullanicilarToolStripMenuItem
            // 
            this.kullanicilarToolStripMenuItem.Name = "kullanicilarToolStripMenuItem";
            this.kullanicilarToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.kullanicilarToolStripMenuItem.Text = "Kullanıcılar";
            this.kullanicilarToolStripMenuItem.Click += new System.EventHandler(this.kullanicilarToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.grbKullaniciKutusu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 625);
            this.panel1.TabIndex = 2;
            // 
            // grbKullaniciKutusu
            // 
            this.grbKullaniciKutusu.Controls.Add(this.btnGiris);
            this.grbKullaniciKutusu.Controls.Add(this.lblKullanici);
            this.grbKullaniciKutusu.Controls.Add(this.txtSifre);
            this.grbKullaniciKutusu.Controls.Add(this.txtKullanici);
            this.grbKullaniciKutusu.Controls.Add(this.lblSifre);
            this.grbKullaniciKutusu.Location = new System.Drawing.Point(438, 142);
            this.grbKullaniciKutusu.Name = "grbKullaniciKutusu";
            this.grbKullaniciKutusu.Size = new System.Drawing.Size(376, 269);
            this.grbKullaniciKutusu.TabIndex = 12;
            this.grbKullaniciKutusu.TabStop = false;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGiris.Location = new System.Drawing.Point(153, 174);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(105, 31);
            this.btnGiris.TabIndex = 12;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Location = new System.Drawing.Point(72, 67);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(85, 16);
            this.lblKullanici.TabIndex = 14;
            this.lblKullanici.Text = "Kullanıcı Adı :";
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.SystemColors.Info;
            this.txtSifre.Location = new System.Drawing.Point(163, 115);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(142, 22);
            this.txtSifre.TabIndex = 16;
            // 
            // txtKullanici
            // 
            this.txtKullanici.BackColor = System.Drawing.SystemColors.Info;
            this.txtKullanici.Location = new System.Drawing.Point(163, 64);
            this.txtKullanici.Multiline = true;
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(142, 22);
            this.txtKullanici.TabIndex = 13;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(90, 118);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(40, 16);
            this.lblSifre.TabIndex = 15;
            this.lblSifre.Text = "Şifre :";
            // 
            // FormAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAnasayfa";
            this.Text = "Halı Stok Takip";
            this.Load += new System.EventHandler(this.FormAnasayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.grbKullaniciKutusu.ResumeLayout(false);
            this.grbKullaniciKutusu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem halilarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparislerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanicilarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stoklarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem haliBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparisOdemeMenu;
        private System.Windows.Forms.ToolStripMenuItem iadelerMenu;
        private System.Windows.Forms.ToolStripMenuItem kargoTakipMenu;
        private System.Windows.Forms.GroupBox grbKullaniciKutusu;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Label lblSifre;
    }
}