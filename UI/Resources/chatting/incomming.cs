using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilsClass;

namespace UI.Resources.chatting
{
    public partial class incomming : UserControl
    {
        public incomming()
        {
            InitializeComponent();
        }

        private void incomming_Load(object sender, EventArgs e)
        {

        }

        private void inName_Click(object sender, EventArgs e)
        {
            //서버로부터 이름 받기
            //서버로부터 label 설정학
            //label size 도 설정하기
        }

        public string Message
        {
            get
            {
                //서버로부터 message 받기
                return receiveTxt.Text;
            }

            set
            {
                receiveTxt.Text = value;

                AdjustchatHeight();
            }
        }

        public string name
        {
            get
            {
                //서버로부터 name 받기
                return inName.Text;
            }
            set
            {
                inName.Text = value;
                AdjustnameHeight();
            }
        }

        void AdjustchatHeight()
        {
            receiveTxt.Location = new Point(12, 42);
            receiveTxt.Height = Utils.GetTextHeight(receiveTxt) + 2;

            //incomtxt 상단 좌표값 + height
            inChat.Location = new Point(-1, 24);
            inChat.Height = receiveTxt.Height + receiveTxt.Top - 5;
        }

        void AdjustnameHeight()
        {
            inName.Location = new Point(3, 0);
            inName.Width = Utils.GetnameWidth(inName) + 1;

            this.Height = inName.Top + inChat.Bottom + 5;
        }

        private void incomming_Resize(object sender, EventArgs e)
        {
            AdjustchatHeight();
            AdjustnameHeight();
        }

        private void inChat_Click(object sender, EventArgs e)
        {

        }
    }
}
