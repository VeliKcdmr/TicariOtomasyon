namespace TicariOtomasyon
{
    partial class FrmProductsAdd
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductsAdd));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.BtnUrunSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUrunGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUrunKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.RTxtDetay = new System.Windows.Forms.RichTextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.NudUrunAdet = new System.Windows.Forms.NumericUpDown();
            this.TxtUrunFiyat = new DevExpress.XtraEditors.TextEdit();
            this.TxtUrunBarkod = new DevExpress.XtraEditors.TextEdit();
            this.TxtUrunAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudUrunAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunAd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.AutoSize = true;
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Location = new System.Drawing.Point(12, 204);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1322, 320);
            this.panelControl2.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "sp_UrunListesi";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1318, 316);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "sqlserver\\sqlexpress.ZorluMotorDB.dbo";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "sp_UrunListesi";
            storedProcQuery1.StoredProcName = "sp_UrunListesi";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
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
            // 
            // colÜrünAdı
            // 
            this.colÜrünAdı.FieldName = "Ürün Adı";
            this.colÜrünAdı.Name = "colÜrünAdı";
            this.colÜrünAdı.Visible = true;
            this.colÜrünAdı.VisibleIndex = 0;
            // 
            // colBarkod
            // 
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 1;
            // 
            // colKategori
            // 
            this.colKategori.FieldName = "Kategori";
            this.colKategori.Name = "colKategori";
            this.colKategori.Visible = true;
            this.colKategori.VisibleIndex = 2;
            // 
            // colMarka
            // 
            this.colMarka.FieldName = "Marka";
            this.colMarka.Name = "colMarka";
            this.colMarka.Visible = true;
            this.colMarka.VisibleIndex = 3;
            // 
            // colModel
            // 
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 4;
            // 
            // colYıl
            // 
            this.colYıl.FieldName = "Yıl";
            this.colYıl.Name = "colYıl";
            this.colYıl.Visible = true;
            this.colYıl.VisibleIndex = 5;
            // 
            // colRaf
            // 
            this.colRaf.FieldName = "Raf";
            this.colRaf.Name = "colRaf";
            this.colRaf.Visible = true;
            this.colRaf.VisibleIndex = 6;
            // 
            // colTedarikçi
            // 
            this.colTedarikçi.FieldName = "Tedarikçi";
            this.colTedarikçi.Name = "colTedarikçi";
            this.colTedarikçi.Visible = true;
            this.colTedarikçi.VisibleIndex = 7;
            // 
            // colStokAdeti
            // 
            this.colStokAdeti.FieldName = "Stok Adeti";
            this.colStokAdeti.Name = "colStokAdeti";
            this.colStokAdeti.Visible = true;
            this.colStokAdeti.VisibleIndex = 8;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Birim Fiyat (TL)";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 9;
            // 
            // colAçıklama
            // 
            this.colAçıklama.FieldName = "Açıklama";
            this.colAçıklama.Name = "colAçıklama";
            this.colAçıklama.Visible = true;
            this.colAçıklama.VisibleIndex = 10;
            // 
            // colEklenmeTarihi
            // 
            this.colEklenmeTarihi.FieldName = "Eklenme Tarihi";
            this.colEklenmeTarihi.Name = "colEklenmeTarihi";
            this.colEklenmeTarihi.Visible = true;
            this.colEklenmeTarihi.VisibleIndex = 11;
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSize = true;
            this.panelControl1.Controls.Add(this.labelControl12);
            this.panelControl1.Controls.Add(this.BtnUrunSil);
            this.panelControl1.Controls.Add(this.BtnUrunGuncelle);
            this.panelControl1.Controls.Add(this.BtnUrunKaydet);
            this.panelControl1.Controls.Add(this.RTxtDetay);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.NudUrunAdet);
            this.panelControl1.Controls.Add(this.TxtUrunFiyat);
            this.panelControl1.Controls.Add(this.TxtUrunBarkod);
            this.panelControl1.Controls.Add(this.TxtUrunAd);
            this.panelControl1.Controls.Add(this.labelControl10);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1320, 192);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl12
            // 
            this.labelControl12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(567, 95);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(10, 19);
            this.labelControl12.TabIndex = 15;
            this.labelControl12.Text = "₺";
            // 
            // BtnUrunSil
            // 
            this.BtnUrunSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnUrunSil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunSil.Appearance.Options.UseFont = true;
            this.BtnUrunSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunSil.ImageOptions.Image")));
            this.BtnUrunSil.Location = new System.Drawing.Point(449, 150);
            this.BtnUrunSil.Name = "BtnUrunSil";
            this.BtnUrunSil.Size = new System.Drawing.Size(111, 32);
            this.BtnUrunSil.TabIndex = 14;
            this.BtnUrunSil.Text = "Sil";
            // 
            // BtnUrunGuncelle
            // 
            this.BtnUrunGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnUrunGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunGuncelle.Appearance.Options.UseFont = true;
            this.BtnUrunGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunGuncelle.ImageOptions.Image")));
            this.BtnUrunGuncelle.Location = new System.Drawing.Point(273, 153);
            this.BtnUrunGuncelle.Name = "BtnUrunGuncelle";
            this.BtnUrunGuncelle.Size = new System.Drawing.Size(111, 32);
            this.BtnUrunGuncelle.TabIndex = 13;
            this.BtnUrunGuncelle.Text = "Güncelle";
            // 
            // BtnUrunKaydet
            // 
            this.BtnUrunKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnUrunKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunKaydet.Appearance.Options.UseFont = true;
            this.BtnUrunKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunKaydet.ImageOptions.Image")));
            this.BtnUrunKaydet.Location = new System.Drawing.Point(97, 153);
            this.BtnUrunKaydet.Name = "BtnUrunKaydet";
            this.BtnUrunKaydet.Size = new System.Drawing.Size(111, 32);
            this.BtnUrunKaydet.TabIndex = 12;
            this.BtnUrunKaydet.Text = "Kaydet";
            this.BtnUrunKaydet.Click += new System.EventHandler(this.BtnUrunKaydet_Click);
            // 
            // RTxtDetay
            // 
            this.RTxtDetay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTxtDetay.Location = new System.Drawing.Point(717, 8);
            this.RTxtDetay.Name = "RTxtDetay";
            this.RTxtDetay.Size = new System.Drawing.Size(216, 174);
            this.RTxtDetay.TabIndex = 11;
            this.RTxtDetay.Text = "";
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(603, 11);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(107, 18);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "Ürün Açıklama : ";
            // 
            // NudUrunAdet
            // 
            this.NudUrunAdet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NudUrunAdet.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NudUrunAdet.Location = new System.Drawing.Point(388, 118);
            this.NudUrunAdet.Name = "NudUrunAdet";
            this.NudUrunAdet.Size = new System.Drawing.Size(172, 26);
            this.NudUrunAdet.TabIndex = 10;
            // 
            // TxtUrunFiyat
            // 
            this.TxtUrunFiyat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtUrunFiyat.Location = new System.Drawing.Point(388, 92);
            this.TxtUrunFiyat.Name = "TxtUrunFiyat";
            this.TxtUrunFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUrunFiyat.Properties.Appearance.Options.UseFont = true;
            this.TxtUrunFiyat.Properties.BeepOnError = true;
            this.TxtUrunFiyat.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TxtUrunFiyat.Properties.MaskSettings.Set("mask", "n");
            this.TxtUrunFiyat.Properties.MaskSettings.Set("valueType", typeof(decimal));
            this.TxtUrunFiyat.Properties.MaskSettings.Set("culture", "tr-TR");
            this.TxtUrunFiyat.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.TxtUrunFiyat.Properties.MaskSettings.Set("valueAfterDelete", null);
            this.TxtUrunFiyat.Properties.UseMaskAsDisplayFormat = true;
            this.TxtUrunFiyat.Size = new System.Drawing.Size(172, 24);
            this.TxtUrunFiyat.TabIndex = 9;
            // 
            // TxtUrunBarkod
            // 
            this.TxtUrunBarkod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtUrunBarkod.Location = new System.Drawing.Point(106, 34);
            this.TxtUrunBarkod.Name = "TxtUrunBarkod";
            this.TxtUrunBarkod.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUrunBarkod.Properties.Appearance.Options.UseFont = true;
            this.TxtUrunBarkod.Size = new System.Drawing.Size(172, 22);
            this.TxtUrunBarkod.TabIndex = 2;
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtUrunAd.Location = new System.Drawing.Point(106, 8);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUrunAd.Properties.Appearance.Options.UseFont = true;
            this.TxtUrunAd.Size = new System.Drawing.Size(172, 22);
            this.TxtUrunAd.TabIndex = 1;
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(341, 120);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(45, 18);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "Adet : ";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(341, 94);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(46, 18);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Fiyat : ";
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(57, 120);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(37, 18);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Raf : ";
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(355, 64);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(29, 18);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Yıl : ";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(333, 38);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 18);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Model : ";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(26, 93);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 18);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Tedarikçi : ";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(332, 7);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 18);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Marka : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(25, 66);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Kategori  : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 40);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Ürün Barcod : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(28, 7);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ürün Adı : ";
            // 
            // FrmProductsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 536);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProductsAdd";
            this.Text = "Ürün Ekleme";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudUrunAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunAd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnUrunKaydet;
        private System.Windows.Forms.RichTextBox RTxtDetay;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.NumericUpDown NudUrunAdet;
        private DevExpress.XtraEditors.TextEdit TxtUrunFiyat;
        private DevExpress.XtraEditors.TextEdit TxtUrunBarkod;
        private DevExpress.XtraEditors.TextEdit TxtUrunAd;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnUrunSil;
        private DevExpress.XtraEditors.SimpleButton BtnUrunGuncelle;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
        private DevExpress.XtraEditors.LabelControl labelControl12;
    }
}