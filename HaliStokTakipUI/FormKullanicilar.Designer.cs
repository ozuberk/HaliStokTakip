namespace HaliStokTakipUI
{
    partial class FormKullanicilar
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
            this.lblKullaniciAciklama = new System.Windows.Forms.Label();
            this.lblKulAktifMi = new System.Windows.Forms.Label();
            this.rbKullaniciEvet = new System.Windows.Forms.RadioButton();
            this.rbKullaniciHayir = new System.Windows.Forms.RadioButton();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.grbKullaniciBilgi = new System.Windows.Forms.GroupBox();
            this.cbYetkiAdi = new System.Windows.Forms.ComboBox();
            this.lblYetkiID = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.grbKullanicilar = new System.Windows.Forms.GroupBox();
            this.btSilKullanici = new System.Windows.Forms.Button();
            this.btGuncelleKullanici = new System.Windows.Forms.Button();
            this.btKaydetKullanici = new System.Windows.Forms.Button();
            this.grbYetkiBilgi = new System.Windows.Forms.GroupBox();
            this.txtYetkiAdi = new System.Windows.Forms.TextBox();
            this.lblYetkiAdi = new System.Windows.Forms.Label();
            this.txtYetkiAciklama = new System.Windows.Forms.TextBox();
            this.rbYetkiHayir = new System.Windows.Forms.RadioButton();
            this.rbYetkiEvet = new System.Windows.Forms.RadioButton();
            this.lblYetkiAktifMi = new System.Windows.Forms.Label();
            this.lblYetkiAciklama = new System.Windows.Forms.Label();
            this.grbYetkiler = new System.Windows.Forms.GroupBox();
            this.dgvYetkiler = new System.Windows.Forms.DataGridView();
            this.grbNotBilgi = new System.Windows.Forms.GroupBox();
            this.dtpNotTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtNotIcerigi = new System.Windows.Forms.TextBox();
            this.lblNot = new System.Windows.Forms.Label();
            this.cbKullaniciID = new System.Windows.Forms.ComboBox();
            this.lblKullaniciID = new System.Windows.Forms.Label();
            this.rbNotHayir = new System.Windows.Forms.RadioButton();
            this.rbNotEvet = new System.Windows.Forms.RadioButton();
            this.lblNotAktifMi = new System.Windows.Forms.Label();
            this.lblNotTarihi = new System.Windows.Forms.Label();
            this.grbNotlar = new System.Windows.Forms.GroupBox();
            this.dgvNotlar = new System.Windows.Forms.DataGridView();
            this.btnSilYetki = new System.Windows.Forms.Button();
            this.btnGuncYetki = new System.Windows.Forms.Button();
            this.btnKaydetYetki = new System.Windows.Forms.Button();
            this.btnSilNot = new System.Windows.Forms.Button();
            this.btnGuncNot = new System.Windows.Forms.Button();
            this.btnKaydetNot = new System.Windows.Forms.Button();
            this.grbKullaniciBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            this.grbKullanicilar.SuspendLayout();
            this.grbYetkiBilgi.SuspendLayout();
            this.grbYetkiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYetkiler)).BeginInit();
            this.grbNotBilgi.SuspendLayout();
            this.grbNotlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotlar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullaniciAciklama
            // 
            this.lblKullaniciAciklama.AutoSize = true;
            this.lblKullaniciAciklama.Location = new System.Drawing.Point(285, 32);
            this.lblKullaniciAciklama.Name = "lblKullaniciAciklama";
            this.lblKullaniciAciklama.Size = new System.Drawing.Size(69, 16);
            this.lblKullaniciAciklama.TabIndex = 1;
            this.lblKullaniciAciklama.Text = "Açıklama :";
            // 
            // lblKulAktifMi
            // 
            this.lblKulAktifMi.AutoSize = true;
            this.lblKulAktifMi.Location = new System.Drawing.Point(298, 140);
            this.lblKulAktifMi.Name = "lblKulAktifMi";
            this.lblKulAktifMi.Size = new System.Drawing.Size(49, 16);
            this.lblKulAktifMi.TabIndex = 2;
            this.lblKulAktifMi.Text = "Aktif Mi";
            // 
            // rbKullaniciEvet
            // 
            this.rbKullaniciEvet.AutoSize = true;
            this.rbKullaniciEvet.Location = new System.Drawing.Point(380, 138);
            this.rbKullaniciEvet.Name = "rbKullaniciEvet";
            this.rbKullaniciEvet.Size = new System.Drawing.Size(55, 20);
            this.rbKullaniciEvet.TabIndex = 4;
            this.rbKullaniciEvet.TabStop = true;
            this.rbKullaniciEvet.Text = "Evet";
            this.rbKullaniciEvet.UseVisualStyleBackColor = true;
            // 
            // rbKullaniciHayir
            // 
            this.rbKullaniciHayir.AutoSize = true;
            this.rbKullaniciHayir.Location = new System.Drawing.Point(478, 138);
            this.rbKullaniciHayir.Name = "rbKullaniciHayir";
            this.rbKullaniciHayir.Size = new System.Drawing.Size(60, 20);
            this.rbKullaniciHayir.TabIndex = 5;
            this.rbKullaniciHayir.TabStop = true;
            this.rbKullaniciHayir.Text = "Hayır";
            this.rbKullaniciHayir.UseVisualStyleBackColor = true;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(350, 32);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(224, 89);
            this.txtAciklama.TabIndex = 22;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(17, 32);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(82, 16);
            this.lblKullaniciAdi.TabIndex = 25;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(104, 29);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(167, 22);
            this.txtKullaniciAdi.TabIndex = 26;
            // 
            // grbKullaniciBilgi
            // 
            this.grbKullaniciBilgi.Controls.Add(this.cbYetkiAdi);
            this.grbKullaniciBilgi.Controls.Add(this.lblYetkiID);
            this.grbKullaniciBilgi.Controls.Add(this.txtMail);
            this.grbKullaniciBilgi.Controls.Add(this.lblMail);
            this.grbKullaniciBilgi.Controls.Add(this.txtSifre);
            this.grbKullaniciBilgi.Controls.Add(this.lblSifre);
            this.grbKullaniciBilgi.Controls.Add(this.txtKullaniciAdi);
            this.grbKullaniciBilgi.Controls.Add(this.lblKullaniciAdi);
            this.grbKullaniciBilgi.Controls.Add(this.txtAciklama);
            this.grbKullaniciBilgi.Controls.Add(this.rbKullaniciHayir);
            this.grbKullaniciBilgi.Controls.Add(this.rbKullaniciEvet);
            this.grbKullaniciBilgi.Controls.Add(this.lblKulAktifMi);
            this.grbKullaniciBilgi.Controls.Add(this.lblKullaniciAciklama);
            this.grbKullaniciBilgi.Location = new System.Drawing.Point(-3, 31);
            this.grbKullaniciBilgi.Name = "grbKullaniciBilgi";
            this.grbKullaniciBilgi.Size = new System.Drawing.Size(586, 225);
            this.grbKullaniciBilgi.TabIndex = 5;
            this.grbKullaniciBilgi.TabStop = false;
            this.grbKullaniciBilgi.Text = "Kullanıcı Bilgileri";
            // 
            // cbYetkiAdi
            // 
            this.cbYetkiAdi.FormattingEnabled = true;
            this.cbYetkiAdi.Location = new System.Drawing.Point(104, 129);
            this.cbYetkiAdi.Name = "cbYetkiAdi";
            this.cbYetkiAdi.Size = new System.Drawing.Size(167, 24);
            this.cbYetkiAdi.TabIndex = 32;
            // 
            // lblYetkiID
            // 
            this.lblYetkiID.AutoSize = true;
            this.lblYetkiID.Location = new System.Drawing.Point(17, 138);
            this.lblYetkiID.Name = "lblYetkiID";
            this.lblYetkiID.Size = new System.Drawing.Size(63, 16);
            this.lblYetkiID.TabIndex = 31;
            this.lblYetkiID.Text = "Yetki Adı:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(104, 98);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(167, 22);
            this.txtMail.TabIndex = 30;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(17, 101);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(51, 16);
            this.lblMail.TabIndex = 29;
            this.lblMail.Text = "E-Mail :";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(104, 65);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(167, 22);
            this.txtSifre.TabIndex = 28;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(17, 68);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(40, 16);
            this.lblSifre.TabIndex = 27;
            this.lblSifre.Text = "Şifre :";
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKullanicilar.Location = new System.Drawing.Point(3, 18);
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.RowHeadersWidth = 51;
            this.dgvKullanicilar.RowTemplate.Height = 24;
            this.dgvKullanicilar.Size = new System.Drawing.Size(574, 343);
            this.dgvKullanicilar.TabIndex = 0;
            this.dgvKullanicilar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKullanicilar_CellDoubleClick);
            this.dgvKullanicilar.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvKullanicilar_CellFormatting);
            // 
            // grbKullanicilar
            // 
            this.grbKullanicilar.Controls.Add(this.dgvKullanicilar);
            this.grbKullanicilar.Location = new System.Drawing.Point(3, 255);
            this.grbKullanicilar.Name = "grbKullanicilar";
            this.grbKullanicilar.Size = new System.Drawing.Size(580, 364);
            this.grbKullanicilar.TabIndex = 6;
            this.grbKullanicilar.TabStop = false;
            this.grbKullanicilar.Text = "Kullanıcılar";
            // 
            // btSilKullanici
            // 
            this.btSilKullanici.Location = new System.Drawing.Point(349, 5);
            this.btSilKullanici.Name = "btSilKullanici";
            this.btSilKullanici.Size = new System.Drawing.Size(75, 23);
            this.btSilKullanici.TabIndex = 12;
            this.btSilKullanici.Text = "Sil";
            this.btSilKullanici.UseVisualStyleBackColor = true;
            this.btSilKullanici.Click += new System.EventHandler(this.btSilKullanici_Click);
            // 
            // btGuncelleKullanici
            // 
            this.btGuncelleKullanici.Location = new System.Drawing.Point(195, 5);
            this.btGuncelleKullanici.Name = "btGuncelleKullanici";
            this.btGuncelleKullanici.Size = new System.Drawing.Size(94, 23);
            this.btGuncelleKullanici.TabIndex = 11;
            this.btGuncelleKullanici.Text = "Guncelle";
            this.btGuncelleKullanici.UseVisualStyleBackColor = true;
            this.btGuncelleKullanici.Click += new System.EventHandler(this.btGuncelleKullanici_Click);
            // 
            // btKaydetKullanici
            // 
            this.btKaydetKullanici.Location = new System.Drawing.Point(40, 4);
            this.btKaydetKullanici.Name = "btKaydetKullanici";
            this.btKaydetKullanici.Size = new System.Drawing.Size(75, 23);
            this.btKaydetKullanici.TabIndex = 10;
            this.btKaydetKullanici.Text = "Kaydet";
            this.btKaydetKullanici.UseVisualStyleBackColor = true;
            this.btKaydetKullanici.Click += new System.EventHandler(this.btKaydetKullanici_Click);
            // 
            // grbYetkiBilgi
            // 
            this.grbYetkiBilgi.Controls.Add(this.txtYetkiAdi);
            this.grbYetkiBilgi.Controls.Add(this.lblYetkiAdi);
            this.grbYetkiBilgi.Controls.Add(this.txtYetkiAciklama);
            this.grbYetkiBilgi.Controls.Add(this.rbYetkiHayir);
            this.grbYetkiBilgi.Controls.Add(this.rbYetkiEvet);
            this.grbYetkiBilgi.Controls.Add(this.lblYetkiAktifMi);
            this.grbYetkiBilgi.Controls.Add(this.lblYetkiAciklama);
            this.grbYetkiBilgi.Location = new System.Drawing.Point(589, 31);
            this.grbYetkiBilgi.Name = "grbYetkiBilgi";
            this.grbYetkiBilgi.Size = new System.Drawing.Size(325, 225);
            this.grbYetkiBilgi.TabIndex = 33;
            this.grbYetkiBilgi.TabStop = false;
            this.grbYetkiBilgi.Text = "Yetki Bilgileri";
            // 
            // txtYetkiAdi
            // 
            this.txtYetkiAdi.Location = new System.Drawing.Point(92, 29);
            this.txtYetkiAdi.Name = "txtYetkiAdi";
            this.txtYetkiAdi.Size = new System.Drawing.Size(188, 22);
            this.txtYetkiAdi.TabIndex = 26;
            // 
            // lblYetkiAdi
            // 
            this.lblYetkiAdi.AutoSize = true;
            this.lblYetkiAdi.Location = new System.Drawing.Point(17, 32);
            this.lblYetkiAdi.Name = "lblYetkiAdi";
            this.lblYetkiAdi.Size = new System.Drawing.Size(63, 16);
            this.lblYetkiAdi.TabIndex = 25;
            this.lblYetkiAdi.Text = "Yetki Adı:";
            // 
            // txtYetkiAciklama
            // 
            this.txtYetkiAciklama.Location = new System.Drawing.Point(92, 62);
            this.txtYetkiAciklama.Multiline = true;
            this.txtYetkiAciklama.Name = "txtYetkiAciklama";
            this.txtYetkiAciklama.Size = new System.Drawing.Size(188, 89);
            this.txtYetkiAciklama.TabIndex = 22;
            // 
            // rbYetkiHayir
            // 
            this.rbYetkiHayir.AutoSize = true;
            this.rbYetkiHayir.Location = new System.Drawing.Point(213, 176);
            this.rbYetkiHayir.Name = "rbYetkiHayir";
            this.rbYetkiHayir.Size = new System.Drawing.Size(60, 20);
            this.rbYetkiHayir.TabIndex = 5;
            this.rbYetkiHayir.TabStop = true;
            this.rbYetkiHayir.Text = "Hayır";
            this.rbYetkiHayir.UseVisualStyleBackColor = true;
            // 
            // rbYetkiEvet
            // 
            this.rbYetkiEvet.AutoSize = true;
            this.rbYetkiEvet.Location = new System.Drawing.Point(115, 176);
            this.rbYetkiEvet.Name = "rbYetkiEvet";
            this.rbYetkiEvet.Size = new System.Drawing.Size(55, 20);
            this.rbYetkiEvet.TabIndex = 4;
            this.rbYetkiEvet.TabStop = true;
            this.rbYetkiEvet.Text = "Evet";
            this.rbYetkiEvet.UseVisualStyleBackColor = true;
            // 
            // lblYetkiAktifMi
            // 
            this.lblYetkiAktifMi.AutoSize = true;
            this.lblYetkiAktifMi.Location = new System.Drawing.Point(20, 176);
            this.lblYetkiAktifMi.Name = "lblYetkiAktifMi";
            this.lblYetkiAktifMi.Size = new System.Drawing.Size(49, 16);
            this.lblYetkiAktifMi.TabIndex = 2;
            this.lblYetkiAktifMi.Text = "Aktif Mi";
            // 
            // lblYetkiAciklama
            // 
            this.lblYetkiAciklama.AutoSize = true;
            this.lblYetkiAciklama.Location = new System.Drawing.Point(17, 65);
            this.lblYetkiAciklama.Name = "lblYetkiAciklama";
            this.lblYetkiAciklama.Size = new System.Drawing.Size(69, 16);
            this.lblYetkiAciklama.TabIndex = 1;
            this.lblYetkiAciklama.Text = "Açıklama :";
            // 
            // grbYetkiler
            // 
            this.grbYetkiler.Controls.Add(this.dgvYetkiler);
            this.grbYetkiler.Location = new System.Drawing.Point(589, 255);
            this.grbYetkiler.Name = "grbYetkiler";
            this.grbYetkiler.Size = new System.Drawing.Size(325, 364);
            this.grbYetkiler.TabIndex = 7;
            this.grbYetkiler.TabStop = false;
            this.grbYetkiler.Text = "Yetkiler";
            // 
            // dgvYetkiler
            // 
            this.dgvYetkiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYetkiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvYetkiler.Location = new System.Drawing.Point(3, 18);
            this.dgvYetkiler.Name = "dgvYetkiler";
            this.dgvYetkiler.RowHeadersWidth = 51;
            this.dgvYetkiler.RowTemplate.Height = 24;
            this.dgvYetkiler.Size = new System.Drawing.Size(319, 343);
            this.dgvYetkiler.TabIndex = 0;
            this.dgvYetkiler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYetkiler_CellDoubleClick);
            this.dgvYetkiler.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvYetkiler_CellFormatting);
            // 
            // grbNotBilgi
            // 
            this.grbNotBilgi.Controls.Add(this.dtpNotTarihi);
            this.grbNotBilgi.Controls.Add(this.txtNotIcerigi);
            this.grbNotBilgi.Controls.Add(this.lblNot);
            this.grbNotBilgi.Controls.Add(this.cbKullaniciID);
            this.grbNotBilgi.Controls.Add(this.lblKullaniciID);
            this.grbNotBilgi.Controls.Add(this.rbNotHayir);
            this.grbNotBilgi.Controls.Add(this.rbNotEvet);
            this.grbNotBilgi.Controls.Add(this.lblNotAktifMi);
            this.grbNotBilgi.Controls.Add(this.lblNotTarihi);
            this.grbNotBilgi.Location = new System.Drawing.Point(920, 31);
            this.grbNotBilgi.Name = "grbNotBilgi";
            this.grbNotBilgi.Size = new System.Drawing.Size(332, 225);
            this.grbNotBilgi.TabIndex = 34;
            this.grbNotBilgi.TabStop = false;
            this.grbNotBilgi.Text = "Not Bilgileri";
            // 
            // dtpNotTarihi
            // 
            this.dtpNotTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNotTarihi.Location = new System.Drawing.Point(113, 63);
            this.dtpNotTarihi.Name = "dtpNotTarihi";
            this.dtpNotTarihi.Size = new System.Drawing.Size(167, 22);
            this.dtpNotTarihi.TabIndex = 35;
            // 
            // txtNotIcerigi
            // 
            this.txtNotIcerigi.Location = new System.Drawing.Point(113, 91);
            this.txtNotIcerigi.Multiline = true;
            this.txtNotIcerigi.Name = "txtNotIcerigi";
            this.txtNotIcerigi.Size = new System.Drawing.Size(167, 73);
            this.txtNotIcerigi.TabIndex = 27;
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.Location = new System.Drawing.Point(20, 98);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(45, 16);
            this.lblNot.TabIndex = 34;
            this.lblNot.Text = "İçerik :";
            // 
            // cbKullaniciID
            // 
            this.cbKullaniciID.FormattingEnabled = true;
            this.cbKullaniciID.Location = new System.Drawing.Point(113, 29);
            this.cbKullaniciID.Name = "cbKullaniciID";
            this.cbKullaniciID.Size = new System.Drawing.Size(167, 24);
            this.cbKullaniciID.TabIndex = 33;
            // 
            // lblKullaniciID
            // 
            this.lblKullaniciID.AutoSize = true;
            this.lblKullaniciID.Location = new System.Drawing.Point(17, 32);
            this.lblKullaniciID.Name = "lblKullaniciID";
            this.lblKullaniciID.Size = new System.Drawing.Size(85, 16);
            this.lblKullaniciID.TabIndex = 25;
            this.lblKullaniciID.Text = "Kullanıcı Adı :";
            // 
            // rbNotHayir
            // 
            this.rbNotHayir.AutoSize = true;
            this.rbNotHayir.Location = new System.Drawing.Point(213, 176);
            this.rbNotHayir.Name = "rbNotHayir";
            this.rbNotHayir.Size = new System.Drawing.Size(60, 20);
            this.rbNotHayir.TabIndex = 5;
            this.rbNotHayir.TabStop = true;
            this.rbNotHayir.Text = "Hayır";
            this.rbNotHayir.UseVisualStyleBackColor = true;
            // 
            // rbNotEvet
            // 
            this.rbNotEvet.AutoSize = true;
            this.rbNotEvet.Location = new System.Drawing.Point(115, 176);
            this.rbNotEvet.Name = "rbNotEvet";
            this.rbNotEvet.Size = new System.Drawing.Size(55, 20);
            this.rbNotEvet.TabIndex = 4;
            this.rbNotEvet.TabStop = true;
            this.rbNotEvet.Text = "Evet";
            this.rbNotEvet.UseVisualStyleBackColor = true;
            // 
            // lblNotAktifMi
            // 
            this.lblNotAktifMi.AutoSize = true;
            this.lblNotAktifMi.Location = new System.Drawing.Point(20, 176);
            this.lblNotAktifMi.Name = "lblNotAktifMi";
            this.lblNotAktifMi.Size = new System.Drawing.Size(49, 16);
            this.lblNotAktifMi.TabIndex = 2;
            this.lblNotAktifMi.Text = "Aktif Mi";
            // 
            // lblNotTarihi
            // 
            this.lblNotTarihi.AutoSize = true;
            this.lblNotTarihi.Location = new System.Drawing.Point(17, 65);
            this.lblNotTarihi.Name = "lblNotTarihi";
            this.lblNotTarihi.Size = new System.Drawing.Size(71, 16);
            this.lblNotTarihi.TabIndex = 1;
            this.lblNotTarihi.Text = "Not Tarihi :";
            // 
            // grbNotlar
            // 
            this.grbNotlar.Controls.Add(this.dgvNotlar);
            this.grbNotlar.Location = new System.Drawing.Point(920, 255);
            this.grbNotlar.Name = "grbNotlar";
            this.grbNotlar.Size = new System.Drawing.Size(325, 364);
            this.grbNotlar.TabIndex = 8;
            this.grbNotlar.TabStop = false;
            this.grbNotlar.Text = "Notlar";
            // 
            // dgvNotlar
            // 
            this.dgvNotlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotlar.Location = new System.Drawing.Point(3, 18);
            this.dgvNotlar.Name = "dgvNotlar";
            this.dgvNotlar.RowHeadersWidth = 51;
            this.dgvNotlar.RowTemplate.Height = 24;
            this.dgvNotlar.Size = new System.Drawing.Size(319, 343);
            this.dgvNotlar.TabIndex = 0;
            this.dgvNotlar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotlar_CellDoubleClick);
            this.dgvNotlar.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNotlar_CellFormatting);
            // 
            // btnSilYetki
            // 
            this.btnSilYetki.Location = new System.Drawing.Point(802, 4);
            this.btnSilYetki.Name = "btnSilYetki";
            this.btnSilYetki.Size = new System.Drawing.Size(75, 23);
            this.btnSilYetki.TabIndex = 37;
            this.btnSilYetki.Text = "Sil";
            this.btnSilYetki.UseVisualStyleBackColor = true;
            this.btnSilYetki.Click += new System.EventHandler(this.btnSilYetki_Click);
            // 
            // btnGuncYetki
            // 
            this.btnGuncYetki.Location = new System.Drawing.Point(694, 5);
            this.btnGuncYetki.Name = "btnGuncYetki";
            this.btnGuncYetki.Size = new System.Drawing.Size(85, 23);
            this.btnGuncYetki.TabIndex = 36;
            this.btnGuncYetki.Text = "Guncelle";
            this.btnGuncYetki.UseVisualStyleBackColor = true;
            this.btnGuncYetki.Click += new System.EventHandler(this.btnGuncYetki_Click);
            // 
            // btnKaydetYetki
            // 
            this.btnKaydetYetki.Location = new System.Drawing.Point(600, 5);
            this.btnKaydetYetki.Name = "btnKaydetYetki";
            this.btnKaydetYetki.Size = new System.Drawing.Size(75, 23);
            this.btnKaydetYetki.TabIndex = 35;
            this.btnKaydetYetki.Text = "Kaydet";
            this.btnKaydetYetki.UseVisualStyleBackColor = true;
            this.btnKaydetYetki.Click += new System.EventHandler(this.btnKaydetYetki_Click);
            // 
            // btnSilNot
            // 
            this.btnSilNot.Location = new System.Drawing.Point(1142, 3);
            this.btnSilNot.Name = "btnSilNot";
            this.btnSilNot.Size = new System.Drawing.Size(75, 23);
            this.btnSilNot.TabIndex = 40;
            this.btnSilNot.Text = "Sil";
            this.btnSilNot.UseVisualStyleBackColor = true;
            this.btnSilNot.Click += new System.EventHandler(this.btnSilNot_Click);
            // 
            // btnGuncNot
            // 
            this.btnGuncNot.Location = new System.Drawing.Point(1021, 4);
            this.btnGuncNot.Name = "btnGuncNot";
            this.btnGuncNot.Size = new System.Drawing.Size(98, 23);
            this.btnGuncNot.TabIndex = 39;
            this.btnGuncNot.Text = "Guncelle";
            this.btnGuncNot.UseVisualStyleBackColor = true;
            this.btnGuncNot.Click += new System.EventHandler(this.btnGuncNot_Click);
            // 
            // btnKaydetNot
            // 
            this.btnKaydetNot.Location = new System.Drawing.Point(940, 4);
            this.btnKaydetNot.Name = "btnKaydetNot";
            this.btnKaydetNot.Size = new System.Drawing.Size(75, 23);
            this.btnKaydetNot.TabIndex = 38;
            this.btnKaydetNot.Text = "Kaydet";
            this.btnKaydetNot.UseVisualStyleBackColor = true;
            this.btnKaydetNot.Click += new System.EventHandler(this.btnKaydetNot_Click);
            // 
            // FormKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 625);
            this.Controls.Add(this.btnSilNot);
            this.Controls.Add(this.btnGuncNot);
            this.Controls.Add(this.btnKaydetNot);
            this.Controls.Add(this.btnSilYetki);
            this.Controls.Add(this.btnGuncYetki);
            this.Controls.Add(this.btnKaydetYetki);
            this.Controls.Add(this.grbNotlar);
            this.Controls.Add(this.grbNotBilgi);
            this.Controls.Add(this.grbYetkiler);
            this.Controls.Add(this.grbYetkiBilgi);
            this.Controls.Add(this.btSilKullanici);
            this.Controls.Add(this.btGuncelleKullanici);
            this.Controls.Add(this.btKaydetKullanici);
            this.Controls.Add(this.grbKullanicilar);
            this.Controls.Add(this.grbKullaniciBilgi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKullanicilar";
            this.Text = "FormKullanicilar";
            this.Load += new System.EventHandler(this.FormKullanicilar_Load);
            this.grbKullaniciBilgi.ResumeLayout(false);
            this.grbKullaniciBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.grbKullanicilar.ResumeLayout(false);
            this.grbYetkiBilgi.ResumeLayout(false);
            this.grbYetkiBilgi.PerformLayout();
            this.grbYetkiler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYetkiler)).EndInit();
            this.grbNotBilgi.ResumeLayout(false);
            this.grbNotBilgi.PerformLayout();
            this.grbNotlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblKullaniciAciklama;
        private System.Windows.Forms.Label lblKulAktifMi;
        private System.Windows.Forms.RadioButton rbKullaniciEvet;
        private System.Windows.Forms.RadioButton rbKullaniciHayir;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.GroupBox grbKullaniciBilgi;
        private System.Windows.Forms.DataGridView dgvKullanicilar;
        private System.Windows.Forms.GroupBox grbKullanicilar;
        private System.Windows.Forms.ComboBox cbYetkiAdi;
        private System.Windows.Forms.Label lblYetkiID;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Button btSilKullanici;
        private System.Windows.Forms.Button btGuncelleKullanici;
        private System.Windows.Forms.Button btKaydetKullanici;
        private System.Windows.Forms.GroupBox grbYetkiBilgi;
        private System.Windows.Forms.TextBox txtYetkiAdi;
        private System.Windows.Forms.Label lblYetkiAdi;
        private System.Windows.Forms.TextBox txtYetkiAciklama;
        private System.Windows.Forms.RadioButton rbYetkiHayir;
        private System.Windows.Forms.RadioButton rbYetkiEvet;
        private System.Windows.Forms.Label lblYetkiAktifMi;
        private System.Windows.Forms.Label lblYetkiAciklama;
        private System.Windows.Forms.GroupBox grbYetkiler;
        private System.Windows.Forms.DataGridView dgvYetkiler;
        private System.Windows.Forms.GroupBox grbNotBilgi;
        private System.Windows.Forms.Label lblKullaniciID;
        private System.Windows.Forms.RadioButton rbNotHayir;
        private System.Windows.Forms.RadioButton rbNotEvet;
        private System.Windows.Forms.Label lblNotAktifMi;
        private System.Windows.Forms.Label lblNotTarihi;
        private System.Windows.Forms.GroupBox grbNotlar;
        private System.Windows.Forms.DataGridView dgvNotlar;
        private System.Windows.Forms.ComboBox cbKullaniciID;
        private System.Windows.Forms.DateTimePicker dtpNotTarihi;
        private System.Windows.Forms.TextBox txtNotIcerigi;
        private System.Windows.Forms.Label lblNot;
        private System.Windows.Forms.Button btnSilYetki;
        private System.Windows.Forms.Button btnGuncYetki;
        private System.Windows.Forms.Button btnKaydetYetki;
        private System.Windows.Forms.Button btnSilNot;
        private System.Windows.Forms.Button btnGuncNot;
        private System.Windows.Forms.Button btnKaydetNot;
    }
}