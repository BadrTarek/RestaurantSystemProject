namespace RestaurantSystem
{
    partial class StartForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cashierButton = new System.Windows.Forms.Button();
            this.managerButton = new System.Windows.Forms.Button();
            this.welcomLabel = new System.Windows.Forms.Label();
            this.exitButton1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cashierButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.managerButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(200, 175);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 100);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // cashierButton
            // 
            this.cashierButton.FlatAppearance.BorderSize = 0;
            this.cashierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierButton.ForeColor = System.Drawing.Color.White;
            this.cashierButton.Location = new System.Drawing.Point(3, 53);
            this.cashierButton.Name = "cashierButton";
            this.cashierButton.Size = new System.Drawing.Size(394, 44);
            this.cashierButton.TabIndex = 2;
            this.cashierButton.Text = "Cashier";
            this.cashierButton.UseVisualStyleBackColor = true;
            this.cashierButton.Click += new System.EventHandler(this.cashierButton_Click);
            // 
            // managerButton
            // 
            this.managerButton.FlatAppearance.BorderSize = 0;
            this.managerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerButton.ForeColor = System.Drawing.Color.White;
            this.managerButton.Location = new System.Drawing.Point(3, 3);
            this.managerButton.Name = "managerButton";
            this.managerButton.Size = new System.Drawing.Size(394, 44);
            this.managerButton.TabIndex = 0;
            this.managerButton.Text = "Manager";
            this.managerButton.UseVisualStyleBackColor = true;
            this.managerButton.Click += new System.EventHandler(this.managerButton_Click);
            // 
            // welcomLabel
            // 
            this.welcomLabel.AutoSize = true;
            this.welcomLabel.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomLabel.Location = new System.Drawing.Point(159, 82);
            this.welcomLabel.Name = "welcomLabel";
            this.welcomLabel.Size = new System.Drawing.Size(483, 35);
            this.welcomLabel.TabIndex = 12;
            this.welcomLabel.Text = "Welcom To Restaurant Program";
            // 
            // exitButton1
            // 
            this.exitButton1.FlatAppearance.BorderSize = 0;
            this.exitButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton1.Location = new System.Drawing.Point(744, 13);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(52, 39);
            this.exitButton1.TabIndex = 11;
            this.exitButton1.Text = "x";
            this.exitButton1.UseVisualStyleBackColor = true;
            this.exitButton1.Click += new System.EventHandler(this.exitButton1_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.welcomLabel);
            this.Controls.Add(this.exitButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button managerButton;
        private System.Windows.Forms.Button cashierButton;
        private System.Windows.Forms.Label welcomLabel;
        private System.Windows.Forms.Button exitButton1;
    }
}