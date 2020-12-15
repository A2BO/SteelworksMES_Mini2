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
    public partial class MaterialOrderManagement : Form
    {
        OrderModify modForm = null;

        public MaterialOrderManagement()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void MaterialOrderManagement_Load(object sender, EventArgs e)
        {
            DisplayAllItem();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (searchConditionComboBox.SelectedIndex == 1)
            {
                List<Order> list = Dao.Order.GetByPK(searchConditionTextBox.Text);
                orderBindingSource.DataSource = list;

            }
            else if (searchConditionComboBox.SelectedIndex == 2)
            {
                List<Order> list = Dao.Order.GetBySellerName(searchConditionTextBox.Text);
                orderBindingSource.DataSource = list;
            }
            else
                DisplayAllItem();
        }

        public void DisplayAllItem()
        {
            List<Order> list = Dao.Order.GetAll();
            orderBindingSource.DataSource = list;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string[] gridRow = new string[6];

            for (int i = 0; i < dataGridView1.SelectedRows[0].Cells.Count; i++)
            {
                gridRow[i] = dataGridView1.SelectedRows[0].Cells[i].Value.ToString();
            }

            modForm = new OrderModify(gridRow);
            modForm.parentForm = this;

            modForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderAdd newOrderAdd = new OrderAdd();
            newOrderAdd.parentForm = this;

            newOrderAdd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("삭제 하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dao.Order.Delete(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                DisplayAllItem();
            }

        }
    }
}
