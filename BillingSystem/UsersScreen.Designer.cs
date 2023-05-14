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
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.clmIdUs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackUsersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.AllowUserToResizeColumns = false;
            this.dgvAdmin.AllowUserToResizeRows = false;
            this.dgvAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.dgvAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdUs,
            this.clmUser,
            this.clmPassword});
            this.dgvAdmin.Location = new System.Drawing.Point(16, 13);
            this.dgvAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAdmin.RowTemplate.Height = 25;
            this.dgvAdmin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvAdmin.Size = new System.Drawing.Size(543, 320);
            this.dgvAdmin.TabIndex = 5;
            this.dgvAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellContentClick);
            // 
            // clmIdUs
            // 
            this.clmIdUs.HeaderText = "ID";
            this.clmIdUs.Name = "clmIdUs";
            this.clmIdUs.ReadOnly = true;
            // 
            // clmUser
            // 
            this.clmUser.HeaderText = "User";
            this.clmUser.Name = "clmUser";
            this.clmUser.ReadOnly = true;
            this.clmUser.Width = 200;
            // 
            // clmPassword
            // 
            this.clmPassword.HeaderText = "Password";
            this.clmPassword.Name = "clmPassword";
            this.clmPassword.ReadOnly = true;
            this.clmPassword.Width = 200;
            // 
            // BackUsersButton
            // 
            this.BackUsersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.BackUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackUsersButton.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackUsersButton.ForeColor = System.Drawing.Color.White;
            this.BackUsersButton.Location = new System.Drawing.Point(156, 346);
            this.BackUsersButton.Name = "BackUsersButton";
            this.BackUsersButton.Size = new System.Drawing.Size(263, 27);
            this.BackUsersButton.TabIndex = 7;
            this.BackUsersButton.Text = "Back";
            this.BackUsersButton.UseVisualStyleBackColor = false;
            this.BackUsersButton.Click += new System.EventHandler(this.BackUsersButton_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(574, 385);
            this.ControlBox = false;
            this.Controls.Add(this.BackUsersButton);
            this.Controls.Add(this.dgvAdmin);
            this.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(590, 424);
            this.MinimumSize = new System.Drawing.Size(590, 424);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvAdmin;
        private DataGridViewTextBoxColumn clmIdUs;
        private DataGridViewTextBoxColumn clmUser;
        private DataGridViewTextBoxColumn clmPassword;
        private Button BackUsersButton;
    }
}