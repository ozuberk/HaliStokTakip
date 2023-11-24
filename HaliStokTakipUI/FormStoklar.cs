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
    public partial class FormStoklar : Form
    {
        public FormStoklar()
        {
            InitializeComponent();
            this.repoHali = new Repository<Halilar>(db);
        }
        HaliStokTakipDBEntities db = new HaliStokTakipDBEntities();
        Repository<Halilar> repoHali;
        StokManager stoklar = new StokManager();
        HalilarManager halilar = new HalilarManager();
        int stoklarID;

        private void FormStoklar_Load(object sender, EventArgs e)
        {
            StoklarListesi();
            StokBilgileri();
            Temizle();

        }
        private void Temizle()
        {
            txtStokAdi.Text = string.Empty;
            cbHaliAdi.SelectedValue = -1;
            mskdStokMik.Text = string.Empty;
            txtAciklama.Text = string.Empty;
            rbEvet.Checked = false;
            rbHayir.Checked = false;
        }
        private void StoklarListesi()
        {
            dgvStoklar.DataSource = stoklar.StoklariListele();
            dgvStoklar.Columns["ID"].Width = 40;
            dgvStoklar.Columns["StokAdi"].Width = 120;
        }
        private void StokBilgileri()
        {

            cbHaliAdi.ValueMember = "ID";
            cbHaliAdi.DisplayMember = "HaliAdi";
            cbHaliAdi.DataSource = halilar.HalilariListele();
            cbHaliAdi.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbHaliAdi.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbHaliAdi.SelectedIndex = -1;
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
                {txtStokAdi.Text,
            cbHaliAdi.Text,
            mskdStokMik.Text,
                };
                if (ZorunluAlanlar(ZorunluTextler) == true)
                {
                    MessageBox.Show("Açıklama Dışındaki Alanlar Boş Bırakılamaz.");
                    return;
                }


                string mesaj = stoklar.Kaydet
                    (txtStokAdi.Text,
                    (int)cbHaliAdi.SelectedValue,
                    rbEvet.Checked == true ? true : false,
                    Convert.ToInt32(mskdStokMik.Text),
                    txtAciklama.Text
                    );

                StoklarListesi();
                StokBilgileri();
                Temizle();
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
                {txtStokAdi.Text,
            cbHaliAdi.Text,
            mskdStokMik.Text,
                };
            if (ZorunluAlanlar(ZorunluTextler) == true)
            {
                MessageBox.Show("Açıklama Dışındaki Alanlar Boş Bırakılamaz.");
                return;
            }


            string mesaj = stoklar.Guncelle
                (stoklarID,
                txtStokAdi.Text,
                (int)cbHaliAdi.SelectedValue,
                rbEvet.Checked == true ? true : false,
                Convert.ToInt32(mskdStokMik.Text),
                txtAciklama.Text
                );

            StoklarListesi();
            StokBilgileri();
            Temizle();
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
                    string mesaj = stoklar.Sil(stoklarID);
                    MessageBox.Show(mesaj);
                }
                StoklarListesi();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında bir hata oluştu.\nHATA: " + ex);
            }
        }


        private void dgvStoklar_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                var haliTxt = dgvStoklar.Rows[e.RowIndex].Cells["HaliAdi"].Value.ToString();
                var haliObj = repoHali.BulQuery(h => h.HaliAdi == haliTxt).FirstOrDefault();
                int secilenKullanici = haliObj.ID;



                stoklarID = (int)dgvStoklar.Rows[e.RowIndex].Cells["ID"].Value;
                cbHaliAdi.SelectedValue = secilenKullanici;

                txtStokAdi.Text = dgvStoklar.Rows[e.RowIndex].Cells["StokAdi"].Value.ToString();
                mskdStokMik.Text = dgvStoklar.Rows[e.RowIndex].Cells["StokMiktari"].Value.ToString();
                txtAciklama.Text = dgvStoklar.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();

                bool aktifMi = (bool)dgvStoklar.Rows[e.RowIndex].Cells["AktifMi"].Value;
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

        private void dgvStoklar_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvStoklar.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToBoolean(dgvStoklar.Rows[i].Cells["AktifMi"].Value) == false)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                dgvStoklar.Rows[i].DefaultCellStyle = renk;
            }
        }
    }
}
