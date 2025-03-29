using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Customization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon
{
    public partial class FrmCategories : DevExpress.XtraEditors.XtraForm
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        // SQL Bağlantısı
        SqlBaglanti bgl = new SqlBaglanti();

        void hatakontrol()
        {
            KontrolHelper.Hatayazdir(TxtKAd, LblKadUyarisi);
            KontrolHelper.Hatayazdir(CmbKDurum, LblDurumUyarisi);
        }
        // TextBox ve ComboBox temizleme
        void temizle()
        {
            TxtKAd.Text = "";
            TxtKNot.Text = "";
            CmbKDurum.EditValue = null;
        }

        void CmbDurumGuncelle()
        {
            CmbKDurum.Properties.Items.Clear();

            // İlk sıraya "Durum Seçiniz" ekleniyor
            CmbKDurum.Properties.Items.Add("Durum Seçiniz");
            CmbKDurum.Properties.Items.Add("Aktif");
            CmbKDurum.Properties.Items.Add("Pasif");

            // Varsayılan olarak ilk öğeyi seçili yap
            CmbKDurum.SelectedIndex = 0; // "Durum Seçiniz" seçilir
        }
        // Kategorileri listeleme
        void listele()
        {
            try
            {
                // DataTable oluştur ve doldur
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT CategoryID, CategoryName, Description, IsActive FROM Categories where IsActive=1", bgl.baglanti());
                da.Fill(dt);

                // "Durum" sütununu ekle ve dönüştür
                if (!dt.Columns.Contains("Durum"))
                    dt.Columns.Add("Durum", typeof(string));

                foreach (DataRow row in dt.Rows)
                    row["Durum"] = Convert.ToBoolean(row["IsActive"]) ? "Aktif" : "Pasif";

                // Eğer veri yoksa boş bir mesaj ekle
                if (dt.Rows.Count == 0)
                {
                    DataRow emptyRow = dt.NewRow();
                    emptyRow["CategoryName"] = "Veri bulunamadı!";
                    emptyRow["Description"] = "-";
                    emptyRow["Durum"] = "-";
                    dt.Rows.Add(emptyRow);
                }

                // GridControl'e bağla ve sütun başlıklarını düzenle
                gridControl1.DataSource = dt;
                gridView1.PopulateColumns();
                gridView1.Columns["CategoryName"].Caption = "Kategori Adı";
                gridView1.Columns["Description"].Caption = "Açıklama";
                gridView1.Columns["Durum"].Caption = "Durum";
                gridView1.Columns["IsActive"].Visible = false; // Orijinal sütunu gizle
                gridView1.Columns["CategoryID"].Visible = false; // ID sütununu gizle
                gridView1.BestFitColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Form yüklendiğinde işlemleri yap
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            CmbDurumGuncelle();
            listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            hatakontrol();
            if (LblKadUyarisi.Visible || LblDurumUyarisi.Visible)
            {
                XtraMessageBox.Show("Lütfen eksik alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi durdur
            }
            try
            {   // Kategori ekleme
                SqlCommand komut = new SqlCommand("INSERT INTO Categories (CategoryName, Description, IsActive) VALUES (@p1, @p2, @p3)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtKAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtKNot.Text);
                komut.Parameters.AddWithValue("@p3", CmbKDurum.Text == "Aktif" ? true : false);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                XtraMessageBox.Show("Kategori başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
                listele();
                CmbDurumGuncelle();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            hatakontrol();
            if (LblKadUyarisi.Visible || LblDurumUyarisi.Visible)
            {
                XtraMessageBox.Show("Lütfen eksik alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi durdur
            }
            try
            {
                // Kategori güncelleme
                SqlCommand komut = new SqlCommand("UPDATE Categories SET CategoryName=@p1, Description=@p2, IsActive=@p3 WHERE CategoryID=@p4", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtKAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtKNot.Text);
                komut.Parameters.AddWithValue("@p3", CmbKDurum.Text == "Aktif" ? true : false);
                komut.Parameters.AddWithValue("@p4", gridView1.GetFocusedRowCellValue("CategoryID"));
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                XtraMessageBox.Show("Kategori başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
                listele();
                CmbDurumGuncelle();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            hatakontrol();
            if (LblKadUyarisi.Visible || LblDurumUyarisi.Visible)
            {
                XtraMessageBox.Show("Lütfen eksik alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi durdur
            }
            try
            {
                //Kategori pasif hale getirme
                SqlCommand komut = new SqlCommand("UPDATE Categories SET IsActive=0 WHERE CategoryID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", gridView1.GetFocusedRowCellValue("CategoryID"));
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                XtraMessageBox.Show("Kategori başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
                listele();
                CmbDurumGuncelle();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            // Seçilen satırın bilgilerini TextBox ve ComboBox'lara aktarma
            if (gridView1.GetFocusedRowCellValue("CategoryName").ToString() == "Veri bulunamadı!")
                return; // Eğer veri yoksa işlem yapma
            TxtKAd.Text = gridView1.GetFocusedRowCellValue("CategoryName").ToString();
            TxtKNot.Text = gridView1.GetFocusedRowCellValue("Description").ToString();
            CmbKDurum.Text = gridView1.GetFocusedRowCellValue("Durum").ToString();

        }
    }
}

