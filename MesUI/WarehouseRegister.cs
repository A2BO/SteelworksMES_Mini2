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
    public partial class WarehouseRegister : Form
    {
        public WarehouseRegister()
        {
            InitializeComponent();

            textboxList = new List<Object>();

            textboxList.Add(textBoxWarehouseId);
            textboxList.Add(textBoxWarehouseAreaSize);
            textboxList.Add(textBoxEmployeeId);
            textboxList.Add(textBoxWarehousePhoneNumber);
        }

        string[] gridRow = new string[4];
        List<Object> textboxList;

        public WarehouseManagement parentForm = null;

        public WarehouseRegister(string[] gridRow)
        {
            InitializeComponent();
        }

        private void WarehouseAddBtn_Click(object sender, EventArgs e)
        {
            string[] strArray = new string[4];

            for (int i = 0; i < textboxList.Count(); i++)
            {
                    strArray[i] = ((TextBox)textboxList[i]).Text;
            }

            Dao.WaereHouse.InsertWareHouse(strArray);

            ((WarehouseManagement)this.parentForm).DisplayAllItem();

            this.Hide();
        }
    }
}
