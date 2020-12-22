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
    public partial class SalesPerformanceForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public SalesPerformanceForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //if (DesignMode)
            //    return;

            //List<SalesPerformence> list = Dao.salesPerformence.GetAll();
            bdsModel.DataSource = Dao.Team.GetModel();
        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
