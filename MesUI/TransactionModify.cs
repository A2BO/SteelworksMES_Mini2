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
    

    public partial class TransactionModify : Form
    {
        string[] gridRow = new string[7];
        List<Object> textboxList;

        public TransactionStock parentForm = null;

        public TransactionModify()
        {
            InitializeComponent();
        }

        private void TransactionModify_Load(object sender, EventArgs e)
        {

        }

        public TransactionModify(string[] gridRow)
        {
            InitializeComponent();

            textboxList = new List<Object>();

            textboxList.Add(textBoxId);
            textboxList.Add(textBoxSellerName);
            textboxList.Add(textBoxDate);
            textboxList.Add(textBoxOrigin);
            textboxList.Add(textBoxEmployeeId);
            textboxList.Add(textBoxType);
            textboxList.Add(textBoxWareHouseId);

            this.gridRow = gridRow;

            for (int i = 0; i < textboxList.Count(); i++)
            {
                ((TextBox)textboxList[i]).Text = gridRow[i];
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < textboxList.Count(); i++)
            {
                list.Add(((TextBox)textboxList[i]).Text);
            }
            Dao.Transaction.UpdateTransaction(list);

            ((TransactionStock)this.parentForm).DisplayAllItem();

            this.Hide();
        }

        private void textBoxEmployeeId_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("포커스 아웃");
            if (!MesRegEx.IsNumber(textBoxEmployeeId.Text))
            {
                MessageBox.Show("숫자만 입력 가능합니다", "입력 데이터 오류");
                textBoxEmployeeId.Focus();
            }
        }

        private void textBoxWareHouseId_Leave(object sender, EventArgs e)
        {
            if (!MesRegEx.IsNumber(textBoxWareHouseId.Text))
            {
                MessageBox.Show("숫자만 입력 가능합니다", "입력 데이터 오류");
                textBoxWareHouseId.Focus();
            }
        }
    }

}
