using HaliStokTakipBLL.Interface;
using HaliStokTakipBLL.Manager;
using HaliStokTakipDLL.RepositoryFolder;
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
    public partial class FormKargoTakip : Form
    {
        public FormKargoTakip()
        {
            InitializeComponent();
            HaliStokTakipDBEntities db = new HaliStokTakipDBEntities();
            this.repoSiparis = new Repository<Siparisler>(db);
        }
        Repository<Siparisler> repoSiparis;


        SiparislerManager siparisler = new SiparislerManager();
        KargolarManager kargolar = new KargolarManager();
        int kargoId;

        private void FormKargoTakip_Load(object sender, EventArgs e)
        {
            KargoListesi();
            Temizle();
            KargoBilgileri();
        }
        private void KargoBilgileri()
        {
            cbSiparisAdi.ValueMember = "ID";
            cbSiparisAdi.DisplayMember = "SiparisAdi";
            cbSiparisAdi.DataSource = siparisler.SiparisleriListele();
            cbSiparisAdi.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSiparisAdi.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSiparisAdi.SelectedIndex = -1;
        }
        private void Temizle()
        {
            kargoId = 0;
            cbSiparisAdi.SelectedIndex = -1;
            txtFirmaAdi.Text = string.Empty;
            mskdTakipKodu.Text = string.Empty;
            dtpTahTeslimTarihi.Text = string.Empty;
            dtpTeslimTarihi.Text = string.Empty;
            txtAciklama.Text = string.Empty;
            rbEvet.Checked = false;
            rbHayir.Checked = false;
        }
        private void KargoListesi()
        {
            dgvKargolar.DataSource = kargolar.KargolariListele();
            dgvKargolar.Columns["ID"].Width= 30;
            dgvKargolar.Columns["SiparisAdi"].Width= 60;
            dgvKargolar.Columns["FirmaAdi"].Width= 60;
            dgvKargolar.Columns["TakipKodu"].Width= 75;
            dgvKargolar.Columns["TahminiTeslimTarihi"].Width= 105;
            dgvKargolar.Columns["AktifMi"].Width= 44;
            dgvKargolar.Columns["Aciklama"].Width= 87;

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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ZorunluTextler = new string[]
                {
                    cbSiparisAdi.Text,
                    txtFirmaAdi.Text,
                    mskdTakipKodu.Text,
                    dtpTahTeslimTarihi.Text
                };
                if (ZorunluAlanlar(ZorunluTextler) == true)
                {
                    MessageBox.Show("Alanlar Boş Bırakılamaz.");
                    return;
                }

                string mesaj = kargolar.Kaydet(
                    (int)cbSiparisAdi.SelectedValue,
                    txtFirmaAdi.Text,
                    mskdTakipKodu.Text,
                    Convert.ToDateTime(dtpTahTeslimTarihi.Text),
                    Convert.ToDateTime(dtpTeslimTarihi.Text),
                    rbEvet.Checked == true ? true : false,
                    txtAciklama.Text
                    );
                KargoListesi();
                Temizle();
                KargoBilgileri();
                MessageBox.Show(mesaj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında bir hata oluştu.\nHATA: " + ex);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string[] ZorunluTextler = new string[]
                {
                    cbSiparisAdi.Text,
                    txtFirmaAdi.Text,
                    mskdTakipKodu.Text,
                    dtpTahTeslimTarihi.Text
                };
            if (ZorunluAlanlar(ZorunluTextler) == true)
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz.");
                return;
            }
            

            string mesaj = kargolar.Guncelle(
                kargoId,
                (int)cbSiparisAdi.SelectedValue,
                txtFirmaAdi.Text,
                mskdTakipKodu.Text,
                Convert.ToDateTime(dtpTahTeslimTarihi.Text),
                Convert.ToDateTime(dtpTeslimTarihi.Text),
                rbEvet.Checked == true ? true : false,
                txtAciklama.Text
                );
            KargoListesi();
            Temizle();
            KargoBilgileri();
            MessageBox.Show(mesaj);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult silOnay = new DialogResult();
                silOnay = MessageBox.Show("Bu Öğeyi Silmek İstiyor musunuz?", "----ALERT----", MessageBoxButtons.OKCancel);
                if (silOnay == DialogResult.OK)
                {
                    string mesaj = kargolar.Sil(kargoId);
                    MessageBox.Show(mesaj);
                }
                KargoListesi();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında bir hata oluştu.\nHATA: " + ex);
            }
        }



        private void dgvKargolar_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                var siparisTxt = dgvKargolar.Rows[e.RowIndex].Cells["SiparisAdi"].Value.ToString();
                var siparisObj = repoSiparis.BulQuery(s => s.SiparisAdi == siparisTxt).FirstOrDefault();
                int secilenSiparis = siparisObj.ID;

                kargoId = (int)dgvKargolar.Rows[e.RowIndex].Cells["ID"].Value;
                cbSiparisAdi.SelectedValue = secilenSiparis;
                txtFirmaAdi.Text = dgvKargolar.Rows[e.RowIndex].Cells["FirmaAdi"].Value.ToString();
                mskdTakipKodu.Text = dgvKargolar.Rows[e.RowIndex].Cells["TakipKodu"].Value.ToString();
                dtpTahTeslimTarihi.Text = dgvKargolar.Rows[e.RowIndex].Cells["TahminiTeslimTarihi"].Value.ToString();
                dtpTeslimTarihi.Text = dgvKargolar.Rows[e.RowIndex].Cells["TeslimTarihi"].Value.ToString();
                txtAciklama.Text = dgvKargolar.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();

                bool aktifMi = (bool)dgvKargolar.Rows[e.RowIndex].Cells["AktifMi"].Value;
                if (aktifMi == true)
                {
                    rbEvet.Checked = true;
                }
                else
                {
                    rbHayir.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu. \nHATA: " + ex.Message);
            }
        }

        private void dgvKargolar_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvKargolar.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToBoolean(dgvKargolar.Rows[i].Cells["AktifMi"].Value) == false)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                dgvKargolar.Rows[i].DefaultCellStyle = renk;
            }
        }

    }
}
