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

        //chattingRoom에 있어야할 기본 정보
        string myName = "";
        string groupId = "";
        string groupName = "";

        //incomming에서 받아오는 data
        string userName = "";
        string chatMessage = "";
        string timeStamp = "";

        //처음 chattingRoom load
        public chattingRoom(string MyName, string groupID, string GroupName, TcpConnection Connection)
        {
            groupId = groupID;
            tcpConnection = Connection;
            myName = MyName;
            groupName = GroupName;
            MessageBox.Show(groupName); //check용

            InitializeComponent();

            this.MinimumSize = new Size(482, 797);
            this.MaximumSize = new Size(482, 797);

            if (!tcpConnection.m_bConnect) tcpConnection.Connect(); //서버에 연결 완료

            if (tcpConnection.m_bConnect)
            {
                groupinter = new Thread(new ThreadStart(Intergroup)); //intergroup의 정보 보기
                groupinter.Start();

                Invoke((MethodInvoker)delegate {
                    namelbl.Text = groupName;
                });

                sendThread = new Thread(new ThreadStart(ProcessIncomingMessage));
                sendThread.Start();
            }
        }

        //incomming UI
        void AddIncomming(string userName, string message)
        {
            var bubble = new UI.Resources.chatting.incomming(); //Incomming 인스턴스를 새로 생성
            chatPnl.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.name = userName; //userName 으로 들어가야함
            bubble.Message = message;
        }

        //outcomming UI
        void AddOutgoing(string message)
        {
            var bubble = new UI.Resources.chatting.outgoing();
            chatPnl.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
        }

        //그룹 입장 + 과거 메시지 보내주기
        private void Intergroup()
        {
            string messageNum = "";
            string UserName = "";
            string message = "";
            int loopnum = 0;
            int index = 2; //parts -> 유저이름 부터 보기 위함
            tcpConnection.m_Write.WriteLine("4," + groupId); //request

            string interresponse = tcpConnection.m_Read.ReadLine(); //response

            string[] parts = interresponse.Split(',');
            //response가 올바르지 않을 경우
            MessageBox.Show("response의 tag 올바름?" + parts[0]);
            if (parts[0] != "8") MessageBox.Show("intergroup resposne : error");

            if (groupId != parts[1]) MessageBox.Show("incomming : groupId error");

            messageNum = parts[1];
            loopnum = int.Parse(messageNum);

            //과거 메시지 보내기
            while (loopnum >= 0)
            {
                if (myName == parts[index])
                {
                    Invoke((MethodInvoker)delegate
                    {
                        AddOutgoing(parts[index++]); //msg  
                    });
                    index++; //tinestamp 건너띄기
                }
                else
                {
                    Invoke((MethodInvoker)delegate
                    {
                        AddIncomming(parts[index], parts[index++]); //username, msg
                    });
                    index++; //timestamp
                }
                loopnum--;
            }//while문
        }//Intergroup func

        private void ProcessIncomingMessage()
        {
            string message = tcpConnection.m_Read.ReadLine(); //incomming 해올거 서버로부터 받ㅇ아오기
            string[] parts = message.Split(',');
            string tag = "";

            while (true)
            {
                if (groupId != parts[1])
                {
                   MessageBox.Show("incomming : groupId error");
                }
                userName = parts[2];
                chatMessage = parts[3];
                timeStamp = parts[4];
                tag = parts[0];

                //receive
                if (tag == "11")
                {
                  Invoke((MethodInvoker)delegate
                  {
                      AddIncomming(userName, chatMessage);
                  });
                }
            }
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

            //메세지에 UI 추가
            Invoke((MethodInvoker)delegate
            {
                AddOutgoing(sendTxt.Text);
            });
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string txt = "";
            sendTxt.Text.Replace("\n", txt);
            string response = "7," + groupId + "," + txt + "," + timestamp;

            // 타임스탬프와 메시지 확인을 위한 디버깅 메시지
            //MessageBox.Show("Timestamp: " + timestamp);
            //MessageBox.Show("Sending message: " + response);

            tcpConnection.m_Write.WriteLine(response);
            Invoke((MethodInvoker)delegate
            {
                sendTxt.Text = string.Empty;
            });
        }

        private void FriendAdd_Click(object sender, EventArgs e)
        {
            addGroupFriend = new AddGroupFriend(tcpConnection, groupId);
            addGroupFriend.ShowDialog();
        }

        private void chattingRoom_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void chattingRoom_Load(object sender, EventArgs e)
        {
            tcpConnection.m_Write.WriteLine();
        }
    }
}
