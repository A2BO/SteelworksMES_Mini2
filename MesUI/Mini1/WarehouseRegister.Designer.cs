
namespace MesUI
{
    partial class WarehouseRegister
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
            this.WarehouseAddBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWarehouseId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWarehouseAreaSize = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.textBoxWarehousePhoneNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WarehouseAddBtn
            // 
            this.WarehouseAddBtn.Location = new System.Drawing.Point(118, 134);
            this.WarehouseAddBtn.Name = "WarehouseAddBtn";
            this.WarehouseAddBtn.Size = new System.Drawing.Size(75, 23);
            this.WarehouseAddBtn.TabIndex = 41;
            this.WarehouseAddBtn.Text = "추가";
            this.WarehouseAddBtn.UseVisualStyleBackColor = true;
            this.WarehouseAddBtn.Click += new System.EventHandler(this.WarehouseAddBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "창고 연락처";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "담   당   자";
            // 
            // textBoxWarehouseId
            // 
            this.textBoxWarehouseId.Location = new System.Drawing.Point(77, 10);
            this.textBoxWarehouseId.Name = "textBoxWarehouseId";
            this.textBoxWarehouseId.Size = new System.Drawing.Size(116, 21);
            this.textBoxWarehouseId.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "창고 면적";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "창고 ID ";
            // 
            // textBoxWarehouseAreaSize
            // 
            this.textBoxWarehouseAreaSize.Location = new System.Drawing.Point(77, 40);
            this.textBoxWarehouseAreaSize.Name = "textBoxWarehouseAreaSize";
            this.textBoxWarehouseAreaSize.Size = new System.Drawing.Size(116, 21);
            this.textBoxWarehouseAreaSize.TabIndex = 42;
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Location = new System.Drawing.Point(77, 69);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(116, 21);
            this.textBoxEmployeeId.TabIndex = 43;
            // 
            // textBoxWarehousePhoneNumber
            // 
            this.textBoxWarehousePhoneNumber.Location = new System.Drawing.Point(77, 98);
            this.textBoxWarehousePhoneNumber.Name = "textBoxWarehousePhoneNumber";
            this.textBoxWarehousePhoneNumber.Size = new System.Drawing.Size(116, 21);
            this.textBoxWarehousePhoneNumber.TabIndex = 44;
            // 
            // WarehouseRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 172);
            this.Controls.Add(this.textBoxWarehousePhoneNumber);
            this.Controls.Add(this.textBoxEmployeeId);
            this.Controls.Add(this.textBoxWarehouseAreaSize);
            this.Controls.Add(this.WarehouseAddBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxWarehouseId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WarehouseRegister";
            this.Text = "창고 등록";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button WarehouseAddBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWarehouseId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWarehouseAreaSize;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.TextBox textBoxWarehousePhoneNumber;
    }
}