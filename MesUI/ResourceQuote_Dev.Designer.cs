
namespace MesUI
{
    partial class ResourceQuote_Dev
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
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView5 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView6 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series7 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView7 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series8 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView8 = new DevExpress.XtraCharts.LineSeriesView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.resourceQuoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceQuoteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.resourceQuoteBindingSource;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisX.VisualRange.Auto = false;
            xyDiagram2.AxisX.VisualRange.MaxValueSerializable = "12/25/2020 00:00:00.000";
            xyDiagram2.AxisX.VisualRange.MinValueSerializable = "12/16/2020 00:00:00.000";
            xyDiagram2.AxisX.WholeRange.Auto = false;
            xyDiagram2.AxisX.WholeRange.MaxValueSerializable = "12/25/2020 00:00:00.000";
            xyDiagram2.AxisX.WholeRange.MinValueSerializable = "08/16/2020 00:00:00.000";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram2;
            this.chartControl1.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.CheckBox;
            this.chartControl1.Location = new System.Drawing.Point(12, 12);
            this.chartControl1.Name = "chartControl1";
            series5.ArgumentDataMember = "date";
            series5.Name = "철광석";
            series5.ValueDataMembersSerializable = "Iron_Ore_Quote";
            series5.View = lineSeriesView5;
            series6.ArgumentDataMember = "date";
            series6.Name = "니켈";
            series6.ValueDataMembersSerializable = "Nikel_Quote";
            series6.View = lineSeriesView6;
            series7.ArgumentDataMember = "date";
            series7.Name = "알루미늄";
            series7.ValueDataMembersSerializable = "Aluminum_Quote";
            series7.View = lineSeriesView7;
            series8.ArgumentDataMember = "date";
            series8.Name = "구리";
            series8.ValueDataMembersSerializable = "Copper_Quote";
            series8.View = lineSeriesView8;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series5,
        series6,
        series7,
        series8};
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "date";
            this.chartControl1.Size = new System.Drawing.Size(776, 426);
            this.chartControl1.TabIndex = 0;
            // 
            // resourceQuoteBindingSource
            // 
            this.resourceQuoteBindingSource.DataSource = typeof(MiniSteelworksMES.Data.Resource_Quote);
            // 
            // ResourceQuote_Dev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartControl1);
            this.Name = "ResourceQuote_Dev";
            this.Text = "원자재 시세조회";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceQuoteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource resourceQuoteBindingSource;
    }
}