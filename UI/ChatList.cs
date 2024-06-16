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

        System.Timers.Timer timer;
        Thread RequestThread;
        Thread RespondThread;
        Thread CreateGroupThread;

        public ChatList(TcpConnection connect)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 5000; // 5000ms = 5초
            timer.Elapsed += TimerElapsed; // 타이머 이벤트 핸들러 등록
            Connection = connect;
            InitializeComponent();
            timer.Start();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            RequestThread = new Thread(new ThreadStart(RequestDataFromServer));
            RequestThread.Start();
            RespondThread = new Thread(new ThreadStart(RespondDataFromServer));
            RespondThread.Start();
        }

        private void RequestDataFromServer()
        {
            Connection.m_Write.WriteLine("2");
        }

        private void RespondDataFromServer()
        {
            string data = Connection.m_Read.ReadLine();
            //그룹처리
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
                if(RequestThread != null)
                    RequestThread.Abort();
                if(RespondThread != null)
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
        }
    }
}
