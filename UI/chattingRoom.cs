﻿using System;
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
        private Thread groupinter; //그룹 입장

        string groupId = "";
        string userName = "";
        string chatMessage = "";
        string timeStamp = "";
        string myName = "";

        public chattingRoom(string MyName, string groupID, TcpConnection Connection)
        {
            groupId = groupID;
            tcpConnection = Connection;
            myName = MyName;
            InitializeComponent();

            this.MinimumSize = new Size(482, 797);
            this.MaximumSize = new Size(482, 797);

            if (!tcpConnection.m_bConnect) tcpConnection.Connect(); //서버에 연결 완료

            if (tcpConnection.m_bConnect)
            {
                groupinter = new Thread(new ThreadStart(Intergroup)); //intergroup의 정보 보기
                groupinter.Start();
                sendThread = new Thread(new ThreadStart(ProcessIncomingMessage));
                sendThread.Start();
            }
        }

        private void Intergroup()
        {
            string messageNum = "";
            string UserName = "";
            string message ="";
            int loopnum = 0;
            int index = 2; //parts -> 유저이름 부터 보기 위함

            tcpConnection.m_Write.WriteLine("4," + groupId); //request

            string interresponse = tcpConnection.m_Read.ReadLine(); //response

            string[] parts = interresponse.Split(',');
            //response가 올바르지 않을 경우
            if (parts[0] != "8")
            {
                MessageBox.Show("intergroup resposne : error");
            }

            if(parts.Length >= 5)
            {
                if (groupId != parts[1])
                {
                    MessageBox.Show("incomming : groupId error");
                }

                messageNum = parts[1];
            }
            loopnum = int.Parse(messageNum);

            while (loopnum >= 0)
            {
                //내 톡 내용
                if(myName == parts[index])
                {
                    AddOutgoing(parts[index++]); //msg
                    index++; //tinestamp 건너띄기
                }
                else
                {
                    AddIncomming(parts[index], parts[index++]); //username, msg
                    index++; //timestamp
                }
            }
        }

        private void ProcessIncomingMessage()
        {
            string message = tcpConnection.m_Read.ReadLine();
            string[] parts = message.Split(',');
            if (parts.Length >= 5)
            {
                if(groupId != parts[1])
                {
                    MessageBox.Show("incomming : groupId error");
                }
                userName = parts[2];
                chatMessage = parts[3];
                timeStamp = parts[4];

                //receive
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
            chatPnl.Controls.Add(bubble);
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
            chatPnl.Controls.Add(bubble);
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

        private void chattingRoom_Load(object sender, EventArgs e)
        {
            tcpConnection.m_Write.WriteLine();
        }
    }
}