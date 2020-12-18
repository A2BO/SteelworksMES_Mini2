
namespace MesUI
{
    partial class ResourcePurchaceQuantity
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
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D2 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView2 = new DevExpress.XtraCharts.Pie3DSeriesView();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            this.transactionModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.transactionModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionModelBindingSource
            // 
            this.transactionModelBindingSource.DataSource = typeof(MiniSteelworksMES.Data.TransactionModel);
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            simpleDiagram3D2.RotationMatrixSerializable = "0.894733058655824;-0.0229494406100824;-0.44601129685702;0;-0.293941004764802;0.72" +
    "1610757569171;-0.626798691988351;0;0.336231229165666;0.69191851957881;0.63890321" +
    "8647093;0;0;0;0;1";
            this.chartControl1.Diagram = simpleDiagram3D2;
            this.chartControl1.Location = new System.Drawing.Point(12, 12);
            this.chartControl1.Name = "chartControl1";
            series2.ArgumentDataMember = "ResourceId";
            series2.DataSource = this.transactionModelBindingSource;
            series2.LegendTextPattern = "{A}";
            series2.Name = "Series 1";
            series2.ValueDataMembersSerializable = "Quantity";
            series2.View = pie3DSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl1.SeriesTemplate.View = lineSeriesView2;
            this.chartControl1.Size = new System.Drawing.Size(1121, 618);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Click += new System.EventHandler(this.chartControl1_Click);
            // 
            // ResourcePurchaceQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 642);
            this.Controls.Add(this.chartControl1);
            this.Name = "ResourcePurchaceQuantity";
            this.Text = "광물별 구매비율";
            ((System.ComponentModel.ISupportInitialize)(this.transactionModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource transactionModelBindingSource;
    }
}