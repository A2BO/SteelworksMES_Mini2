﻿
namespace MesUI
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.loginButton = new System.Windows.Forms.Button();
            this.usrIdText = new System.Windows.Forms.TextBox();
            this.passwdText = new System.Windows.Forms.TextBox();
            this.tealLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tealLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loginButton.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginButton.Location = new System.Drawing.Point(471, 301);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(143, 56);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "로그인";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usrIdText
            // 
            this.usrIdText.Location = new System.Drawing.Point(321, 300);
            this.usrIdText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usrIdText.Name = "usrIdText";
            this.usrIdText.Size = new System.Drawing.Size(142, 25);
            this.usrIdText.TabIndex = 1;
            // 
            // passwdText
            // 
            this.passwdText.Location = new System.Drawing.Point(321, 331);
            this.passwdText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwdText.Name = "passwdText";
            this.passwdText.PasswordChar = '*';
            this.passwdText.Size = new System.Drawing.Size(142, 25);
            this.passwdText.TabIndex = 2;
            this.passwdText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwdText_KeyDown);
            // 
            // tealLogo
            // 
            this.tealLogo.Image = ((System.Drawing.Image)(resources.GetObject("tealLogo.Image")));
            this.tealLogo.Location = new System.Drawing.Point(266, 98);
            this.tealLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tealLogo.Name = "tealLogo";
            this.tealLogo.Size = new System.Drawing.Size(377, 182);
            this.tealLogo.TabIndex = 2;
            this.tealLogo.TabStop = false;
            this.tealLogo.Click += new System.EventHandler(this.tealLogo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(215, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "원자재 재고 관리 시스템";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "직원 ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "암호";
            // 
            // LogInForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 594);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tealLogo);
            this.Controls.Add(this.passwdText);
            this.Controls.Add(this.usrIdText);
            this.Controls.Add(this.loginButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LogInForm1";
            this.Text = "로그인 화면";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.LogInForm1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.tealLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox usrIdText;
        private System.Windows.Forms.TextBox passwdText;
        private System.Windows.Forms.PictureBox tealLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}