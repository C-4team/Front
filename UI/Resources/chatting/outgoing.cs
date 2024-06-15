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
            sendTxt.Location = new Point(9, 33);
            sendTxt.Height = Utils.GetTextHeight(sendTxt) + 10;

            //sendtxt 상단 좌표값 + height
            outChat.Height = sendTxt.Top + sendTxt.Height;

            //현재 폼의 높이
            this.Height = outChat.Bottom + 10;
        }

        private void outgoing_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
