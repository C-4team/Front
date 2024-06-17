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
            Signup.Font = new Font("Centaur", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Signup.ForeColor = Color.FromArgb(247, 255, 255);
            Signup.Location = new Point(4, 8);
            Signup.Name = "Signup";
            Signup.Size = new Size(162, 56);
            Signup.TabIndex = 0;
            Signup.Text = "Sign up";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Centaur", 20F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.FromArgb(247, 255, 255);
            nameLabel.Location = new Point(18, 170);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(115, 38);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name : ";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Centaur", 15F, FontStyle.Regular, GraphicsUnit.Point);
            IDLabel.ForeColor = Color.FromArgb(247, 255, 255);
            IDLabel.Location = new Point(19, 289);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(95, 28);
            IDLabel.TabIndex = 2;
            IDLabel.Text = "KW ID :";
            // 
            // pwdLabel
            // 
            pwdLabel.AutoSize = true;
            pwdLabel.Font = new Font("Centaur", 15F, FontStyle.Regular, GraphicsUnit.Point);
            pwdLabel.ForeColor = Color.FromArgb(247, 255, 255);
            pwdLabel.Location = new Point(15, 407);
            pwdLabel.Name = "pwdLabel";
            pwdLabel.Size = new Size(108, 28);
            pwdLabel.TabIndex = 3;
            pwdLabel.Text = "Password :";
            // 
            // namebox
            // 
            namebox.BackColor = Color.White;
            namebox.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            namebox.Location = new Point(122, 173);
            namebox.Margin = new Padding(3, 2, 3, 2);
            namebox.Name = "namebox";
            namebox.Size = new Size(266, 31);
            namebox.TabIndex = 4;
            // 
            // IDbox
            // 
            IDbox.Location = new Point(122, 286);
            IDbox.Margin = new Padding(3, 2, 3, 2);
            IDbox.Multiline = true;
            IDbox.Name = "IDbox";
            IDbox.Size = new Size(266, 31);
            IDbox.TabIndex = 5;
            // 
            // pwdbox
            // 
            pwdbox.Location = new Point(122, 405);
            pwdbox.Margin = new Padding(3, 2, 3, 2);
            pwdbox.Multiline = true;
            pwdbox.Name = "pwdbox";
            pwdbox.Size = new Size(266, 31);
            pwdbox.TabIndex = 6;
            pwdbox.UseSystemPasswordChar = true;
            // 
            // SignupBtn
            // 
            SignupBtn.BackColor = Color.FromArgb(42, 47, 55);
            SignupBtn.FlatAppearance.BorderColor = Color.FromArgb(42, 47, 55);
            SignupBtn.FlatStyle = FlatStyle.Flat;
            SignupBtn.Font = new Font("Centaur", 20F, FontStyle.Regular, GraphicsUnit.Point);
            SignupBtn.ForeColor = Color.FromArgb(247, 255, 255);
            SignupBtn.Location = new Point(78, 579);
            SignupBtn.Margin = new Padding(3, 2, 3, 2);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(302, 55);
            SignupBtn.TabIndex = 7;
            SignupBtn.Text = "Sign up";
            SignupBtn.UseVisualStyleBackColor = false;
            SignupBtn.Click += SignupBtn_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 13, 19);
            ClientSize = new Size(464, 750);
            Controls.Add(SignupBtn);
            Controls.Add(pwdbox);
            Controls.Add(IDbox);
            Controls.Add(namebox);
            Controls.Add(pwdLabel);
            Controls.Add(IDLabel);
            Controls.Add(nameLabel);
            Controls.Add(Signup);
            Margin = new Padding(3, 2, 3, 2);
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