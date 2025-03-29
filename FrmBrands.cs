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
    public partial class FrmBrands : DevExpress.XtraEditors.XtraForm
    {
        public FrmBrands()
        {
            InitializeComponent();
        }

        // SQL Bağlantısı
        SqlBaglanti bgl = new SqlBaglanti();

        // TextBox ve ComboBox temizleme
        void temizle()
        {
            TxtMAd.Text = "";
            TxtMNot.Text = "";
            CmbDurum.EditValue = null;
            CmbKategori.EditValue = null;
        }

        void hatakontrol()
        {
            KontrolHelper.Hatayazdir(TxtMAd, LblMUyarisi);
            KontrolHelper.Hatayazdir(CmbKategori, LblKUyarisi);
            KontrolHelper.Hatayazdir(CmbDurum, LblDUyarisi);
        }

        void CmbDurumGuncelle()
        {
            CmbDurum.Properties.Items.Clear();

            // İlk sıraya "Durum Seçiniz" ekleniyor
            CmbDurum.Properties.Items.Add("Durum Seçiniz");
            CmbDurum.Properties.Items.Add("Aktif");
            CmbDurum.Properties.Items.Add("Pasif");

            // Varsayılan olarak ilk öğeyi seçili yap
            CmbDurum.SelectedIndex = 0; // "Durum Seçiniz" seçilir
        }

        void listele()
        {
            try
            {

                // DataTable oluştur ve doldur
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select BrandID,BrandName,CategoryName,Brands.Description,Brands.IsActive from Brands inner join Categories on Brands.CategoryID = Categories.CategoryID  where Brands.IsActive=1", bgl.baglanti());
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
                    emptyRow["BrandName"] = "Veri bulunamadı!";
                    emptyRow["CategoryName"] = "-";
                    emptyRow["Description"] = "-";
                    emptyRow["Durum"] = "-";
                    dt.Rows.Add(emptyRow);
                }

                // GridControl'e bağla ve sütun başlıklarını düzenle
                gridControl1.DataSource = dt;
                gridView1.PopulateColumns();
                gridView1.Columns["BrandName"].Caption = "Marka Adı";
                gridView1.Columns["CategoryName"].Caption = "Kategori Adı";
                gridView1.Columns["Description"].Caption = "Açıklama";
                gridView1.Columns["Durum"].Caption = "Durum";
                gridView1.Columns["IsActive"].Visible = false; // Orijinal sütunu gizle
                gridView1.Columns["BrandID"].Visible = false; // ID sütununu gizle
                gridView1.BestFitColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //kategori listeleme
            SqlCommand komut = new SqlCommand("Select CategoryID,CategoryName from Categories", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            CmbKategori.Properties.Items.Clear(); // Önce mevcut öğeleri temizleyelim
            CmbKategori.Properties.Items.Add("Kategori Seçiniz"); // İlk sıraya ekleme
            while (dr.Read())
            {

                CmbKategori.Properties.Items.Add(dr[1]);
            }
            CmbKategori.SelectedIndex = 0; // İlk öğeyi seçili yap
            bgl.baglanti().Close();
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
            if (LblMUyarisi.Visible || LblKUyarisi.Visible || LblMUyarisi.Visible)
            {
                XtraMessageBox.Show("Lütfen eksik alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi durdur
            }
            try
            {

                // Marka ekleme
                SqlCommand komut = new SqlCommand("INSERT INTO Brands (BrandName,CategoryID,Description,IsActive) VALUES (@p1,(SELECT CategoryID FROM Categories WHERE CategoryName=@p2),@p3,@p4)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtMAd.Text);
                komut.Parameters.AddWithValue("@p2", CmbKategori.Text);
                komut.Parameters.AddWithValue("@p3", TxtMNot.Text);
                komut.Parameters.AddWithValue("@p4", CmbDurum.Text == "Aktif" ? true : false);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                XtraMessageBox.Show("Marka başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (LblMUyarisi.Visible || LblKUyarisi.Visible || LblMUyarisi.Visible)
            {
                XtraMessageBox.Show("Lütfen eksik alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi durdur
            }
            try
            {
                // Eksik alan kontrolü
                if (string.IsNullOrWhiteSpace(TxtMAd.Text) || string.IsNullOrWhiteSpace(CmbKategori.Text))
                {
                    XtraMessageBox.Show("Lütfen tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Marka güncelleme

                SqlCommand komut = new SqlCommand("UPDATE Brands SET BrandName=@p1,CategoryID=(SELECT CategoryID FROM Categories WHERE CategoryName=@p2),Description=@p3,IsActive=@p4 WHERE BrandID=@p5", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtMAd.Text);
                komut.Parameters.AddWithValue("@p2", CmbKategori.Text);
                komut.Parameters.AddWithValue("@p3", TxtMNot.Text);
                komut.Parameters.AddWithValue("@p4", CmbDurum.Text == "Aktif" ? true : false);
                komut.Parameters.AddWithValue("@p5", gridView1.GetFocusedRowCellValue("BrandID"));
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                XtraMessageBox.Show("Marka başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (LblMUyarisi.Visible || LblKUyarisi.Visible || LblMUyarisi.Visible)
            {
                XtraMessageBox.Show("Lütfen eksik alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi durdur
            }

            try
            {
                // Marka Pasif yapma
                SqlCommand komut = new SqlCommand("UPDATE Brands SET IsActive=0 WHERE BrandID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", gridView1.GetFocusedRowCellValue("BrandID"));
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                XtraMessageBox.Show("Marka başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Seçilen satırın verilerini TextBox ve ComboBox'lara aktarma
            if (gridView1.GetFocusedRowCellValue("BrandName").ToString() == "Veri bulunamadı!")
                return;
            TxtMAd.Text = gridView1.GetFocusedRowCellValue("BrandName").ToString();
            TxtMNot.Text = gridView1.GetFocusedRowCellValue("Description").ToString();
            CmbKategori.Text = gridView1.GetFocusedRowCellValue("CategoryName").ToString();
            CmbDurum.Text = gridView1.GetFocusedRowCellValue("Durum").ToString();
        }
    }
}

