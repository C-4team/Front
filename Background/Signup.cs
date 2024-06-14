using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Background
{
    public partial class Signup : Form
    {
        private Form1 parent;
        Thread m_SendThread;
        Thread m_ReceiveThread;

        public Signup(Form1 form)
        {
            parent = form;
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length == 0 || txtName.Text.Length == 0 || txtPwd.Text.Length == 0) return;

            if(parent.m_bConnect)
            {
                m_SendThread = new Thread(new ThreadStart(Send));
            }
        }

        public void Send()
        {
            string msg;
        }


        public void Receive()
        {
            
        }
    }
}
