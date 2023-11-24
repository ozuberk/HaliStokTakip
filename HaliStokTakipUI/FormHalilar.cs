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
using HaliStokTakipDLL;
using HaliStokTakipDLL.RepositoryFolder;

namespace HaliStokTakipUI
{
    public partial class FormHalilar : Form
    {
        public FormHalilar()
        {
            InitializeComponent();
            this.repoKategori = new Repository<Kategoriler>(db);
            this.repoRenk = new Repository<Renkler>(db);
            this.repoDesen = new Repository<Desenler>(db);
            this.repoMarka = new Repository<Markalar>(db);
            this.repoBoyut = new Repository<Boyutlar>(db);
        }
        HaliStokTakipDBEntities db = new HaliStokTakipDBEntities();
        HalilarManager halilar = new HalilarManager();
        KategoriManager kategoriler = new KategoriManager();
        MarkalarManager markalar = new MarkalarManager();
        RenklerManager renkler = new RenklerManager();
        DesenManager desenler = new DesenManager();
        BoyutlarManager boyutlar = new BoyutlarManager();
        Repository<Kategoriler> repoKategori;
        Repository<Renkler> repoRenk;
        Repository<Desenler> repoDesen;
        Repository<Markalar> repoMarka;
        Repository<Boyutlar> repoBoyut;
        private void FormHalilar_Load(object sender, EventArgs e)
        {
            HaliListesi();
            HaliBilgileri();
            Temizle();

        }
        private void Temizle()
        {
            comboBoxKategori.SelectedValue = -1;
            comboBoxMarka.SelectedValue = -1;
            comboBoxBoyut.SelectedValue = -1;
            comboBoxDesen.SelectedValue = -1;
            comboBoxRenk.SelectedValue = -1;
            maskedTextBoxBarkod.Text = string.Empty;
            textBoxHaliAdi.Text = string.Empty;
            mskdFiyat.Text = string.Empty;
            textBoxAciklama.Text = string.Empty;
            dateTimePickerUretimTarihi.Text = string.Empty;
            radioButtonEvet.Checked = false;
            radioButtonHayir.Checked = false;

        }
        private void HaliBilgileri()
        {

            comboBoxKategori.ValueMember = "ID";
            comboBoxKategori.DisplayMember = "KategoriAdi";
            comboBoxKategori.DataSource = kategoriler.KategoriListele();
            comboBoxKategori.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxKategori.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxKategori.SelectedIndex = -1;

            comboBoxMarka.ValueMember = "ID";
            comboBoxMarka.DisplayMember = "MarkaAdi";
            comboBoxMarka.DataSource = markalar.MarkalariListele();
            comboBoxMarka.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxMarka.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxMarka.SelectedIndex = -1;


            comboBoxRenk.ValueMember = "ID";
            comboBoxRenk.DisplayMember = "RenkAdi";
            comboBoxRenk.DataSource = renkler.RenkleriListele();
            comboBoxRenk.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxRenk.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxRenk.SelectedIndex = -1;


            comboBoxDesen.ValueMember = "ID";
            comboBoxDesen.DisplayMember = "DesenAdi";
            comboBoxDesen.DataSource = desenler.DesenleriListele();
            comboBoxDesen.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxDesen.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxDesen.SelectedIndex = -1;


            comboBoxBoyut.ValueMember = "ID";
            comboBoxBoyut.DisplayMember = "BoyutAdi";
            comboBoxBoyut.DataSource = boyutlar.BoyutlariListele();
            comboBoxBoyut.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxBoyut.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxBoyut.SelectedIndex = -1;


        }
        private void HaliListesi()
        {
            dataGridViewHalilar.DataSource = halilar.HalilariListele();

            dataGridViewHalilar.Columns["ID"].Width = 35;
            dataGridViewHalilar.Columns["KategoriAdi"].Width = 65;
            dataGridViewHalilar.Columns["MarkaAdi"].Width = 65;
            dataGridViewHalilar.Columns["RenkAdi"].Width = 65;
            dataGridViewHalilar.Columns["DesenAdi"].Width = 65;
            dataGridViewHalilar.Columns["BoyutAdi"].Width = 65;
            dataGridViewHalilar.Columns["UretimTarihi"].Width = 75;
            dataGridViewHalilar.Columns["AktifMi"].Width = 50;

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

        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ZorunluTextler = new string[]
                {comboBoxKategori.Text,
            comboBoxMarka.Text,
            comboBoxDesen.Text,
            comboBoxBoyut.Text,
            comboBoxRenk.Text,
            maskedTextBoxBarkod.Text,
            textBoxHaliAdi.Text,
            mskdFiyat.Text,
            dateTimePickerUretimTarihi.Text
                };
                if (ZorunluAlanlar(ZorunluTextler) == true)
                {
                    MessageBox.Show("Açıklama Dışındaki Alanlar Boş Bırakılamaz.");
                    return;
                }


                string mesaj = halilar.Kaydet
                    ((int)comboBoxKategori.SelectedValue,
                    (int)comboBoxMarka.SelectedValue,
                    (int)comboBoxRenk.SelectedValue,
                    (int)comboBoxDesen.SelectedValue,
                    (int)comboBoxBoyut.SelectedValue,
                    maskedTextBoxBarkod.Text,
                    textBoxHaliAdi.Text,
                    Convert.ToDecimal(mskdFiyat.Text),
                    textBoxAciklama.Text,
                    Convert.ToDateTime(dateTimePickerUretimTarihi.Text),
                    radioButtonEvet.Checked == true ? true : false
                    );

                HaliListesi();
                HaliBilgileri();
                Temizle();
                MessageBox.Show(mesaj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında bir hata oluştu.\nHATA: " + ex);
            }
        }

        int halilarID;

        private void dataGridViewHalilar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                halilarID = (int)dataGridViewHalilar.Rows[e.RowIndex].Cells["ID"].Value;

                var txtKategori = dataGridViewHalilar.Rows[e.RowIndex].Cells["KategoriAdi"].Value.ToString();
                var objKategori = repoKategori.BulQuery(s => s.KategoriAdi == txtKategori).FirstOrDefault();
                int secKategori = objKategori.ID;
                comboBoxKategori.SelectedValue = secKategori;

                var txtMarka = dataGridViewHalilar.Rows[e.RowIndex].Cells["MarkaAdi"].Value.ToString();
                var objMarka = repoMarka.BulQuery(s => s.MarkaAdi == txtMarka).FirstOrDefault();
                int secMarka = objMarka.ID;
                comboBoxMarka.SelectedValue = secMarka;


                var txtRenk = dataGridViewHalilar.Rows[e.RowIndex].Cells["RenkAdi"].Value.ToString();
                var objRenk = repoRenk.BulQuery(s => s.RenkAdi == txtRenk).FirstOrDefault();
                int secRenk = objRenk.ID;
                comboBoxRenk.SelectedValue = secRenk;

                var txtDesen = dataGridViewHalilar.Rows[e.RowIndex].Cells["DesenAdi"].Value.ToString();
                var objDesen = repoDesen.BulQuery(s => s.DesenAdi == txtDesen).FirstOrDefault();
                int secDesen = objDesen.ID;
                comboBoxDesen.SelectedValue = secDesen;

                var txtBoyut = dataGridViewHalilar.Rows[e.RowIndex].Cells["BoyutAdi"].Value.ToString();
                var objBoyut = repoBoyut.BulQuery(s => s.BoyutAdi == txtBoyut).FirstOrDefault();
                int secBoyut = objBoyut.ID;
                comboBoxBoyut.SelectedValue = secBoyut;

                maskedTextBoxBarkod.Text = dataGridViewHalilar.Rows[e.RowIndex].Cells["BarkodNo"].Value.ToString();
                textBoxHaliAdi.Text = dataGridViewHalilar.Rows[e.RowIndex].Cells["HaliAdi"].Value.ToString();
                mskdFiyat.Text = dataGridViewHalilar.Rows[e.RowIndex].Cells["Fiyat"].Value.ToString();
                textBoxAciklama.Text = dataGridViewHalilar.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();
                dateTimePickerUretimTarihi.Text = dataGridViewHalilar.Rows[e.RowIndex].Cells["UretimTarihi"].Value.ToString();
                bool aktifMi = (bool)dataGridViewHalilar.Rows[e.RowIndex].Cells["AktifMi"].Value;
                if (aktifMi == true)
                {
                    radioButtonEvet.Checked = true;
                }
                else
                {
                    radioButtonHayir.Checked = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu. \nHATA: " + ex.Message);
            }
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            string[] ZorunluTextler = new string[]
                {comboBoxKategori.Text,
            comboBoxMarka.Text,
            comboBoxDesen.Text,
            comboBoxBoyut.Text,
            comboBoxRenk.Text,
            maskedTextBoxBarkod.Text,
            textBoxHaliAdi.Text,
            mskdFiyat.Text,
            dateTimePickerUretimTarihi.Text
                };
            if (ZorunluAlanlar(ZorunluTextler) == true)
            {
                MessageBox.Show("Açıklama Dışındaki Alanlar Boş Bırakılamaz.");
                return;
            }
            string mesaj = halilar.Guncelle
                (halilarID,
                (int)comboBoxKategori.SelectedValue,
                (int)comboBoxMarka.SelectedValue,
                (int)comboBoxRenk.SelectedValue,
                (int)comboBoxDesen.SelectedValue,
                (int)comboBoxBoyut.SelectedValue,
                maskedTextBoxBarkod.Text,
                textBoxHaliAdi.Text,
                Convert.ToDecimal(mskdFiyat.Text),
                textBoxAciklama.Text,
                Convert.ToDateTime(dateTimePickerUretimTarihi.Value.ToString()),
                radioButtonEvet.Checked == true ? true : false
                );
            HaliListesi();
            HaliBilgileri();
            Temizle();
            MessageBox.Show(mesaj);
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult silOnay = new DialogResult();
                silOnay = MessageBox.Show("Bu Öğeyi Silmek İstiyor musunuz?", "----ALERT----", MessageBoxButtons.OKCancel);
                if (silOnay == DialogResult.OK)
                {
                    string mesaj = halilar.Sil(halilarID);
                    MessageBox.Show(mesaj);
                }
                HaliListesi();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında bir hata oluştu.\nHATA: " + ex);
            }
        }

        private void dataGridViewHalilar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridViewHalilar.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToBoolean(dataGridViewHalilar.Rows[i].Cells["AktifMi"].Value) == false)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                dataGridViewHalilar.Rows[i].DefaultCellStyle = renk;
            }
        }

      
    }
}
