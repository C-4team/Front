namespace UI
{
    partial class chattingRoom
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
            namePnl = new Panel();
            namelbl = new Label();
            chatoutPic = new PictureBox();
            chatPnl = new Panel();
            sendPnl = new Panel();
            sendBtn = new Button();
            sendTxt = new TextBox();
            namePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chatoutPic).BeginInit();
            sendPnl.SuspendLayout();
            SuspendLayout();
            // 
            // namePnl
            // 
            namePnl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            namePnl.Controls.Add(namelbl);
            namePnl.Location = new Point(0, 0);
            namePnl.Name = "namePnl";
            namePnl.Size = new Size(463, 76);
            namePnl.TabIndex = 0;
            // 
            // namelbl
            // 
            namelbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            namelbl.Font = new Font("맑은 고딕", 17F, FontStyle.Regular, GraphicsUnit.Point);
            namelbl.ForeColor = Color.White;
            namelbl.Location = new Point(185, 15);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(96, 47);
            namelbl.TabIndex = 0;
            namelbl.Text = "name";
            namelbl.TextAlign = ContentAlignment.MiddleCenter;
            namelbl.Click += namelbl_Click;
            // 
            // chatoutPic
            // 
            chatoutPic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chatoutPic.Image = Properties.Resources.채팅방_나가기_icon;
            chatoutPic.Location = new Point(416, 12);
            chatoutPic.Name = "chatoutPic";
            chatoutPic.Size = new Size(36, 35);
            chatoutPic.SizeMode = PictureBoxSizeMode.StretchImage;
            chatoutPic.TabIndex = 1;
            chatoutPic.TabStop = false;
            chatoutPic.Click += chatoutPic_Click;
            // 
            // chatPnl
            // 
            chatPnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chatPnl.Location = new Point(0, 76);
            chatPnl.Name = "chatPnl";
            chatPnl.Size = new Size(463, 599);
            chatPnl.TabIndex = 2;
            // 
            // sendPnl
            // 
            sendPnl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sendPnl.BackColor = Color.FromArgb(46, 49, 61);
            sendPnl.Controls.Add(sendBtn);
            sendPnl.Controls.Add(sendTxt);
            sendPnl.Location = new Point(0, 675);
            sendPnl.Name = "sendPnl";
            sendPnl.Size = new Size(463, 74);
            sendPnl.TabIndex = 3;
            // 
            // sendBtn
            // 
            sendBtn.Anchor = AnchorStyles.Right;
            sendBtn.FlatAppearance.BorderColor = Color.FromArgb(66, 71, 85);
            sendBtn.FlatStyle = FlatStyle.Flat;
            sendBtn.ForeColor = Color.White;
            sendBtn.Location = new Point(402, 12);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(58, 51);
            sendBtn.TabIndex = 0;
            sendBtn.Text = "전송";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += sendBtn_Click;
            // 
            // sendTxt
            // 
            sendTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sendTxt.BackColor = Color.FromArgb(66, 71, 85);
            sendTxt.BorderStyle = BorderStyle.None;
            sendTxt.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sendTxt.ForeColor = Color.White;
            sendTxt.Location = new Point(5, 12);
            sendTxt.Multiline = true;
            sendTxt.Name = "sendTxt";
            sendTxt.Size = new Size(393, 51);
            sendTxt.TabIndex = 0;
            // 
            // chattingRoom
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 29, 37);
            ClientSize = new Size(464, 750);
            Controls.Add(sendPnl);
            Controls.Add(chatPnl);
            Controls.Add(chatoutPic);
            Controls.Add(namePnl);
            Name = "chattingRoom";
            Text = "chattingRoom";
            Load += chattingRoom_Load;
            namePnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chatoutPic).EndInit();
            sendPnl.ResumeLayout(false);
            sendPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel namePnl;
        private Label namelbl;
        private PictureBox chatoutPic;
        private Panel chatPnl;
        private Panel sendPnl;
        private Button sendBtn;
        private TextBox sendTxt;
    }
}