using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;

namespace UI
{
    public partial class FriendList : Form
    {
        TcpConnection Connection;
        CancellationTokenSource cts;
        ChatList chatlist;
        AddForm AddFriendForm;

        Thread GetData;
        string Myname = "";
        public FriendList(string name, TcpConnection connection)
        {
            Myname = name;
            Connection = connection;
            cts = new CancellationTokenSource();
            InitializeComponent();
            this.Name = name;
            this.MinimumSize = new Size(482, 797);
            this.MaximumSize = new Size(482, 797);
        }

        private void GetDataFromServer(CancellationToken token)
        {
            while(!token.IsCancellationRequested)
            {
                RequestDataFromServer();
                RespondDataFromServer();
                Thread.Sleep(3000);
            }
            return;
        }

        private void RequestDataFromServer()
        {
            Connection.m_Write.WriteLine("2");
        }

        private void RespondDataFromServer()
        {
            Friend1_ID.Text = "";
            Friend1_Name.Text = "";
            Friend2_ID.Text = "";
            Friend2_Name.Text = "";
            Friend3_ID.Text = "";
            Friend3_Name.Text = "";
            FriendPanel1.BorderStyle = BorderStyle.None;
            FriendPanel2.BorderStyle = BorderStyle.None;
            FriendPanel3.BorderStyle = BorderStyle.None;

            string data = Connection.m_Read.ReadLine();

            if (data.StartsWith("4"))
                return;
            else if (data.StartsWith("5"))
            {
                string[] datas = data.Split(',');
                int G_Cnt = Convert.ToInt32(datas[1]);
                int[] U_cnt;

                if (G_Cnt == 0)
                {
                    int FriendCount = Convert.ToInt32(datas[2]);
                    if (FriendCount == 0)
                    {
                        return;
                    }
                    else if (FriendCount == 1)
                    {
                        FriendPanel1.BorderStyle = BorderStyle.Fixed3D;
                        Friend1_ID.Text = datas[3];
                        Friend1_Name.Text = datas[4];
                    }
                    else if (FriendCount == 2)
                    {
                        FriendPanel1.BorderStyle = BorderStyle.Fixed3D;
                        Friend1_ID.Text = datas[3];
                        Friend1_Name.Text = datas[4];
                        FriendPanel2.BorderStyle = BorderStyle.Fixed3D;
                        Friend2_ID.Text = datas[5];
                        Friend2_Name.Text = datas[6];
                    }
                    else
                    {
                        FriendPanel1.BorderStyle = BorderStyle.Fixed3D;
                        Friend1_ID.Text = datas[3];
                        Friend1_Name.Text = datas[4];
                        FriendPanel2.BorderStyle = BorderStyle.Fixed3D;
                        Friend2_ID.Text = datas[5];
                        Friend2_Name.Text = datas[6];
                        FriendPanel3.BorderStyle = BorderStyle.Fixed3D;
                        Friend3_ID.Text = datas[7];
                        Friend3_Name.Text = datas[8];
                    }
                }
                else if (G_Cnt == 1)
                {
                    U_cnt = new int[G_Cnt];
                    U_cnt[0] = Convert.ToInt32(datas[4]);
                    int FriendCount = Convert.ToInt32(datas[5 + U_cnt[0]]);
                    if (FriendCount == 0)
                    {
                        return;
                    }
                    else if (FriendCount == 1)
                    {
                        FriendPanel1.BorderStyle = BorderStyle.Fixed3D;
                        Friend1_ID.Text = datas[6 + U_cnt[0]];
                        Friend1_Name.Text = datas[7 + U_cnt[0]];
                    }
                    else if (FriendCount == 2)
                    {
                        FriendPanel1.BorderStyle = BorderStyle.Fixed3D;
                        Friend1_ID.Text = datas[6 + U_cnt[0]];
                        Friend1_Name.Text = datas[7 + U_cnt[0]];
                        FriendPanel2.BorderStyle = BorderStyle.Fixed3D;
                        Friend2_ID.Text = datas[8 + U_cnt[0]];
                        Friend2_Name.Text = datas[9 + U_cnt[0]];
                    }
                    else
                    {
                        FriendPanel1.BorderStyle = BorderStyle.Fixed3D;
                        Friend1_ID.Text = datas[6 + U_cnt[0]];
                        Friend1_Name.Text = datas[7 + U_cnt[0]];
                        FriendPanel2.BorderStyle = BorderStyle.Fixed3D;
                        Friend2_ID.Text = datas[8 + U_cnt[0]];
                        Friend2_Name.Text = datas[9 + U_cnt[0]];
                        FriendPanel3.BorderStyle = BorderStyle.Fixed3D;
                        Friend3_ID.Text = datas[10 + U_cnt[0]];
                        Friend3_Name.Text = datas[11 + U_cnt[0]];
                    }
                }
                else if (G_Cnt == 2)
                {
                    U_cnt = new int[G_Cnt];
                    U_cnt[0] = Convert.ToInt32(datas[4]);
                    U_cnt[1] = Convert.ToInt32(datas[7 + U_cnt[0]]);
                    int FriendCount = Convert.ToInt32(datas[8 + U_cnt[0] + U_cnt[1]]);
                    if (FriendCount == 0)
                    {
                        return;
                    }
                    else if (FriendCount == 1)
                    {
                        FriendPanel1.BorderStyle = BorderStyle.Fixed3D;
                        Friend1_ID.Text = datas[9 + U_cnt[0] + U_cnt[1]];
                        Friend1_Name.Text = datas[10 + U_cnt[0] + U_cnt[1]];
                    }
                    else if (FriendCount == 2)
                    {
                        FriendPanel1.BorderStyle = BorderStyle.Fixed3D;
                        Friend1_ID.Text = datas[9 + U_cnt[0] + U_cnt[1]];
                        Friend1_Name.Text = datas[10 + +U_cnt[0] + U_cnt[1]];
                        FriendPanel2.BorderStyle = BorderStyle.Fixed3D;
                        Friend2_ID.Text = datas[11 + U_cnt[0] + U_cnt[1]];
                        Friend2_Name.Text = datas[12 + U_cnt[0] + U_cnt[1]];
                    }
                    else
                    {
                        FriendPanel1.BorderStyle = BorderStyle.Fixed3D;
                        Friend1_ID.Text = datas[9 + U_cnt[0] + U_cnt[1]];
                        Friend1_Name.Text = datas[10 + +U_cnt[0] + U_cnt[1]];
                        FriendPanel2.BorderStyle = BorderStyle.Fixed3D;
                        Friend2_ID.Text = datas[11 + U_cnt[0] + U_cnt[1]];
                        Friend2_Name.Text = datas[12 + U_cnt[0] + U_cnt[1]];
                        FriendPanel3.BorderStyle = BorderStyle.Fixed3D;
                        Friend3_ID.Text = datas[13 + U_cnt[0] + U_cnt[1]];
                        Friend3_Name.Text = datas[14 + U_cnt[0] + U_cnt[1]];
                    }
                }
                else
                {
                    U_cnt = new int[G_Cnt];
                    U_cnt[0] = Convert.ToInt32(datas[4]);
                    U_cnt[1] = Convert.ToInt32(datas[7 + U_cnt[0]]);
                    U_cnt[2] = Convert.ToInt32(datas[U_cnt[0] + U_cnt[1] + 10]);
                    int FriendCount = Convert.ToInt32(datas[11 + U_cnt[0] + U_cnt[1] + U_cnt[2]]);
                    if (FriendCount == 0)
                    {
                        return;
                    }
                    else if (FriendCount == 1)
                    {
                        FriendPanel1.BorderStyle = BorderStyle.Fixed3D;
                        Friend1_ID.Text = datas[12 + U_cnt[0] + U_cnt[1] + U_cnt[2]];
                        Friend1_Name.Text = datas[13 + U_cnt[0] + U_cnt[1] + U_cnt[2]];
                    }
                    else if (FriendCount == 2)
                    {
                        FriendPanel1.BorderStyle = BorderStyle.Fixed3D;
                        Friend1_ID.Text = datas[12 + U_cnt[0] + U_cnt[1] + U_cnt[2]];
                        Friend1_Name.Text = datas[13 + U_cnt[0] + U_cnt[1] + U_cnt[2]];
                        FriendPanel2.BorderStyle = BorderStyle.Fixed3D;
                        Friend2_ID.Text = datas[14 + U_cnt[0] + U_cnt[1] + U_cnt[2]];
                        Friend2_Name.Text = datas[15 + U_cnt[0] + U_cnt[1] + U_cnt[2]];
                    }
                    else
                    {
                        FriendPanel1.BorderStyle = BorderStyle.Fixed3D;
                        Friend1_ID.Text = datas[12 + U_cnt[0] + U_cnt[1] + U_cnt[2]];
                        Friend1_Name.Text = datas[13 + U_cnt[0] + U_cnt[1] + U_cnt[2]];
                        FriendPanel2.BorderStyle = BorderStyle.Fixed3D;
                        Friend2_ID.Text = datas[14 + U_cnt[0] + U_cnt[1] + U_cnt[2]];
                        Friend2_Name.Text = datas[15 + U_cnt[0] + U_cnt[1] + U_cnt[2]];
                        FriendPanel3.BorderStyle = BorderStyle.Fixed3D;
                        Friend3_ID.Text = datas[16 + U_cnt[0] + U_cnt[1] + U_cnt[2]];
                        Friend3_Name.Text = datas[17 + U_cnt[0] + U_cnt[1] + U_cnt[2]];
                    }
                }
            }
        }

        private void toChat_Click(object sender, EventArgs e)
        {
            this.Hide();
            cts.Cancel();
            chatlist = new ChatList(Myname, Connection);
            chatlist.ShowDialog();
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("로그아웃 하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                cts.Cancel();
                Connection.Disconnect();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddFriendForm = new AddForm(0, Connection);
            AddFriendForm.ShowDialog();
        }

        private void FriendList_Load(object sender, EventArgs e)
        {
            GetData = new Thread(() => GetDataFromServer(cts.Token));
            GetData.Start();
        }
    }
}
