
namespace MesUI
{
    partial class ExpenseForm
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
            DevExpress.XtraCharts.XYDiagram3D xyDiagram3D1 = new DevExpress.XtraCharts.XYDiagram3D();
            DevExpress.XtraCharts.Line3DSeriesView line3DSeriesView1 = new DevExpress.XtraCharts.Line3DSeriesView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.bdsExpense = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(line3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.bdsExpense;
            xyDiagram3D1.AxisY.Interlaced = false;
            xyDiagram3D1.AxisY.MinorCount = 2;
            xyDiagram3D1.RotationMatrixSerializable = "-0.999615669060522;-0.0156085059887642;-0.022910449788652;0;-0.0175629249545107;0" +
    ".995988087421189;0.087745503486779;0;0.0214489588502941;0.0881141546853001;-0.99" +
    "5879429403159;0;0;0;0;1";
            this.chartControl1.Diagram = xyDiagram3D1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "CategoryName";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Date";
            this.chartControl1.SeriesTemplate.SeriesDataMember = "CategoryName";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Cost";
            this.chartControl1.SeriesTemplate.View = line3DSeriesView1;
            this.chartControl1.Size = new System.Drawing.Size(940, 554);
            this.chartControl1.TabIndex = 0;
            // 
            // bdsExpense
            // 
            this.bdsExpense.DataSource = typeof(MiniSteelworksMES.Data.Expense);
            // 
            // ExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 554);
            this.Controls.Add(this.chartControl1);
            this.Name = "ExpenseForm";
            this.Text = "Expense";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(line3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsExpense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource bdsExpense;
    }
}