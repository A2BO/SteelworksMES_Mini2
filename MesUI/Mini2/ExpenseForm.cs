using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniSteelworksMES.Data.Dao;

namespace MesUI
{
    public partial class ExpenseForm : Form
    {
        public ExpenseForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            bdsExpense.DataSource = Dao.expense.Search();
        }
    }
}
