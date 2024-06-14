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
                MessageBox.Show("try to connect");
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

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login = new Login(this);
            login.MdiParent = this;
            login.Text = "Log In";
            login.Show();
            login.SignupClicked += Login_SignupClicked;
        }

        private void Login_SignupClicked(object sender, EventArgs e)
        {
            signup = new Signup();
            signup.MdiParent = this;
            signup.Text = "Sign Up";
            signup.Show();
        }
    }
}