using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Text;

namespace UI
{
    public class TcpConnection
    {
        //public event Action<string> MessageRecevied;

        /*public NetworkStream m_Stream;
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
            m_Write.AutoFlush = true;

        }*/
        /*
        private void RecevieMessages()
        {
            try
            {
                byte[] buffer new byte[1024];
                while (true)
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if(bytesRead > 0)
                    {
                        string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        MessageReceived?.Invoke(message);
                    }
                }
            }
            catch(Exception ex)
            {
                //예외처리
            }
        }*/

        /*public void SendMessage(string message)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                Stream.Write(data, 0, data.Length);
            }
            catch(Exception ex) {
                throw new Exception("Error" + ex.Message);
            }
        }*/
    }

}