using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;
using System.Net;
using System.Net.Http.Headers;

//using System.Net.Sockets;
using System.Security.Cryptography;

namespace UI
{
    public partial class LoginForm : Form
    {
        TcpConnection tcpConnection;
        SignupForm signupform = new SignupForm();
        chattingRoom chatRoom;

        public LoginForm()
        {
            chatRoom = new chattingRoom(tcpConnection);
            InitializeComponent();
            chatRoom.ShowDialog();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = IDbox;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string ID = IDbox.Text;
            string Pwd = pwdBox.Text;
            string loginMessage = ID + "," + Pwd;
            if (LOGIN(loginMessage))
                MessageBox.Show("login completed");
            else
                MessageBox.Show("Wrong Try");
        }

        private bool LOGIN(string loginmessage)
        {
            //������ ���̵�, ��� ������ �ִ��� Ȯ���ϰ� ��ȯ
            //������ true, ������ false

            return true;
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            signupform.ShowDialog();
            //chatRoom.ShowDialog();
        }
    }
}