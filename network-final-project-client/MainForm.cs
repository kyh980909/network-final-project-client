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
        Socket mainSock;
        IPAddress thisAddress;

        public MainForm()
        {
            InitializeComponent();
            mainSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void OnFormLoaded(object sender, EventArgs e)
        {
            thisAddress = IPAddress.Parse("192.168.1.186");
            int port = 9000;

            try
            {
                mainSock.Connect(thisAddress, port);
            }
            catch (Exception ex)
            {
                MsgBoxHelper.Error("연결에 실패했습니다!\n오류 내용:{0}", MessageBoxButtons.OK, ex.Message);
                Close();
            }
            var onlineList = new JObject();
            onlineList.Add("req", "list");

            byte[] onlineListData = Encoding.UTF8.GetBytes(onlineList.ToString());

            AsyncObject obj = new AsyncObject(4096);
            obj.WorkingSocket = mainSock;
            mainSock.BeginReceive(obj.Buffer, 0, obj.BufferSize, 0, DataReceived, obj);

            mainSock.Send(onlineListData);
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

            string text = Encoding.UTF8.GetString(obj.Buffer);


            obj.ClearBuffer();

            obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }
    }
}
