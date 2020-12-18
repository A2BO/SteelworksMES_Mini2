
namespace MesUI
{
    partial class PurchaceFromOriginQuantity
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
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.pieChartDataAdapter1 = new DevExpress.XtraMap.PieChartDataAdapter();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Layers.Add(this.vectorItemsLayer1);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(800, 450);
            this.mapControl1.TabIndex = 0;
            this.bingMapDataProvider1.BingKey = "AgvMO35OGV6SrETYJ66iBZkuemtqDfYvwqHv4in8tjYI7TJU5zG5SZYI-3l-vZZC";
            this.bingMapDataProvider1.Kind = DevExpress.XtraMap.BingMapKind.Road;
            this.imageLayer1.DataProvider = this.bingMapDataProvider1;
            this.vectorItemsLayer1.Data = this.pieChartDataAdapter1;
            this.pieChartDataAdapter1.DataSource = this.transactionBindingSource;
            this.pieChartDataAdapter1.Mappings.Latitude = "Latitude_Member";
            this.pieChartDataAdapter1.Mappings.Longitude = "Longgitude_Member";
            this.pieChartDataAdapter1.Mappings.PieSegment = "ResourceId";
            this.pieChartDataAdapter1.Mappings.Text = "Origin";
            this.pieChartDataAdapter1.Mappings.Value = "Quantity";
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(MiniSteelworksMES.Data.Transaction);
            // 
            // PurchaceFromOriginQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mapControl1);
            this.Name = "PurchaceFromOriginQuantity";
            this.Text = "PurchaceFromOriginQuantity";
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
        private DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1;
        private DevExpress.XtraMap.PieChartDataAdapter pieChartDataAdapter1;
        private System.Windows.Forms.BindingSource transactionBindingSource;
    }
}