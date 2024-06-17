namespace UI.Resources.chatting
{
    partial class incomming
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            inName = new Label();
            inChat = new PictureBox();
            receiveTxt = new Label();
            ((System.ComponentModel.ISupportInitialize)inChat).BeginInit();
            SuspendLayout();
            // 
            // inName
            // 
            inName.Dock = DockStyle.Top;
            inName.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            inName.ForeColor = Color.White;
            inName.Location = new Point(0, 0);
            inName.Name = "inName";
            inName.Size = new Size(660, 24);
            inName.TabIndex = 0;
            inName.Text = "name";
            inName.Click += inName_Click;
            // 
            // inChat
            // 
            inChat.Image = Properties.Resources.receive_chat;
            inChat.Location = new Point(-1, 24);
            inChat.Name = "inChat";
            inChat.Size = new Size(304, 60);
            inChat.SizeMode = PictureBoxSizeMode.StretchImage;
            inChat.TabIndex = 1;
            inChat.TabStop = false;
            inChat.Click += inChat_Click;
            // 
            // receiveTxt
            // 
            receiveTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            receiveTxt.BackColor = Color.FromArgb(46, 49, 50);
            receiveTxt.FlatStyle = FlatStyle.Flat;
            receiveTxt.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            receiveTxt.ForeColor = Color.White;
            receiveTxt.Location = new Point(12, 41);
            receiveTxt.Name = "receiveTxt";
            receiveTxt.Size = new Size(280, 30);
            receiveTxt.TabIndex = 2;
            receiveTxt.Text = "여기에 이 글씨가 길어진다면";
            // 
            // incomming
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(27, 29, 37);
            Controls.Add(receiveTxt);
            Controls.Add(inName);
            Controls.Add(inChat);
            Name = "incomming";
            Size = new Size(660, 87);
            Load += incomming_Load;
            ((System.ComponentModel.ISupportInitialize)inChat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label inName;
        private PictureBox inChat;
        public Label receiveTxt;
    }
}
