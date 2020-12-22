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
            LogInForm form = (LogInForm)dictForm["loginForm"];
            form.Hide();
        }

        public void ShowForm(int index = 0)
        {
            if (index == 10)
            {
                AnnouncementForm form = (AnnouncementForm)dictForm["loginForm2"];
                form.Show();
                form.Activate();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

#if DEBUG
            loginState = true;
            ShowChildForm(new ProductSalesForm());
#else
            LogInForm1 loginForm = new LogInForm1();
            loginForm.MdiParent = this;
            dictForm.Add("loginForm", loginForm);

            //loginForm.Width = 900;
            //loginForm.Height = 600;

            LogInForm2 login2Form = new LogInForm2();
            login2Form.MdiParent = this;
            dictForm.Add("loginForm2", login2Form);

            loginForm.Show();
#endif
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
            ShowChildForm(new ResourceQuoteForm());
        }

        private void RibbonControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loginState == false)
                return;

            HideLoginForm();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new ProductListForm());
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new PurchasedRatioForm());
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new OriginForm());
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new ProductSalesForm());
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new SaleToForm());
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new GrossProfitForm());
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new ExpenseForm());
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new GrowthRateForm());
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new SalesPerformanceForm());
        }
    }
}
