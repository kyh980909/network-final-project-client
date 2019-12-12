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
    public partial class MainForm : Form
    {
        public string PassId { get; set; }
        public Socket PassSocket { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnFormLoaded(object sender, EventArgs e)
        { 
            var onlineListReq = new JObject();
            onlineListReq.Add("req", "list");

            byte[] onlineListData = Encoding.UTF8.GetBytes(onlineListReq.ToString());

            AsyncObject obj = new AsyncObject(4096);
            obj.WorkingSocket = PassSocket;
            PassSocket.BeginReceive(obj.Buffer, 0, obj.BufferSize, 0, DataReceived, obj);

            PassSocket.Send(onlineListData);
        }

        void DataReceived(IAsyncResult ar)
        {
            AsyncObject obj = (AsyncObject)ar.AsyncState;
            try
            {
                int received = obj.WorkingSocket.EndReceive(ar);

                if (received <= 0)
                {
                    obj.WorkingSocket.Close();
                    Application.Exit();
                    return;
                }

                string data = Encoding.UTF8.GetString(obj.Buffer);
                var readJson = JObject.Parse(data);
                onlineList.Items.Clear();
                foreach (var item in readJson["result"])
                {
                    SetListView(onlineList, item.ToString());
                }

                obj.ClearBuffer();

                obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
            }
            catch
            {
                SetFormClose(this);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var logout = new JObject();
            logout.Add("req", "logout");
            logout.Add("id", PassId);
            byte[] logoutData = Encoding.UTF8.GetBytes(logout.ToString());
            PassSocket.Send(logoutData);
        }

        public void SetListView(ListView target, string item)
        {
            if (target.InvokeRequired)
            {
                target.Invoke(new EventHandler(
                    delegate
                    {
                        target.Items.Add(item);
                    }));
            }
            else
            {
                target.Items.Add(item);
            }
        }

        public void SetListViewClear(ListView target)
        {
            if (target.InvokeRequired)
            {
                target.Invoke(new EventHandler(
                    delegate
                    {
                        target.Items.Clear();
                    }));
            }
            else
            {
                target.Items.Clear();
            }
        }

        public void SetFormClose(Form target)
        {
            if (target.InvokeRequired)
            {
                target.Invoke(new EventHandler(
                    delegate
                    {
                        target.Close();
                    }));
            }
            else
            {
                target.Close();
            }
        }
    }
}
