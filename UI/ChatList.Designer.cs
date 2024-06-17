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
            Group1_List = new Label();
            Group1_Info = new Label();
            Group2_Panel = new Panel();
            Group2_List = new Label();
            Group3_Panel = new Panel();
            Group3_List = new Label();
            Group3_Info = new Label();
            Group2_Info = new Label();
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
            label2.Font = new Font("Centaur", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(4, 8);
            label2.Name = "label2";
            label2.Size = new Size(128, 56);
            label2.TabIndex = 2;
            label2.Text = "Chats";
            // 
            // toFriend
            // 
            toFriend.Image = (Image)resources.GetObject("toFriend.Image");
            toFriend.Location = new Point(88, 686);
            toFriend.Margin = new Padding(3, 2, 3, 2);
            toFriend.Name = "toFriend";
            toFriend.Size = new Size(72, 64);
            toFriend.SizeMode = PictureBoxSizeMode.StretchImage;
            toFriend.TabIndex = 7;
            toFriend.TabStop = false;
            toFriend.Click += toFriend_Click;
            // 
            // toChat
            // 
            toChat.Image = (Image)resources.GetObject("toChat.Image");
            toChat.Location = new Point(281, 685);
            toChat.Margin = new Padding(3, 2, 3, 2);
            toChat.Name = "toChat";
            toChat.Size = new Size(73, 60);
            toChat.SizeMode = PictureBoxSizeMode.StretchImage;
            toChat.TabIndex = 8;
            toChat.TabStop = false;
            // 
            // Setting
            // 
            Setting.Image = (Image)resources.GetObject("Setting.Image");
            Setting.Location = new Point(406, 11);
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
            Add.Location = new Point(332, 8);
            Add.Name = "Add";
            Add.Size = new Size(73, 57);
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
            tableLayoutPanel1.Location = new Point(0, 70);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(463, 608);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // Group1_Panel
            // 
            Group1_Panel.Controls.Add(Group1_List);
            Group1_Panel.Controls.Add(Group1_Info);
            Group1_Panel.Dock = DockStyle.Fill;
            Group1_Panel.Location = new Point(3, 3);
            Group1_Panel.Name = "Group1_Panel";
            Group1_Panel.Size = new Size(457, 196);
            Group1_Panel.TabIndex = 0;
            Group1_Panel.Click += Group1_Panel_Click;
            // 
            // Group1_List
            // 
            Group1_List.AutoSize = true;
            Group1_List.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Group1_List.ForeColor = Color.White;
            Group1_List.Location = new Point(103, 67);
            Group1_List.Name = "Group1_List";
            Group1_List.Size = new Size(105, 18);
            Group1_List.TabIndex = 1;
            Group1_List.Text = "4) User_Name";
            // 
            // Group1_Info
            // 
            Group1_Info.AutoSize = true;
            Group1_Info.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            Group1_Info.ForeColor = Color.White;
            Group1_Info.Location = new Point(52, 25);
            Group1_Info.Name = "Group1_Info";
            Group1_Info.Size = new Size(118, 42);
            Group1_Info.TabIndex = 0;
            Group1_Info.Text = "TEST";
            // 
            // Group2_Panel
            // 
            Group2_Panel.Controls.Add(Group2_List);
            Group2_Panel.Controls.Add(Group2_Info);
            Group2_Panel.Dock = DockStyle.Fill;
            Group2_Panel.Location = new Point(3, 205);
            Group2_Panel.Name = "Group2_Panel";
            Group2_Panel.Size = new Size(457, 196);
            Group2_Panel.TabIndex = 1;
            Group2_Panel.Click += Group2_Panel_Click;
            // 
            // Group2_List
            // 
            Group2_List.AutoSize = true;
            Group2_List.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Group2_List.ForeColor = Color.White;
            Group2_List.Location = new Point(103, 68);
            Group2_List.Name = "Group2_List";
            Group2_List.Size = new Size(88, 18);
            Group2_List.TabIndex = 2;
            Group2_List.Text = "User_Name";
            // 
            // Group3_Panel
            // 
            Group3_Panel.Controls.Add(Group3_List);
            Group3_Panel.Controls.Add(Group3_Info);
            Group3_Panel.Dock = DockStyle.Fill;
            Group3_Panel.Location = new Point(3, 407);
            Group3_Panel.Name = "Group3_Panel";
            Group3_Panel.Size = new Size(457, 198);
            Group3_Panel.TabIndex = 2;
            Group3_Panel.Click += Group3_Panel_Click;
            // 
            // Group3_List
            // 
            Group3_List.AutoSize = true;
            Group3_List.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Group3_List.ForeColor = Color.White;
            Group3_List.Location = new Point(103, 68);
            Group3_List.Name = "Group3_List";
            Group3_List.Size = new Size(88, 18);
            Group3_List.TabIndex = 2;
            Group3_List.Text = "User_Name";
            // 
            // Group3_Info
            // 
            Group3_Info.AutoSize = true;
            Group3_Info.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            Group3_Info.ForeColor = Color.White;
            Group3_Info.Location = new Point(52, 25);
            Group3_Info.Name = "Group3_Info";
            Group3_Info.Size = new Size(124, 42);
            Group3_Info.TabIndex = 0;
            Group3_Info.Text = "label1";
            // 
            // Group2_Info
            // 
            Group2_Info.AutoSize = true;
            Group2_Info.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            Group2_Info.ForeColor = Color.White;
            Group2_Info.Location = new Point(52, 25);
            Group2_Info.Name = "Group2_Info";
            Group2_Info.Size = new Size(124, 42);
            Group2_Info.TabIndex = 0;
            Group2_Info.Text = "label1";
            // 
            // ChatList
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 13, 19);
            ClientSize = new Size(464, 750);
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
        private Panel Group3_Panel;
        private Label Group3_Info;
        private Label Group1_List;
        private Label Group2_List;
        private Label Group3_List;
        private Label Group2_Info;
    }
}