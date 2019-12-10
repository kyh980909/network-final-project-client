﻿using MySql.Data.MySqlClient;
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
            loginBt.Enabled = false;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var Login = new JObject();

            Login.Add("req", "login");
            Login.Add("id", id.Text);
            Login.Add("pw", pw.Text);

            byte[] loginData = Encoding.UTF8.GetBytes(Login.ToString());

            try
            {
                socket.Connect(IPAddress.Parse("192.168.1.186"), 9000);
            }
            catch (Exception ex)
            {
                MsgBoxHelper.Error("연결에 실패했습니다!\n오류 내용:{0}", MessageBoxButtons.OK, ex.Message);
            }

            if (!socket.IsBound)
            {
                MsgBoxHelper.Warn("서버가 실행되고 있지 않습니다!");
                return;
            }


            AsyncObject obj = new AsyncObject(4096);
            obj.WorkingSocket = socket;
            socket.BeginReceive(obj.Buffer, 0, obj.BufferSize, 0, DataReceived, obj);

            socket.Send(loginData);

          
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

        void DataReceived(IAsyncResult ar)
        {
            AsyncObject obj = (AsyncObject)ar.AsyncState;
            int received = obj.WorkingSocket.EndReceive(ar);

            if (received <= 0)
            {
                obj.WorkingSocket.Close();
                return;
            }

            string data = Encoding.UTF8.GetString(obj.Buffer);

            var readJson = JObject.Parse(data);

            if (readJson["res"].ToString() == "true")
            {
                this.Visible = false;
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            }
            else
            {
                MsgBoxHelper.Show(readJson["result"].ToString(), MessageBoxButtons.OK);
            }
            loginBt.Enabled = true;
        }

        private void RegisterBt_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
