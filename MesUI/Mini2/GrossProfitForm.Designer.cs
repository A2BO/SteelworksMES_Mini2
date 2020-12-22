
namespace MesUI
{
    partial class GrossProfitForm
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
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.grossProfitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCost = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategory = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grossProfitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.grossProfitBindingSource;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldName,
            this.fieldDate,
            this.fieldCost,
            this.fieldCategory});
            this.pivotGridControl1.Location = new System.Drawing.Point(1, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.Size = new System.Drawing.Size(996, 528);
            this.pivotGridControl1.TabIndex = 2;
            // 
            // grossProfitBindingSource
            // 
            this.grossProfitBindingSource.DataSource = typeof(MiniSteelworksMES.Data.GrossProfit);
            // 
            // fieldName
            // 
            this.fieldName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldName.AreaIndex = 1;
            this.fieldName.FieldName = "Name";
            this.fieldName.Name = "fieldName";
            // 
            // fieldDate
            // 
            this.fieldDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldDate.AreaIndex = 0;
            this.fieldDate.FieldName = "Date";
            this.fieldDate.Name = "fieldDate";
            // 
            // fieldCost
            // 
            this.fieldCost.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCost.AreaIndex = 0;
            this.fieldCost.FieldName = "Cost";
            this.fieldCost.Name = "fieldCost";
            // 
            // fieldCategory
            // 
            this.fieldCategory.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategory.AreaIndex = 0;
            this.fieldCategory.FieldName = "Category";
            this.fieldCategory.Name = "fieldCategory";
            // 
            // GrossProfitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 528);
            this.Controls.Add(this.pivotGridControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GrossProfitForm";
            this.Text = "매출이익";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grossProfitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.BindingSource grossProfitBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDate;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCost;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategory;
    }
}