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


            this.MinimumSize = new Size(420, 657);
            this.MaximumSize = new Size(420, 657);
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
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            //textbox 서버로 보내기
            sendTxt.Text = string.Empty;
        }

        private void chatPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void incomming1_Load(object sender, EventArgs e)
        {

        }
    }
}
