using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using MiniSteelworksMES.Data.Dao;

namespace MesUI
{
    public partial class ResourceQuoteForm_Dev : Form
    {
        public ResourceQuoteForm_Dev()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            chartControl1.DataSource = Dao.Resource_Quote.GetAll();
        }
    }
}
