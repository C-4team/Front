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
    public partial class FriendList : Form
    {
        TcpConnection Connection;
        public FriendList(TcpConnection connection)
        {
            Connection = connection;
            InitializeComponent();
        }
    }
}
