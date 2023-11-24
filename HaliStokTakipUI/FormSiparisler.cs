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
    public partial class FormSiparisler : Form
    {
        HaliStokTakipDBEntities db;

        public FormSiparisler()
        {
            InitializeComponent();
            HaliStokTakipDBEntities db = new HaliStokTakipDBEntities();
            this.repoSiparis = new Repository<Siparisler>(db);
            this.repoHali = new Repository<Halilar>(db);
            this.repoMusteri = new Repository<Musteriler>(db);

        }
        Repository<Siparisler> repoSiparis;
        Repository<Halilar> repoHali;
        Repository<Musteriler> repoMusteri;

        SiparisDetayManager siparisDetaylari = new SiparisDetayManager();
        SiparislerManager siparisler = new SiparislerManager();
        MusteriManager musteriler = new MusteriManager();
        HalilarManager halilar = new HalilarManager();
        int siparisId;
        int haliId;
        decimal tutar = 0;


        private void FormSiparisler_Load(object sender, EventArgs e)
        {
            TemizleSiparis();
            SiparisListesi();
            SiparisBilgileri();
        }
        private void TemizleSiparis()
        {
            siparisId = 0;
            haliId = 0;
            tutar = 0;
            txtSiparisAdi.Text = string.Empty;
            cbSiparisMusteriAdi.SelectedIndex = -1;
            mskdSiparisTotal.Text = string.Empty;
            dtpSiparisTarihi.Text = string.Empty;
            dtpTeslimatTarihi.Text = string.Empty;
            rbSiparisEvet.Checked = false;
            rbSiparisHayir.Checked = false;
            txtAciklama.Text = string.Empty;
            chbHalilar.Items.Clear();
        }
        private void SiparisBilgileri()
        {
            cbSiparisMusteriAdi.ValueMember = "ID";
            cbSiparisMusteriAdi.DisplayMember = "Adi";
            cbSiparisMusteriAdi.DataSource = musteriler.MusteriListele();
            cbSiparisMusteriAdi.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSiparisMusteriAdi.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSiparisMusteriAdi.SelectedIndex = -1;

            var haliListesi = halilar.HalilariListele();
            foreach (var item in haliListesi)
            {
                chbHalilar.Items.Add(item.HaliAdi);
            }
        }
        private void SiparisListesi()
        {
            dgvSiparisler.DataSource = siparisler.SiparisleriListele();
            dgvSiparisler.Columns["ID"].Width = 50;
            dgvSiparisler.Columns["SiparisAdi"].Width = 110;
            dgvSiparisler.Columns["Adi"].Width = 110;
            dgvSiparisler.Columns["HaliAdi"].Width = 112;

        }
        private bool ZorunluAlanlar(string[] Metinler)
        {
            bool sonuc = true;
            foreach (var item in Metinler)
            {
                if (!string.IsNullOrWhiteSpace(item))
                {
                    sonuc = false;
                }
                else
                {
                    sonuc = true;
                    return sonuc;
                }
            }
            return sonuc;
        }



        private void toolSiparisKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ZorunluTextler = new string[]
                {txtSiparisAdi.Text,
                cbSiparisMusteriAdi.Text,
                dtpSiparisTarihi.Text,
                mskdSiparisTotal.Text
                };
                if (ZorunluAlanlar(ZorunluTextler) == true)
                {
                    MessageBox.Show("Alanlar Boş Bırakılamaz.");
                    return;
                }

                //Sipariş Detay için Kaydetme İşlemi

                string secilenHalilarListesi = string.Empty;
                foreach (var item in chbHalilar.CheckedItems)
                {
                    secilenHalilarListesi += item.ToString() + ",";
                }
                if (!string.IsNullOrEmpty(secilenHalilarListesi))
                {
                    //siparis detay kısmının halilar chckbox kontrolü  yukarda verilmiştir.

                    string mesaj = siparisler.Kaydet
                    (txtSiparisAdi.Text,
                    (int)cbSiparisMusteriAdi.SelectedValue,
                    Convert.ToDateTime(dtpSiparisTarihi.Text),
                    Convert.ToDateTime(dtpTeslimatTarihi.Text),
                    rbSiparisEvet.Checked == true ? true : false,
                    Convert.ToDecimal(mskdSiparisTotal.Text)
                    );

                    //siparis detay kısmı kaydetmek için devamı.

                    var secilenHalilar = secilenHalilarListesi
                        .Remove(secilenHalilarListesi.Length - 1, 1)
                        .Split(',');
                    foreach (var secilenHali in secilenHalilar)
                    {
                        var siparisObje = repoSiparis.BulQuery(s => s.SiparisAdi == txtSiparisAdi.Text).FirstOrDefault();
                        siparisId = siparisObje.ID;

                        var haliObje = repoHali.BulQuery(h => h.HaliAdi == secilenHali).FirstOrDefault();
                        haliId = haliObje.ID;
                        siparisDetaylari.Kaydet(
                            siparisId,
                            haliId,
                            txtAciklama.Text,
                            rbSiparisEvet.Checked == true ? true : false
                            );
                    }
                    TemizleSiparis();
                    SiparisListesi();
                    SiparisBilgileri();
                    MessageBox.Show(mesaj);
                }
                else
                {
                    MessageBox.Show("Sipariş Oluşturmak için Halı Seçin.");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında bir hata oluştu.\nHATA: " + ex);
            }
        }

        private void toolSiparisGuncelle_Click(object sender, EventArgs e)
        {
            string[] ZorunluTextler = new string[]
                {txtSiparisAdi.Text,
                cbSiparisMusteriAdi.Text,
                dtpSiparisTarihi.Text,
                mskdSiparisTotal.Text
                };
            if (ZorunluAlanlar(ZorunluTextler) == true)
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz.");
                return;
            }

            //Sipariş Detay için Kaydetme İşlemi

            string secilenHalilarListesi = string.Empty;
            foreach (var item in chbHalilar.CheckedItems)
            {
                secilenHalilarListesi += item.ToString() + ",";
            }
            if (!string.IsNullOrEmpty(secilenHalilarListesi))
            {
                //siparis detay kısmının halilar chckbox kontrolü  yukarda verilmiştir.

                string mesaj = siparisler.Guncelle
                (siparisId,
                txtSiparisAdi.Text,
                (int)cbSiparisMusteriAdi.SelectedValue,
                Convert.ToDateTime(dtpSiparisTarihi.Text),
                Convert.ToDateTime(dtpTeslimatTarihi.Text),
                rbSiparisEvet.Checked == true ? true : false,
                Convert.ToDecimal(mskdSiparisTotal.Text)
                );

                //siparis detay kısmı kaydetmek için devamı.

                var secilenHalilar = secilenHalilarListesi
                    .Remove(secilenHalilarListesi.Length - 1, 1)
                    .Split(',');
                foreach (var secilenHali in secilenHalilar)
                {
                    var haliObje = repoHali.BulQuery(h => h.HaliAdi == secilenHali).FirstOrDefault();
                    haliId = haliObje.ID;
                    siparisDetaylari.Kaydet(
                        siparisId,
                        haliId,
                        txtAciklama.Text,
                        rbSiparisEvet.Checked == true ? true : false
                        );
                }
                TemizleSiparis();
                SiparisListesi();
                SiparisBilgileri();
                MessageBox.Show(mesaj);
            }
            else
            {
                MessageBox.Show("Sipariş Oluşturmak için Halı Seçin.");
                return;
            }
        }

        private void toolSiparisSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult silOnay = new DialogResult();
                silOnay = MessageBox.Show("Bu Öğeyi Silmek İstiyor musunuz?", "----ALERT----", MessageBoxButtons.OKCancel);
                if (silOnay == DialogResult.OK)
                {

                    string secilenHalilarListesi = string.Empty;
                    foreach (var item in chbHalilar.CheckedItems)
                    {
                        secilenHalilarListesi += item.ToString() + ",";
                    }
                    if (!string.IsNullOrEmpty(secilenHalilarListesi))
                    {

                        var secilenHalilar = secilenHalilarListesi
                            .Remove(secilenHalilarListesi.Length - 1, 1)
                            .Split(',');
                        foreach (var secilenHali in secilenHalilar)
                        {
                            var haliObje = repoHali.BulQuery(h => h.HaliAdi == secilenHali).FirstOrDefault();
                            haliId = haliObje.ID;
                            siparisDetaylari.Sil(siparisId, haliId);
                        }
                        string mesaj = siparisler.Sil(siparisId);

                        TemizleSiparis();
                        SiparisListesi();
                        SiparisBilgileri();
                        MessageBox.Show(mesaj);
                    }
                    else
                    {
                        MessageBox.Show("Siparişe Kayıtlı Halılar Seçilmeli");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında bir hata oluştu.\nHATA: " + ex);
            }
        }



        private void dgvSiparisler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                var musteriTxt = dgvSiparisler.Rows[e.RowIndex].Cells["Adi"].Value.ToString();
                var musteriObj = repoMusteri.BulQuery(m => m.Adi == musteriTxt).FirstOrDefault();
                int secilenMusteri = musteriObj.ID;


                siparisId = (int)dgvSiparisler.Rows[e.RowIndex].Cells["ID"].Value;
                txtSiparisAdi.Text = dgvSiparisler.Rows[e.RowIndex].Cells["SiparisAdi"].Value.ToString();
                cbSiparisMusteriAdi.SelectedValue = secilenMusteri;
                dtpSiparisTarihi.Text = dgvSiparisler.Rows[e.RowIndex].Cells["SiparisTarihi"].Value.ToString();
                dtpTeslimatTarihi.Text = dgvSiparisler.Rows[e.RowIndex].Cells["TeslimatTarihi"].Value.ToString();
                mskdSiparisTotal.Text = dgvSiparisler.Rows[e.RowIndex].Cells["ToplamTutar"].Value.ToString();
                txtAciklama.Text= dgvSiparisler.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();

              

                var secilmisHali = dgvSiparisler.Rows[e.RowIndex].Cells["HaliAdi"].Value.ToString();
                var secilmisHaliObje=repoHali.BulQuery(h=>h.HaliAdi==secilmisHali).FirstOrDefault();

                for (int i = 0; i < chbHalilar.Items.Count; i++)
                {
                    if (chbHalilar.Items[i].ToString()==secilmisHaliObje.HaliAdi)
                    {
                        chbHalilar.SetItemChecked(i, true);
                    }
                    else
                    {
                        chbHalilar.SetItemChecked(i, false);
                    }
                }
                bool aktifMi = (bool)dgvSiparisler.Rows[e.RowIndex].Cells["SiparisDurumu"].Value;
                if (aktifMi == true)
                {
                    rbSiparisEvet.Checked = true;
                }
                else
                {
                    rbSiparisHayir.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu. \nHATA: " + ex.Message);
            }
        }


        private void btnHaliEkle_Click(object sender, EventArgs e)
        {
            string secilenHalilarListesi = string.Empty;
            foreach (var item in chbHalilar.CheckedItems)
            {
                secilenHalilarListesi += item.ToString() + ",";
            }
            var secilenHalilar = secilenHalilarListesi
                        .Remove(secilenHalilarListesi.Length - 1, 1)
                        .Split(',');
            foreach (var secilenHali in secilenHalilar)
            {

                var haliObje = repoHali.BulQuery(h => h.HaliAdi == secilenHali).FirstOrDefault();
                tutar += haliObje.Fiyat;

            }
            mskdSiparisTotal.Text = tutar.ToString();
        }

        private void chbHalilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            tutar = 0;
        }

        private void dgvSiparisler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvSiparisler.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToBoolean(dgvSiparisler.Rows[i].Cells["SiparisDurumu"].Value) == false)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                dgvSiparisler.Rows[i].DefaultCellStyle = renk;
            }
        }
    }
}
