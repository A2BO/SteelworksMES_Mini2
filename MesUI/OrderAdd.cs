using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniSteelworksMES.Data.Dao;

namespace MesUI
{
    public partial class OrderAdd : Form
    {
        public OrderAdd()
        {
            InitializeComponent();

            textboxList = new List<Object>();

            textboxList.Add(textBoxOrderId);
            textboxList.Add(textBoxResoureId);
            textboxList.Add(dateTimePicker);
            textboxList.Add(textBoxEmployeeId);
            textboxList.Add(textBoxQuantity);
            textboxList.Add(textBoxSellerName);
        }

        string[] gridRow = new string[5];
        List<Object> textboxList;

        public MaterialOrderManagement parentForm = null;

        public OrderAdd(string[] gridRow)
        {
            InitializeComponent();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string[] strArray = new string[6];

            for (int i = 0; i < textboxList.Count(); i++)
            {
                if(i ==2)
                    strArray[i] = ((DateTimePicker)textboxList[i]).Value.ToString();
                else
                    strArray[i] = ((TextBox)textboxList[i]).Text;
            }

            Dao.Order.InsertOrder(strArray);

            ((MaterialOrderManagement)this.parentForm).DisplayAllItem();

            this.Hide();
        }
    }
}
