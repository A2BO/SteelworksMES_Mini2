using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Native;
using MesUI.Mini2;
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

namespace MesUI
{
       
    public partial class ProductSalesForm : Form
    {
        public ProductSalesForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //if (DesignMode)
            //    return;

            //List<SalesPerformence> list = Dao.salesPerformence.GetAll();
            productSalesQuantityModel2BindingSource.DataSource = Dao.ProductDetail.GetModels();
        }
        private void chartControl1_SelectedItemsChanged(object sender, SelectedItemsChangedEventArgs e)
        {
            ProductSalesQuantityModel2 selectedItem = chartControl1.SelectedItems[0] as ProductSalesQuantityModel2;

            if (selectedItem == null)
                return;

            StainlessForm newStainless = new StainlessForm(this, selectedItem);
            newStainless.Show();
          
        }
    }
}
