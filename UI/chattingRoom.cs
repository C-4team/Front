﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

            InitializeComponent();
            this.Text = MyName;


            this.MinimumSize = new Size(482, 797);
            this.MaximumSize = new Size(482, 797);

            if (!tcpConnection.m_bConnect) tcpConnection.Connect(); //서버에 연결 완결

            namelbl.Location = new Point(91, 13);

            namelbl.Text = groupName;
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
            Thread.Sleep(1000);
            tcpConnection.m_Write.WriteLine("4," + groupId); //request

            string message = tcpConnection.m_Read.ReadLine();
            string[] parts = message.Split(',');

            if (parts[0] == "8")
            {
                int index = 1;
                string msgNum = parts[1];
                int loop = int.Parse(msgNum);

                while (loop > 0)
                {
                    index++;
                    string prename = parts[index];
                    if (prename == myName)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            index++;
                            AddOutgoing(parts[index]);
                        });
                        index++;
                        loop--;
                    }
                    else
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            index++;
                            AddIncomming(prename, parts[index]);
                        });
                        index++;
                        loop--;
                    }
                }
            }
            receiveThread.Start();
        }//Intergroup func

        private void ProcessIncomingMessage()
        {
            while (true)
            {
                string messageNum = "";
                int loopnum = 0;
                int index;

                string message = tcpConnection.m_Read.ReadLine(); //incomming 해올거 서버로부터 받ㅇ아오기
                string[] parts = message.Split(',');

                //받아오는 data 일 때,
                if (parts[0] == "11")
                {
                    userName = parts[2];
                    chatMessage = parts[3];
                    timeStamp = parts[4];
                    if (userName == myName)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            AddOutgoing(chatMessage);
                        });
                    }
                    else
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            AddIncomming(userName, chatMessage);
                        });
                    }
                }
            }
        }//processincommingmessage()

        private void chatoutPic_Click(object sender, EventArgs e)
        {
            if (groupinter != null && groupinter.IsAlive)
            {
                groupinter.Abort();
            }

            if (receiveThread != null && receiveThread.IsAlive)
            {
                receiveThread.Abort();
            }

            if (sendThread != null && sendThread.IsAlive)
            {
                sendThread.Abort();
            }

            this.Close();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            sendThread = new Thread(new ThreadStart(Send));
            sendThread.Start();
        }

        void Send()
        {
            try
            {
                if (sendTxt.Text.Trim().Length == 0) return;

                //response
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string txt = "";
                sendTxt.Text = sendTxt.Text.Replace("\n", txt);
                tcpConnection.m_Write.WriteLine("7," + groupId + "," + sendTxt.Text + "," + timestamp);

                Invoke((MethodInvoker)delegate
                {
                    sendTxt.Text = string.Empty;
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show("send 오류 : " + ex.Message);
            }

        }

        private void FriendAdd_Click(object sender, EventArgs e)
        {
            addGroupFriend = new AddGroupFriend(tcpConnection, groupId);
            addGroupFriend.ShowDialog();
        }

        private void chattingRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (groupinter != null && groupinter.IsAlive)
            {
                groupinter.Abort();
            }
                
            if (receiveThread != null && receiveThread.IsAlive)
            {
                receiveThread.Abort();
            }

            if (sendThread != null && sendThread.IsAlive)
            {
                sendThread.Abort();
            }
        }

        private void chattingRoom_Load(object sender, EventArgs e)
        {
            if (tcpConnection.m_bConnect)
            {
                groupinter = new Thread(new ThreadStart(Intergroup)); //intergroup의 정보 보기
                groupinter.Start();

                Thread.Sleep(1000);

                receiveThread = new Thread(new ThreadStart(ProcessIncomingMessage));
            }
        }
    }
}
