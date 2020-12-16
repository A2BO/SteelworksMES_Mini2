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
    public partial class ResourceQuote_Dev : Form
    {
        public ResourceQuote_Dev()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            List<Resource_Quote> list = Dao.Resource_Quote.GetAll();
            resourceQuoteBindingSource.DataSource = list;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List<Resource_Quote> list = Dao.Resource_Quote.GetByDate(dateEdit1.DateTime, dateEdit2.DateTime);

            if (dateEdit1.DateTime > dateEdit2.DateTime)
            {
                MessageBox.Show("기간이 잘못되었음", "오류");
            }

            if (dateEdit1.DateTime <= dateEdit2.DateTime && list.Count == 0)
            {
                MessageBox.Show("조회 기간에 시세 데이터가 없습니다.");
            }
            for (int i = 0; i < chartControl1.Series.Count; i++)
            {
                chartControl1.Series[i].ArgumentDataMember = "date";
            }

            resourceQuoteBindingSource.DataSource = list;
        }
    }
}
