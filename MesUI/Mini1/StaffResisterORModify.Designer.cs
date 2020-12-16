
namespace MesUI
{
    partial class StaffResisterORModify
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StaffModifyOrRegisterButton = new System.Windows.Forms.Button();
            this.EmployeeId = new System.Windows.Forms.TextBox();
            this.Position = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.StaffName = new System.Windows.Forms.TextBox();
            this.StaffInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BossID = new System.Windows.Forms.TextBox();
            this.Team = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "성      함";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "직      책";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "연  락 처";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "주      소";
            // 
            // StaffModifyOrRegisterButton
            // 
            this.StaffModifyOrRegisterButton.Location = new System.Drawing.Point(126, 246);
            this.StaffModifyOrRegisterButton.Name = "StaffModifyOrRegisterButton";
            this.StaffModifyOrRegisterButton.Size = new System.Drawing.Size(75, 23);
            this.StaffModifyOrRegisterButton.TabIndex = 20;
            this.StaffModifyOrRegisterButton.Text = "수정/등록";
            this.StaffModifyOrRegisterButton.UseVisualStyleBackColor = true;
            this.StaffModifyOrRegisterButton.Click += new System.EventHandler(this.StaffModifyOrRegisterButton_Click);
            // 
            // EmployeeId
            // 
            this.EmployeeId.Location = new System.Drawing.Point(75, 48);
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Size = new System.Drawing.Size(126, 21);
            this.EmployeeId.TabIndex = 51;
            // 
            // Position
            // 
            this.Position.Location = new System.Drawing.Point(75, 105);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(126, 21);
            this.Position.TabIndex = 50;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(75, 159);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(126, 21);
            this.Address.TabIndex = 49;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(75, 186);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(126, 21);
            this.PhoneNumber.TabIndex = 48;
            // 
            // StaffName
            // 
            this.StaffName.Location = new System.Drawing.Point(75, 75);
            this.StaffName.Name = "StaffName";
            this.StaffName.Size = new System.Drawing.Size(126, 21);
            this.StaffName.TabIndex = 47;
            // 
            // StaffInfo
            // 
            this.StaffInfo.AutoSize = true;
            this.StaffInfo.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StaffInfo.Location = new System.Drawing.Point(34, 12);
            this.StaffInfo.Name = "StaffInfo";
            this.StaffInfo.Size = new System.Drawing.Size(152, 21);
            this.StaffInfo.TabIndex = 52;
            this.StaffInfo.Text = "직원 수정/등록";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 53;
            this.label2.Text = "BossID";
            // 
            // BossID
            // 
            this.BossID.Location = new System.Drawing.Point(75, 132);
            this.BossID.Name = "BossID";
            this.BossID.Size = new System.Drawing.Size(126, 21);
            this.BossID.TabIndex = 54;
            // 
            // Team
            // 
            this.Team.Location = new System.Drawing.Point(75, 213);
            this.Team.Name = "Team";
            this.Team.Size = new System.Drawing.Size(126, 21);
            this.Team.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 12);
            this.label6.TabIndex = 55;
            this.label6.Text = "소     속";
            // 
            // StaffResisterORModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 287);
            this.Controls.Add(this.Team);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BossID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StaffInfo);
            this.Controls.Add(this.EmployeeId);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.StaffName);
            this.Controls.Add(this.StaffModifyOrRegisterButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "StaffResisterORModify";
            this.Text = "StaffRegister";
            this.Load += new System.EventHandler(this.StaffResisterORModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button StaffModifyOrRegisterButton;
        private System.Windows.Forms.TextBox EmployeeId;
        private System.Windows.Forms.TextBox Position;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.TextBox StaffName;
        private System.Windows.Forms.Label StaffInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BossID;
        private System.Windows.Forms.TextBox Team;
        private System.Windows.Forms.Label label6;
    }
}