using HaliStokTakipBLL.Manager;
using HaliStokTakipDLL;
using HaliStokTakipDLL.RepositoryFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaliStokTakipUI
{
    public partial class FormIadeler : Form
    {
        public FormIadeler()
        {
            InitializeComponent();
            HaliStokTakipDBEntities db = new HaliStokTakipDBEntities();
            this.repoSiparis = new Repository<Siparisler>(db);
        }
        Repository<Siparisler> repoSiparis;


        SiparislerManager siparisler = new SiparislerManager();
        IadeManager iadeler = new IadeManager();
        int iadeId;

        private void FormIadeler_Load(object sender, EventArgs e)
        {
            IadelerListesi();
            Temizle();
            IadeBilgileri();
        }

        private void IadeBilgileri()
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
            iadeId = 0;
            cbSiparisAdi.SelectedIndex = -1;
            dtpIadeTarihi.Text = string.Empty;
            txtıadeNedeni.Text = string.Empty;
            rbEvet.Checked = false;
            rbHayir.Checked = false;
        }
        private void IadelerListesi()
        {
            dgvIadeler.DataSource = iadeler.IadeleriListele();
            dgvIadeler.Columns["IadeOnayDurumu"].Width= 100;
            dgvIadeler.Columns["IadeNedeni"].Width= 110;
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
                    dtpIadeTarihi.Text,
                    txtıadeNedeni.Text,
                };
                if (ZorunluAlanlar(ZorunluTextler) == true)
                {
                    MessageBox.Show("Alanlar Boş Bırakılamaz.");
                    return;
                }

                string mesaj = iadeler.Kaydet(
                    (int)cbSiparisAdi.SelectedValue,
                    Convert.ToDateTime(dtpIadeTarihi.Text),
                    txtıadeNedeni.Text,
                    rbEvet.Checked == true ? true : false
                    );
                IadelerListesi();
                Temizle();
                IadeBilgileri();
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
                    dtpIadeTarihi.Text,
                    txtıadeNedeni.Text,
                };
            if (ZorunluAlanlar(ZorunluTextler) == true)
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz.");
                return;
            }

            string mesaj = iadeler.Guncelle(
                iadeId,
                (int)cbSiparisAdi.SelectedValue,
                Convert.ToDateTime(dtpIadeTarihi.Text),
                txtıadeNedeni.Text,
                rbEvet.Checked == true ? true : false
                );
            IadelerListesi();
            Temizle();
            IadeBilgileri();
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
                    string mesaj = iadeler.Sil(iadeId);
                    MessageBox.Show(mesaj);
                }
                IadelerListesi();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında bir hata oluştu.\nHATA: " + ex);
            }
        }

       

        private void dgvIadeler_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvIadeler.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToBoolean(dgvIadeler.Rows[i].Cells["IadeOnayDurumu"].Value) == false)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                dgvIadeler.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void dgvIadeler_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                var siparisTxt = dgvIadeler.Rows[e.RowIndex].Cells["SiparisAdi"].Value.ToString();
                var siparisObj = repoSiparis.BulQuery(s => s.SiparisAdi == siparisTxt).FirstOrDefault();
                int secilenSiparis = siparisObj.ID;

                iadeId = (int)dgvIadeler.Rows[e.RowIndex].Cells["ID"].Value;
                cbSiparisAdi.SelectedValue = secilenSiparis;
                dtpIadeTarihi.Text = dgvIadeler.Rows[e.RowIndex].Cells["IadeTarihi"].Value.ToString();
                txtıadeNedeni.Text = dgvIadeler.Rows[e.RowIndex].Cells["IadeNedeni"].Value.ToString();

                bool aktifMi = (bool)dgvIadeler.Rows[e.RowIndex].Cells["IadeOnayDurumu"].Value;
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
    }
}
