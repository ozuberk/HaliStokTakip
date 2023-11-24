using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HaliStokTakipBLL.Manager;
using HaliStokTakipUI;

namespace HaliStokTakipUI
{
    public partial class FormAnasayfa : Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();
            formHalilar = new FormHalilar();
            haliBilgileri = new FormHaliBilgileri();
            formMusteriler = new FormMusteriler();
            formStoklar = new FormStoklar();
            formSiparisler = new FormSiparisler();
            formKullanicilar = new FormKullanicilar();
            formSiparisOdemeleri = new FormSiparisOdemeleri();
            formIadeler = new FormIadeler();
            formKargoTakip = new FormKargoTakip();
        }


        private void FormAnasayfa_Load(object sender, EventArgs e)
        {
            menuStrip1.Hide();
        }

        private void ButonRengi(object sender, EventArgs e)
        {
            // Tıklanan ToolStripMenuItem'i alın
            ToolStripMenuItem clickedButton = sender as ToolStripMenuItem;

            // Tüm ToolStripMenuItem'lerin renklerini sıfırla
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.BackColor = SystemColors.ButtonHighlight;
                item.ForeColor = SystemColors.ControlText;
            }
            foreach (ToolStripMenuItem item in siparislerToolStripMenuItem.DropDownItems)
            {
                item.BackColor = SystemColors.ButtonHighlight;
                item.ForeColor = SystemColors.ControlText;
            }

            // Seçilen ToolStripMenuItem'in rengini ayarla
            clickedButton.BackColor = Color.Red;
            clickedButton.ForeColor = Color.White;
        }

        FormHalilar formHalilar;
        private void halilarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            formHalilar.TopLevel = false;
            panel1.Controls.Add(formHalilar);
            formHalilar.Dock = DockStyle.Fill;
            formHalilar.Show();
            ButonRengi(sender, e);
        }

        FormHaliBilgileri haliBilgileri;

        private void haliBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            haliBilgileri.TopLevel = false;
            panel1.Controls.Add(haliBilgileri);
            haliBilgileri.Dock = DockStyle.Fill;
            haliBilgileri.Show();
            ButonRengi(sender, e);

        }


        FormSiparisler formSiparisler;
        private void siparislerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            formSiparisler.TopLevel = false;
            panel1.Controls.Add(formSiparisler);
            formSiparisler.Dock = DockStyle.Fill;
            formSiparisler.Show();
            ButonRengi(sender, e);
        }


        FormKullanicilar formKullanicilar;
        private void kullanicilarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            formKullanicilar.TopLevel = false;
            panel1.Controls.Add(formKullanicilar);
            formKullanicilar.Dock = DockStyle.Fill;
            formKullanicilar.Show();
            ButonRengi(sender, e);


        }


        FormMusteriler formMusteriler;
        private void musterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            formMusteriler.TopLevel = false;
            panel1.Controls.Add(formMusteriler);
            formMusteriler.Dock = DockStyle.Fill;
            formMusteriler.Show();
            ButonRengi(sender, e);


        }

        FormStoklar formStoklar;
        private void stoklarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            formStoklar.TopLevel = false;
            panel1.Controls.Add(formStoklar);
            formStoklar.Dock = DockStyle.Fill;
            formStoklar.Show();
            ButonRengi(sender, e);


        }

        FormSiparisOdemeleri formSiparisOdemeleri;
        private void siparisOdemeMenu_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            formSiparisOdemeleri.TopLevel = false;
            panel1.Controls.Add(formSiparisOdemeleri);
            formSiparisOdemeleri.Dock = DockStyle.Fill;
            formSiparisOdemeleri.Show();
            ButonRengi(sender, e);
        }
        FormIadeler formIadeler;
        private void iadelerMenu_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            formIadeler.TopLevel = false;
            panel1.Controls.Add(formIadeler);
            formIadeler.Dock = DockStyle.Fill;
            formIadeler.Show();
            ButonRengi(sender, e);
        }
        FormKargoTakip formKargoTakip;
        private void kargoTakipMenu_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            formKargoTakip.TopLevel = false;
            panel1.Controls.Add(formKargoTakip);
            formKargoTakip.Dock = DockStyle.Fill;
            formKargoTakip.Show();
            ButonRengi(sender, e);
        }

        KullanicilarManager kullanicilarManager = new KullanicilarManager();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var sonuc = kullanicilarManager.Giris(txtKullanici.Text, txtSifre.Text);
            if (sonuc != null)
            {
                var yetkiId = kullanicilarManager.Yetki(txtKullanici.Text, txtSifre.Text);
                txtKullanici.Clear();
                txtSifre.Clear();
                if (yetkiId == 1)
                {
                    menuStrip1.Show();
                    grbKullaniciKutusu.Hide();
                }
                else if (yetkiId == 2)
                {
                    menuStrip1.Show();
                    kullanicilarToolStripMenuItem.Visible = false;
                    grbKullaniciKutusu.Hide();
                }


            }
            else
            {
                MessageBox.Show("Kullanıcıadı Veya Şifre Hatalı");
                txtKullanici.Clear();
                txtSifre.Clear();
            }
        }
    }
}
