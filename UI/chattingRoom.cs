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
    public partial class chattingRoom : Form
    {
        public chattingRoom()
        {
            InitializeComponent();


            this.MinimumSize = new Size(482, 797);
            this.MaximumSize = new Size(482, 797);
        }



        private void chattingRoom_Load(object sender, EventArgs e)
        {
            //시간 남으면 txt 모양 바꾸기
        }

        private void namelbl_Click(object sender, EventArgs e)
        {
            //서버로부터 요청보내기
            //서버로부터 요청받기
        }

        private void chatoutPic_Click(object sender, EventArgs e)
        {
            //chatlist로 이동
            this.Close();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            Send();
        }

        void Send()
        {
            if (sendTxt.Text.Trim().Length == 0) return;

            //textbox 서버로 보내기
            AddOutgoing(sendTxt.Text);
            sendTxt.Text = string.Empty;

            //get random response
        }

        /*void receiveSend()
        {
            if (sendTxt.Text.Trim().Length == 0) return;

            //textbox 서버로 보내기
            AddIncomming(sendTxt.Text);
            sendTxt.Text = string.Empty;

        }*/
        void AddIncomming(string message)
        {
            var bubble = new UI.Resources.chatting.incomming(); //Incomming 인스턴스를 새로 생성
            chatPnl.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
        }

        void AddOutgoing(string message)
        {
            var bubble = new UI.Resources.chatting.outgoing();
            chatPnl.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
        }
        /*
        private void sendTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                /*
                if(sendTxt.Text.StartsWith('2'))
                {
                    receiveSend();
                }
                Send();
            }

        }*/
    }
}
