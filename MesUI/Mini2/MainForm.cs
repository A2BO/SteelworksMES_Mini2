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

            //loginForm.Width = 900;
            //loginForm.Height = 600;

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
                MessageBox.Show("로그인이 필요합니다.");
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
            ShowChildForm(new ResourceQuote_Dev());
        }

        private void RibbonControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loginState == false)
                return;

            HideLoginForm();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new ProductList());
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new ResourcePurchaceQuantity());
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new PurchaceFromOriginQuantity());
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new ProductSalesQuantity());
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new ProductSalesByBuyer());
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new GrossProfit());
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new ExpenseForm());
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new GrowthRate());
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new SalesPerformence());
        }
    }
}
