
namespace OtelYeniProje.Formlar.AnaForm
{
    partial class FrmAnaForm
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.gridControlUrunStokListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlMisafirListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlBugunGelecekMisafirler = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlMesajListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.chartControlGrafik1 = new DevExpress.XtraCharts.ChartControl();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.chartControlOdaDoluluk = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunStokListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMisafirListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBugunGelecekMisafirler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMesajListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlGrafik1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlOdaDoluluk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlUrunStokListesi
            // 
            this.gridControlUrunStokListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUrunStokListesi.Location = new System.Drawing.Point(2, 28);
            this.gridControlUrunStokListesi.MainView = this.gridView1;
            this.gridControlUrunStokListesi.Name = "gridControlUrunStokListesi";
            this.gridControlUrunStokListesi.Size = new System.Drawing.Size(297, 164);
            this.gridControlUrunStokListesi.TabIndex = 1;
            this.gridControlUrunStokListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlUrunStokListesi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlUrunStokListesi);
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(301, 194);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Ürün-Stok Listesi";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlMisafirListesi);
            this.groupControl2.Location = new System.Drawing.Point(307, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(301, 194);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Misafir Listesi";
            // 
            // gridControlMisafirListesi
            // 
            this.gridControlMisafirListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMisafirListesi.Location = new System.Drawing.Point(2, 28);
            this.gridControlMisafirListesi.MainView = this.gridView2;
            this.gridControlMisafirListesi.Name = "gridControlMisafirListesi";
            this.gridControlMisafirListesi.Size = new System.Drawing.Size(297, 164);
            this.gridControlMisafirListesi.TabIndex = 1;
            this.gridControlMisafirListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlMisafirListesi;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControlBugunGelecekMisafirler);
            this.groupControl3.Location = new System.Drawing.Point(2, 202);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(301, 194);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Bugün Gelecek Misafirler";
            // 
            // gridControlBugunGelecekMisafirler
            // 
            this.gridControlBugunGelecekMisafirler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBugunGelecekMisafirler.Location = new System.Drawing.Point(2, 28);
            this.gridControlBugunGelecekMisafirler.MainView = this.gridView3;
            this.gridControlBugunGelecekMisafirler.Name = "gridControlBugunGelecekMisafirler";
            this.gridControlBugunGelecekMisafirler.Size = new System.Drawing.Size(297, 164);
            this.gridControlBugunGelecekMisafirler.TabIndex = 1;
            this.gridControlBugunGelecekMisafirler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControlBugunGelecekMisafirler;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.gridControlMesajListesi);
            this.groupControl4.Location = new System.Drawing.Point(307, 202);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(301, 194);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "Mesaj Listesi";
            // 
            // gridControlMesajListesi
            // 
            this.gridControlMesajListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMesajListesi.Location = new System.Drawing.Point(2, 28);
            this.gridControlMesajListesi.MainView = this.gridView4;
            this.gridControlMesajListesi.Name = "gridControlMesajListesi";
            this.gridControlMesajListesi.Size = new System.Drawing.Size(297, 164);
            this.gridControlMesajListesi.TabIndex = 1;
            this.gridControlMesajListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gridControlMesajListesi;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.DoubleClick += new System.EventHandler(this.gridView4_DoubleClick);
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.chartControlGrafik1);
            this.groupControl5.Location = new System.Drawing.Point(612, 2);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(409, 194);
            this.groupControl5.TabIndex = 4;
            this.groupControl5.Text = "Grafik 1";
            // 
            // chartControlGrafik1
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControlGrafik1.Diagram = xyDiagram1;
            this.chartControlGrafik1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlGrafik1.Legend.LegendID = -1;
            this.chartControlGrafik1.Location = new System.Drawing.Point(2, 28);
            this.chartControlGrafik1.Name = "chartControlGrafik1";
            series1.Name = "Urun_Stok";
            series1.SeriesID = 0;
            this.chartControlGrafik1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControlGrafik1.Size = new System.Drawing.Size(405, 164);
            this.chartControlGrafik1.TabIndex = 0;
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.chartControlOdaDoluluk);
            this.groupControl6.Location = new System.Drawing.Point(612, 202);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(409, 194);
            this.groupControl6.TabIndex = 4;
            this.groupControl6.Text = "Oda Doluluk Grafiği";
            // 
            // chartControlOdaDoluluk
            // 
            this.chartControlOdaDoluluk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlOdaDoluluk.Legend.LegendID = -1;
            this.chartControlOdaDoluluk.Location = new System.Drawing.Point(2, 28);
            this.chartControlOdaDoluluk.Name = "chartControlOdaDoluluk";
            series2.LegendTextPattern = "{A}";
            series2.Name = "Durumlar";
            series2.SeriesID = 1;
            series2.View = pieSeriesView1;
            this.chartControlOdaDoluluk.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControlOdaDoluluk.Size = new System.Drawing.Size(405, 164);
            this.chartControlOdaDoluluk.TabIndex = 1;
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 398);
            this.Controls.Add(this.groupControl6);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Form";
            this.Load += new System.EventHandler(this.FrmAnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunStokListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMisafirListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBugunGelecekMisafirler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMesajListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlGrafik1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlOdaDoluluk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlUrunStokListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControlMisafirListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridControlBugunGelecekMisafirler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl gridControlMesajListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraCharts.ChartControl chartControlGrafik1;
        private DevExpress.XtraCharts.ChartControl chartControlOdaDoluluk;
    }
}