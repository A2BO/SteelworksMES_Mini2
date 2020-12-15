using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RfidReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.CheckedChanged += radioButton_CheckedChanged;
            radioButton2.CheckedChanged += radioButton_CheckedChanged;//라디오버튼 추가
        }
        private int transactionCheckedState { get; set; }

        String tag1 = " 04 d7 cb 2b";
        String tag2 = " d5 99 55 23";
        String tag3 = " 83 3d 47 02";
        String tag4 = " e5 e1 5e 23";//

        resource[] mineral = new resource[4];

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && !serialPort1.IsOpen)
            {
                serialPort1.PortName = textBox1.Text;
                serialPort1.Open();
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string input = serialPort1.ReadLine();

                for (int i = 0; i < mineral.Length; i++)
                {
                    if (input.IndexOf(mineral[i].cardid) != -1)
                    {
                        textBox2.Invoke(new MethodInvoker(delegate ()
                        {
                            textBox2.Text = mineral[i].name;
                        }));
                        textBox3.Invoke(new MethodInvoker(delegate ()
                        {
                            textBox3.Text = mineral[i].SellerName;
                        }));
                        textBox4.Invoke(new MethodInvoker(delegate ()
                        {
                            textBox4.Text = mineral[i].Origin;
                        }));
                        textBox5.Invoke(new MethodInvoker(delegate ()
                        {
                            mineral[i].dt = DateTime.Now;
                            textBox5.Text = mineral[i].dt.ToString();
                        }));
                        textBox8.Invoke(new MethodInvoker(delegate ()
                        {
                            textBox8.Text = mineral[i].ResourceId.ToString();
                        }));
                        textBox9.Invoke(new MethodInvoker(delegate ()
                        {
                            textBox9.Text = mineral[i].Category.ToString();
                        }));

                        break;
                    }
                }
            }
        }
        class resource
        {
            public int ResourceId;
            public string name;
            public string SellerName;
            public string Origin;
            public string cardid;
            public int Category;
            public DateTime dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mineral[0] = new resource();
            mineral[0].ResourceId = 1;
            mineral[0].name = "철광석";
            mineral[0].SellerName = "A채광";
            mineral[0].Origin = "인도네시아";
            mineral[0].cardid = tag1;
            mineral[0].Category = 1;
            mineral[0].dt = DateTime.Now;

            mineral[1] = new resource();
            mineral[1].ResourceId = 2;
            mineral[1].name = "니켈";
            mineral[1].SellerName = "B채광";
            mineral[1].Origin = "중국";
            mineral[1].cardid = tag2;
            mineral[1].Category = 1;
            mineral[1].dt = DateTime.Now;

            mineral[2] = new resource();
            mineral[2].ResourceId = 3;
            mineral[2].name = "알루미늄";
            mineral[2].SellerName = "C채광";
            mineral[2].Origin = "인도";
            mineral[2].cardid = tag3;
            mineral[2].Category = 0;
            mineral[2].dt = DateTime.Now;

            mineral[3] = new resource();
            mineral[3].ResourceId = 4;
            mineral[3].name = "구리";
            mineral[3].SellerName = "D채광"; ;
            mineral[3].Origin = "미국";
            mineral[3].cardid = tag4;
            mineral[3].Category = 0;
            mineral[3].dt = DateTime.Now;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && radioButton2.Checked == false)
                transactionCheckedState = 0; // 입고
            else if (radioButton1.Checked == false && radioButton2.Checked == true)
                transactionCheckedState = 1; // 출고

        }



        private void btn_DBInData_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection MESDBConn = new SqlConnection();
                //DB 연결 변수
                MESDBConn.ConnectionString = "Server = 192.168.8.173; database = MES01; uid = sa; pwd = 3512";
                //DB 열기
                MESDBConn.Open();

                //저장프로시저 사용
                SqlCommand Command = new SqlCommand();
                Command.Connection = MESDBConn;
                Command.CommandType = CommandType.StoredProcedure;
                //Command.Parameters.Clear();
                //저장프로시저명

                Command.CommandText = "DBInData";
                {
                    Command.Parameters.AddWithValue("@ResourceId", textBox8.Text);
                    Command.Parameters.AddWithValue("@Name", textBox2.Text);
                    Command.Parameters.AddWithValue("@SellerName", textBox3.Text);
                    Command.Parameters.AddWithValue("@Quantity", textBox7.Text);
                    Command.Parameters.AddWithValue("@Category", textBox9.Text);
                    Command.Parameters.AddWithValue("@Date", textBox5.Text);
                    Command.Parameters.AddWithValue("@Origin", textBox4.Text);
                    Command.Parameters.AddWithValue("@EmployeeId", textBox6.Text);
                    Command.Parameters.AddWithValue("@Type", transactionCheckedState);
                    Command.Parameters.AddWithValue("@WareHouseId", comboBox1.Text);
                }

                if (radioButton1.Checked == true && radioButton2.Checked == false)
                {
                    //transactionCheckedState = 0;
                    MessageBox.Show("입고되었습니다.", "Information");
                }
                else if (radioButton1.Checked == false && radioButton2.Checked == true)
                {
                    //transactionCheckedState = 1;
                    MessageBox.Show("출고되었습니다.", "Information");
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
