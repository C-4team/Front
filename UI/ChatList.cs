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

        Thread RequestThread;
        Thread RespondThread;
        Thread CreateGroupThread;

        public ChatList(TcpConnection connect)
        {
            Connection = connect;
            InitializeComponent();
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
                    FriendCnt[0] = Convert.ToInt32(datas[3]);
                    Group1_Info.Text = datas[2] + " " + FriendCnt[0];
                    Group1_Panel.BorderStyle = BorderStyle.Fixed3D;
                }
                else if (GroupCnt == 2)
                {
                    FriendCnt = new int[GroupCnt];
                    FriendCnt[0] = Convert.ToInt32(datas[3]);
                    FriendCnt[1] = Convert.ToInt32(datas[5 + 2 * FriendCnt[0]]);
                    Group1_Info.Text = datas[2] + " " + FriendCnt[0];
                    Group2_Info.Text = datas[4 + 2 * FriendCnt[0]] + " " + FriendCnt[1];
                    Group1_Panel.BorderStyle = BorderStyle.Fixed3D;
                    Group2_Panel.BorderStyle = BorderStyle.Fixed3D;
                }
                else
                {
                    FriendCnt = new int[GroupCnt];
                    FriendCnt[0] = Convert.ToInt32(datas[3]);
                    FriendCnt[1] = Convert.ToInt32(datas[5 + 2 * FriendCnt[0]]);
                    FriendCnt[2] = Convert.ToInt32(datas[FriendCnt[0] * 2 + FriendCnt[1] * 2 + 7]);
                    Group1_Info.Text = datas[2] + " " + FriendCnt[0];
                    Group1_Panel.BorderStyle = BorderStyle.Fixed3D;
                    Group2_Info.Text = datas[4 + 2 * FriendCnt[0]] + " " + FriendCnt[1];
                    Group2_Panel.BorderStyle = BorderStyle.Fixed3D;
                    Group3_Info.Text = datas[FriendCnt[0] * 2 + FriendCnt[1] * 2 + 6] + " " + FriendCnt[2];
                    Group3_Panel.BorderStyle = BorderStyle.Fixed3D;
                }
            }
        }

        private void toFriend_Click(object sender, EventArgs e)
        {
            this.Hide();
            friendlist = new FriendList(Connection);
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
            if (Group3_Info.Text == "") return;
            //채팅창 열기
        }

        private void Group2_Panel_Paint(object sender, PaintEventArgs e)
        {
            if (Group3_Info.Text == "") return;
            //채팅창 열기
        }

        private void Group3_Panel_Paint(object sender, PaintEventArgs e)
        {
            if (Group3_Info.Text == "") return;
            //채팅창 열기
        }
    }
}
