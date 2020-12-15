
namespace MesUI
{
    partial class WarehouseManagement
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wareHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddWarehousebtn = new System.Windows.Forms.Button();
            this.DeleteWarehousebtn = new System.Windows.Forms.Button();
            this.ModifyWarehousebtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchWarehouse = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.resourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AllBtn = new System.Windows.Forms.Button();
            this.wareHouseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wareHouseIdDataGridViewTextBoxColumn,
            this.areaSizeDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wareHouseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(546, 135);
            this.dataGridView1.TabIndex = 1;
            // 
            // wareHouseBindingSource
            // 
            this.wareHouseBindingSource.DataSource = typeof(MiniSteelworksMES.Data.WareHouse);
            // 
            // AddWarehousebtn
            // 
            this.AddWarehousebtn.Location = new System.Drawing.Point(404, 421);
            this.AddWarehousebtn.Name = "AddWarehousebtn";
            this.AddWarehousebtn.Size = new System.Drawing.Size(75, 23);
            this.AddWarehousebtn.TabIndex = 3;
            this.AddWarehousebtn.Text = "추가";
            this.AddWarehousebtn.UseVisualStyleBackColor = true;
            this.AddWarehousebtn.Click += new System.EventHandler(this.AddWarehousebtn_Click);
            // 
            // DeleteWarehousebtn
            // 
            this.DeleteWarehousebtn.Location = new System.Drawing.Point(483, 421);
            this.DeleteWarehousebtn.Name = "DeleteWarehousebtn";
            this.DeleteWarehousebtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteWarehousebtn.TabIndex = 4;
            this.DeleteWarehousebtn.Text = "삭제";
            this.DeleteWarehousebtn.UseVisualStyleBackColor = true;
            this.DeleteWarehousebtn.Click += new System.EventHandler(this.DeleteWarehousebtn_Click);
            // 
            // ModifyWarehousebtn
            // 
            this.ModifyWarehousebtn.Location = new System.Drawing.Point(323, 421);
            this.ModifyWarehousebtn.Name = "ModifyWarehousebtn";
            this.ModifyWarehousebtn.Size = new System.Drawing.Size(75, 23);
            this.ModifyWarehousebtn.TabIndex = 5;
            this.ModifyWarehousebtn.Text = "수정";
            this.ModifyWarehousebtn.UseVisualStyleBackColor = true;
            this.ModifyWarehousebtn.Click += new System.EventHandler(this.ModifyWarehousebtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(142, 421);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "조회";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchWarehouse
            // 
            this.SearchWarehouse.FormattingEnabled = true;
            this.SearchWarehouse.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.SearchWarehouse.Location = new System.Drawing.Point(15, 423);
            this.SearchWarehouse.Name = "SearchWarehouse";
            this.SearchWarehouse.Size = new System.Drawing.Size(121, 20);
            this.SearchWarehouse.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryDataGridViewTextBoxColumn,
            this.resourceIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.sellerNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.resourceBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 153);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(546, 254);
            this.dataGridView2.TabIndex = 2;
            // 
            // resourceBindingSource
            // 
            this.resourceBindingSource.DataSource = typeof(MiniSteelworksMES.Data.Resource);
            // 
            // AllBtn
            // 
            this.AllBtn.Location = new System.Drawing.Point(242, 421);
            this.AllBtn.Name = "AllBtn";
            this.AllBtn.Size = new System.Drawing.Size(75, 23);
            this.AllBtn.TabIndex = 8;
            this.AllBtn.Text = "전체";
            this.AllBtn.UseVisualStyleBackColor = true;
            this.AllBtn.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // wareHouseIdDataGridViewTextBoxColumn
            // 
            this.wareHouseIdDataGridViewTextBoxColumn.DataPropertyName = "WareHouseId";
            this.wareHouseIdDataGridViewTextBoxColumn.Frozen = true;
            this.wareHouseIdDataGridViewTextBoxColumn.HeaderText = "창고 ID";
            this.wareHouseIdDataGridViewTextBoxColumn.Name = "wareHouseIdDataGridViewTextBoxColumn";
            this.wareHouseIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // areaSizeDataGridViewTextBoxColumn
            // 
            this.areaSizeDataGridViewTextBoxColumn.DataPropertyName = "AreaSize";
            this.areaSizeDataGridViewTextBoxColumn.Frozen = true;
            this.areaSizeDataGridViewTextBoxColumn.HeaderText = "창고 면적";
            this.areaSizeDataGridViewTextBoxColumn.Name = "areaSizeDataGridViewTextBoxColumn";
            this.areaSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Frozen = true;
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "담당자";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "창고 전화번호";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 200;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "창고 ID";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resourceIdDataGridViewTextBoxColumn
            // 
            this.resourceIdDataGridViewTextBoxColumn.DataPropertyName = "ResourceId";
            this.resourceIdDataGridViewTextBoxColumn.HeaderText = "원자재 ID";
            this.resourceIdDataGridViewTextBoxColumn.Name = "resourceIdDataGridViewTextBoxColumn";
            this.resourceIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "원자재";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "재고량";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellerNameDataGridViewTextBoxColumn
            // 
            this.sellerNameDataGridViewTextBoxColumn.DataPropertyName = "SellerName";
            this.sellerNameDataGridViewTextBoxColumn.HeaderText = "수입처";
            this.sellerNameDataGridViewTextBoxColumn.Name = "sellerNameDataGridViewTextBoxColumn";
            this.sellerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // WarehouseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 464);
            this.Controls.Add(this.AllBtn);
            this.Controls.Add(this.SearchWarehouse);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.ModifyWarehousebtn);
            this.Controls.Add(this.DeleteWarehousebtn);
            this.Controls.Add(this.AddWarehousebtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WarehouseManagement";
            this.Text = "창고 관리 및 조회";
            this.Load += new System.EventHandler(this.WarehouseManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddWarehousebtn;
        private System.Windows.Forms.Button DeleteWarehousebtn;
        private System.Windows.Forms.Button ModifyWarehousebtn;
        private System.Windows.Forms.BindingSource wareHouseBindingSource;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.ComboBox SearchWarehouse;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource resourceBindingSource;
        private System.Windows.Forms.Button AllBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wareHouseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerNameDataGridViewTextBoxColumn;
    }
}