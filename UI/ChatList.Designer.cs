namespace UI
{
    partial class ChatList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatList));
            label2 = new Label();
            toFriend = new PictureBox();
            toChat = new PictureBox();
            Setting = new PictureBox();
            Add = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            Group1_Panel = new Panel();
            Group1_Info = new Label();
            Group2_Panel = new Panel();
            Group2_Info = new Label();
            Group3_Panel = new Panel();
            Group3_Info = new Label();
            ((System.ComponentModel.ISupportInitialize)toFriend).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toChat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Setting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Add).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            Group1_Panel.SuspendLayout();
            Group2_Panel.SuspendLayout();
            Group3_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(9, -1);
            label2.Name = "label2";
            label2.Size = new Size(130, 57);
            label2.TabIndex = 2;
            label2.Text = "Chats";
            // 
            // toFriend
            // 
            toFriend.Image = (Image)resources.GetObject("toFriend.Image");
            toFriend.Location = new Point(74, 502);
            toFriend.Margin = new Padding(3, 2, 3, 2);
            toFriend.Name = "toFriend";
            toFriend.Size = new Size(92, 82);
            toFriend.TabIndex = 7;
            toFriend.TabStop = false;
            toFriend.Click += toFriend_Click;
            // 
            // toChat
            // 
            toChat.Image = (Image)resources.GetObject("toChat.Image");
            toChat.Location = new Point(253, 502);
            toChat.Margin = new Padding(3, 2, 3, 2);
            toChat.Name = "toChat";
            toChat.Size = new Size(97, 85);
            toChat.TabIndex = 8;
            toChat.TabStop = false;
            // 
            // Setting
            // 
            Setting.Image = (Image)resources.GetObject("Setting.Image");
            Setting.Location = new Point(347, 14);
            Setting.Margin = new Padding(3, 2, 3, 2);
            Setting.Name = "Setting";
            Setting.Size = new Size(43, 45);
            Setting.SizeMode = PictureBoxSizeMode.Zoom;
            Setting.TabIndex = 11;
            Setting.TabStop = false;
            Setting.Click += Setting_Click;
            // 
            // Add
            // 
            Add.Image = (Image)resources.GetObject("Add.Image");
            Add.Location = new Point(290, 12);
            Add.Name = "Add";
            Add.Size = new Size(63, 52);
            Add.SizeMode = PictureBoxSizeMode.StretchImage;
            Add.TabIndex = 9;
            Add.TabStop = false;
            Add.Click += Add_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(Group1_Panel, 0, 0);
            tableLayoutPanel1.Controls.Add(Group2_Panel, 0, 1);
            tableLayoutPanel1.Controls.Add(Group3_Panel, 0, 2);
            tableLayoutPanel1.Location = new Point(9, 70);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(393, 427);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // Group1_Panel
            // 
            Group1_Panel.Controls.Add(Group1_Info);
            Group1_Panel.Dock = DockStyle.Fill;
            Group1_Panel.Location = new Point(3, 3);
            Group1_Panel.Name = "Group1_Panel";
            Group1_Panel.Size = new Size(387, 136);
            Group1_Panel.TabIndex = 0;
            Group1_Panel.Click += Group1_Panel_Click;
            // 
            // Group1_Info
            // 
            Group1_Info.AutoSize = true;
            Group1_Info.ForeColor = Color.White;
            Group1_Info.Location = new Point(52, 24);
            Group1_Info.Name = "Group1_Info";
            Group1_Info.Size = new Size(50, 20);
            Group1_Info.TabIndex = 0;
            Group1_Info.Text = "label1";
            // 
            // Group2_Panel
            // 
            Group2_Panel.Controls.Add(Group2_Info);
            Group2_Panel.Dock = DockStyle.Fill;
            Group2_Panel.Location = new Point(3, 145);
            Group2_Panel.Name = "Group2_Panel";
            Group2_Panel.Size = new Size(387, 136);
            Group2_Panel.TabIndex = 1;
            Group2_Panel.Click += Group2_Panel_Click;
            // 
            // Group2_Info
            // 
            Group2_Info.AutoSize = true;
            Group2_Info.ForeColor = Color.White;
            Group2_Info.Location = new Point(52, 25);
            Group2_Info.Name = "Group2_Info";
            Group2_Info.Size = new Size(50, 20);
            Group2_Info.TabIndex = 0;
            Group2_Info.Text = "label1";
            // 
            // Group3_Panel
            // 
            Group3_Panel.Controls.Add(Group3_Info);
            Group3_Panel.Dock = DockStyle.Fill;
            Group3_Panel.Location = new Point(3, 287);
            Group3_Panel.Name = "Group3_Panel";
            Group3_Panel.Size = new Size(387, 137);
            Group3_Panel.TabIndex = 2;
            Group3_Panel.Click += Group3_Panel_Click;
            // 
            // Group3_Info
            // 
            Group3_Info.AutoSize = true;
            Group3_Info.ForeColor = Color.White;
            Group3_Info.Location = new Point(52, 27);
            Group3_Info.Name = "Group3_Info";
            Group3_Info.Size = new Size(50, 20);
            Group3_Info.TabIndex = 0;
            Group3_Info.Text = "label1";
            // 
            // ChatList
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 13, 19);
            ClientSize = new Size(414, 593);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Setting);
            Controls.Add(Add);
            Controls.Add(toChat);
            Controls.Add(toFriend);
            Controls.Add(label2);
            Location = new Point(13, 11);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ChatList";
            Text = "ChatList";
            Load += ChatList_Load;
            ((System.ComponentModel.ISupportInitialize)toFriend).EndInit();
            ((System.ComponentModel.ISupportInitialize)toChat).EndInit();
            ((System.ComponentModel.ISupportInitialize)Setting).EndInit();
            ((System.ComponentModel.ISupportInitialize)Add).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            Group1_Panel.ResumeLayout(false);
            Group1_Panel.PerformLayout();
            Group2_Panel.ResumeLayout(false);
            Group2_Panel.PerformLayout();
            Group3_Panel.ResumeLayout(false);
            Group3_Panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox toFriend;
        private PictureBox toChat;
        private PictureBox Setting;
        private PictureBox Add;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel Group1_Panel;
        private Label Group1_Info;
        private Panel Group2_Panel;
        private Label Group2_Info;
        private Panel Group3_Panel;
        private Label Group3_Info;
    }
}