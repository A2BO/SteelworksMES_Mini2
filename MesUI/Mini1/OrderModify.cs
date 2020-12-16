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
    public partial class OrderModify : Form
    {
        public OrderModify()
        {
            InitializeComponent();
        }

       
        string[] gridRow = new string[5];
        List<Object> textboxList;

        public MaterialOrderManagement parentForm = null;

        private void TransactionModify_Load(object sender, EventArgs e)
        {

        }

        public OrderModify(string[] gridRow)
        {
            InitializeComponent();

            textboxList = new List<Object>();

            textboxList.Add(textBoxOrderId);
            textboxList.Add(textBoxResoureId);
            textboxList.Add(textBoxDate);
            textboxList.Add(textBoxEmployeeId);
            textboxList.Add(textBoxQuantity);
            textboxList.Add(textBoxSellerName);

            this.gridRow = gridRow;

            for (int i = 0; i < textboxList.Count(); i++)
            {
                ((TextBox)textboxList[i]).Text = gridRow[i];
            }
        }

       private void btnModify_Click_1(object sender, EventArgs e)
       {
           List<string> list = new List<string>();
       
           for (int i = 0; i < textboxList.Count(); i++)
           {
               list.Add(((TextBox)textboxList[i]).Text);
           }
           Dao.Order.UpdateOrder(list);
       
           ((MaterialOrderManagement)this.parentForm).DisplayAllItem();
       
           this.Hide();
       }
    }
}
