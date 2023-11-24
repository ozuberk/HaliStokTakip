using HaliStokTakipBLL.Interface;
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
    public partial class FormSiparisOdemeleri : Form
    {
        public FormSiparisOdemeleri()
        {
            InitializeComponent();
            HaliStokTakipDBEntities db =new HaliStokTakipDBEntities();
            this.repoSiparis = new Repository<Siparisler>(db);
        }
        Repository<Siparisler> repoSiparis;
        SiparislerManager siparisler = new SiparislerManager();
        OdemelerManager odemeler = new OdemelerManager();
        int odemeId;

        private void FormSiparisOdemeleri_Load(object sender, EventArgs e)
        {
            OdemeListesi();
            Temizle();
            OdemeBilgileri();
        }
        private void OdemeBilgileri()
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
            odemeId = 0;
            cbSiparisAdi.SelectedIndex = -1;
            dtpOdemeTarihi.Text = string.Empty;
            txtOdemeYontemi.Text = string.Empty;
            rbEvet.Checked = false;
            rbHayir.Checked = false;
        }
        private void OdemeListesi()
        {
            dgvOdemeler.DataSource = odemeler.OdemeleriListele();
            dgvOdemeler.Columns["AktifMi"].Width = 58;
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ZorunluTextler = new string[]
                {
                    cbSiparisAdi.Text,
                    dtpOdemeTarihi.Text,
                    txtOdemeYontemi.Text,
                };
                if (ZorunluAlanlar(ZorunluTextler) == true)
                {
                    MessageBox.Show("Alanlar Boş Bırakılamaz.");
                    return;
                }

                string mesaj = odemeler.Kaydet(
                    (int)cbSiparisAdi.SelectedValue,
                    Convert.ToDateTime(dtpOdemeTarihi.Text),
                    txtOdemeYontemi.Text,
                    rbEvet.Checked == true ? true : false
                    );
                OdemeListesi();
                Temizle();
                OdemeBilgileri();
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
                    dtpOdemeTarihi.Text,
                    txtOdemeYontemi.Text,
                };
            if (ZorunluAlanlar(ZorunluTextler) == true)
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz.");
                return;
            }

            string mesaj = odemeler.Guncelle(
                odemeId,
                (int)cbSiparisAdi.SelectedValue,
                Convert.ToDateTime(dtpOdemeTarihi.Text),
                txtOdemeYontemi.Text,
                rbEvet.Checked == true ? true : false
                );
            OdemeListesi();
            Temizle();
            OdemeBilgileri();
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
                    string mesaj = odemeler.Sil(odemeId);
                    MessageBox.Show(mesaj);
                }
                OdemeListesi();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında bir hata oluştu.\nHATA: " + ex);
            }
        }


        private void dgvOdemeler_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                var siparisTxt = dgvOdemeler.Rows[e.RowIndex].Cells["SiparisAdi"].Value.ToString();
                var siparisObj = repoSiparis.BulQuery(s => s.SiparisAdi == siparisTxt).FirstOrDefault();
                int secilenSiparis = siparisObj.ID;

                odemeId = (int)dgvOdemeler.Rows[e.RowIndex].Cells["ID"].Value;
                cbSiparisAdi.SelectedValue = secilenSiparis;
                dtpOdemeTarihi.Text = dgvOdemeler.Rows[e.RowIndex].Cells["OdemeTarihi"].Value.ToString();
                txtOdemeYontemi.Text = dgvOdemeler.Rows[e.RowIndex].Cells["OdemeYontemi"].Value.ToString();

                bool aktifMi = (bool)dgvOdemeler.Rows[e.RowIndex].Cells["AktifMi"].Value;
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

        private void dgvOdemeler_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvOdemeler.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToBoolean(dgvOdemeler.Rows[i].Cells["AktifMi"].Value) == false)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                dgvOdemeler.Rows[i].DefaultCellStyle = renk;
            }
        }
    }
}
