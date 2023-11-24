using HaliStokTakipBLL.Manager;
using HaliStokTakipDLL;
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
    public partial class FormHaliBilgileri : Form
    {
        public FormHaliBilgileri()
        {
            InitializeComponent();
        }
        KategoriManager kategoriler = new KategoriManager();
        MarkalarManager markalar = new MarkalarManager();
        RenklerManager renkler = new RenklerManager();
        DesenManager desenler = new DesenManager();
        BoyutlarManager boyutlar = new BoyutlarManager();
        int kategorilerID;
        int markalarID;
        int renklerID;
        int desenlerID;
        int boyutlarID;

        private void FormDesenler_Load(object sender, EventArgs e)
        {
            BilgileriListesi();
            Temizle();
        }

        private void Temizle()
        {
            desenlerID = 0;
            txtDesenAdi.Text = string.Empty;
            txtDesenAciklama.Text = string.Empty;
            rbDesenEvet.Checked = false;
            rbDesenHayir.Checked = false;

            boyutlarID = 0;
            txtBoyutAdi.Text = string.Empty;
            mskdBoyutEni.Text = string.Empty;
            mskdBoyutBoyu.Text = string.Empty;
            mskdBoyutAlan.Text = string.Empty;
            rbBoyutEvet.Checked = false;
            rbBoyutHayir.Checked = false;

            renklerID = 0;
            txtRenkAdi.Text = string.Empty;
            txtRenkAciklama.Text = string.Empty;
            rbRenkEvet.Checked = false;
            rbRenkHayir.Checked = false;

            markalarID = 0;
            txtMarkaAdi.Text = string.Empty;
            txtMarkaAciklama.Text = string.Empty;
            rbMarkaEvet.Checked = false;
            rbMarkaHayir.Checked = false;

            kategorilerID = 0;
            txtKtgrAdi.Text = string.Empty;
            txtKtgrAciklama.Text = string.Empty;
            rbKtgrEvet.Checked = false;
            rbKtgrHayir.Checked = false;

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

        private void BilgileriListesi()
        {
            dgvDesenler.DataSource = desenler.DesenleriListele();
            dgvBoyutlar.DataSource = boyutlar.BoyutlariListele();
            dgvKategoriler.DataSource = kategoriler.KategoriListele();
            dgvRenkler.DataSource = renkler.RenkleriListele();
            dgvMarkalar.DataSource = markalar.MarkalariListele();

            dgvDesenler.Columns["Halilar"].Width = -1;
            dgvDesenler.Columns["ID"].Width = 30;
            dgvDesenler.Columns["DesenAdi"].Width = 55;
            dgvDesenler.Columns["AktifMi"].Width = 43;
            dgvDesenler.Columns["Aciklama"].Width = 65;

            dgvKategoriler.Columns["Halilar"].Width = -1;
            dgvKategoriler.Columns["ID"].Width = 30;
            dgvKategoriler.Columns["KategoriAdi"].Width = 55;
            dgvKategoriler.Columns["AktifMi"].Width = 43;
            dgvKategoriler.Columns["Aciklama"].Width = 65;

            dgvRenkler.Columns["Halilar"].Width = -1;
            dgvRenkler.Columns["ID"].Width = 30;
            dgvRenkler.Columns["RenkAdi"].Width = 55;
            dgvRenkler.Columns["AktifMi"].Width = 43;
            dgvRenkler.Columns["Aciklama"].Width = 65;

            dgvMarkalar.Columns["Halilar"].Width = -1;
            dgvMarkalar.Columns["ID"].Width = 30;
            dgvMarkalar.Columns["MarkaAdi"].Width = 55;
            dgvMarkalar.Columns["AktifMi"].Width = 43;
            dgvMarkalar.Columns["Aciklama"].Width = 65;

            dgvBoyutlar.Columns["Halilar"].Width = -1;
            dgvBoyutlar.Columns["ID"].Width = 30;
            dgvBoyutlar.Columns["BoyutAdi"].Width = 50;
            dgvBoyutlar.Columns["Eni"].Width = 30;
            dgvBoyutlar.Columns["Boyu"].Width = 30;
            dgvBoyutlar.Columns["Alani"].Width = 35;
            dgvBoyutlar.Columns["AktifMi"].Width = 43;


        }





        #region Desenler


        private void btKaydetDesen_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ZorunluTextler = new string[]
                {
                    txtDesenAdi.Text,
                    txtDesenAciklama.Text
                };
                if (ZorunluAlanlar(ZorunluTextler) == true)
                {
                    MessageBox.Show("Alanlar Boş Bırakılamaz.");
                    return;
                }

                string desenMesaj = desenler.Kaydet(
                    txtDesenAdi.Text,
                    rbDesenEvet.Checked == true ? true : false,
                    txtDesenAciklama.Text
                    );
                BilgileriListesi();
                Temizle();
                MessageBox.Show(desenMesaj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında bir hata oluştu.\nHATA: " + ex);
            }
        }

        private void btGuncelleDesen_Click(object sender, EventArgs e)
        {
            string[] ZorunluTextler = new string[]
                {
                    txtDesenAdi.Text,
                    txtDesenAciklama.Text
                };
            if (ZorunluAlanlar(ZorunluTextler) == true)
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz.");
                return;
            }
            string desenMesaj = desenler.Guncelle(
                    desenlerID,
                    txtDesenAdi.Text,
                    rbDesenEvet.Checked == true ? true : false,
                    txtDesenAciklama.Text
                    );
            BilgileriListesi();
            Temizle();
            MessageBox.Show(desenMesaj);

        }

        private void btSilDesen_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult silOnay = new DialogResult();
                silOnay = MessageBox.Show("Bu Öğeyi Silmek İstiyor musunuz?", "----ALERT----", MessageBoxButtons.OKCancel);
                if (silOnay == DialogResult.OK)
                {
                    string mesaj = desenler.Sil(desenlerID);
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

        private void dgvDesenler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                desenlerID = (int)dgvDesenler.Rows[e.RowIndex].Cells["ID"].Value;
                txtDesenAdi.Text = dgvDesenler.Rows[e.RowIndex].Cells["DesenAdi"].Value.ToString();
                txtDesenAciklama.Text = dgvDesenler.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();
                bool aktifMi = (bool)dgvDesenler.Rows[e.RowIndex].Cells["AktifMi"].Value;
                if (aktifMi == true)
                {
                    rbDesenEvet.Checked = true;
                }
                else
                {
                    rbDesenHayir.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu. \nHATA: " + ex.Message);
            }
        }


        #endregion

        #region Renkler        

        private void dgvRenkler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                renklerID = (int)dgvRenkler.Rows[e.RowIndex].Cells["ID"].Value;
                txtRenkAdi.Text = dgvRenkler.Rows[e.RowIndex].Cells["RenkAdi"].Value.ToString();
                txtRenkAciklama.Text = dgvRenkler.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();
                bool aktifMi = (bool)dgvRenkler.Rows[e.RowIndex].Cells["AktifMi"].Value;
                if (aktifMi == true)
                {
                    rbRenkEvet.Checked = true;
                }
                else
                {
                    rbRenkHayir.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu. \nHATA: " + ex.Message);
            }
        }

        private void btKaydetRenk_Click(object sender, EventArgs e)
        {

            try
            {
                string[] ZorunluTextler = new string[]
                {
                    txtRenkAdi.Text,
                    txtRenkAciklama.Text
                };
                if (ZorunluAlanlar(ZorunluTextler) == true)
                {
                    MessageBox.Show("Alanlar Boş Bırakılamaz.");
                    return;
                }

                string renkMesaj = renkler.Kaydet(
                    txtRenkAdi.Text,
                    rbRenkEvet.Checked == true ? true : false,
                    txtRenkAciklama.Text
                    );
                BilgileriListesi();
                Temizle();
                MessageBox.Show(renkMesaj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında bir hata oluştu.\nHATA: " + ex);
            }
        }

        private void btGuncelleRenk_Click(object sender, EventArgs e)
        {

            string[] ZorunluTextler = new string[]
                {
                    txtRenkAdi.Text,
                    txtRenkAciklama.Text
                };
            if (ZorunluAlanlar(ZorunluTextler) == true)
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz.");
                return;
            }
            string renkMesaj = renkler.Guncelle(
                    renklerID,
                    txtRenkAdi.Text,
                    rbRenkEvet.Checked == true ? true : false,
                    txtRenkAciklama.Text
                    );
            BilgileriListesi();
            Temizle();
            MessageBox.Show(renkMesaj);

        }

        private void btSilRenk_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult silOnay = new DialogResult();
                silOnay = MessageBox.Show("Bu Öğeyi Silmek İstiyor musunuz?", "----ALERT----", MessageBoxButtons.OKCancel);
                if (silOnay == DialogResult.OK)
                {
                    string mesaj = renkler.Sil(renklerID);
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
        #endregion

        #region Boyutlar

        private void btKaydetBoyut_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ZorunluTextler = new string[]
                {
                    txtBoyutAdi.Text,
                    mskdBoyutEni.Text,
                    mskdBoyutBoyu.Text
                };
                if (ZorunluAlanlar(ZorunluTextler) == true)
                {
                    MessageBox.Show("Alanlar Boş Bırakılamaz.");
                    return;
                }
                int en;
                int boy;
                int alan;
                string boyutMesaj = boyutlar.Kaydet(
                    txtBoyutAdi.Text,
                    en = Convert.ToInt32(mskdBoyutEni.Text),
                    boy = Convert.ToInt32(mskdBoyutBoyu.Text),
                    alan = Convert.ToInt32(mskdBoyutAlan.Text),
                    rbBoyutEvet.Checked == true ? true : false
                    );

                BilgileriListesi();
                Temizle();
                MessageBox.Show(boyutMesaj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında bir hata oluştu.\nHATA: " + ex);
            }
        }

        private void btGuncelleBoyut_Click(object sender, EventArgs e)
        {
            string[] ZorunluTextler = new string[]
                {
                    txtBoyutAdi.Text,
                    mskdBoyutBoyu.Text,
                    mskdBoyutBoyu.Text
                };
            if (ZorunluAlanlar(ZorunluTextler) == true)
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz.");
                return;
            }
            int en;
            int boy;
            int alan;
            string boyutMesaj = boyutlar.Guncelle(
                boyutlarID,
                txtBoyutAdi.Text,
                en = Convert.ToInt32(mskdBoyutEni.Text),
                boy = Convert.ToInt32(mskdBoyutBoyu.Text),
                alan = Convert.ToInt32(mskdBoyutAlan.Text),
                rbBoyutEvet.Checked == true ? true : false
                );

            BilgileriListesi();
            Temizle();
            MessageBox.Show(boyutMesaj);
        }

        private void btSilBoyut_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult silOnay = new DialogResult();
                silOnay = MessageBox.Show("Bu Öğeyi Silmek İstiyor musunuz?", "----ALERT----", MessageBoxButtons.OKCancel);
                if (silOnay == DialogResult.OK)
                {
                    string mesaj = boyutlar.Sil(boyutlarID);
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

        private void dgvBoyutlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                boyutlarID = (int)dgvBoyutlar.Rows[e.RowIndex].Cells["ID"].Value;
                txtBoyutAdi.Text = dgvBoyutlar.Rows[e.RowIndex].Cells["BoyutAdi"].Value.ToString();
                mskdBoyutEni.Text = dgvBoyutlar.Rows[e.RowIndex].Cells["Eni"].Value.ToString();
                mskdBoyutBoyu.Text = dgvBoyutlar.Rows[e.RowIndex].Cells["Boyu"].Value.ToString();
                mskdBoyutAlan.Text = dgvBoyutlar.Rows[e.RowIndex].Cells["Alani"].Value.ToString();
                bool aktifMi = (bool)dgvBoyutlar.Rows[e.RowIndex].Cells["AktifMi"].Value;
                if (aktifMi == true)
                {
                    rbBoyutEvet.Checked = true;
                }
                else
                {
                    rbBoyutHayir.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu. \nHATA: " + ex.Message);
            }
        }


        private void mskdBoyutEni_TextChanged(object sender, EventArgs e)
        {
            AlanHesabi();
        }

        private void mskdBoyutBoyu_TextChanged(object sender, EventArgs e)
        {
            AlanHesabi();

        }
        private void AlanHesabi()
        {
            // İki MaskedTextBox'tan sayıları alın
            int sayi1, sayi2;
            if (int.TryParse(mskdBoyutEni.Text, out sayi1) && int.TryParse(mskdBoyutBoyu.Text, out sayi2))
            {
                // İki sayıyı toplayın
                int alan = sayi1 * sayi2;

                // Sonucu üçüncü MaskedTextBox'ta gösterin
                mskdBoyutAlan.Text = alan.ToString("0000");
            }
            else
            {
                // Eğer geçerli sayılar girilmemişse veya dönüşüm başarısızsa, üçüncü MaskedTextBox'ı temizleyin
                mskdBoyutAlan.Text = string.Empty;
            }
        }


        #endregion

        #region Markalar
        private void btKaydetMarka_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ZorunluTextler = new string[]
                {
                    txtMarkaAdi.Text,
                    txtMarkaAciklama.Text
                };
                if (ZorunluAlanlar(ZorunluTextler) == true)
                {
                    MessageBox.Show("Alanlar Boş Bırakılamaz.");
                    return;
                }

                string markaMesaj = markalar.Kaydet(
                    txtMarkaAdi.Text,
                    rbMarkaEvet.Checked == true ? true : false,
                    txtMarkaAciklama.Text
                    );
                BilgileriListesi();
                Temizle();
                MessageBox.Show(markaMesaj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında bir hata oluştu.\nHATA: " + ex);
            }
        }

        private void btGuncelleMarka_Click(object sender, EventArgs e)
        {


            string[] ZorunluTextler = new string[]
                {
                    txtMarkaAdi.Text,
                    txtMarkaAciklama.Text
                };
            if (ZorunluAlanlar(ZorunluTextler) == true)
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz.");
                return;
            }
            string markaMesaj = markalar.Guncelle(
                    markalarID,
                    txtMarkaAdi.Text,
                    rbMarkaEvet.Checked == true ? true : false,
                    txtMarkaAciklama.Text
                    );
            BilgileriListesi();
            Temizle();
            MessageBox.Show(markaMesaj);

        }

        private void btSilMarka_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult silOnay = new DialogResult();
                silOnay = MessageBox.Show("Bu Öğeyi Silmek İstiyor musunuz?", "----ALERT----", MessageBoxButtons.OKCancel);
                if (silOnay == DialogResult.OK)
                {
                    string mesaj = markalar.Sil(markalarID);
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
        private void dgvMarkalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                markalarID = (int)dgvMarkalar.Rows[e.RowIndex].Cells["ID"].Value;
                txtMarkaAdi.Text = dgvMarkalar.Rows[e.RowIndex].Cells["MarkaAdi"].Value.ToString();
                txtMarkaAciklama.Text = dgvMarkalar.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();
                bool aktifMi = (bool)dgvMarkalar.Rows[e.RowIndex].Cells["AktifMi"].Value;
                if (aktifMi == true)
                {
                    rbMarkaEvet.Checked = true;
                }
                else
                {
                    rbMarkaHayir.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu. \nHATA: " + ex.Message);
            }
        }
        #endregion

        #region Kategoriler
        private void btKaydetKtgr_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ZorunluTextler = new string[]
                {
                    txtKtgrAdi.Text,
                    txtKtgrAciklama.Text
                };
                if (ZorunluAlanlar(ZorunluTextler) == true)
                {
                    MessageBox.Show("Alanlar Boş Bırakılamaz.");
                    return;
                }

                string renkMesaj = kategoriler.Kaydet(
                    txtKtgrAdi.Text,
                    rbKtgrEvet.Checked == true ? true : false,
                    txtKtgrAciklama.Text
                    );
                BilgileriListesi();
                Temizle();
                MessageBox.Show(renkMesaj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında bir hata oluştu.\nHATA: " + ex);
            }
        }

        private void btGuncelleKtgr_Click(object sender, EventArgs e)
        {

            string[] ZorunluTextler = new string[]
                {
                    txtKtgrAdi.Text,
                    txtKtgrAciklama.Text
                };
            if (ZorunluAlanlar(ZorunluTextler) == true)
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz.");
                return;
            }
            string KtgrMesaj = kategoriler.Guncelle(
                    kategorilerID,
                    txtKtgrAdi.Text,
                    rbKtgrEvet.Checked == true ? true : false,
                    txtKtgrAciklama.Text
                    );
            BilgileriListesi();
            Temizle();
            MessageBox.Show(KtgrMesaj);

        }

        private void btSilKtgr_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult silOnay = new DialogResult();
                silOnay = MessageBox.Show("Bu Öğeyi Silmek İstiyor musunuz?", "----ALERT----", MessageBoxButtons.OKCancel);
                if (silOnay == DialogResult.OK)
                {
                    string mesaj = kategoriler.Sil(kategorilerID);
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
        private void dgvKategoriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                kategorilerID = (int)dgvKategoriler.Rows[e.RowIndex].Cells["ID"].Value;
                txtKtgrAdi.Text = dgvKategoriler.Rows[e.RowIndex].Cells["KategoriAdi"].Value.ToString();
                txtKtgrAciklama.Text = dgvKategoriler.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();
                bool aktifMi = (bool)dgvKategoriler.Rows[e.RowIndex].Cells["AktifMi"].Value;
                if (aktifMi == true)
                {
                    rbKtgrEvet.Checked = true;
                }
                else
                {
                    rbKtgrHayir.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu. \nHATA: " + ex.Message);
            }
        }





        #endregion

        private void dgvDesenler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvDesenler.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToBoolean(dgvDesenler.Rows[i].Cells["AktifMi"].Value) == false)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                dgvDesenler.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void dgvBoyutlar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvBoyutlar.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToBoolean(dgvBoyutlar.Rows[i].Cells["AktifMi"].Value) == false)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                dgvBoyutlar.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void dgvRenkler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvRenkler.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToBoolean(dgvRenkler.Rows[i].Cells["AktifMi"].Value) == false)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                dgvRenkler.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void dgvMarkalar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvMarkalar.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToBoolean(dgvMarkalar.Rows[i].Cells["AktifMi"].Value) == false)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                dgvMarkalar.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void dgvKategoriler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvKategoriler.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToBoolean(dgvKategoriler.Rows[i].Cells["AktifMi"].Value) == false)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                dgvKategoriler.Rows[i].DefaultCellStyle = renk;
            }
        }
    }
}
