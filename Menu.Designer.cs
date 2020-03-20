namespace TestTask
{
    partial class Menu
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
            this.Employees_button = new System.Windows.Forms.Button();
            this.Department_button = new System.Windows.Forms.Button();
            this.Structure_button = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // Employees_button
            // 
            this.Employees_button.AutoSize = true;
            this.Employees_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Employees_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Employees_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Employees_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip;
            this.Employees_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Employees_button.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Employees_button.Location = new System.Drawing.Point(35, 88);
            this.Employees_button.Name = "Employees_button";
            this.Employees_button.Size = new System.Drawing.Size(289, 84);
            this.Employees_button.TabIndex = 5;
            this.Employees_button.Text = "Персонал";
            this.Employees_button.UseVisualStyleBackColor = false;
            this.Employees_button.Click += new System.EventHandler(this.Employees_button_Click);
            // 
            // Department_button
            // 
            this.Department_button.AutoSize = true;
            this.Department_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Department_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Department_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip;
            this.Department_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Department_button.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Department_button.Location = new System.Drawing.Point(35, 197);
            this.Department_button.Name = "Department_button";
            this.Department_button.Size = new System.Drawing.Size(289, 79);
            this.Department_button.TabIndex = 6;
            this.Department_button.Text = "Департаменты";
            this.Department_button.UseVisualStyleBackColor = false;
            this.Department_button.Click += new System.EventHandler(this.Department_button_Click);
            // 
            // Structure_button
            // 
            this.Structure_button.AutoSize = true;
            this.Structure_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Structure_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Structure_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip;
            this.Structure_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Structure_button.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Structure_button.Location = new System.Drawing.Point(35, 301);
            this.Structure_button.Name = "Structure_button";
            this.Structure_button.Size = new System.Drawing.Size(289, 86);
            this.Structure_button.TabIndex = 7;
            this.Structure_button.Text = "Структура предприятия";
            this.Structure_button.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = global::TestTask.Properties.Resources.exit;
            this.Exit.Location = new System.Drawing.Point(311, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(41, 31);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 8;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(161)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(364, 469);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Structure_button);
            this.Controls.Add(this.Department_button);
            this.Controls.Add(this.Employees_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Employees_button;
        private System.Windows.Forms.Button Department_button;
        private System.Windows.Forms.Button Structure_button;
        private System.Windows.Forms.PictureBox Exit;
    }
}