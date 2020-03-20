namespace TestTask
{
    partial class DepartmentsForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.Cansel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Dep = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Code_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.Department_code = new System.Windows.Forms.TextBox();
            this.Department_name = new System.Windows.Forms.TextBox();
            this.Change = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DataViewDep = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewDep)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(161)))), ((int)(((byte)(185)))));
            this.panel4.Controls.Add(this.Cansel);
            this.panel4.Controls.Add(this.Save);
            this.panel4.Controls.Add(this.Dep);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.Code_label);
            this.panel4.Controls.Add(this.name_label);
            this.panel4.Controls.Add(this.Department_code);
            this.panel4.Controls.Add(this.Department_name);
            this.panel4.Controls.Add(this.Change);
            this.panel4.Controls.Add(this.Del);
            this.panel4.Controls.Add(this.Add);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(321, 448);
            this.panel4.TabIndex = 27;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel4_MouseMove);
            // 
            // Cansel
            // 
            this.Cansel.BackColor = System.Drawing.Color.White;
            this.Cansel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cansel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Cansel.Location = new System.Drawing.Point(172, 284);
            this.Cansel.Name = "Cansel";
            this.Cansel.Size = new System.Drawing.Size(125, 35);
            this.Cansel.TabIndex = 37;
            this.Cansel.Text = "Отмена";
            this.Cansel.UseVisualStyleBackColor = false;
            this.Cansel.Click += new System.EventHandler(this.Cansel_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.White;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Save.Location = new System.Drawing.Point(41, 284);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(125, 35);
            this.Save.TabIndex = 36;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Dep
            // 
            this.Dep.FormattingEnabled = true;
            this.Dep.Location = new System.Drawing.Point(57, 234);
            this.Dep.Name = "Dep";
            this.Dep.Size = new System.Drawing.Size(193, 24);
            this.Dep.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(52, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Родительский отдел";
            // 
            // Code_label
            // 
            this.Code_label.AutoSize = true;
            this.Code_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Code_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Code_label.Location = new System.Drawing.Point(36, 148);
            this.Code_label.Name = "Code_label";
            this.Code_label.Size = new System.Drawing.Size(111, 25);
            this.Code_label.TabIndex = 30;
            this.Code_label.Text = "Мнемокод";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.name_label.Location = new System.Drawing.Point(36, 111);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(54, 25);
            this.name_label.TabIndex = 29;
            this.name_label.Text = "Имя";
            // 
            // Department_code
            // 
            this.Department_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Department_code.Location = new System.Drawing.Point(153, 148);
            this.Department_code.Multiline = true;
            this.Department_code.Name = "Department_code";
            this.Department_code.Size = new System.Drawing.Size(144, 31);
            this.Department_code.TabIndex = 27;
            this.Department_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Department_name
            // 
            this.Department_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Department_name.Location = new System.Drawing.Point(153, 107);
            this.Department_name.Multiline = true;
            this.Department_name.Name = "Department_name";
            this.Department_name.Size = new System.Drawing.Size(144, 29);
            this.Department_name.TabIndex = 24;
            this.Department_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Change
            // 
            this.Change.BackColor = System.Drawing.Color.White;
            this.Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Change.Location = new System.Drawing.Point(214, 403);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(101, 35);
            this.Change.TabIndex = 19;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = false;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Del
            // 
            this.Del.BackColor = System.Drawing.Color.White;
            this.Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del.Location = new System.Drawing.Point(119, 403);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(89, 35);
            this.Del.TabIndex = 18;
            this.Del.Text = "Удалить";
            this.Del.UseVisualStyleBackColor = false;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.White;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Add.Location = new System.Drawing.Point(12, 403);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 35);
            this.Add.TabIndex = 17;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::TestTask.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(67, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(161)))), ((int)(((byte)(185)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::TestTask.Properties.Resources.exit;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // DataViewDep
            // 
            this.DataViewDep.AllowUserToAddRows = false;
            this.DataViewDep.AllowUserToDeleteRows = false;
            this.DataViewDep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataViewDep.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataViewDep.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataViewDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewDep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataViewDep.Location = new System.Drawing.Point(321, 0);
            this.DataViewDep.Name = "DataViewDep";
            this.DataViewDep.ReadOnly = true;
            this.DataViewDep.RowHeadersWidth = 51;
            this.DataViewDep.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Myriad Pro", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataViewDep.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataViewDep.RowTemplate.ErrorText = "Ошибка";
            this.DataViewDep.RowTemplate.Height = 24;
            this.DataViewDep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataViewDep.Size = new System.Drawing.Size(805, 448);
            this.DataViewDep.TabIndex = 28;
            this.DataViewDep.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataViewDep_RowHeaderMouseClick);
            this.DataViewDep.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataViewDep_RowHeaderMouseClick);
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1126, 448);
            this.Controls.Add(this.DataViewDep);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepartmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Департамент";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewDep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.DataGridView DataViewDep;
        private System.Windows.Forms.ComboBox Dep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Code_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox Department_code;
        private System.Windows.Forms.TextBox Department_name;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cansel;
    }
}