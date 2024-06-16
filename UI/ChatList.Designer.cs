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
            TLPanel = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)toFriend).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toChat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Setting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Add).BeginInit();
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
            // TLPanel
            // 
            TLPanel.ColumnCount = 1;
            TLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TLPanel.Location = new Point(8, 81);
            TLPanel.Name = "TLPanel";
            TLPanel.RowCount = 3;
            TLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TLPanel.Size = new Size(397, 413);
            TLPanel.TabIndex = 12;
            // 
            // ChatList
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 13, 19);
            ClientSize = new Size(414, 593);
            Controls.Add(TLPanel);
            Controls.Add(Setting);
            Controls.Add(Add);
            Controls.Add(toChat);
            Controls.Add(toFriend);
            Controls.Add(label2);
            Location = new Point(13, 11);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ChatList";
            Text = "ChatList";
            ((System.ComponentModel.ISupportInitialize)toFriend).EndInit();
            ((System.ComponentModel.ISupportInitialize)toChat).EndInit();
            ((System.ComponentModel.ISupportInitialize)Setting).EndInit();
            ((System.ComponentModel.ISupportInitialize)Add).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox toFriend;
        private PictureBox toChat;
        private PictureBox Setting;
        private PictureBox Add;
        private TableLayoutPanel TLPanel;
    }
}