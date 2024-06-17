namespace Background
{
    partial class Signup
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
            btnSend = new Button();
            textBox1 = new TextBox();
            txtID = new TextBox();
            txtName = new TextBox();
            txtPwd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(42, 47, 55);
            btnSend.FlatStyle = FlatStyle.Popup;
            btnSend.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSend.ForeColor = Color.FromArgb(247, 255, 255);
            btnSend.Location = new Point(100, 504);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(244, 61);
            btnSend.TabIndex = 6;
            btnSend.Text = "Sign Up";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(12, 13, 19);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("맑은 고딕", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(247, 255, 255);
            textBox1.Location = new Point(7, -3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 67);
            textBox1.TabIndex = 7;
            textBox1.Text = "Sign Up";
            // 
            // txtID
            // 
            txtID.Location = new Point(154, 181);
            txtID.Name = "txtID";
            txtID.Size = new Size(240, 31);
            txtID.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(154, 234);
            txtName.Name = "txtName";
            txtName.Size = new Size(240, 31);
            txtName.TabIndex = 9;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(154, 286);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(240, 31);
            txtPwd.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(247, 255, 255);
            label1.Location = new Point(41, 181);
            label1.Name = "label1";
            label1.Size = new Size(40, 25);
            label1.TabIndex = 11;
            label1.Text = "ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(247, 255, 255);
            label2.Location = new Point(41, 231);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 12;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(247, 255, 255);
            label3.Location = new Point(41, 280);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 13;
            label3.Text = "Password :";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 13, 19);
            ClientSize = new Size(438, 650);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPwd);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(textBox1);
            Controls.Add(btnSend);
            Name = "Signup";
            Text = "Signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private TextBox textBox1;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtPwd;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}