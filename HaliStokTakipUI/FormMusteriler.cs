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
    public partial class FormMusteriler : Form
    {
        public FormMusteriler()
        {
            InitializeComponent();
        }
        MusteriManager musteriler=new MusteriManager();
        int musterilerID;
        private void FormMusteriler_Load(object sender, EventArgs e)
        {
            MusteriListesi();
            Temizle();
        }
        private void Temizle()
        {
            txtMusteriAdi.Text= string.Empty;
            txtAdres.Text= string.Empty;
            mskdTelefon.Text= string.Empty;
            txtEMail.Text= string.Empty;
            mskdVergiNo.Text= string.Empty;
            txtAciklama.Text= string.Empty;
            rbEvet.Checked = false;
            rbHayir.Checked = false;
        }
        private void MusteriListesi()
        {
            dgvMüsteriler.DataSource = musteriler.MusteriListele();
            dgvMüsteriler.Columns["Siparisler"].Width = -1;
            dgvMüsteriler.Columns["Email"].Width = 165;
            dgvMüsteriler.Columns["Adi"].Width = 110;
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

        private void dgvMüsteriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                musterilerID = (int)dgvMüsteriler.Rows[e.RowIndex].Cells["ID"].Value;

                
                txtMusteriAdi.Text = dgvMüsteriler.Rows[e.RowIndex].Cells["Adi"].Value.ToString();
                txtAdres.Text = dgvMüsteriler.Rows[e.RowIndex].Cells["Adresi"].Value.ToString();
                mskdTelefon.Text = dgvMüsteriler.Rows[e.RowIndex].Cells["Telefon"].Value.ToString();
                txtEMail.Text = dgvMüsteriler.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                mskdVergiNo.Text = dgvMüsteriler.Rows[e.RowIndex].Cells["VergiNo"].Value.ToString();
                txtAciklama.Text= dgvMüsteriler.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();
                bool aktifMi = (bool)dgvMüsteriler.Rows[e.RowIndex].Cells["AktifMi"].Value;
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ZorunluTextler = new string[]
                {txtMusteriAdi.Text,
            txtAdres.Text,
            mskdTelefon.Text,
            txtEMail.Text,
            mskdVergiNo.Text,
                };
                if (ZorunluAlanlar(ZorunluTextler) == true)
                {
                    MessageBox.Show("Açıklama Dışındaki Alanlar Boş Bırakılamaz.");
                    return;
                }


                string mesaj = musteriler.Kaydet
                    (
                    txtMusteriAdi.Text,
                    txtAdres.Text,
                    mskdTelefon.Text,
                    txtEMail.Text,
                    mskdVergiNo.Text,
                    txtAciklama.Text,
                    rbEvet.Checked == true ? true : false
                    );

                MusteriListesi();
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
                {txtMusteriAdi.Text,
            txtAdres.Text,
            mskdTelefon.Text,
            txtEMail.Text,
            mskdVergiNo.Text,
                };
            if (ZorunluAlanlar(ZorunluTextler) == true)
            {
                MessageBox.Show("Açıklama Dışındaki Alanlar Boş Bırakılamaz.");
                return;
            }
            string mesaj = musteriler.Guncelle
                (musterilerID,
                txtMusteriAdi.Text,
                    txtAdres.Text,
                    mskdTelefon.Text,
                    txtEMail.Text,
                    mskdVergiNo.Text,
                    txtAciklama.Text,
                    rbEvet.Checked == true ? true : false
                );
            MusteriListesi();
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
                    string mesaj = musteriler.Sil(musterilerID);
                    MessageBox.Show(mesaj);
                }
                MusteriListesi();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında bir hata oluştu.\nHATA: " + ex);
            }
        }

        private void dgvMüsteriler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvMüsteriler.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToBoolean(dgvMüsteriler.Rows[i].Cells["AktifMi"].Value) == false)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                dgvMüsteriler.Rows[i].DefaultCellStyle = renk;
            }
        }
    }
}
