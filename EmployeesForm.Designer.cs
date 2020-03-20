namespace TestTask
{
    partial class EmployeesForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Change = new System.Windows.Forms.Button();
            this.Del_employee = new System.Windows.Forms.Button();
            this.Add_employee = new System.Windows.Forms.Button();
            this.Dep_list = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // DataView
            // 
            this.DataView.AllowUserToAddRows = false;
            this.DataView.AllowUserToDeleteRows = false;
            this.DataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataView.Location = new System.Drawing.Point(324, 0);
            this.DataView.Name = "DataView";
            this.DataView.ReadOnly = true;
            this.DataView.RowHeadersWidth = 51;
            this.DataView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Myriad Pro", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataView.RowTemplate.ErrorText = "Ошибка";
            this.DataView.RowTemplate.Height = 24;
            this.DataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataView.Size = new System.Drawing.Size(986, 462);
            this.DataView.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Change);
            this.panel3.Controls.Add(this.Del_employee);
            this.panel3.Controls.Add(this.Add_employee);
            this.panel3.Controls.Add(this.Dep_list);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.Back);
            this.panel3.Controls.Add(this.Exit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 462);
            this.panel3.TabIndex = 3;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel3_MouseMove);
            // 
            // Change
            // 
            this.Change.BackColor = System.Drawing.Color.White;
            this.Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Change.Location = new System.Drawing.Point(54, 404);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(209, 35);
            this.Change.TabIndex = 19;
            this.Change.Text = "Просмотр | Изменение";
            this.Change.UseVisualStyleBackColor = false;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Del_employee
            // 
            this.Del_employee.BackColor = System.Drawing.Color.White;
            this.Del_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del_employee.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del_employee.Location = new System.Drawing.Point(174, 352);
            this.Del_employee.Name = "Del_employee";
            this.Del_employee.Size = new System.Drawing.Size(89, 35);
            this.Del_employee.TabIndex = 18;
            this.Del_employee.Text = "Удалить";
            this.Del_employee.UseVisualStyleBackColor = false;
            this.Del_employee.Click += new System.EventHandler(this.Del_employee_Click);
            // 
            // Add_employee
            // 
            this.Add_employee.BackColor = System.Drawing.Color.White;
            this.Add_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_employee.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Add_employee.Location = new System.Drawing.Point(54, 352);
            this.Add_employee.Name = "Add_employee";
            this.Add_employee.Size = new System.Drawing.Size(100, 35);
            this.Add_employee.TabIndex = 17;
            this.Add_employee.Text = "Добавить";
            this.Add_employee.UseVisualStyleBackColor = false;
            this.Add_employee.Click += new System.EventHandler(this.Add_employee_Click);
            // 
            // Dep_list
            // 
            this.Dep_list.AllowDrop = true;
            this.Dep_list.DropDownHeight = 200;
            this.Dep_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dep_list.FormattingEnabled = true;
            this.Dep_list.IntegralHeight = false;
            this.Dep_list.ItemHeight = 16;
            this.Dep_list.Location = new System.Drawing.Point(31, 146);
            this.Dep_list.MaxDropDownItems = 4;
            this.Dep_list.Name = "Dep_list";
            this.Dep_list.Size = new System.Drawing.Size(267, 24);
            this.Dep_list.TabIndex = 16;
            this.Dep_list.Tag = "";
            this.Dep_list.SelectedIndexChanged += new System.EventHandler(this.Dep_list_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(161)))), ((int)(((byte)(185)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Выбрать департамент";
            // 
            // Back
            // 
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Image = global::TestTask.Properties.Resources.back;
            this.Back.Location = new System.Drawing.Point(67, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(45, 34);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back.TabIndex = 10;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(161)))), ((int)(((byte)(185)))));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = global::TestTask.Properties.Resources.exit;
            this.Exit.Location = new System.Drawing.Point(12, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(35, 34);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 9;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(161)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1310, 462);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestTask";
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Dep_list;
        private System.Windows.Forms.Button Del_employee;
        private System.Windows.Forms.Button Add_employee;
        public System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.Button Change;
    }
}

