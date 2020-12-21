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
    public partial class GrossProfit : Form
    {
        public GrossProfit()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            originModelBindingSource.DataSource = Dao.Transaction.GetModels2();

        }
    }
}
