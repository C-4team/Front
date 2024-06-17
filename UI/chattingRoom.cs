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
        AddGroupFriend addGroupFriend;
        private Thread receiveThread; //그룹채팅이든 아니든 이걸로 연결해야함
        private Thread sendThread; //그룹채팅이든 아니든 이걸로 연결해야함
        string groupId = "";
        string userName = "";
        string chatMessage = "";
        string timeStamp = "";

        public chattingRoom(TcpConnection Connection)
        {
            tcpConnection = Connection;
            InitializeComponent();

            this.MinimumSize = new Size(482, 797);
            this.MaximumSize = new Size(482, 797);

            if (!tcpConnection.m_bConnect) tcpConnection.Connect(); //서버에 연결 완료

            if (tcpConnection.m_bConnect)
            {
                sendThread = new Thread(new ThreadStart(ProcessIncomingMessage));
                sendThread.Start();
            }
        }

        private void ProcessIncomingMessage()
        {
            string message = tcpConnection.m_Read.ReadLine();
            string[] parts = message.Split(',');
            if (parts.Length >= 5)
            {
                groupId = parts[1];
                userName = parts[2];
                chatMessage = parts[3];
                timeStamp = parts[4];

                if (groupId != "11")
                {
                    AddIncomming(userName, chatMessage);
                }
            }
        }

        //void AddIncomming(string userName, string message)
        void AddIncomming(string userName, string message)
        {
            var bubble = new UI.Resources.chatting.incomming(); //Incomming 인스턴스를 새로 생성
            chatPnl.Controls.Add(풍선껌);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.name = userName; //userName 으로 들어가야함
            bubble.Message = message;
        }

        private void chatoutPic_Click(object sender, EventArgs e)
        {
            //chatlist로 이동
            this.Close();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            receiveThread = new Thread(new ThreadStart(Send));
            receiveThread.Start();

            //Send();
        }

        void Send()
        {
            if (sendTxt.Text.Trim().Length == 0) return;


            /***********<TEST>**********
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
            }*/

            //메세지에 UI 추가
            AddOutgoing(sendTxt.Text);
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            tcpConnection.m_Write.WriteLine("7," + groupId + "," + sendTxt.Text + "," + timestamp);
            sendTxt.Text = string.Empty;
        }

        void AddOutgoing(string message)
        {
            var bubble = new UI.Resources.chatting.outgoing();
            chatPnl.Controls.Add(풍선껌);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
        }

        private void FriendAdd_Click(object sender, EventArgs e)
        {
            addGroupFriend = new AddGroupFriend(tcpConnection, groupId);
            addGroupFriend.ShowDialog();
        }

        private void chattingRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            tcpConnection.Disconnect();
            receiveThread.Abort();
            sendThread.Abort();
        }
    }
}
