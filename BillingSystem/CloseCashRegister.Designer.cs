namespace BillingSystem
{
    partial class CloseCashRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloseCashRegister));
            this.lvwCerrar = new System.Windows.Forms.ListView();
            this.clmChocolateCake = new System.Windows.Forms.ColumnHeader();
            this.clmMiloCake = new System.Windows.Forms.ColumnHeader();
            this.clmChocolateBread = new System.Windows.Forms.ColumnHeader();
            this.columnCoffee = new System.Windows.Forms.ColumnHeader();
            this.clmOrangeJuice = new System.Windows.Forms.ColumnHeader();
            this.columnWater = new System.Windows.Forms.ColumnHeader();
            this.columnCheeseStick = new System.Windows.Forms.ColumnHeader();
            this.columnPastry = new System.Windows.Forms.ColumnHeader();
            this.columnCroissant = new System.Windows.Forms.ColumnHeader();
            this.RecordButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwCerrar
            // 
            this.lvwCerrar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmChocolateCake,
            this.clmMiloCake,
            this.clmChocolateBread,
            this.columnCoffee,
            this.clmOrangeJuice,
            this.columnWater,
            this.columnCheeseStick,
            this.columnPastry,
            this.columnCroissant});
            this.lvwCerrar.Location = new System.Drawing.Point(15, 12);
            this.lvwCerrar.Name = "lvwCerrar";
            this.lvwCerrar.Size = new System.Drawing.Size(905, 501);
            this.lvwCerrar.TabIndex = 7;
            this.lvwCerrar.UseCompatibleStateImageBehavior = false;
            this.lvwCerrar.View = System.Windows.Forms.View.Details;
            // 
            // clmChocolateCake
            // 
            this.clmChocolateCake.Text = "Chocolate Cake";
            this.clmChocolateCake.Width = 100;
            // 
            // clmMiloCake
            // 
            this.clmMiloCake.Text = "Milo Cake";
            this.clmMiloCake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmMiloCake.Width = 100;
            // 
            // clmChocolateBread
            // 
            this.clmChocolateBread.Text = "Chocolate Bread";
            this.clmChocolateBread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmChocolateBread.Width = 100;
            // 
            // columnCoffee
            // 
            this.columnCoffee.Text = "Coffee";
            this.columnCoffee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCoffee.Width = 100;
            // 
            // clmOrangeJuice
            // 
            this.clmOrangeJuice.Text = "Orange Juice";
            this.clmOrangeJuice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmOrangeJuice.Width = 100;
            // 
            // columnWater
            // 
            this.columnWater.Text = "Water";
            this.columnWater.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnWater.Width = 100;
            // 
            // columnCheeseStick
            // 
            this.columnCheeseStick.Text = "Chesse Stick";
            this.columnCheeseStick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCheeseStick.Width = 100;
            // 
            // columnPastry
            // 
            this.columnPastry.Text = "Pastry";
            this.columnPastry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPastry.Width = 100;
            // 
            // columnCroissant
            // 
            this.columnCroissant.Text = "Croissant";
            this.columnCroissant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCroissant.Width = 100;
            // 
            // RecordButton
            // 
            this.RecordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.RecordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RecordButton.Font = new System.Drawing.Font("Montserrat", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RecordButton.ForeColor = System.Drawing.Color.White;
            this.RecordButton.Location = new System.Drawing.Point(107, 544);
            this.RecordButton.Margin = new System.Windows.Forms.Padding(0);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(320, 50);
            this.RecordButton.TabIndex = 16;
            this.RecordButton.TabStop = false;
            this.RecordButton.Text = "Record Register";
            this.RecordButton.UseVisualStyleBackColor = false;
            this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Font = new System.Drawing.Font("Montserrat", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(507, 544);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(320, 50);
            this.CloseButton.TabIndex = 17;
            this.CloseButton.TabStop = false;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CloseCashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(934, 621);
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RecordButton);
            this.Controls.Add(this.lvwCerrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(950, 660);
            this.MinimumSize = new System.Drawing.Size(950, 660);
            this.Name = "CloseCashRegister";
            this.Text = "Close Cash Register";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvwCerrar;
        private ColumnHeader clmChocolateCake;
        private ColumnHeader clmMiloCake;
        private ColumnHeader clmChocolateBread;
        private ColumnHeader clmOrangeJuice;
        private ColumnHeader columnCoffee;
        private ColumnHeader columnWater;
        private ColumnHeader columnCheeseStick;
        private ColumnHeader columnPastry;
        private ColumnHeader columnCroissant;
        public Button RecordButton;
        public Button CloseButton;
    }
}