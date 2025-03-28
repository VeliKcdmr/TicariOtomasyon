namespace TicariOtomasyon
{
    partial class FrmProductsList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductsList));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colÜrünAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKategori = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYıl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTedarikçi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdeti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAçıklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEklenmeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colÜrünAdı,
            this.colBarkod,
            this.colKategori,
            this.colMarka,
            this.colModel,
            this.colYıl,
            this.colRaf,
            this.colTedarikçi,
            this.colStokAdeti,
            this.gridColumn1,
            this.colAçıklama,
            this.colEklenmeTarihi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colÜrünAdı
            // 
            this.colÜrünAdı.FieldName = "Ürün Adı";
            this.colÜrünAdı.Name = "colÜrünAdı";
            this.colÜrünAdı.Visible = true;
            this.colÜrünAdı.VisibleIndex = 1;
            // 
            // colBarkod
            // 
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 2;
            // 
            // colKategori
            // 
            this.colKategori.FieldName = "Kategori";
            this.colKategori.Name = "colKategori";
            this.colKategori.Visible = true;
            this.colKategori.VisibleIndex = 3;
            // 
            // colMarka
            // 
            this.colMarka.FieldName = "Marka";
            this.colMarka.Name = "colMarka";
            this.colMarka.Visible = true;
            this.colMarka.VisibleIndex = 4;
            // 
            // colModel
            // 
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 5;
            // 
            // colYıl
            // 
            this.colYıl.FieldName = "Yıl";
            this.colYıl.Name = "colYıl";
            this.colYıl.Visible = true;
            this.colYıl.VisibleIndex = 6;
            // 
            // colRaf
            // 
            this.colRaf.FieldName = "Raf";
            this.colRaf.Name = "colRaf";
            this.colRaf.Visible = true;
            this.colRaf.VisibleIndex = 7;
            // 
            // colTedarikçi
            // 
            this.colTedarikçi.FieldName = "Tedarikçi";
            this.colTedarikçi.Name = "colTedarikçi";
            this.colTedarikçi.Visible = true;
            this.colTedarikçi.VisibleIndex = 8;
            // 
            // colStokAdeti
            // 
            this.colStokAdeti.FieldName = "Stok Adeti";
            this.colStokAdeti.Name = "colStokAdeti";
            this.colStokAdeti.Visible = true;
            this.colStokAdeti.VisibleIndex = 9;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Birim Fiyat (TL)";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 10;
            // 
            // colAçıklama
            // 
            this.colAçıklama.FieldName = "Açıklama";
            this.colAçıklama.Name = "colAçıklama";
            this.colAçıklama.Visible = true;
            this.colAçıklama.VisibleIndex = 11;
            // 
            // colEklenmeTarihi
            // 
            this.colEklenmeTarihi.FieldName = "Eklenme Tarihi";
            this.colEklenmeTarihi.Name = "colEklenmeTarihi";
            this.colEklenmeTarihi.Visible = true;
            this.colEklenmeTarihi.VisibleIndex = 12;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "sp_UrunListesi";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "sqlserver\\sqlexpress.ZorluMotorDB.dbo";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery2.Name = "sp_UrunListesi";
            storedProcQuery2.StoredProcName = "sp_UrunListesi";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // FrmProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmProductsList";
            this.Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colÜrünAdı;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colKategori;
        private DevExpress.XtraGrid.Columns.GridColumn colMarka;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colYıl;
        private DevExpress.XtraGrid.Columns.GridColumn colRaf;
        private DevExpress.XtraGrid.Columns.GridColumn colTedarikçi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdeti;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colAçıklama;
        private DevExpress.XtraGrid.Columns.GridColumn colEklenmeTarihi;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}