
namespace MesUI
{
    partial class GrossProfit
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.BubbleSeriesView bubbleSeriesView1 = new DevExpress.XtraCharts.BubbleSeriesView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.originModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bubbleSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.originModelBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Location = new System.Drawing.Point(12, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "OriginId";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "OriginId";
            this.chartControl1.SeriesTemplate.SeriesDataMember = "OriginId";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Quantity;Quantity";
            this.chartControl1.SeriesTemplate.View = bubbleSeriesView1;
            this.chartControl1.Size = new System.Drawing.Size(974, 504);
            this.chartControl1.TabIndex = 1;
            // 
            // originModelBindingSource
            // 
            this.originModelBindingSource.DataSource = typeof(MiniSteelworksMES.Data.OriginModel);
            // 
            // GrossProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 528);
            this.Controls.Add(this.chartControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GrossProfit";
            this.Text = "GrossProfit";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bubbleSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource originModelBindingSource;
    }
}