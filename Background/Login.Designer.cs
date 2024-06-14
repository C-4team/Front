namespace Background
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            txtPwd = new TextBox();
            btnLogin = new Button();
            btnSignup = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(102, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(245, 247, 255);
            label1.Location = new Point(112, 278);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(245, 247, 255);
            label2.Location = new Point(54, 321);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txtID
            // 
            txtID.Location = new Point(158, 278);
            txtID.Name = "txtID";
            txtID.Size = new Size(206, 31);
            txtID.TabIndex = 3;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(158, 321);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(206, 31);
            txtPwd.TabIndex = 4;
            txtPwd.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(42, 47, 55);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.ForeColor = Color.FromArgb(247, 255, 255);
            btnLogin.Location = new Point(93, 379);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(244, 46);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.FromArgb(42, 47, 55);
            btnSignup.FlatStyle = FlatStyle.Popup;
            btnSignup.ForeColor = Color.FromArgb(247, 255, 255);
            btnSignup.Location = new Point(93, 555);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(244, 46);
            btnSignup.TabIndex = 6;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 13, 19);
            ClientSize = new Size(438, 650);
            Controls.Add(btnSignup);
            Controls.Add(btnLogin);
            Controls.Add(txtPwd);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtID;
        private TextBox txtPwd;
        private Button btnLogin;
        private Button btnSignup;
    }
}