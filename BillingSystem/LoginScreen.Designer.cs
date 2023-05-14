namespace BillingSystem
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.Register = new System.Windows.Forms.Label();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AcceptLoginButton = new System.Windows.Forms.Button();
            this.ExitLoginButton = new System.Windows.Forms.Button();
            this.RegisterLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Register
            // 
            this.Register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Register.AutoSize = true;
            this.Register.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.Register.Location = new System.Drawing.Point(154, 37);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(76, 29);
            this.Register.TabIndex = 0;
            this.Register.Text = "Login";
            this.Register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Register.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserBox
            // 
            this.UserBox.BackColor = System.Drawing.Color.White;
            this.UserBox.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserBox.ForeColor = System.Drawing.Color.Black;
            this.UserBox.Location = new System.Drawing.Point(105, 259);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(175, 22);
            this.UserBox.TabIndex = 1;
            this.UserBox.TextChanged += new System.EventHandler(this.UserBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(168, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.White;
            this.PasswordBox.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordBox.Location = new System.Drawing.Point(105, 316);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(175, 22);
            this.PasswordBox.TabIndex = 2;
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.label2.Location = new System.Drawing.Point(149, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AcceptLoginButton
            // 
            this.AcceptLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.AcceptLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AcceptLoginButton.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AcceptLoginButton.ForeColor = System.Drawing.Color.White;
            this.AcceptLoginButton.Location = new System.Drawing.Point(105, 374);
            this.AcceptLoginButton.Name = "AcceptLoginButton";
            this.AcceptLoginButton.Size = new System.Drawing.Size(76, 24);
            this.AcceptLoginButton.TabIndex = 3;
            this.AcceptLoginButton.Text = "Accept";
            this.AcceptLoginButton.UseVisualStyleBackColor = false;
            this.AcceptLoginButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // ExitLoginButton
            // 
            this.ExitLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.ExitLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitLoginButton.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitLoginButton.ForeColor = System.Drawing.Color.White;
            this.ExitLoginButton.Location = new System.Drawing.Point(205, 374);
            this.ExitLoginButton.Name = "ExitLoginButton";
            this.ExitLoginButton.Size = new System.Drawing.Size(76, 24);
            this.ExitLoginButton.TabIndex = 4;
            this.ExitLoginButton.Text = "Exit";
            this.ExitLoginButton.UseVisualStyleBackColor = false;
            this.ExitLoginButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RegisterLink
            // 
            this.RegisterLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(120)))), ((int)(((byte)(66)))));
            this.RegisterLink.AutoSize = true;
            this.RegisterLink.LinkColor = System.Drawing.Color.Black;
            this.RegisterLink.Location = new System.Drawing.Point(168, 408);
            this.RegisterLink.Name = "RegisterLink";
            this.RegisterLink.Size = new System.Drawing.Size(49, 15);
            this.RegisterLink.TabIndex = 5;
            this.RegisterLink.TabStop = true;
            this.RegisterLink.Text = "Register";
            this.RegisterLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegisterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLink_LinkClicked);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.ControlBox = false;
            this.Controls.Add(this.RegisterLink);
            this.Controls.Add(this.ExitLoginButton);
            this.Controls.Add(this.AcceptLoginButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.Register);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Register;
        private TextBox UserBox;
        private Label label1;
        private TextBox PasswordBox;
        private Label label2;
        private PictureBox pictureBox1;
        private Button AcceptLoginButton;
        private Button ExitLoginButton;
        private LinkLabel RegisterLink;
    }
}