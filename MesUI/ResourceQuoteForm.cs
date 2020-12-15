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
    public partial class ResourceQuoteForm : Form
    {
        public ResourceQuoteForm()
        {
            load();
        }

        public void load()
        {
            InitializeComponent();
            checkBox1.CheckedChanged += checkBox_CheckedChanged;
            checkBox2.CheckedChanged += checkBox_CheckedChanged;
            checkBox3.CheckedChanged += checkBox_CheckedChanged;
            checkBox4.CheckedChanged += checkBox_CheckedChanged;
        }

        private void ResourceQuoteForm_Load(object sender, EventArgs e)
        {
            DisplayQuote();
        }

        public void DisplayQuote()
        {
            List<Resource_Quote> list = Dao.Resource_Quote.GetAll();
            resourceQuoteBindingSource.DataSource = list;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox[] boxes = new CheckBox[4];
            boxes[0] = checkBox1;
            boxes[1] = checkBox2;
            boxes[2] = checkBox3;
            boxes[3] = checkBox4;

            for (int i = 0; i < boxes.Length; i++)
            {
                if (boxes[i].Checked)
                {
                    chart1.Series[i].Enabled = true;
                    AutoMaxMin();
                }
                else
                {
                    chart1.Series[i].Enabled = false;
                    AutoMaxMin();
                }
            }
        }

        private  void AutoMaxMin()
        {
            chart1.ChartAreas[0].RecalculateAxesScale();
            chart1.ChartAreas[0].AxisY.IsStartedFromZero = false;
        }

        private void PeriodSearch_Click(object sender, EventArgs e)
        {
            List<Resource_Quote> list = Dao.Resource_Quote.GetByDate(uiDt_StartTime.Value.Date, uiDt_EndTime.Value.Date);

            if (uiDt_StartTime.Value.Date > uiDt_EndTime.Value.Date)
            {
                MessageBox.Show("기간이 잘못되었음", "오류");
            }

            if (uiDt_StartTime.Value <= uiDt_EndTime.Value && list.Count == 0)
            {
                MessageBox.Show("조회 기간에 시세 데이터가 없습니다.");
            }

            for (int i = 0; i < chart1.Series.Count; i++)
            {
                chart1.Series[i].XValueMember = "date";
                chart1.Series[i].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                chart1.Series[i].MarkerSize = 10;
            }

            chart1.ChartAreas[0].AxisX.Interval = 1;

            resourceQuoteBindingSource.DataSource = list;

        }
        
        private void Reset_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            load();
            DisplayQuote();
        }
    }
}
