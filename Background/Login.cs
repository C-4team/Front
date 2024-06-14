using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Background
{
    public partial class Login : Form
    {
        private Form1 parent;
        public event EventHandler SignupClicked;
        public event EventHandler Logined;
        Thread m_WriteThread;
        Thread m_Readthread;


        public Login(Form1 form)
        {
            parent = form;
            this.Controls.Add(btnSignup);
            this.Controls.Add(btnLogin);
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtID;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length == 0 || txtPwd.Text.Length == 0)
            {
                MessageBox.Show("아이디와 비밀번호를 입력하세요");
                return;
            }
            if(!parent.m_bConnect)
                parent.Connect();
            if(parent.m_bConnect) {
                MessageBox.Show("접속 성공");
                m_WriteThread = new Thread(new ThreadStart(WriteInfo));
                m_WriteThread.Start();

                Thread.Sleep(1000);

                m_Readthread = new Thread(new ThreadStart(ReadRight));
                m_Readthread.Start();
            }
        }

        public void ReadRight()
        {
            try
            {
                string isRight = parent.m_Read.ReadLine();
                if (Logined != null)
                {
                    if (isRight == "Right")
                    {
                        Logined?.Invoke(this, EventArgs.Empty);
                    }
                }
                else return;
            }
            catch
            {
                MessageBox.Show("Read Error!");
            }
        }

        public void WriteInfo()
        {
            try
            {
                parent.m_Write.WriteLine("1," + txtID.Text + "," + "###," + txtPwd.Text);
                parent.m_Write.Flush();
            } catch {
                MessageBox.Show("Error in WriteInfo");
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignupClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
