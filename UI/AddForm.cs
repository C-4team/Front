using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AddForm : Form
    {
        TcpConnection Connection;
        Thread RequestThread;
        Thread RespondThread;

        int isChat;
        public AddForm(int ischat, TcpConnection connection)
        {
            isChat = ischat;
            if (isChat == 0)
            {
                this.Text = "AddFriends";
            }
            else
            {
                this.Text = "AddChats";
            }
            Connection = connection;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtContent.Text.Length == 0) return;

            if (isChat == 0)
            {
                RequestThread = new Thread(new ThreadStart(RequestFriend));
                RequestThread.Start();

                RespondThread = new Thread(new ThreadStart(RespondFriend));
                RespondThread.Start();
            }
            else
            {
                RequestThread = new Thread(new ThreadStart(RequestChat));
                RequestThread.Start();

                RespondThread = new Thread(new ThreadStart(RespondChat));
                RespondThread.Start();
            }
        }

        private void RequestFriend()
        {
            Connection.m_Write.WriteLine("3," + txtContent.Text);
        }

        private void RespondFriend()
        {
            string response = Connection.m_Read.ReadLine();

            if (response.StartsWith("6"))
            {
                MessageBox.Show("이미 친구이거나 존재하지 않는 유저입니다.");
                this.Invoke((MethodInvoker)delegate
                {
                    this.Close();
                });
            }
            else if (response.StartsWith("7"))
            {
                MessageBox.Show("친구 추가가 완료되었습니다.");
                this.Invoke((MethodInvoker)delegate
                {
                    this.Close();
                });
            }
        }

        private void RequestChat()
        {
            Connection.m_Write.WriteLine("5," + txtContent.Text);
        }

        private void RespondChat()
        {
            string response = Connection.m_Read.ReadLine();
            this.Invoke((MethodInvoker)delegate
            {
                this.Close();
            });
        }

    }
}
