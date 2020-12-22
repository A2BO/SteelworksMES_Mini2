using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MiniSteelworksMES.Data;

namespace MesUI.Mini2
{
    public partial class StainlessForm : DevExpress.XtraEditors.XtraForm
    {
        public StainlessForm(ProductSalesForm quantityForm, ProductSalesQuantityModel2 model)
        {
            InitializeComponent();

            QuantityForm = quantityForm;
            Model = model;
        }

        public ProductSalesForm QuantityForm { get;  }

        public ProductSalesQuantityModel2 Model { get; }

        private void Stainless_Load(object sender, EventArgs e)
        {
        }
    }
}