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
    public partial class WarehouseModify : Form
    {
        public WarehouseModify()
        {
            InitializeComponent();
        }

        string[] gridRow = new string[4];
        List<Object> textboxList;

        public WarehouseManagement parentForm = null;

        public WarehouseModify(string[] gridRow)
        {
            InitializeComponent();

            textboxList = new List<Object>();

            textboxList.Add(textBoxWarehouseId);
            textboxList.Add(textBoxWarehouseAreaSize);
            textboxList.Add(textBoxEmployeeId);
            textboxList.Add(textBoxWarehousePhoneNumber);

            this.gridRow = gridRow;

            for (int i = 0; i < textboxList.Count(); i++)
            {
                ((TextBox)textboxList[i]).Text = gridRow[i];
            }
        }

        private void WarehouseModifyBtn_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < textboxList.Count(); i++)
            {
                list.Add(((TextBox)textboxList[i]).Text);
            }
            Dao.WaereHouse.UpdateWareHouse(list);

            ((WarehouseManagement)this.parentForm).DisplayAllItem();

            this.Hide();
        }
    }
}
