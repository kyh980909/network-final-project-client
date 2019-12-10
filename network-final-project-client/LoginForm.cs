using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace network_final_project_client
{
    public partial class LoginForm : Form
    {
        Socket socket;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBt_Click(object sender, EventArgs e)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            byte[] bytes = new byte[1024];
            var Login = new JObject();

            Login.Add("req", "login");
            Login.Add("id", id.Text);
            Login.Add("pw", pw.Text);

            byte[] loginData = Encoding.UTF8.GetBytes(Login.ToString());

            try
            {
                socket.Connect(IPAddress.Parse("192.168.1.186"), 9000);
                socket.Send(loginData);

                string data = Encoding.UTF8.GetString(bytes, 0, socket.Receive(bytes));
                var readJson =  JObject.Parse(data);

                MsgBoxHelper.Show(readJson["res"].ToString(), MessageBoxButtons.OK);

                if (readJson["res"].ToString() == "true")
                {
                    this.Visible = false;
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MsgBoxHelper.Error("연결에 실패했습니다!\n오류 내용:{0}", MessageBoxButtons.OK, ex.Message);
                Close();
            }
            //string connStr = string.Format(@"server=localhost;
            //                                  user=root;
            //                                  password=1234;
            //                                  database=network");
            //MySqlConnection conn = new MySqlConnection(connStr);

            //try
            //{
            //    conn.Open();

            //    MessageBox.Show("MySQL 연결 성공");
            //}
            //catch
            //{
            //    conn.Close();
            //    MessageBox.Show("MySQL 연결 실패");
            //    Application.OpenForms["MainForm"].Close();      // 실패시 폼을 닫아준다.
            //}
        }
    }
}
