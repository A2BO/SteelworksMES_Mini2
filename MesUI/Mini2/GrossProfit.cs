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
using System.Data.Entity;

namespace MesUI
{
    public partial class GrossProfit : Form
    {
        public GrossProfit()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            MiniSteelworksMES.Data.MesEntities dbContext = new MiniSteelworksMES.Data.MesEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.GrossProfits.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                pivotGridControl1.DataSource = dbContext.GrossProfits.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            //MiniSteelworksMES.Data.MesEntities dbContext = new MiniSteelworksMES.Data.MesEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.GrossProfits.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                pivotGridControl1.DataSource = dbContext.GrossProfits.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            //MiniSteelworksMES.Data.MesEntities dbContext = new MiniSteelworksMES.Data.MesEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.GrossProfits.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    pivotGridControl1.DataSource = dbContext.GrossProfits.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            grossProfitBindingSource.DataSource = Dao.Transaction.GetModels2();

        }
    }
}
