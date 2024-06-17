using System;
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

        Thread RequestThread;
        Thread RespondThread;

        string Group1_ID = "";
        string Group2_ID = "";
        string Group3_ID = "";
        string MyName;
        public ChatList(string name, TcpConnection connect)
        {
            MyName = name;
            Connection = connect;
            InitializeComponent();
            Group1_Info.Text = "";
            Group2_Info.Text = "";
            Group3_Info.Text = "";
            Group1_Panel.BorderStyle = BorderStyle.None;
            Group2_Panel.BorderStyle = BorderStyle.None;
            Group3_Panel.BorderStyle = BorderStyle.None;
        }

        private void GetDataFromServer()
        {
            RequestThread = new Thread(new ThreadStart(RequestDataFromServer));
            RequestThread.Start();
            RespondThread = new Thread(new ThreadStart(RespondDataFromServer));
            RespondThread.Start();

            return;
        }

        private void RequestDataFromServer()
        {
            Connection.m_Write.WriteLine("2");
        }

        private void RespondDataFromServer()
        {
            Group1_Info.Text = "";
            Group2_Info.Text = "";
            Group3_Info.Text = "";
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
                    FriendCnt = new int[GroupCnt];
                    FriendCnt[0] = Convert.ToInt32(datas[4]);
                    Group1_ID = datas[2];
                    Group1_Info.Text = datas[3] + " " + FriendCnt[0];
                    Group1_Panel.BorderStyle = BorderStyle.Fixed3D;
                }
                else if (GroupCnt == 2)
                {
                    FriendCnt = new int[GroupCnt];
                    FriendCnt[0] = Convert.ToInt32(datas[4]);
                    FriendCnt[1] = Convert.ToInt32(datas[7 + FriendCnt[0]]);
                    Group1_ID = datas[2];
                    Group2_ID = datas[FriendCnt[0] + 5];
                    Group1_Info.Text = datas[3] + " " + FriendCnt[0];
                    Group2_Info.Text = datas[6 + FriendCnt[0]] + " " + FriendCnt[1];
                    Group1_Panel.BorderStyle = BorderStyle.Fixed3D;
                    Group2_Panel.BorderStyle = BorderStyle.Fixed3D;
                }
                else
                {
                    FriendCnt = new int[GroupCnt];
                    FriendCnt[0] = Convert.ToInt32(datas[4]);
                    FriendCnt[1] = Convert.ToInt32(datas[7 + FriendCnt[0]]);
                    FriendCnt[2] = Convert.ToInt32(datas[FriendCnt[0] + FriendCnt[1] + 10]);
                    Group1_ID = datas[2];
                    Group2_ID = datas[FriendCnt[0] + 5];
                    Group3_ID = datas[FriendCnt[0] + FriendCnt[1] + 8];
                    Group1_Info.Text = datas[3] + " " + FriendCnt[0];
                    Group1_Panel.BorderStyle = BorderStyle.Fixed3D;
                    Group2_Info.Text = datas[6 + FriendCnt[0]] + " " + FriendCnt[1];
                    Group2_Panel.BorderStyle = BorderStyle.Fixed3D;
                    Group3_Info.Text = datas[FriendCnt[0] + FriendCnt[1] + 9] + " " + FriendCnt[2];
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
                if (RequestThread != null)
                    RequestThread.Abort();
                if (RespondThread != null)
                    RespondThread.Abort();
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
            GetDataFromServer();
        }

        private void ChatList_Load(object sender, EventArgs e)
        {
            Group1_Info.Text = "";
            Group2_Info.Text = "";
            Group3_Info.Text = "";
            GetDataFromServer();
        }

        private void Group1_Panel_Paint(object sender, PaintEventArgs e)
        {

            //채팅창 열기
        }

        private void Group1_Panel_Click(object sender, EventArgs e)
        {
            if (Group1_Info.Text == "") return;
            ChatRoom = new chattingRoom(MyName, Group1_ID, Connection);
            ChatRoom.Show();
        }

        private void Group2_Panel_Click(object sender, EventArgs e)
        {
            if (Group2_Info.Text == "") return;
            ChatRoom = new chattingRoom(MyName, Group2_ID, Connection);
            ChatRoom.Show();
        }

        private void Group3_Panel_Click(object sender, EventArgs e)
        {
            if (Group3_Info.Text == "") return;
            ChatRoom = new chattingRoom(MyName, Group3_ID, Connection);
            ChatRoom.Show();
        }
    }
}
