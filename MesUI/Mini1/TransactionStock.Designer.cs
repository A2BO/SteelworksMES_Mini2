
namespace MesUI
{
    partial class TransactionStock
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.rscTransactionGrid = new System.Windows.Forms.DataGridView();
            this.resourceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wareHouseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsTransaction = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxPageNumber = new System.Windows.Forms.ComboBox();
            this.checkBoxResourceId = new System.Windows.Forms.CheckBox();
            this.comboBoxRscId = new System.Windows.Forms.ComboBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.labelPageNumber = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.rscTransactionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTransaction)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(744, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(825, 18);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "수정";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // rscTransactionGrid
            // 
            this.rscTransactionGrid.AllowUserToAddRows = false;
            this.rscTransactionGrid.AllowUserToDeleteRows = false;
            this.rscTransactionGrid.AutoGenerateColumns = false;
            this.rscTransactionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rscTransactionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resourceIdDataGridViewTextBoxColumn,
            this.sellerNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.originDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.typeTextDataGridViewTextBoxColumn,
            this.wareHouseIdDataGridViewTextBoxColumn});
            this.rscTransactionGrid.DataSource = this.bdsTransaction;
            this.rscTransactionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rscTransactionGrid.Location = new System.Drawing.Point(3, 17);
            this.rscTransactionGrid.Name = "rscTransactionGrid";
            this.rscTransactionGrid.ReadOnly = true;
            this.rscTransactionGrid.RowHeadersVisible = false;
            this.rscTransactionGrid.RowTemplate.Height = 23;
            this.rscTransactionGrid.Size = new System.Drawing.Size(1300, 459);
            this.rscTransactionGrid.TabIndex = 3;
            this.rscTransactionGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rscTransactionGrid_CellContentClick);
            // 
            // resourceIdDataGridViewTextBoxColumn
            // 
            this.resourceIdDataGridViewTextBoxColumn.DataPropertyName = "ResourceId";
            this.resourceIdDataGridViewTextBoxColumn.HeaderText = "원자재 ID";
            this.resourceIdDataGridViewTextBoxColumn.Name = "resourceIdDataGridViewTextBoxColumn";
            this.resourceIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellerNameDataGridViewTextBoxColumn
            // 
            this.sellerNameDataGridViewTextBoxColumn.DataPropertyName = "SellerName";
            this.sellerNameDataGridViewTextBoxColumn.HeaderText = "수입처";
            this.sellerNameDataGridViewTextBoxColumn.Name = "sellerNameDataGridViewTextBoxColumn";
            this.sellerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "시각";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // originDataGridViewTextBoxColumn
            // 
            this.originDataGridViewTextBoxColumn.DataPropertyName = "Origin";
            this.originDataGridViewTextBoxColumn.HeaderText = "원산지";
            this.originDataGridViewTextBoxColumn.Name = "originDataGridViewTextBoxColumn";
            this.originDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "담당자 ID";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeTextDataGridViewTextBoxColumn
            // 
            this.typeTextDataGridViewTextBoxColumn.DataPropertyName = "TypeText";
            this.typeTextDataGridViewTextBoxColumn.HeaderText = "입출고 구분";
            this.typeTextDataGridViewTextBoxColumn.Name = "typeTextDataGridViewTextBoxColumn";
            this.typeTextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wareHouseIdDataGridViewTextBoxColumn
            // 
            this.wareHouseIdDataGridViewTextBoxColumn.DataPropertyName = "WareHouseId";
            this.wareHouseIdDataGridViewTextBoxColumn.HeaderText = "창고 번호";
            this.wareHouseIdDataGridViewTextBoxColumn.Name = "wareHouseIdDataGridViewTextBoxColumn";
            this.wareHouseIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bdsTransaction
            // 
            this.bdsTransaction.DataSource = typeof(MiniSteelworksMES.Data.Transaction);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(272, 18);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerStart.TabIndex = 5;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(537, 18);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerEnd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "시작날짜";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "종료날짜";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxPageNumber);
            this.groupBox2.Controls.Add(this.checkBoxResourceId);
            this.groupBox2.Controls.Add(this.comboBoxRscId);
            this.groupBox2.Controls.Add(this.checkBoxDate);
            this.groupBox2.Controls.Add(this.labelPageNumber);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.dateTimePickerStart);
            this.groupBox2.Controls.Add(this.btnModify);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePickerEnd);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 489);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1306, 79);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // comboBoxPageNumber
            // 
            this.comboBoxPageNumber.FormattingEnabled = true;
            this.comboBoxPageNumber.Location = new System.Drawing.Point(272, 45);
            this.comboBoxPageNumber.Name = "comboBoxPageNumber";
            this.comboBoxPageNumber.Size = new System.Drawing.Size(121, 20);
            this.comboBoxPageNumber.TabIndex = 10;
            this.comboBoxPageNumber.SelectedIndexChanged += new System.EventHandler(this.comboBoxPageNumber_SelectedIndexChanged);
            // 
            // checkBoxResourceId
            // 
            this.checkBoxResourceId.AutoSize = true;
            this.checkBoxResourceId.Location = new System.Drawing.Point(6, 42);
            this.checkBoxResourceId.Name = "checkBoxResourceId";
            this.checkBoxResourceId.Size = new System.Drawing.Size(75, 16);
            this.checkBoxResourceId.TabIndex = 8;
            this.checkBoxResourceId.Text = "원자재 ID";
            this.checkBoxResourceId.UseVisualStyleBackColor = true;
            // 
            // comboBoxRscId
            // 
            this.comboBoxRscId.FormattingEnabled = true;
            this.comboBoxRscId.Location = new System.Drawing.Point(87, 40);
            this.comboBoxRscId.Name = "comboBoxRscId";
            this.comboBoxRscId.Size = new System.Drawing.Size(121, 20);
            this.comboBoxRscId.TabIndex = 9;
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Location = new System.Drawing.Point(6, 20);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(48, 16);
            this.checkBoxDate.TabIndex = 8;
            this.checkBoxDate.Text = "기간";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            // 
            // labelPageNumber
            // 
            this.labelPageNumber.AutoSize = true;
            this.labelPageNumber.Location = new System.Drawing.Point(232, 48);
            this.labelPageNumber.Name = "labelPageNumber";
            this.labelPageNumber.Size = new System.Drawing.Size(34, 12);
            this.labelPageNumber.TabIndex = 7;
            this.labelPageNumber.Text = "Page";
            this.labelPageNumber.MouseLeave += new System.EventHandler(this.labelPage1_MouseLeave);
            this.labelPageNumber.MouseHover += new System.EventHandler(this.labelPage1_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rscTransactionGrid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1306, 479);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // TransactionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 594);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "TransactionStock";
            this.Text = "원자재 입출고 조회";
            this.Load += new System.EventHandler(this.TransactionStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rscTransactionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTransaction)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridView rscTransactionGrid;
        private System.Windows.Forms.BindingSource bdsTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wareHouseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.CheckBox checkBoxResourceId;
        private System.Windows.Forms.Label labelPageNumber;
        private System.Windows.Forms.ComboBox comboBoxRscId;
        private System.Windows.Forms.ComboBox comboBoxPageNumber;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}