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
    public partial class ChatList : Form
    {
        TcpConnection Connection;

        public ChatList(TcpConnection connect)
        {
            Connection = connect;
            InitializeComponent();
        }
    }
}
