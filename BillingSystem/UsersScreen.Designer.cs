namespace BillingSystem
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            dgvAdmin = new DataGridView();
            clmIdUs = new DataGridViewTextBoxColumn();
            clmUser = new DataGridViewTextBoxColumn();
            clmPassword = new DataGridViewTextBoxColumn();
            BackUsersButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAdmin).BeginInit();
            SuspendLayout();
            // 
            // dgvAdmin
            // 
            dgvAdmin.AllowUserToAddRows = false;
            dgvAdmin.AllowUserToDeleteRows = false;
            dgvAdmin.AllowUserToResizeColumns = false;
            dgvAdmin.AllowUserToResizeRows = false;
            dgvAdmin.BackgroundColor = Color.FromArgb(255, 249, 244);
            dgvAdmin.BorderStyle = BorderStyle.None;
            dgvAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAdmin.Columns.AddRange(new DataGridViewColumn[] { clmIdUs, clmUser, clmPassword });
            dgvAdmin.Location = new Point(16, 13);
            dgvAdmin.Margin = new Padding(0);
            dgvAdmin.Name = "dgvAdmin";
            dgvAdmin.ReadOnly = true;
            dgvAdmin.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvAdmin.RowTemplate.Height = 25;
            dgvAdmin.ScrollBars = ScrollBars.None;
            dgvAdmin.Size = new Size(543, 320);
            dgvAdmin.TabIndex = 5;
            dgvAdmin.CellContentClick += dgvAdmin_CellContentClick;
            // 
            // clmIdUs
            // 
            clmIdUs.HeaderText = "ID";
            clmIdUs.Name = "clmIdUs";
            clmIdUs.ReadOnly = true;
            // 
            // clmUser
            // 
            clmUser.HeaderText = "User";
            clmUser.Name = "clmUser";
            clmUser.ReadOnly = true;
            clmUser.Width = 200;
            // 
            // clmPassword
            // 
            clmPassword.HeaderText = "Password";
            clmPassword.Name = "clmPassword";
            clmPassword.ReadOnly = true;
            clmPassword.Width = 200;
            // 
            // BackUsersButton
            // 
            BackUsersButton.BackColor = Color.FromArgb(12, 142, 112);
            BackUsersButton.FlatStyle = FlatStyle.Popup;
            BackUsersButton.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            BackUsersButton.ForeColor = Color.White;
            BackUsersButton.Location = new Point(156, 346);
            BackUsersButton.Name = "BackUsersButton";
            BackUsersButton.Size = new Size(263, 27);
            BackUsersButton.TabIndex = 7;
            BackUsersButton.Text = "Back";
            BackUsersButton.UseVisualStyleBackColor = false;
            BackUsersButton.Click += BackUsersButton_Click;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 244);
            ClientSize = new Size(574, 385);
            ControlBox = false;
            Controls.Add(BackUsersButton);
            Controls.Add(dgvAdmin);
            Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(590, 424);
            MinimumSize = new Size(590, 424);
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            Load += Users_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAdmin;
        private DataGridViewTextBoxColumn clmIdUs;
        private DataGridViewTextBoxColumn clmUser;
        private DataGridViewTextBoxColumn clmPassword;
        private Button BackUsersButton;
    }
}