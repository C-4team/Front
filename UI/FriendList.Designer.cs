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
            ((System.ComponentModel.ISupportInitialize)Add).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Setting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toFriend).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toChat).BeginInit();
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
            TLPanel.Location = new Point(11, 83);
            TLPanel.Name = "TLPanel";
            TLPanel.RowCount = 3;
            TLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TLPanel.Size = new Size(393, 410);
            TLPanel.TabIndex = 7;
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
            ((System.ComponentModel.ISupportInitialize)Add).EndInit();
            ((System.ComponentModel.ISupportInitialize)Setting).EndInit();
            ((System.ComponentModel.ISupportInitialize)toFriend).EndInit();
            ((System.ComponentModel.ISupportInitialize)toChat).EndInit();
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
    }
}