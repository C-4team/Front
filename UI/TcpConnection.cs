using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace UI
{
    public class TcpConnection
    {
        public NetworkStream m_Stream;
        public StreamReader m_Read;
        public StreamWriter m_Write;
        const int PORT = 12000;
        string IpAddress = "127.0.0.1";
        public bool m_bConnect = false;
        TcpClient m_Client;

        public void Connect()
        {
            try
            {
                m_Client = new TcpClient(IpAddress, PORT);
                MessageBox.Show("연결");
            }
            catch
            {
                MessageBox.Show("연결 오류");
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
    }

}