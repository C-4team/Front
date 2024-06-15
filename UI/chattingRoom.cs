using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class chattingRoom : Form
    {
        //TCP 객체 불러오기
        private TcpConnection tcpConnection;

        public chattingRoom()
        {
            InitializeComponent();


            this.MinimumSize = new Size(482, 797);
            this.MaximumSize = new Size(482, 797);

            //Tcp 클라이언트 초기화
            //tcpConnection = new TcpConnection();

            //tcpConnection.MessageReceived += TcpConnection_MessageReceived;
            
            //서버에 연결
            //tcpConnection.Connect("Server_IP_ADDRESS", SERVER_PORT);
        }

        /*
          private void TcpConnection_MessageReceive(string message){
            //UI 스레드에서 메시지 추가
            this.Invoke(new MethodInvoker(() =>
            {
                ProcessIncommingMessage(message);
            }));
          }
        */

        
        private void ProcessIncomingMessage(string message)
        {
            string[] parts = message.Split(',');
            if (parts.Length >= 5)
            {
                string groupId = parts[1];
                string userName = parts[2];
                string chatMessage = parts[3];
                string timestamp = parts[4];

                //AddIncomming(userName, chatMessage); 원래 이게 맞음
                AddIncomming(chatMessage);
            }
        } 
        private void chatoutPic_Click(object sender, EventArgs e)
        {
            //chatlist로 이동
            this.Close();
        }

        private void ProcessIncommingMessage(string message)
        {
            string[] parts = message.Split(',');
            if(parts.Length >= 5 )
            {
                string groupId = parts[1];
                string userName = parts[2];
                string chatMessage = parts[3];
                string timestamp = parts[4];

                //AddIncomming(userName, chatMessage);
            }
        }
        private void sendBtn_Click(object sender, EventArgs e)
        {
            Send();
        }

        void Send()
        {
            if (sendTxt.Text.Trim().Length == 0) return;

            /*
             ***********<TEST>***********
            if (sendTxt.Text.StartsWith('2'))
            {
                AddIncomming(sendTxt.Text);
                sendTxt.Text = string.Empty;
            }
            
             else
            {
                //메세지에 UI 추가
                AddOutgoing(sendTxt.Text);
                sendTxt.Text = string.Empty;
            }
            */

            /*
            //textbox 서버로 보내기
            string groupId = "group Id"; //톡방 들어올 때부터 전역변수로든 어떤 형태로 저장하고 있어야할 듯

            string message = sendTxt.Text;
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string request = $"7,{groupId},{message},{timestamp}";*/

            //서버에 보내기 tcpConnection 클래스에 새로 만들어야할 듯
            //tcpConnection.SendMessage(request);
            
            //메세지에 UI 추가
            AddOutgoing(sendTxt.Text);
            sendTxt.Text = string.Empty;
        }

        //void AddIncomming(string userName, string message)
        void AddIncomming(string message)
        {
            var bubble = new UI.Resources.chatting.incomming(); //Incomming 인스턴스를 새로 생성
            chatPnl.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.name = "나는야 광운대 소프트생"; //userName 으로 들어가야함
            bubble.Message = message;
        }

        void AddOutgoing(string message)
        {
            var bubble = new UI.Resources.chatting.outgoing();
            chatPnl.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
        }
    }
}
