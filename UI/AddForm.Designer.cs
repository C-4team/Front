namespace UI
{
    partial class AddForm
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
            txtContent = new TextBox();
            btnAdd = new Button();
            inputPic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)inputPic).BeginInit();
            SuspendLayout();
            // 
            // txtContent
            // 
            txtContent.BackColor = Color.FromArgb(216, 219, 231);
            txtContent.BorderStyle = BorderStyle.None;
            txtContent.Font = new Font("Centaur", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContent.Location = new Point(29, 22);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(220, 23);
            txtContent.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(66, 71, 85);
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(66, 71, 85);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Centaur", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(94, 67);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(87, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // inputPic
            // 
            inputPic.Image = Properties.Resources.send_chat;
            inputPic.Location = new Point(20, 14);
            inputPic.Name = "inputPic";
            inputPic.Size = new Size(239, 35);
            inputPic.SizeMode = PictureBoxSizeMode.StretchImage;
            inputPic.TabIndex = 3;
            inputPic.TabStop = false;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 49, 61);
            ClientSize = new Size(274, 111);
            Controls.Add(txtContent);
            Controls.Add(inputPic);
            Controls.Add(btnAdd);
            Name = "AddForm";
            Text = "Add";
            ((System.ComponentModel.ISupportInitialize)inputPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContent;
        private Button btnAdd;
        private PictureBox inputPic;
    }
}