using Microsoft.VisualBasic.ApplicationServices;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Security.Cryptography;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.IO;

namespace UI
{
    public partial class LoginForm : Form
    {
        TcpConnection Connection;
        Thread m_RequestThread;
        Thread m_RespondThread;

        SignupForm signupform;
        FriendList friendlist;

        string myName;
        public LoginForm()
        {
            InitializeComponent();
            Connection = new TcpConnection();
            signupform = new SignupForm(Connection, this);
            myName = "";

            this.MinimumSize = new Size(482, 797);
            this.MaximumSize = new Size(482, 797);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = IDbox;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (IDbox.Text.Length == 0 || pwdBox.Text.Length == 0)
            {
                MessageBox.Show("아이디와 비밀번호를 입력하세요");
                Connection.Disconnect();
                return;
            }

            Connection.Connect();
            if (Connection.m_bConnect)
            {
                m_RequestThread = new Thread(new ThreadStart(WriteInfo));
                m_RequestThread.Start();

                m_RespondThread = new Thread(new ThreadStart(ReadRight));
                m_RespondThread.Start();
            }
        }

        public void ReadRight()
        {
            try
            {
                string isRight = Connection.m_Read.ReadLine();
                string[] datas = isRight.Split(',');
                string Right = "3";
                string Wrong = "2";

                if (datas[0] == Right)
                {
                    myName = datas[1];

                    this.Hide();
                    friendlist = new FriendList(myName, Connection);
                    friendlist.ShowDialog();
                }
                else if (datas[0] == Wrong)
                {
                    m_RequestThread.Abort();
                    m_RespondThread.Abort();
                    Connection.Disconnect();
                }
                else
                {
                    MessageBox.Show(isRight);
                }
            }
            catch
            {
                MessageBox.Show("Read Error!");
            }
        }

        public void WriteInfo()
        {
            try
            {
                Connection.m_Write.WriteLine("1," + IDbox.Text + "," + pwdBox.Text);
                Connection.m_Write.Flush();
            }
            catch
            {
                MessageBox.Show("Error in WriteInfo");
            }
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            signupform.ShowDialog();
            signupform.FormClosed += (s, args) => this.Show();
        }
    }
}