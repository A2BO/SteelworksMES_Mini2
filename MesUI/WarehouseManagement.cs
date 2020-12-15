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
    public partial class WarehouseManagement : Form
    {
        WarehouseModify modForm = null;
        public WarehouseManagement()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void WarehouseManagement_Load(object sender, EventArgs e)
        {
            DisplayAllItem();
        }

        public void DisplayAllItem()
        {
            List<WareHouse> list = Dao.WaereHouse.GetAll();
            wareHouseBindingSource.DataSource = list;

            List<Resource> list1 = Dao.Resource.GetResourceInfo();
            resourceBindingSource.DataSource = list1;
        }

        private void ModifyWarehousebtn_Click(object sender, EventArgs e)
        {
            string[] gridRow = new string[4];

            for (int i = 0; i < dataGridView1.SelectedRows[0].Cells.Count; i++)
            {
                gridRow[i] = dataGridView1.SelectedRows[0].Cells[i].Value.ToString();
            }

            modForm = new WarehouseModify(gridRow);
            modForm.parentForm = this;

            modForm.Show();
        }

        private void AddWarehousebtn_Click(object sender, EventArgs e)
        {
            WarehouseRegister newWarehouseRegister = new WarehouseRegister();
            newWarehouseRegister.parentForm = this;

            newWarehouseRegister.Show();
        }

        private void DeleteWarehousebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("삭제 하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dao.WaereHouse.Delete(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                DisplayAllItem();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
                List<Resource> list1 = Dao.Resource.GetByPK(SearchWarehouse.Text);
                resourceBindingSource.DataSource = list1;
        }

        private void AllBtn_Click(object sender, EventArgs e)
        {
            List<Resource> list1 = Dao.Resource.GetResourceInfo();
            resourceBindingSource.DataSource = list1;
        }
    }
}
