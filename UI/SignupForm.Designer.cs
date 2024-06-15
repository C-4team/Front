namespace UI
{
    partial class SignupForm
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
            Signup = new Label();
            nameLabel = new Label();
            IDLabel = new Label();
            pwdLabel = new Label();
            namebox = new TextBox();
            IDbox = new TextBox();
            pwdbox = new TextBox();
            SignupBtn = new Button();
            SuspendLayout();
            // 
            // Signup
            // 
            Signup.AutoSize = true;
            Signup.Font = new Font("맑은 고딕", 25F, FontStyle.Regular, GraphicsUnit.Point);
            Signup.ForeColor = Color.FromArgb(247, 255, 255);
            Signup.Location = new Point(8, -8);
            Signup.Name = "Signup";
            Signup.Size = new Size(204, 67);
            Signup.TabIndex = 0;
            Signup.Text = "Sign up";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = Color.FromArgb(247, 255, 255);
            nameLabel.Location = new Point(47, 216);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(73, 25);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "name : ";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.ForeColor = Color.FromArgb(247, 255, 255);
            IDLabel.Location = new Point(47, 290);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(86, 25);
            IDLabel.TabIndex = 2;
            IDLabel.Text = "KW ID :  ";
            // 
            // pwdLabel
            // 
            pwdLabel.AutoSize = true;
            pwdLabel.ForeColor = Color.FromArgb(247, 255, 255);
            pwdLabel.Location = new Point(47, 366);
            pwdLabel.Name = "pwdLabel";
            pwdLabel.Size = new Size(105, 25);
            pwdLabel.TabIndex = 3;
            pwdLabel.Text = "password : ";
            // 
            // namebox
            // 
            namebox.BackColor = Color.White;
            namebox.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            namebox.Location = new Point(172, 213);
            namebox.Name = "namebox";
            namebox.Size = new Size(295, 36);
            namebox.TabIndex = 4;
            // 
            // IDbox
            // 
            IDbox.Location = new Point(172, 287);
            IDbox.Name = "IDbox";
            IDbox.Size = new Size(295, 31);
            IDbox.TabIndex = 5;
            // 
            // pwdbox
            // 
            pwdbox.Location = new Point(172, 363);
            pwdbox.Name = "pwdbox";
            pwdbox.Size = new Size(295, 31);
            pwdbox.TabIndex = 6;
            pwdbox.UseSystemPasswordChar = true;
            // 
            // SignupBtn
            // 
            SignupBtn.BackColor = Color.FromArgb(42, 47, 55);
            SignupBtn.FlatStyle = FlatStyle.Popup;
            SignupBtn.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SignupBtn.ForeColor = Color.FromArgb(247, 255, 255);
            SignupBtn.Location = new Point(85, 656);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(336, 69);
            SignupBtn.TabIndex = 7;
            SignupBtn.Text = "Sign up";
            SignupBtn.UseVisualStyleBackColor = false;
            SignupBtn.Click += SignupBtn_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 13, 19);
            ClientSize = new Size(518, 829);
            Controls.Add(SignupBtn);
            Controls.Add(pwdbox);
            Controls.Add(IDbox);
            Controls.Add(namebox);
            Controls.Add(pwdLabel);
            Controls.Add(IDLabel);
            Controls.Add(nameLabel);
            Controls.Add(Signup);
            Name = "SignupForm";
            Text = "SignupForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Signup;
        private Label nameLabel;
        private Label IDLabel;
        private Label pwdLabel;
        private TextBox namebox;
        private TextBox IDbox;
        private TextBox pwdbox;
        private Button SignupBtn;
    }
}