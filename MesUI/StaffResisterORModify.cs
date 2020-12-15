using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MesUI
{
    public partial class StaffResisterORModify : Form
    {
        public StaffResisterORModify()
        {
            InitializeComponent();
        }

        private void StaffResisterORModify_Load(object sender, EventArgs e)
        {

        }

        private void StaffModifyOrRegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection MESDBConn = new SqlConnection();
                //DB 연결 변수
                MESDBConn.ConnectionString = "Server = 192.168.8.142; database = MES01; uid = sa; pwd = 3512";
                //DB 열기
                MESDBConn.Open();
                //저장프로시저 사용
                SqlCommand Command = new SqlCommand();
                Command.Connection = MESDBConn;
                Command.CommandType = CommandType.StoredProcedure;
                //Command.Parameters.Clear();
                //저장프로시저명

                Command.CommandText = "DBInStaffData";
                {
                    Command.Parameters.AddWithValue("@EmployeeId", EmployeeId.Text);
                    Command.Parameters.AddWithValue("@Name", StaffName.Text);
                    Command.Parameters.AddWithValue("@Position", Position.Text);
                    Command.Parameters.AddWithValue("@BossId", BossID.Text);
                    Command.Parameters.AddWithValue("@Address", Address.Text);
                    Command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber.Text);
                    Command.Parameters.AddWithValue("@Team", Team.Text);
                }

                Command.ExecuteNonQuery();
                //DB 닫기
                MESDBConn.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}