﻿using MiniSteelworksMES.Data;
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
    public partial class ResourcePurchaceQuantity : Form
    {
        public ResourcePurchaceQuantity()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            var transactions = Dao.Transaction.GetModels();
            transactionModelBindingSource.DataSource = transactions;


        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
