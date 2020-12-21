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
    public partial class ResourcePurchaceQuantity : Form
    {
        public ResourcePurchaceQuantity()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            transactionModelBindingSource.DataSource = Dao.Transaction.GetModels();


        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        //private void simpleButton1_Click(object sender, EventArgs e)
        //{

        //    List<Transaction> list = Dao.Transaction.GetByDate(dateTimeOffsetEdit1.DateTimeOffset, dateTimeOffsetEdit2.DateTimeOffset);

        //    if (dateTimeOffsetEdit1.DateTimeOffset > dateTimeOffsetEdit2.DateTimeOffset)
        //    {
        //        MessageBox.Show("기간이 잘못되었음", "오류");
        //    }

        //    if (dateTimeOffsetEdit1.DateTimeOffset <= dateTimeOffsetEdit2.DateTimeOffset && list.Count == 0)
        //    {
        //        MessageBox.Show("조회 기간에 시세 데이터가 없습니다.");
        //    }
        //    for (int i = 0; i < chartControl1.Series.Count; i++)
        //    {
        //        chartControl1.Series[i].ArgumentDataMember = "date";
        //    }

        //    transactionModel2BindingSource.DataSource = list;
        //}
    }
}
