namespace UI.Resources.chatting
{
    partial class outgoing
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
            outChat = new PictureBox();
            sendTxt = new Label();
            ((System.ComponentModel.ISupportInitialize)outChat).BeginInit();
            SuspendLayout();
            // 
            // outChat
            // 
            outChat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            outChat.Image = Properties.Resources.send_chat;
            outChat.Location = new Point(355, 10);
            outChat.Name = "outChat";
            outChat.Size = new Size(304, 60);
            outChat.SizeMode = PictureBoxSizeMode.StretchImage;
            outChat.TabIndex = 0;
            outChat.TabStop = false;
            // 
            // sendTxt
            // 
            sendTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sendTxt.BackColor = Color.FromArgb(216, 219, 231);
            sendTxt.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sendTxt.Location = new Point(368, 26);
            sendTxt.Name = "sendTxt";
            sendTxt.Size = new Size(281, 31);
            sendTxt.TabIndex = 1;
            sendTxt.Text = "이걸로 보낼거야.";
            // 
            // outgoing
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 29, 37);
            Controls.Add(sendTxt);
            Controls.Add(outChat);
            Name = "outgoing";
            Size = new Size(660, 87);
            DockChanged += outgoing_DockChanged;
            ((System.ComponentModel.ISupportInitialize)outChat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox outChat;
        public Label sendTxt;
    }
}
