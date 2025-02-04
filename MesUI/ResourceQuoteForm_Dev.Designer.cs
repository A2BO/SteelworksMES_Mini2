﻿
namespace MesUI
{
    partial class ResourceQuoteForm_Dev
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
            DevExpress.XtraCharts.ChartCalculatedField chartCalculatedField1 = new DevExpress.XtraCharts.ChartCalculatedField();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView4 = new DevExpress.XtraCharts.LineSeriesView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.resourceQuoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceQuoteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            chartCalculatedField1.DisplayName = "CalculatedField1";
            chartCalculatedField1.Name = "CalculatedField1";
            this.chartControl1.CalculatedFields.AddRange(new DevExpress.XtraCharts.ChartCalculatedField[] {
            chartCalculatedField1});
            this.chartControl1.DataSource = this.resourceQuoteBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center;
            this.chartControl1.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.CheckBoxAndMarker;
            this.chartControl1.Legend.MarkerSize = new System.Drawing.Size(17, 25);
            this.chartControl1.Location = new System.Drawing.Point(12, 12);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "date";
            series1.Name = "철광석";
            series1.ValueDataMembersSerializable = "Iron_Ore_Quote";
            series1.View = lineSeriesView1;
            series2.ArgumentDataMember = "date";
            series2.Name = "니켈";
            series2.ValueDataMembersSerializable = "Nikel_Quote";
            series2.View = lineSeriesView2;
            series3.ArgumentDataMember = "date";
            series3.Name = "알루미늄";
            series3.ValueDataMembersSerializable = "Aluminum_Quote";
            series3.View = lineSeriesView3;
            series4.ArgumentDataMember = "date";
            series4.Name = "구리";
            series4.ValueDataMembersSerializable = "Copper_Quote";
            series4.View = lineSeriesView4;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3,
        series4};
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "date";
            this.chartControl1.Size = new System.Drawing.Size(686, 526);
            this.chartControl1.TabIndex = 0;
            // 
            // resourceQuoteBindingSource
            // 
            this.resourceQuoteBindingSource.DataSource = typeof(MiniSteelworksMES.Data.Resource_Quote);
            // 
            // ResourceQuoteForm_Dev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 552);
            this.Controls.Add(this.chartControl1);
            this.Name = "ResourceQuoteForm_Dev";
            this.Text = "ResourceQuoteForm_Dev";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceQuoteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource resourceQuoteBindingSource;
    }
}