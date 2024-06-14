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

        public event EventHandler Joined;

        public Signup(Form1 form)
        {
            parent = form;
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length == 0 || txtName.Text.Length == 0 || txtPwd.Text.Length == 0) return;
            if(!parent.m_bConnect)
                parent.Connect();

            if(parent.m_bConnect)
            {
                m_SendThread = new Thread(new ThreadStart(Send));
                m_SendThread.Start();

                Thread.Sleep(1000);

                m_ReceiveThread = new Thread(new ThreadStart(Receive));
                m_ReceiveThread.Start();
            }
        }

        public void Send()
        {
            try
            {
                string msg = "0," + txtID.Text + "," + txtName.Text + "," + txtPwd.Text;
                parent.m_Write.WriteLine(msg);
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
                string isRight = parent.m_Read.ReadLine();
                if (isRight[0] == 1)
                {
                    Joined?.Invoke(this, EventArgs.Empty);
                }
                else if (isRight[0] == 0)
                {
                    m_SendThread.Abort();
                    m_ReceiveThread.Abort();

                    parent.Disconnect();
                }
            }
            catch
            {
                MessageBox.Show("Read Error!");
            }
        }
    }
}
