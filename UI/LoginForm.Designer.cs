namespace UI
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            IDbox = new TextBox();
            pwdBox = new TextBox();
            pictureBox1 = new PictureBox();
            LoginBtn = new Button();
            SignupBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // IDbox
            // 
            IDbox.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
<<<<<<< HEAD
            IDbox.Location = new Point(54, 258);
=======
            IDbox.Location = new Point(76, 344);
>>>>>>> daf876f0c43f5080aa55483454f9dbce57aefb00
            IDbox.Margin = new Padding(3, 2, 3, 2);
            IDbox.Name = "IDbox";
            IDbox.Size = new Size(299, 41);
            IDbox.TabIndex = 0;
            // 
            // pwdBox
            // 
            pwdBox.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
<<<<<<< HEAD
            pwdBox.Location = new Point(54, 300);
=======
            pwdBox.Location = new Point(76, 389);
>>>>>>> daf876f0c43f5080aa55483454f9dbce57aefb00
            pwdBox.Margin = new Padding(3, 2, 3, 2);
            pwdBox.Name = "pwdBox";
            pwdBox.Size = new Size(299, 41);
            pwdBox.TabIndex = 1;
            pwdBox.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
<<<<<<< HEAD
            pictureBox1.Location = new Point(64, 36);
=======
            pictureBox1.Location = new Point(91, 79);
>>>>>>> daf876f0c43f5080aa55483454f9dbce57aefb00
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(42, 47, 55);
<<<<<<< HEAD
            LoginBtn.FlatStyle = FlatStyle.Popup;
            LoginBtn.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.FromArgb(247, 255, 255);
            LoginBtn.Location = new Point(54, 354);
            LoginBtn.Margin = new Padding(3, 2, 3, 2);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(299, 38);
=======
            LoginBtn.FlatAppearance.BorderColor = Color.FromArgb(42, 47, 55);
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Century", 16.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.FromArgb(247, 255, 255);
            LoginBtn.Location = new Point(107, 560);
            LoginBtn.Margin = new Padding(3, 2, 3, 2);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(247, 56);
>>>>>>> daf876f0c43f5080aa55483454f9dbce57aefb00
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Log In";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // SignupBtn
            // 
            SignupBtn.BackColor = Color.FromArgb(12, 13, 19);
            SignupBtn.FlatStyle = FlatStyle.Popup;
<<<<<<< HEAD
            SignupBtn.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SignupBtn.ForeColor = Color.FromArgb(247, 255, 255);
            SignupBtn.Location = new Point(117, 517);
=======
            SignupBtn.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            SignupBtn.ForeColor = Color.FromArgb(247, 255, 255);
            SignupBtn.Location = new Point(140, 620);
>>>>>>> daf876f0c43f5080aa55483454f9dbce57aefb00
            SignupBtn.Margin = new Padding(3, 2, 3, 2);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(181, 47);
            SignupBtn.TabIndex = 5;
            SignupBtn.Text = "Sign Up";
            SignupBtn.UseVisualStyleBackColor = false;
            SignupBtn.Click += SignupBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 13, 19);
<<<<<<< HEAD
            ClientSize = new Size(414, 593);
=======
            ClientSize = new Size(464, 750);
>>>>>>> daf876f0c43f5080aa55483454f9dbce57aefb00
            Controls.Add(SignupBtn);
            Controls.Add(LoginBtn);
            Controls.Add(pictureBox1);
            Controls.Add(pwdBox);
            Controls.Add(IDbox);
<<<<<<< HEAD
=======
            ForeColor = Color.FromArgb(18, 19, 25);
>>>>>>> daf876f0c43f5080aa55483454f9dbce57aefb00
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IDbox;
        private TextBox pwdBox;
        private PictureBox pictureBox1;
        private Button LoginBtn;
        private Button SignupBtn;
    }
}