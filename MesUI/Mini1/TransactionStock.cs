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
    public partial class TransactionStock : Form
    {
        TransactionModify modForm = null;

        public Dictionary<string, int> dictResource = null;

        /// <summary>
        ///  페이지 단위로 보여주기 위한 페이지 개수를 저장하는 변수 선언
        /// </summary>
        private int pageCount = 0; // 결과가 많을 때 나눠서 보여줄 페이지수
        private int rowsCountPerPage = 20; // 스킵해서 조회할 건수

        public TransactionStock()
        {
            InitializeComponent();

            SetGridLayout();

            SetResourceId();
        }

        private void DisplayPageControl(bool showOrNot)
        {
            if (showOrNot)
            {
                labelPageNumber.Show();
                comboBoxPageNumber.Show();
            }
            else
            {
                labelPageNumber.Hide();
                comboBoxPageNumber.Hide();
            }
        }

        private void SetResourceId()
        {
            List<Resource> list = ResourceInfo.getInstance();
            dictResource = new Dictionary<string, int>();

            for (int i = 0; i < list.Count; i++)
            {
                comboBoxRscId.Items.Add(list[i].Name);

                dictResource.Add(list[i].Name, list[i].ResourceId);
            }
        }

        private void TransactionStock_Load(object sender, EventArgs e)
        {
            DisplayPageControl(false);
        }

        /// <summary>
        /// 조회 쿼리 결과 값을 화면에 출력한다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DisplayPageControl(false);

            List<Transaction> list = null;

            if (checkBoxDate.Checked && !checkBoxResourceId.Checked)
                list = Dao.Transaction.GetByDate(dateTimePickerStart.Value, dateTimePickerEnd.Value);
            else if (checkBoxResourceId.Checked && checkBoxDate.Checked)
                list = Dao.Transaction.GetByResourceIdAndDate(dictResource[comboBoxRscId.Text], dateTimePickerStart.Value, dateTimePickerEnd.Value);
            else if (checkBoxResourceId.Checked)
                list = Dao.Transaction.GetByResourceId(dictResource[comboBoxRscId.Text]);
            else
            { // 조건 없이 모두 조회한다, 페이징 처리를 해야 한다
                pageCount = Dao.Transaction.GetPageCount(rowsCountPerPage);

                comboBoxPageNumber.Items.Clear();

                for (int i=1; i<=pageCount; i++)
                    comboBoxPageNumber.Items.Add(i.ToString());

                if (pageCount > 1)
                {
                    comboBoxPageNumber.SelectedIndex = 0;
                    list = Dao.Transaction.GetAllByPagingQuery(1);
                    DisplayPageControl(true);
                }
                else
                    list = Dao.Transaction.GetAll();
            }

            bdsTransaction.DataSource = list;

            if (list.Count == 0)
            {
                MessageBox.Show("0건 조회 되었습니다", "조회 결과");
            }
        }

        private void SetGridLayout()
        {
            //rscTransactionGrid.ColumnCount = 7;

            rscTransactionGrid.Columns[2].Width = 160;

            //rscTransactionGrid.Columns[0].Name = "시각";
            //rscTransactionGrid.Columns[1].Name = "창고";
            //rscTransactionGrid.Columns[2].Name = "담당자";
            //rscTransactionGrid.Columns[3].Name = "원자재명";
            //rscTransactionGrid.Columns[4].Name = "구분";
            //rscTransactionGrid.Columns[5].Name = "원산지";
            //rscTransactionGrid.Columns[6].Name = "수입처";
            
            rscTransactionGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void rscTransactionGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if( rscTransactionGrid.RowCount < 1 )
            {
                MessageBox.Show("조회 후 수정 가능합니다", "수정 오류");
                return;
            }

            string[] gridRow = new string[7];

            for (int i = 0; i < rscTransactionGrid.SelectedRows[0].Cells.Count; i++)
            {
                gridRow[i] = rscTransactionGrid.SelectedRows[0].Cells[i].Value.ToString();
            }

            modForm = new TransactionModify(gridRow);
            modForm.parentForm = this;

            modForm.Show();
        }

        public void DisplayAllItem()
        {
            List<Transaction> list = Dao.Transaction.GetAll();
            bdsTransaction.DataSource = list;
        }

        private void labelPage1_MouseHover(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Aqua;
        }

        private void labelPage1_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Black;
        }

        private void comboBoxPageNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Transaction> list = null;

            list = Dao.Transaction.GetAllByPagingQuery(Convert.ToInt32(comboBoxPageNumber.Text));

            bdsTransaction.DataSource = list;
        }
    }
}
