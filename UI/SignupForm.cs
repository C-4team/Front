using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Xml.Linq;

namespace UI
{
    public partial class SignupForm : Form
    {
        TcpConnection Connection;
        Thread m_RequestThread;
        Thread m_RespondThread;

        FriendList friendlist;
        LoginForm loginForm;
        public SignupForm(TcpConnection connection, LoginForm login)
        {
            Connection = connection;
            InitializeComponent();
            loginForm = login;

            MinimumSize = new Size(420, 657);
            MaximumSize = new Size(420, 657);
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            if (namebox.Text.Length == 0 || IDbox.Text.Length == 0 || pwdbox.Text.Length == 0) return;

            if(!Connection.m_bConnect) Connection.Connect();

            m_RequestThread = new Thread(new ThreadStart(Send));
            m_RequestThread.Start();

            m_RespondThread = new Thread(new ThreadStart(Receive));
            m_RespondThread.Start();
        }

        public void Send()
        {
            try
            {
                string msg = "0," + IDbox.Text + "," + namebox.Text + "," + pwdbox.Text;
                Connection.m_Write.WriteLine(msg);
            }
            catch
            {
                MessageBox.Show("Send Error");
            }
        }


        public void Receive()
        {
            try
            {
                string isRight = Connection.m_Read.ReadLine();
                string prefix = isRight.Length >= 2 ? isRight.Substring(0, 1) : isRight;

                if (prefix == "1")
                {
                    this.Hide();
                    loginForm.Hide();
                    friendlist = new FriendList(Connection);
                    friendlist.ShowDialog();
                }
                else if (prefix == "0")
                {
                    m_RequestThread.Abort();
                    m_RespondThread.Abort();

                    Connection.Disconnect();
                }
            }
            catch
            {
                MessageBox.Show("Read Error!");
            }
        }
    }
}
