namespace UI
{
    partial class FriendList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendList));
            label1 = new Label();
            label2 = new Label();
            Add = new PictureBox();
            Setting = new PictureBox();
            toFriend = new PictureBox();
            toChat = new PictureBox();
            TLPanel = new TableLayoutPanel();
            FriendPanel1 = new Panel();
            Friend1_ID = new Label();
            Friend1_Name = new Label();
            FriendPanel3 = new Panel();
            Friend3_Name = new Label();
            Friend3_ID = new Label();
            FriendPanel2 = new Panel();
            Friend2_ID = new Label();
            Friend2_Name = new Label();
            ((System.ComponentModel.ISupportInitialize)Add).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Setting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toFriend).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toChat).BeginInit();
            TLPanel.SuspendLayout();
            FriendPanel1.SuspendLayout();
            FriendPanel3.SuspendLayout();
            FriendPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 35F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(0, -8);
            label2.Name = "label2";
            label2.Size = new Size(200, 78);
            label2.TabIndex = 1;
            label2.Text = "Friend";
            // 
            // Add
            // 
            Add.Image = (Image)resources.GetObject("Add.Image");
            Add.Location = new Point(282, 18);
            Add.Name = "Add";
            Add.Size = new Size(63, 52);
            Add.SizeMode = PictureBoxSizeMode.Zoom;
            Add.TabIndex = 2;
            Add.TabStop = false;
            Add.Click += Add_Click;
            // 
            // Setting
            // 
            Setting.Image = (Image)resources.GetObject("Setting.Image");
            Setting.Location = new Point(340, 18);
            Setting.Margin = new Padding(3, 2, 3, 2);
            Setting.Name = "Setting";
            Setting.Size = new Size(54, 52);
            Setting.SizeMode = PictureBoxSizeMode.Zoom;
            Setting.TabIndex = 4;
            Setting.TabStop = false;
            Setting.Click += Setting_Click;
            // 
            // toFriend
            // 
            toFriend.Image = (Image)resources.GetObject("toFriend.Image");
            toFriend.Location = new Point(70, 502);
            toFriend.Margin = new Padding(3, 2, 3, 2);
            toFriend.Name = "toFriend";
            toFriend.Size = new Size(92, 82);
            toFriend.TabIndex = 5;
            toFriend.TabStop = false;
            // 
            // toChat
            // 
            toChat.Image = (Image)resources.GetObject("toChat.Image");
            toChat.Location = new Point(251, 502);
            toChat.Margin = new Padding(3, 2, 3, 2);
            toChat.Name = "toChat";
            toChat.Size = new Size(97, 85);
            toChat.TabIndex = 6;
            toChat.TabStop = false;
            toChat.Click += toChat_Click;
            // 
            // TLPanel
            // 
            TLPanel.ColumnCount = 1;
            TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TLPanel.Controls.Add(FriendPanel1, 0, 0);
            TLPanel.Controls.Add(FriendPanel3, 0, 2);
            TLPanel.Controls.Add(FriendPanel2, 0, 1);
            TLPanel.Location = new Point(11, 83);
            TLPanel.Name = "TLPanel";
            TLPanel.RowCount = 3;
            TLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TLPanel.Size = new Size(393, 410);
            TLPanel.TabIndex = 7;
            // 
            // FriendPanel1
            // 
            FriendPanel1.Controls.Add(Friend1_ID);
            FriendPanel1.Controls.Add(Friend1_Name);
            FriendPanel1.Dock = DockStyle.Fill;
            FriendPanel1.Location = new Point(3, 3);
            FriendPanel1.Name = "FriendPanel1";
            FriendPanel1.Size = new Size(387, 130);
            FriendPanel1.TabIndex = 0;
            // 
            // Friend1_ID
            // 
            Friend1_ID.AutoSize = true;
            Friend1_ID.ForeColor = Color.White;
            Friend1_ID.Location = new Point(56, 58);
            Friend1_ID.Name = "Friend1_ID";
            Friend1_ID.Size = new Size(17, 20);
            Friend1_ID.TabIndex = 1;
            Friend1_ID.Text = "1";
            // 
            // Friend1_Name
            // 
            Friend1_Name.AutoSize = true;
            Friend1_Name.ForeColor = Color.White;
            Friend1_Name.Location = new Point(56, 20);
            Friend1_Name.Name = "Friend1_Name";
            Friend1_Name.Size = new Size(17, 20);
            Friend1_Name.TabIndex = 0;
            Friend1_Name.Text = "1";
            // 
            // FriendPanel3
            // 
            FriendPanel3.Controls.Add(Friend3_Name);
            FriendPanel3.Controls.Add(Friend3_ID);
            FriendPanel3.Dock = DockStyle.Fill;
            FriendPanel3.Location = new Point(3, 275);
            FriendPanel3.Name = "FriendPanel3";
            FriendPanel3.Size = new Size(387, 132);
            FriendPanel3.TabIndex = 1;
            // 
            // Friend3_Name
            // 
            Friend3_Name.AutoSize = true;
            Friend3_Name.ForeColor = Color.White;
            Friend3_Name.Location = new Point(56, 22);
            Friend3_Name.Name = "Friend3_Name";
            Friend3_Name.Size = new Size(50, 20);
            Friend3_Name.TabIndex = 1;
            Friend3_Name.Text = "label6";
            // 
            // Friend3_ID
            // 
            Friend3_ID.AutoSize = true;
            Friend3_ID.ForeColor = Color.White;
            Friend3_ID.Location = new Point(56, 56);
            Friend3_ID.Name = "Friend3_ID";
            Friend3_ID.Size = new Size(50, 20);
            Friend3_ID.TabIndex = 0;
            Friend3_ID.Text = "label5";
            // 
            // FriendPanel2
            // 
            FriendPanel2.Controls.Add(Friend2_ID);
            FriendPanel2.Controls.Add(Friend2_Name);
            FriendPanel2.Dock = DockStyle.Fill;
            FriendPanel2.Location = new Point(3, 139);
            FriendPanel2.Name = "FriendPanel2";
            FriendPanel2.Size = new Size(387, 130);
            FriendPanel2.TabIndex = 2;
            // 
            // Friend2_ID
            // 
            Friend2_ID.AutoSize = true;
            Friend2_ID.ForeColor = Color.White;
            Friend2_ID.Location = new Point(56, 55);
            Friend2_ID.Name = "Friend2_ID";
            Friend2_ID.Size = new Size(50, 20);
            Friend2_ID.TabIndex = 1;
            Friend2_ID.Text = "label4";
            // 
            // Friend2_Name
            // 
            Friend2_Name.AutoSize = true;
            Friend2_Name.ForeColor = Color.White;
            Friend2_Name.Location = new Point(56, 24);
            Friend2_Name.Name = "Friend2_Name";
            Friend2_Name.Size = new Size(50, 20);
            Friend2_Name.TabIndex = 0;
            Friend2_Name.Text = "label3";
            // 
            // FriendList
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 13, 19);
            ClientSize = new Size(414, 593);
            Controls.Add(TLPanel);
            Controls.Add(toChat);
            Controls.Add(toFriend);
            Controls.Add(Setting);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Add);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FriendList";
            Text = " ";
            Load += FriendList_Load;
            ((System.ComponentModel.ISupportInitialize)Add).EndInit();
            ((System.ComponentModel.ISupportInitialize)Setting).EndInit();
            ((System.ComponentModel.ISupportInitialize)toFriend).EndInit();
            ((System.ComponentModel.ISupportInitialize)toChat).EndInit();
            TLPanel.ResumeLayout(false);
            FriendPanel1.ResumeLayout(false);
            FriendPanel1.PerformLayout();
            FriendPanel3.ResumeLayout(false);
            FriendPanel3.PerformLayout();
            FriendPanel2.ResumeLayout(false);
            FriendPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox Add;
        private PictureBox Setting;
        private PictureBox toFriend;
        private PictureBox toChat;
        private TableLayoutPanel TLPanel;
        private Panel FriendPanel1;
        private Label Friend1_Name;
        private Label Friend1_ID;
        private Panel FriendPanel3;
        private Label Friend3_Name;
        private Label Friend3_ID;
        private Panel FriendPanel2;
        private Label Friend2_ID;
        private Label Friend2_Name;
    }
}