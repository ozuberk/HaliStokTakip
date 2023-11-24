using HaliStokTakipBLL.Manager;
using HaliStokTakipDLL;
using HaliStokTakipDLL.RepositoryFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaliStokTakipUI
{
    public partial class FormKullanicilar : Form
    {
        public FormKullanicilar()
        {
            InitializeComponent();
            HaliStokTakipDBEntities db=new HaliStokTakipDBEntities();
            this.repoYetki = new Repository<Yetkiler>(db);
            this.repoKullanici = new Repository<Kullanicilar>(db);
        }
        Repository<Yetkiler> repoYetki;
        Repository<Kullanicilar> repoKullanici;

        KullanicilarManager kullanicilar = new KullanicilarManager();
        YetkilerManager yetkiler = new YetkilerManager();
        NotlarManager notlar = new NotlarManager();
        int kullaniciID;
        int yetkiID;
        int notID;

        private void FormKullanicilar_Load(object sender, EventArgs e)
        {
            BilgileriListesi();
            Bilgiler();
            Temizle();
        }
        private void BilgileriListesi()
        {
            dgvKullanicilar.DataSource = kullanicilar.KullaniciListele();
            dgvYetkiler.DataSource = yetkiler.YetkileriListele();
            dgvNotlar.DataSource = notlar.NotlariListele();

            dgvKullanicilar.Columns["ID"].Width = 30;
            dgvKullanicilar.Columns["KullaniciEmail"].Width = 120;
            dgvKullanicilar.Columns["KullaniciAdi"].Width = 70;
            dgvKullanicilar.Columns["KullaniciSifre"].Width = 70;
            dgvKullanicilar.Columns["AktifMi"].Width = 42;

            dgvYetkiler.Columns["ID"].Width = 30;
            dgvYetkiler.Columns["YetkiAdi"].Width = 70;
            dgvYetkiler.Columns["AktifMi"].Width = 52;
            dgvYetkiler.Columns["Kullanicilar"].Width = -1;


            dgvNotlar.Columns["ID"].Width = 30;
            dgvNotlar.Columns["KullaniciAdi"].Width = 70;
            dgvNotlar.Columns["AktifMi"].Width = 42;



        }
        private void Temizle()
        {
            kullaniciID = 0;
            txtKullaniciAdi.Text = string.Empty;
            txtSifre.Text = string.Empty;
            txtMail.Text = string.Empty;
            cbYetkiAdi.SelectedIndex = -1;
            txtAciklama.Text = string.Empty;
            rbKullaniciEvet.Checked = false;
            rbKullaniciHayir.Checked = false;

            yetkiID = 0;
            txtYetkiAdi.Text = string.Empty;
            txtYetkiAciklama.Text = string.Empty;
            rbYetkiEvet.Checked = false;
            rbYetkiHayir.Checked = false;

            notID = 0;
            cbKullaniciID.SelectedIndex = -1;
            dtpNotTarihi.Text = string.Empty;
            txtNotIcerigi.Text = string.Empty;
            rbNotEvet.Checked = false;
            rbNotHayir.Checked = false;

        }
        private void Bilgiler()
        {
            cbYetkiAdi.ValueMember = "ID";
            cbYetkiAdi.DisplayMember = "YetkiAdi";
            cbYetkiAdi.DataSource = yetkiler.YetkileriListele();
            cbYetkiAdi.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbYetkiAdi.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbYetkiAdi.SelectedIndex = -1;

            cbKullaniciID.ValueMember = "ID";
            cbKullaniciID.DisplayMember = "KullaniciAdi";
            cbKullaniciID.DataSource = kullanicilar.KullaniciListele();
            cbKullaniciID.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbKullaniciID.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbKullaniciID.SelectedIndex = -1;

        }
        private bool ZorunluAlanlar(string[] Metinler)
        {
            bool sonuc = true;
            foreach (var item in Metinler)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    sonuc = false;
                }
                else
                {
                    sonuc = true;
                    break;
                }
            }
            return sonuc;
        }

        #region Kullanıcılar
        private void btKaydetKullanici_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ZorunluTextler = new string[]
                {
                    txtKullaniciAdi.Text,
                    txtSifre.Text,
                    txtMail.Text,
                    cbYetkiAdi.Text
                };
                if (ZorunluAlanlar(ZorunluTextler) == true)
                {
                    MessageBox.Show("Alanlar Boş Bırakılamaz.");
                    return;
                }

                string kullaniciMesaj = kullanicilar.Kaydet(
                    txtKullaniciAdi.Text,
                    txtSifre.Text,
                    txtMail.Text,
                    (int)cbYetkiAdi.SelectedValue,
                    txtAciklama.Text,
                    rbKullaniciEvet.Checked == true ? true : false
                    );
                BilgileriListesi();
                Bilgiler();
                Temizle();
                MessageBox.Show(kullaniciMesaj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında bir hata oluştu.\nHATA: " + ex);
            }
        }

        private void btGuncelleKullanici_Click(object sender, EventArgs e)
        {
            string[] ZorunluTextler = new string[]
                {
                    txtKullaniciAdi.Text,
                    txtSifre.Text,
                    txtMail.Text,
                    cbYetkiAdi.Text
                };
            if (ZorunluAlanlar(ZorunluTextler) == true)
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz.");
                return;
            }

            string kullaniciMesaj = kullanicilar.Guncelle(
                kullaniciID,
                txtKullaniciAdi.Text,
                txtSifre.Text,
                txtMail.Text,
                (int)cbYetkiAdi.SelectedValue,
                txtAciklama.Text,
                rbKullaniciEvet.Checked == true ? true : false

                );
            BilgileriListesi();
            Bilgiler();
            Temizle();
            MessageBox.Show(kullaniciMesaj);
        }

        private void btSilKullanici_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult silOnay = new DialogResult();
                silOnay = MessageBox.Show("Bu Öğeyi Silmek İstiyor musunuz?", "----ALERT----", MessageBoxButtons.OKCancel);
                if (silOnay == DialogResult.OK)
                {
                    string mesaj = kullanicilar.Sil(kullaniciID);
                    MessageBox.Show(mesaj);
                }
                BilgileriListesi();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında bir hata oluştu.\nHATA: " + ex);
            }
        }

        private void dgvKullanicilar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                var yetkiText= dgvKullanicilar.Rows[e.RowIndex].Cells["YetkiAdi"].Value.ToString();
                var yetkiObje=repoYetki.BulQuery(y=>y.YetkiAdi==yetkiText).FirstOrDefault();
                int secilenYetki = yetkiObje.ID;

                kullaniciID = (int)dgvKullanicilar.Rows[e.RowIndex].Cells["ID"].Value;
                txtKullaniciAdi.Text = dgvKullanicilar.Rows[e.RowIndex].Cells["KullaniciAdi"].Value.ToString();
                txtSifre.Text = dgvKullanicilar.Rows[e.RowIndex].Cells["KullaniciSifre"].Value.ToString();
                txtMail.Text = dgvKullanicilar.Rows[e.RowIndex].Cells["KullaniciEmail"].Value.ToString();
                cbYetkiAdi.SelectedValue = secilenYetki;
                txtAciklama.Text = dgvKullanicilar.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();
                bool aktifMi = (bool)dgvKullanicilar.Rows[e.RowIndex].Cells["AktifMi"].Value;
                if (aktifMi == true)
                {
                    rbKullaniciEvet.Checked = true;
                }
                else
                {
                    rbKullaniciHayir.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu. \nHATA: " + ex.Message);
            }
        }
        #endregion

        #region Yetkiler
        private void btnKaydetYetki_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ZorunluTextler = new string[]
                {
                    txtYetkiAdi.Text,
                };
                if (ZorunluAlanlar(ZorunluTextler) == true)
                {
                    MessageBox.Show("Alanlar Boş Bırakılamaz.");
                    return;
                }

                string yetkiMesaj = yetkiler.Kaydet(
                    txtYetkiAdi.Text,
                    rbYetkiEvet.Checked == true ? true : false,
                    txtYetkiAciklama.Text
                    );
                BilgileriListesi();
                Bilgiler();
                Temizle();
                MessageBox.Show(yetkiMesaj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında bir hata oluştu.\nHATA: " + ex);
            }
        }

        private void btnGuncYetki_Click(object sender, EventArgs e)
        {
            string[] ZorunluTextler = new string[]
                {
                    txtYetkiAdi.Text,
                };
            if (ZorunluAlanlar(ZorunluTextler) == true)
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz.");
                return;
            }

            string yetkiMesaj = yetkiler.Guncelle(
                yetkiID,
                txtYetkiAdi.Text,
                rbYetkiEvet.Checked == true ? true : false,
                txtYetkiAciklama.Text
                );
            BilgileriListesi();
            Bilgiler();
            Temizle();
            MessageBox.Show(yetkiMesaj);
        }

        private void btnSilYetki_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult silOnay = new DialogResult();
                silOnay = MessageBox.Show("Bu Öğeyi Silmek İstiyor musunuz?", "----ALERT----", MessageBoxButtons.OKCancel);
                if (silOnay == DialogResult.OK)
                {
                    string mesaj = yetkiler.Sil(yetkiID);
                    MessageBox.Show(mesaj);
                }
                BilgileriListesi();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında bir hata oluştu.\nHATA: " + ex);
            }
        }

        private void dgvYetkiler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                yetkiID = (int)dgvYetkiler.Rows[e.RowIndex].Cells["ID"].Value;
                txtYetkiAdi.Text = dgvYetkiler.Rows[e.RowIndex].Cells["YetkiAdi"].Value.ToString();
                txtYetkiAciklama.Text = dgvYetkiler.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();
                bool aktifMi = (bool)dgvYetkiler.Rows[e.RowIndex].Cells["AktifMi"].Value;
                if (aktifMi == true)
                {
                    rbYetkiEvet.Checked = true;
                }
                else
                {
                    rbYetkiHayir.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu. \nHATA: " + ex.Message);
            }
        }
        #endregion

        #region Notlar
        private void btnKaydetNot_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ZorunluTextler = new string[]
                {
                    cbKullaniciID.Text,
                    dtpNotTarihi.Text,
                    txtNotIcerigi.Text,
                };
                if (ZorunluAlanlar(ZorunluTextler) == true)
                {
                    MessageBox.Show("Alanlar Boş Bırakılamaz.");
                    return;
                }

                string notMesaj = notlar.Kaydet(
                    (int)cbKullaniciID.SelectedValue,
                    Convert.ToDateTime(dtpNotTarihi.Text),
                    txtNotIcerigi.Text,
                    rbNotEvet.Checked == true ? true : false
                    );
                BilgileriListesi();
                Bilgiler();
                Temizle();
                MessageBox.Show(notMesaj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında bir hata oluştu.\nHATA: " + ex);
            }
        }

        private void btnGuncNot_Click(object sender, EventArgs e)
        {
            string[] ZorunluTextler = new string[]
                {
                    cbKullaniciID.Text,
                    dtpNotTarihi.Text,
                    txtNotIcerigi.Text,
                };
            if (ZorunluAlanlar(ZorunluTextler) == true)
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz.");
                return;
            }

            string notMesaj = notlar.Guncelle(
                notID,
                (int)cbKullaniciID.SelectedValue,
                Convert.ToDateTime(dtpNotTarihi.Text),
                txtNotIcerigi.Text,
                rbNotEvet.Checked == true ? true : false
                );
            BilgileriListesi();
            Bilgiler();
            Temizle();
            MessageBox.Show(notMesaj);
        }

        private void btnSilNot_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult silOnay = new DialogResult();
                silOnay = MessageBox.Show("Bu Öğeyi Silmek İstiyor musunuz?", "----ALERT----", MessageBoxButtons.OKCancel);
                if (silOnay == DialogResult.OK)
                {
                    string mesaj = notlar.Sil(notID);
                    MessageBox.Show(mesaj);
                }
                BilgileriListesi();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında bir hata oluştu.\nHATA: " + ex);
            }
        }

        private void dgvNotlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                var kullaniciText = dgvNotlar.Rows[e.RowIndex].Cells["KullaniciAdi"].Value.ToString();
                var kullaniciObje = repoKullanici.BulQuery(k => k.KullaniciAdi == kullaniciText).FirstOrDefault();
                int secilenKullanici = kullaniciObje.ID;


                notID = (int)dgvNotlar.Rows[e.RowIndex].Cells["ID"].Value;
                cbKullaniciID.SelectedValue = secilenKullanici;
                dtpNotTarihi.Text = dgvNotlar.Rows[e.RowIndex].Cells["NotTarihi"].Value.ToString();
                txtNotIcerigi.Text = dgvNotlar.Rows[e.RowIndex].Cells["NotIcerigi"].Value.ToString();
                bool aktifMi = (bool)dgvNotlar.Rows[e.RowIndex].Cells["AktifMi"].Value;
                if (aktifMi == true)
                {
                    rbNotEvet.Checked = true;
                }
                else
                {
                    rbNotHayir.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu. \nHATA: " + ex.Message);
            }
        }
        #endregion

        private void dgvKullanicilar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvKullanicilar.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToBoolean(dgvKullanicilar.Rows[i].Cells["AktifMi"].Value) == false)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                dgvKullanicilar.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void dgvYetkiler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvYetkiler.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToBoolean(dgvYetkiler.Rows[i].Cells["AktifMi"].Value) == false)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                dgvYetkiler.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void dgvNotlar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvNotlar.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToBoolean(dgvNotlar.Rows[i].Cells["AktifMi"].Value) == false)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                dgvNotlar.Rows[i].DefaultCellStyle = renk;
            }
        }
    }
}
