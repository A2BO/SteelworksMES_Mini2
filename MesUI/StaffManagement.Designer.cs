
namespace MesUI
{
    partial class StaffManagement
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxStaffName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textboxAddress = new System.Windows.Forms.TextBox();
            this.buttonModifyEmployee = new System.Windows.Forms.Button();
            this.buttonAddNewEmployee = new System.Windows.Forms.Button();
            this.textboxStaffPosition = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonStaffSearch = new System.Windows.Forms.Button();
            this.textboxStaffId = new System.Windows.Forms.TextBox();
            this.treeViewEmployee = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonClearAllForm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxBossId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textboxTeamName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "직책";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "연락처";
            // 
            // textboxStaffName
            // 
            this.textboxStaffName.Location = new System.Drawing.Point(519, 81);
            this.textboxStaffName.Name = "textboxStaffName";
            this.textboxStaffName.Size = new System.Drawing.Size(113, 21);
            this.textboxStaffName.TabIndex = 2;
            this.textboxStaffName.Leave += new System.EventHandler(this.textboxStaffName_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 31;
            this.label8.Text = "주소";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "이름";
            // 
            // textboxPhoneNumber
            // 
            this.textboxPhoneNumber.Location = new System.Drawing.Point(519, 166);
            this.textboxPhoneNumber.Name = "textboxPhoneNumber";
            this.textboxPhoneNumber.Size = new System.Drawing.Size(113, 21);
            this.textboxPhoneNumber.TabIndex = 5;
            this.textboxPhoneNumber.Leave += new System.EventHandler(this.textboxPhoneNumber_Leave);
            // 
            // textboxAddress
            // 
            this.textboxAddress.Location = new System.Drawing.Point(519, 248);
            this.textboxAddress.Name = "textboxAddress";
            this.textboxAddress.Size = new System.Drawing.Size(271, 21);
            this.textboxAddress.TabIndex = 8;
            // 
            // buttonModifyEmployee
            // 
            this.buttonModifyEmployee.Location = new System.Drawing.Point(540, 357);
            this.buttonModifyEmployee.Name = "buttonModifyEmployee";
            this.buttonModifyEmployee.Size = new System.Drawing.Size(92, 23);
            this.buttonModifyEmployee.TabIndex = 11;
            this.buttonModifyEmployee.Text = "수정";
            this.buttonModifyEmployee.UseVisualStyleBackColor = true;
            this.buttonModifyEmployee.Click += new System.EventHandler(this.buttonModifyEmployee_Click);
            // 
            // buttonAddNewEmployee
            // 
            this.buttonAddNewEmployee.Location = new System.Drawing.Point(736, 357);
            this.buttonAddNewEmployee.Name = "buttonAddNewEmployee";
            this.buttonAddNewEmployee.Size = new System.Drawing.Size(92, 23);
            this.buttonAddNewEmployee.TabIndex = 13;
            this.buttonAddNewEmployee.Text = "새직원 등록";
            this.buttonAddNewEmployee.UseVisualStyleBackColor = true;
            this.buttonAddNewEmployee.Click += new System.EventHandler(this.buttonAddNewEmployee_Click);
            // 
            // textboxStaffPosition
            // 
            this.textboxStaffPosition.Location = new System.Drawing.Point(519, 112);
            this.textboxStaffPosition.Name = "textboxStaffPosition";
            this.textboxStaffPosition.Size = new System.Drawing.Size(113, 21);
            this.textboxStaffPosition.TabIndex = 3;
            this.textboxStaffPosition.Leave += new System.EventHandler(this.textboxStaffPosition_Leave);
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Location = new System.Drawing.Point(519, 305);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(111, 21);
            this.textBoxEmployeeId.TabIndex = 9;
            this.textBoxEmployeeId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 12);
            this.label5.TabIndex = 45;
            this.label5.Text = "직원 ID";
            // 
            // buttonStaffSearch
            // 
            this.buttonStaffSearch.Location = new System.Drawing.Point(444, 357);
            this.buttonStaffSearch.Name = "buttonStaffSearch";
            this.buttonStaffSearch.Size = new System.Drawing.Size(92, 23);
            this.buttonStaffSearch.TabIndex = 10;
            this.buttonStaffSearch.Text = "조회";
            this.buttonStaffSearch.UseVisualStyleBackColor = true;
            this.buttonStaffSearch.Click += new System.EventHandler(this.buttonStaffSearch_Click);
            // 
            // textboxStaffId
            // 
            this.textboxStaffId.Enabled = false;
            this.textboxStaffId.Location = new System.Drawing.Point(519, 52);
            this.textboxStaffId.Name = "textboxStaffId";
            this.textboxStaffId.Size = new System.Drawing.Size(113, 21);
            this.textboxStaffId.TabIndex = 1;
            // 
            // treeViewEmployee
            // 
            this.treeViewEmployee.Font = new System.Drawing.Font("HYsupB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.treeViewEmployee.Location = new System.Drawing.Point(12, 12);
            this.treeViewEmployee.Name = "treeViewEmployee";
            this.treeViewEmployee.Size = new System.Drawing.Size(404, 529);
            this.treeViewEmployee.TabIndex = 11;
            this.treeViewEmployee.TabStop = false;
            this.treeViewEmployee.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewEmployee_NodeMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 47;
            this.label2.Text = "직원 ID";
            // 
            // buttonClearAllForm
            // 
            this.buttonClearAllForm.Location = new System.Drawing.Point(638, 357);
            this.buttonClearAllForm.Name = "buttonClearAllForm";
            this.buttonClearAllForm.Size = new System.Drawing.Size(92, 23);
            this.buttonClearAllForm.TabIndex = 12;
            this.buttonClearAllForm.Text = "새직원 추가";
            this.buttonClearAllForm.UseVisualStyleBackColor = true;
            this.buttonClearAllForm.Click += new System.EventHandler(this.buttonRegisterEmployee_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "담당상사ID";
            // 
            // textboxBossId
            // 
            this.textboxBossId.Location = new System.Drawing.Point(519, 139);
            this.textboxBossId.Name = "textboxBossId";
            this.textboxBossId.Size = new System.Drawing.Size(113, 21);
            this.textboxBossId.TabIndex = 4;
            this.textboxBossId.Leave += new System.EventHandler(this.textboxStaffPosition_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "팀";
            // 
            // textboxTeamName
            // 
            this.textboxTeamName.Location = new System.Drawing.Point(519, 193);
            this.textboxTeamName.Name = "textboxTeamName";
            this.textboxTeamName.Size = new System.Drawing.Size(113, 21);
            this.textboxTeamName.TabIndex = 6;
            this.textboxTeamName.Leave += new System.EventHandler(this.textboxPhoneNumber_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(444, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 12);
            this.label9.TabIndex = 27;
            this.label9.Text = "로그인 암호";
            // 
            // textboxPassword
            // 
            this.textboxPassword.Location = new System.Drawing.Point(519, 221);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.Size = new System.Drawing.Size(113, 21);
            this.textboxPassword.TabIndex = 7;
            this.textboxPassword.Leave += new System.EventHandler(this.textboxPhoneNumber_Leave);
            // 
            // StaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 577);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeViewEmployee);
            this.Controls.Add(this.textboxStaffId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonStaffSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textboxStaffName);
            this.Controls.Add(this.textBoxEmployeeId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textboxBossId);
            this.Controls.Add(this.textboxStaffPosition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClearAllForm);
            this.Controls.Add(this.buttonAddNewEmployee);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.textboxTeamName);
            this.Controls.Add(this.textboxPhoneNumber);
            this.Controls.Add(this.buttonModifyEmployee);
            this.Controls.Add(this.textboxAddress);
            this.Name = "StaffManagement";
            this.Text = "직원 관리 화면";
            this.Load += new System.EventHandler(this.StaffManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxStaffName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxPhoneNumber;
        private System.Windows.Forms.TextBox textboxAddress;
        private System.Windows.Forms.Button buttonModifyEmployee;
        private System.Windows.Forms.Button buttonAddNewEmployee;
        private System.Windows.Forms.TextBox textboxStaffPosition;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonStaffSearch;
        private System.Windows.Forms.TextBox textboxStaffId;
        private System.Windows.Forms.TreeView treeViewEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonClearAllForm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textboxBossId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textboxTeamName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textboxPassword;
    }
}