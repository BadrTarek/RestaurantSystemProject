namespace RestaurantSystem
{
    partial class ManagerAccounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchName = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.managerNames = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.managerNames)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(718, 81);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(54, 23);
            this.searchButton.TabIndex = 28;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchName
            // 
            this.searchName.Location = new System.Drawing.Point(614, 83);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(100, 20);
            this.searchName.TabIndex = 27;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(600, 295);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(88, 38);
            this.resetButton.TabIndex = 26;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(210, 205);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(178, 20);
            this.password.TabIndex = 25;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(210, 157);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(178, 20);
            this.name.TabIndex = 24;
            // 
            // managerNames
            // 
            this.managerNames.AllowUserToAddRows = false;
            this.managerNames.AllowUserToDeleteRows = false;
            this.managerNames.AllowUserToResizeColumns = false;
            this.managerNames.AllowUserToResizeRows = false;
            this.managerNames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Format = "Names";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.managerNames.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.managerNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managerNames.ColumnHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.managerNames.DefaultCellStyle = dataGridViewCellStyle10;
            this.managerNames.Location = new System.Drawing.Point(614, 109);
            this.managerNames.MultiSelect = false;
            this.managerNames.Name = "managerNames";
            this.managerNames.ReadOnly = true;
            this.managerNames.RowHeadersVisible = false;
            this.managerNames.ShowCellErrors = false;
            this.managerNames.ShowCellToolTips = false;
            this.managerNames.ShowEditingIcon = false;
            this.managerNames.ShowRowErrors = false;
            this.managerNames.Size = new System.Drawing.Size(158, 167);
            this.managerNames.TabIndex = 23;
            this.managerNames.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.managerNames_CellContentDoubleClick);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(614, 382);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 26);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(434, 295);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 38);
            this.deleteButton.TabIndex = 21;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(267, 295);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(88, 38);
            this.updateButton.TabIndex = 20;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(102, 295);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 38);
            this.addButton.TabIndex = 19;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Manager Accounts";
            // 
            // exitButton1
            // 
            this.exitButton1.FlatAppearance.BorderSize = 0;
            this.exitButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton1.Location = new System.Drawing.Point(741, 12);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(52, 39);
            this.exitButton1.TabIndex = 15;
            this.exitButton1.Text = "x";
            this.exitButton1.UseVisualStyleBackColor = true;
            this.exitButton1.Click += new System.EventHandler(this.exitButton1_Click);
            // 
            // ManagerAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.managerNames);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagerAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Accounts";
            this.Load += new System.EventHandler(this.ManagerAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.managerNames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchName;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DataGridView managerNames;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton1;
    }
}