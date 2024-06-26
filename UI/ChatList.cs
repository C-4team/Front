﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace UI
{
    public partial class ChatList : Form
    {
        TcpConnection Connection;
        FriendList friendlist;
        AddForm addForm;
        chattingRoom ChatRoom;

        Thread GetData;

        string MyName;
        Group group1;
        Group group2;
        Group group3;

        public ChatList(string name, TcpConnection connect)
        {
            MyName = name;
            Connection = connect;
            group1 = new Group();
            group2 = new Group();
            group3 = new Group();

            InitializeComponent();
            this.Text = name;
            this.MinimumSize = new Size(482, 797);
            this.MaximumSize = new Size(482, 797);

            Group1_Info.Text = "";
            Group2_Info.Text = "";
            Group3_Info.Text = "";
            Group1_List.Text = "";
            Group2_List.Text = "";
            Group3_List.Text = "";
            Group1_Panel.BorderStyle = BorderStyle.None;
            Group2_Panel.BorderStyle = BorderStyle.None;
            Group3_Panel.BorderStyle = BorderStyle.None;
        }

        private void GetDataFromServer()
        {
            RequestDataFromServer();
            RespondDataFromServer();

            return;
        }

        private void RequestDataFromServer()
        {
            string request = "2";
            if(request == "2")
                Connection.m_Write.WriteLine(request);
        }

        private void RespondDataFromServer()
        {
            Group1_Panel.BorderStyle = BorderStyle.None;
            Group2_Panel.BorderStyle = BorderStyle.None;
            Group3_Panel.BorderStyle = BorderStyle.None;

            string data = Connection.m_Read.ReadLine();

            if (data.StartsWith("4"))
            {
                return;
            }
            if (data.StartsWith("5"))
            {
                string[] datas = data.Split(',');
                int GroupCnt = Convert.ToInt32(datas[1]);
                int[] FriendCnt;

                if (GroupCnt == 0)
                {
                    return;
                }
                else if (GroupCnt == 1)
                {
                    group1.User_Count = Convert.ToInt32(datas[4]);
                    group1.ID = datas[2];
                    group1.Name = datas[3];
                    group1.Users.Clear();
                    for (int i = 0; i < group1.User_Count; i++)
                    {
                        group1.Users.Add(datas[5 + i]);
                    }
                    string result = string.Join(", ", group1.Users);
                    Group1_Info.Text = group1.Name;
                    Group1_List.Text = group1.User_Count + ") " + result;
                    Group1_Panel.BorderStyle = BorderStyle.Fixed3D;

                }
                else if (GroupCnt == 2)
                {
                    group1.User_Count = Convert.ToInt32(datas[4]);
                    group1.ID = datas[2];
                    group1.Name = datas[3];
                    group1.Users.Clear();
                    for (int i = 0; i < group1.User_Count; i++)
                    {
                        group1.Users.Add(datas[5 + i]);
                    }
                    group2.ID = datas[group1.User_Count + 5];
                    group2.Name = datas[group1.User_Count + 6];
                    group2.User_Count = Convert.ToInt32(datas[7 + group1.User_Count]);
                    group2.Users.Clear();
                    for (int i = 0; i < group2.User_Count; i++)
                    {
                        group2.Users.Add(datas[8 + group1.User_Count + i]);
                    }
                    String result1 = string.Join(", ", group1.Users);
                    String result2 = string.Join(", ", group2.Users);
                    Group1_Info.Text = group1.Name;
                    Group2_Info.Text = group2.Name;
                    Group1_List.Text = group1.User_Count + ") " + result1;
                    Group2_List.Text = group2.User_Count + ") " + result2;
                    Group1_Panel.BorderStyle = BorderStyle.Fixed3D;
                    Group2_Panel.BorderStyle = BorderStyle.Fixed3D;
                }
                else
                {
                    group1.User_Count = Convert.ToInt32(datas[4]);
                    group1.ID = datas[2];
                    group1.Name = datas[3];
                    group1.Users.Clear();
                    for (int i = 0; i < group1.User_Count; i++)
                    {
                        group1.Users.Add(datas[5 + i]);
                    }
                    String result1 = string.Join(", ", group1.Users);
                    group2.ID = datas[group1.User_Count + 5];
                    group2.Name = datas[group1.User_Count + 6];
                    group2.User_Count = Convert.ToInt32(datas[7 + group1.User_Count]);
                    group2.Users.Clear();
                    for (int i = 0; i < group2.User_Count; i++)
                    {
                        group2.Users.Add(datas[8 + group1.User_Count + i]);
                    }
                    String result2 = string.Join(", ", group2.Users);
                    group3.Name = datas[group1.User_Count + group2.Users.Count + 9];
                    group3.User_Count = Convert.ToInt32(datas[group1.User_Count + group2.User_Count + 8]);
                    group3.ID = datas[group1.User_Count + group2.User_Count + 8];
                    group3.Users.Clear();
                    for (int i = 0; i < group3.User_Count; i++)
                    {
                        group3.Users.Add(datas[group1.User_Count + group2.User_Count + 9 + i]);
                    }
                    String result3 = string.Join(", ", group3.Users);
                    Group1_Info.Text = group1.Name;
                    Group2_Info.Text = group2.Name;
                    Group3_Info.Text = group3.Name;
                    Group1_List.Text = group1.User_Count + ") " + result1;
                    Group2_List.Text = group2.User_Count + ") " + result2;
                    Group3_List.Text = group3.User_Count + ") " + result3;
                    Group1_Panel.BorderStyle = BorderStyle.Fixed3D;
                    Group2_Panel.BorderStyle = BorderStyle.Fixed3D;
                    Group3_Panel.BorderStyle = BorderStyle.Fixed3D;
                }
            }
        }

        private void toFriend_Click(object sender, EventArgs e)
        {
            this.Hide();
            friendlist = new FriendList(MyName, Connection);
            friendlist.ShowDialog();
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("로그아웃 하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Connection.Disconnect();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            addForm = new AddForm(1, Connection);
            addForm.ShowDialog();
            GetData = new Thread(new ThreadStart(GetDataFromServer));
            GetData.Start();
        }

        private void ChatList_Load(object sender, EventArgs e)
        {
            GetData = new Thread(new ThreadStart(GetDataFromServer));
            GetData.Start();
        }

        private void Group1_Panel_Click(object sender, EventArgs e)
        {

            if (Group1_Info.Text == "") return;
            ChatRoom = new chattingRoom(MyName, group1.ID, group1.Name, Connection);
            ChatRoom.Show();
        }

        private void Group2_Panel_Click(object sender, EventArgs e)
        {
            if (Group2_Info.Text == "") return;
            ChatRoom = new chattingRoom(MyName, group2.ID, group2.Name, Connection);
            ChatRoom.Show();
        }

        private void Group3_Panel_Click(object sender, EventArgs e)
        {
            if (Group3_Info.Text == "") return;
            ChatRoom = new chattingRoom(MyName, group3.ID, group3.Name, Connection);
            ChatRoom.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            GetData = new Thread(new ThreadStart(GetDataFromServer));
            GetData.Start();
        }
    }

    public class Group
    {
        public string ID = "";
        public string Name = "";
        public List<string> Users = new List<string>();
        public int User_Count = 0;

        public Group() { }

        public Group(string id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
