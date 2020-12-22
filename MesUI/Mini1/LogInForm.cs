using MiniSteelworksMES.Data;
using MiniSteelworksMES.Data.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace MesUI
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (Dao.Employee.VerifyIdPassword(usrIdText.Text, passwdText.Text))
            {
                MessageBox.Show(Dao.Employee.GetName(usrIdText.Text) + "님 안녕하세요!", "로그인 성공");
                ((MainForm)(this.MdiParent)).loginState = true;
                ((MainForm)(this.MdiParent)).ShowForm("loginForm2");
                ((MainForm)(this.MdiParent)).HideLoginForm();


            }
            else
            {
                MessageBox.Show("ID 또는 암호가 틀렸습니다!", "로그인 실패");
                ((MainForm)(this.MdiParent)).loginState = false;
            }
        }

        private void tealLogo_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(usrNameText.Text + "님, 안녕하세요!");

            //if (Dao.Employee.VerifyIdPassword(usrNameText.Text, passwdText.Text))
            //    loginstate = true;// MessageBox.Show(usrNameText.Text + "인증 성공");
            ////LogInForm2 form1 = (LogInForm2)((Form1)(this.MdiParent)).dictForm["loginForm2"];
            //((Form1)(this.MdiParent)).ShowForm("loginForm2");
        }

        private void LogInForm1_Activated(object sender, EventArgs e)
        {
            usrIdText.Focus();
        }

        private void LogInForm1_Shown(object sender, EventArgs e)
        {
            usrIdText.Focus();
        }

        private void passwdText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender, e);
            }
        }
    }
}
