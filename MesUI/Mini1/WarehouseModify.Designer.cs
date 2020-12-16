
namespace MesUI
{
    partial class WarehouseModify
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
            this.textBoxWarehousePhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.textBoxWarehouseAreaSize = new System.Windows.Forms.TextBox();
            this.WarehouseModifyBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWarehouseId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxWarehousePhoneNumber
            // 
            this.textBoxWarehousePhoneNumber.Location = new System.Drawing.Point(101, 103);
            this.textBoxWarehousePhoneNumber.Name = "textBoxWarehousePhoneNumber";
            this.textBoxWarehousePhoneNumber.Size = new System.Drawing.Size(116, 21);
            this.textBoxWarehousePhoneNumber.TabIndex = 53;
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Location = new System.Drawing.Point(101, 74);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(116, 21);
            this.textBoxEmployeeId.TabIndex = 52;
            // 
            // textBoxWarehouseAreaSize
            // 
            this.textBoxWarehouseAreaSize.Location = new System.Drawing.Point(101, 45);
            this.textBoxWarehouseAreaSize.Name = "textBoxWarehouseAreaSize";
            this.textBoxWarehouseAreaSize.Size = new System.Drawing.Size(116, 21);
            this.textBoxWarehouseAreaSize.TabIndex = 51;
            // 
            // WarehouseModifyBtn
            // 
            this.WarehouseModifyBtn.Location = new System.Drawing.Point(142, 139);
            this.WarehouseModifyBtn.Name = "WarehouseModifyBtn";
            this.WarehouseModifyBtn.Size = new System.Drawing.Size(75, 23);
            this.WarehouseModifyBtn.TabIndex = 50;
            this.WarehouseModifyBtn.Text = "수정";
            this.WarehouseModifyBtn.UseVisualStyleBackColor = true;
            this.WarehouseModifyBtn.Click += new System.EventHandler(this.WarehouseModifyBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 49;
            this.label4.Text = "창고 연락처";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 48;
            this.label3.Text = "담   당   자";
            // 
            // textBoxWarehouseId
            // 
            this.textBoxWarehouseId.Enabled = false;
            this.textBoxWarehouseId.Location = new System.Drawing.Point(101, 15);
            this.textBoxWarehouseId.Name = "textBoxWarehouseId";
            this.textBoxWarehouseId.Size = new System.Drawing.Size(116, 21);
            this.textBoxWarehouseId.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 46;
            this.label2.Text = "창고 면적";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
            this.label1.TabIndex = 45;
            this.label1.Text = "창고 ID ";
            // 
            // WarehouseModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 174);
            this.Controls.Add(this.textBoxWarehousePhoneNumber);
            this.Controls.Add(this.textBoxEmployeeId);
            this.Controls.Add(this.textBoxWarehouseAreaSize);
            this.Controls.Add(this.WarehouseModifyBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxWarehouseId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WarehouseModify";
            this.Text = "창고 정보 수정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWarehousePhoneNumber;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.TextBox textBoxWarehouseAreaSize;
        private System.Windows.Forms.Button WarehouseModifyBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWarehouseId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}