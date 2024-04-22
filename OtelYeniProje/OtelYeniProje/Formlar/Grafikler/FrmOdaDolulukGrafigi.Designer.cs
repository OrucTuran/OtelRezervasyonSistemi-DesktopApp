
namespace OtelYeniProje.Formlar.Grafikler
{
    partial class FrmOdaDolulukGrafigi
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
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.HatchFillOptions hatchFillOptions1 = new DevExpress.XtraCharts.HatchFillOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdaDolulukGrafigi));
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.LegendID = -1;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "OdaDoluluk";
            series1.SeriesID = 2;
            sideBySideBarSeriesView1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(143)))));
            sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(146)))));
            sideBySideBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Hatch;
            hatchFillOptions1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(60)))));
            sideBySideBarSeriesView1.FillStyle.Options = hatchFillOptions1;
            series1.View = sideBySideBarSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(1024, 398);
            this.chartControl1.TabIndex = 0;
            // 
            // FrmOdaDolulukGrafigi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 398);
            this.Controls.Add(this.chartControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOdaDolulukGrafigi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda Doluluk Grafiği";
            this.Load += new System.EventHandler(this.FrmOdaDolulukGrafigi_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}