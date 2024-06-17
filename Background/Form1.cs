using System.Net.Sockets;
using System.Text;

namespace Background
{
    public partial class Form1 : Form
    {
        public NetworkStream m_Stream;
        public StreamReader m_Read;
        public StreamWriter m_Write;
        const int PORT = 12000;
        string IpAddress = "127.0.0.1";
        public bool m_bConnect = false;
        TcpClient m_Client;
        public Thread m_Thread;

        Login login;
        Signup signup;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public void Connect()
        {
            try
            {
                m_Client = new TcpClient(IpAddress, PORT);
            }
            catch
            {
                m_bConnect = false;
                return;
            }
            m_bConnect = true;
            m_Stream = m_Client.GetStream();
            m_Read = new StreamReader(m_Stream);
            m_Write = new StreamWriter(m_Stream);
            m_Write.AutoFlush = true;
        }

        public void Disconnect()
        {
            m_bConnect = false;

            m_Read.Close();
            m_Write.Close();
            m_Stream.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login = new Login(this);
            login.MdiParent = this;
            login.Text = "Log In";
            login.Show();
            login.SignupClicked += Login_SignupClicked;
            login.Logined += Login_Logined;
            signup.Joined += Signup_Joined;
        }

        private void Login_SignupClicked(object sender, EventArgs e)
        {
            signup = new Signup(this);
            signup.MdiParent = this;
            signup.Text = "Sign Up";
            signup.Show();
        }

        private void Login_Logined(object sender, EventArgs e)
        {
            //模备芒 家券
        }

        private void Signup_Joined(object sender, EventArgs e)
        {
            //模备芒 家券
        }
    }
}