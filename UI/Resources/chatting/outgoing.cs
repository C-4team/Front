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
    public partial class outgoing : UserControl
    {
        public outgoing()
        {
            InitializeComponent();
        }

        public string Message
        {
            get
            {
                //서버로부터 message 받기
                return sendTxt.Text;
            }
            set
            {
                sendTxt.Text = value;

                AdjustHeight();
            }
        }

        void AdjustHeight()
        {
            sendTxt.Location = new Point(368, 26);
            sendTxt.Height = Utils.GetTextHeight(sendTxt) + 2;

            //sendtxt 상단 좌표값 + height
            outChat.Location = new Point(355, 10);
            outChat.Height = sendTxt.Top + sendTxt.Height;

            //현재 폼의 높이
            this.Height = outChat.Bottom + 5;
        }

        private void outgoing_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void outgoing_DockChanged(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
