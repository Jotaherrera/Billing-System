namespace BillingSystem
{
    partial class RegisterScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterScreen));
            CancelRegisterButton = new Button();
            RegisterButton = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            PasswordBox = new TextBox();
            UserBox = new TextBox();
            Register = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CancelRegisterButton
            // 
            CancelRegisterButton.BackColor = Color.FromArgb(12, 142, 112);
            CancelRegisterButton.FlatStyle = FlatStyle.Popup;
            CancelRegisterButton.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            CancelRegisterButton.ForeColor = Color.White;
            CancelRegisterButton.Location = new Point(205, 387);
            CancelRegisterButton.Name = "CancelRegisterButton";
            CancelRegisterButton.Size = new Size(76, 24);
            CancelRegisterButton.TabIndex = 5;
            CancelRegisterButton.Text = "Cancel";
            CancelRegisterButton.UseVisualStyleBackColor = false;
            CancelRegisterButton.Click += CancelRegisterButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.FromArgb(12, 142, 112);
            RegisterButton.FlatStyle = FlatStyle.Popup;
            RegisterButton.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterButton.ForeColor = Color.White;
            RegisterButton.Location = new Point(105, 387);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(76, 24);
            RegisterButton.TabIndex = 3;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(124, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(12, 142, 112);
            label2.Location = new Point(149, 305);
            label2.Name = "label2";
            label2.Size = new Size(83, 18);
            label2.TabIndex = 10;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(12, 142, 112);
            label1.Location = new Point(167, 249);
            label1.Name = "label1";
            label1.Size = new Size(44, 18);
            label1.TabIndex = 11;
            label1.Text = "User";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // PasswordBox
            // 
            PasswordBox.BackColor = Color.White;
            PasswordBox.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordBox.ForeColor = Color.Black;
            PasswordBox.Location = new Point(105, 329);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(175, 21);
            PasswordBox.TabIndex = 2;
            PasswordBox.UseSystemPasswordChar = true;
            PasswordBox.TextChanged += PasswordBox_TextChanged;
            // 
            // UserBox
            // 
            UserBox.BackColor = Color.White;
            UserBox.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            UserBox.ForeColor = Color.Black;
            UserBox.Location = new Point(105, 272);
            UserBox.Name = "UserBox";
            UserBox.Size = new Size(175, 21);
            UserBox.TabIndex = 1;
            UserBox.TextChanged += UserBox_TextChanged;
            // 
            // Register
            // 
            Register.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Register.AutoSize = true;
            Register.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Register.ForeColor = Color.FromArgb(12, 142, 112);
            Register.Location = new Point(140, 38);
            Register.Name = "Register";
            Register.Size = new Size(100, 25);
            Register.TabIndex = 7;
            Register.Text = "Register";
            Register.TextAlign = ContentAlignment.MiddleCenter;
            Register.Click += Register_Click;
            // 
            // RegisterScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 244);
            ClientSize = new Size(384, 461);
            ControlBox = false;
            Controls.Add(CancelRegisterButton);
            Controls.Add(RegisterButton);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordBox);
            Controls.Add(UserBox);
            Controls.Add(Register);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(400, 500);
            MinimumSize = new Size(400, 500);
            Name = "RegisterScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += RegisterScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CancelRegisterButton;
        private Button RegisterButton;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox PasswordBox;
        private TextBox UserBox;
        private Label Register;
    }
}