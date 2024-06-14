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
    public partial class Login : Form
    {
        private Form1 parent;
        public event EventHandler SignupClicked;
        public event EventHandler Logined;

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
            parent.Connect();
            parent.m_Thread = new Thread(new ThreadStart(WriteInfo));

            string isRight = parent.m_Read.ReadLine();
            //if (isRight == "Right") {
            //    Logined?Invoke(this, EventArgs.Empty);
            //}
        }

        public void WriteInfo()
        {
            try
            {
                parent.m_Write.WriteLine("1," + txtID.Text + "," + "###," + txtPwd.Text);
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
