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
    public partial class RegisterForm : Form
    {
        Socket socket;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void LoginBt_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void RegisterBt_Click(object sender, EventArgs e)
        {
            registerBt.Enabled = false;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var Register = new JObject();

            Register.Add("req", "register");
            Register.Add("id", id.Text);
            Register.Add("pw", pw.Text);

            byte[] registerData = Encoding.UTF8.GetBytes(Register.ToString());

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

            socket.Send(registerData);


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
                MsgBoxHelper.Show("회원가입이 되었습니다!", MessageBoxButtons.OK);
                SetVisibility(this, false);
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }
            else
            {
                MsgBoxHelper.Show(readJson["result"].ToString(), MessageBoxButtons.OK);
            }
            SetEnabled(registerBt, true);
        }

        public void SetVisibility(Control target, bool visible)
        {
            if (target.InvokeRequired)
            {
                target.Invoke(new EventHandler(
                    delegate
                    {
                        target.Visible = visible;
                    }));
            }
            else
            {
                target.Visible = visible;
            }
        }

        public void SetEnabled(Control target, bool enabled)
        {
            if (target.InvokeRequired)
            {
                target.Invoke(new EventHandler(
                    delegate
                    {
                        target.Enabled = enabled;
                    }));
            }
            else
            {
                target.Enabled = enabled;
            }
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }
}
