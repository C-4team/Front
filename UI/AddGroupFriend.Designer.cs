namespace UI
{
    partial class AddGroupFriend
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
            inputId = new TextBox();
            Addbutton = new Button();
            inputPic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)inputPic).BeginInit();
            SuspendLayout();
            // 
            // inputId
            // 
            inputId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputId.BackColor = Color.FromArgb(216, 219, 231);
            inputId.BorderStyle = BorderStyle.None;
            inputId.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            inputId.ForeColor = Color.Black;
            inputId.Location = new Point(27, 20);
            inputId.Name = "inputId";
            inputId.Size = new Size(220, 23);
            inputId.TabIndex = 0;
            inputId.TextAlign = HorizontalAlignment.Center;
            inputId.Leave += inputId_Leave;
            // 
            // Addbutton
            // 
            Addbutton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Addbutton.BackColor = Color.FromArgb(66, 71, 85);
            Addbutton.FlatAppearance.BorderColor = Color.FromArgb(66, 71, 85);
            Addbutton.FlatAppearance.BorderSize = 0;
            Addbutton.FlatStyle = FlatStyle.Flat;
            Addbutton.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Addbutton.ForeColor = Color.White;
            Addbutton.Location = new Point(94, 67);
            Addbutton.Name = "Addbutton";
            Addbutton.Size = new Size(87, 29);
            Addbutton.TabIndex = 1;
            Addbutton.Text = "Add";
            Addbutton.UseVisualStyleBackColor = false;
            Addbutton.Click += Addbutton_Click;
            // 
            // inputPic
            // 
            inputPic.Image = Properties.Resources.send_chat;
            inputPic.Location = new Point(20, 14);
            inputPic.Name = "inputPic";
            inputPic.Size = new Size(239, 35);
            inputPic.SizeMode = PictureBoxSizeMode.StretchImage;
            inputPic.TabIndex = 2;
            inputPic.TabStop = false;
            // 
            // AddGroupFriend
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 49, 61);
            ClientSize = new Size(274, 111);
            Controls.Add(inputId);
            Controls.Add(inputPic);
            Controls.Add(Addbutton);
            ForeColor = SystemColors.ControlText;
            Name = "AddGroupFriend";
            Text = "AddGroupFriend";
            ((System.ComponentModel.ISupportInitialize)inputPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputId;
        private Button Addbutton;
        private PictureBox inputPic;
    }
}