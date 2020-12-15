using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesUI
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public bool loginState = false;

        public Dictionary<string, Form> dictForm = new Dictionary<string, Form>();

        public void HideLoginForm()
        {
            LogInForm1 form = (LogInForm1)dictForm["loginForm"];
            form.Hide();
        }

        public void ShowForm(int index = 0)
        {
            if (index == 10)
            {
                LogInForm2 form = (LogInForm2)dictForm["loginForm2"];
                form.Show();
                form.Activate();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LogInForm1 loginForm = new LogInForm1();
            loginForm.MdiParent = this;
            dictForm.Add("loginForm", loginForm);

            loginForm.Width = 900;
            loginForm.Height = 600;

            LogInForm2 login2Form = new LogInForm2();
            login2Form.MdiParent = this;
            dictForm.Add("loginForm2", login2Form);

            loginForm.Show();
        }
        public void ShowForm(string formName)
        {
            Form form = (Form)dictForm[formName];
            if (form != null)
            {
                    form.Show();
                    form.Activate();               
            }
        }
        private void ShowChildForm(Form form)
        {
            if (loginState == true)
            {
                form.MdiParent = this;
                form.Show();
            }
            else if (loginState == false)
            {
                this.Show();
            }
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new StaffManagement());
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new TransactionStock());
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new MaterialOrderManagement());
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new WarehouseManagement());
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new ResourceQuoteForm());
        }

        private void RibbonControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loginState == false)
                return;

            HideLoginForm();
        }
    }
}
