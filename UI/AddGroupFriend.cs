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
    public partial class AddGroupFriend : Form
    {
        private TcpConnection tcpConnection;
        private Thread requestThread;
        private Thread responseThread;
        private string groupID = "";
        public AddGroupFriend(TcpConnection Connection, string groupId)
        {
            groupID = groupId;
            tcpConnection = Connection;
            InitializeComponent();
            inputId.Leave += new EventHandler(inputId_Leave);
        }

        private void inputId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputId.Text))
            {
                inputId.Text = "Id를 입력하세요.";
                inputId.ForeColor = Color.White;
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (!tcpConnection.m_bConnect) tcpConnection.Connect(); //서버에 연결 완료

            if (tcpConnection.m_bConnect)
            {
                Send();
                //responseThread = new Thread(new ThreadStart(checkResponse));
            }
            inputId.Text = string.Empty;
            this.Close();
        }

        private void Send()
        {
            if (inputId.Text.Trim().Length == 0) { return; }

            tcpConnection.m_Write.WriteLine("6," + groupID + "," + inputId.Text);
        }
    }
}
