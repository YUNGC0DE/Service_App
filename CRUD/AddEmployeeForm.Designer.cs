namespace TestTask
{
    partial class AddEmployeeForm
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
            this.Save = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.TextBox();
            this.Dep = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Docnum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Docser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.Patr = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Dateofbirth = new System.Windows.Forms.DateTimePicker();
            this.F_name = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.AutoSize = true;
            this.Save.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Save.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Save.Location = new System.Drawing.Point(352, 419);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(120, 37);
            this.Save.TabIndex = 51;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(27, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 29);
            this.label10.TabIndex = 50;
            this.label10.Text = "Должность";
            // 
            // Position
            // 
            this.Position.Location = new System.Drawing.Point(259, 232);
            this.Position.Multiline = true;
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(213, 31);
            this.Position.TabIndex = 49;
            this.Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Dep
            // 
            this.Dep.FormattingEnabled = true;
            this.Dep.Location = new System.Drawing.Point(260, 190);
            this.Dep.Name = "Dep";
            this.Dep.Size = new System.Drawing.Size(212, 24);
            this.Dep.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(26, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 29);
            this.label7.TabIndex = 43;
            this.label7.Text = "Номер паспорта";
            // 
            // Docnum
            // 
            this.Docnum.Location = new System.Drawing.Point(260, 330);
            this.Docnum.Multiline = true;
            this.Docnum.Name = "Docnum";
            this.Docnum.Size = new System.Drawing.Size(153, 31);
            this.Docnum.TabIndex = 42;
            this.Docnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(28, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 29);
            this.label6.TabIndex = 41;
            this.label6.Text = "Серия паспорта";
            // 
            // Docser
            // 
            this.Docser.Location = new System.Drawing.Point(260, 282);
            this.Docser.Multiline = true;
            this.Docser.Name = "Docser";
            this.Docser.Size = new System.Drawing.Size(85, 31);
            this.Docser.TabIndex = 40;
            this.Docser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(28, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 29);
            this.label5.TabIndex = 39;
            this.label5.Text = "Отдел";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(27, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 29);
            this.label3.TabIndex = 37;
            this.label3.Text = "Дата рождения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(28, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 36;
            this.label2.Text = "Отчество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Фамилия";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(27, 27);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(63, 29);
            this.label.TabIndex = 34;
            this.label.Text = "Имя";
            // 
            // Patr
            // 
            this.Patr.Location = new System.Drawing.Point(260, 109);
            this.Patr.Multiline = true;
            this.Patr.Name = "Patr";
            this.Patr.Size = new System.Drawing.Size(254, 30);
            this.Patr.TabIndex = 33;
            this.Patr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(260, 67);
            this.Surname.Multiline = true;
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(254, 31);
            this.Surname.TabIndex = 32;
            this.Surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Dateofbirth
            // 
            this.Dateofbirth.Location = new System.Drawing.Point(260, 152);
            this.Dateofbirth.Name = "Dateofbirth";
            this.Dateofbirth.Size = new System.Drawing.Size(190, 22);
            this.Dateofbirth.TabIndex = 30;
            // 
            // F_name
            // 
            this.F_name.Location = new System.Drawing.Point(260, 27);
            this.F_name.Multiline = true;
            this.F_name.Name = "F_name";
            this.F_name.Size = new System.Drawing.Size(254, 29);
            this.F_name.TabIndex = 29;
            this.F_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cancel
            // 
            this.Cancel.AutoSize = true;
            this.Cancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Cancel.Location = new System.Drawing.Point(493, 419);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(110, 37);
            this.Cancel.TabIndex = 53;
            this.Cancel.Text = "Назад";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(161)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(627, 487);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.Dep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Docnum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Docser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Patr);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Dateofbirth);
            this.Controls.Add(this.F_name);
            this.Name = "AddEmployeeForm";
            this.Text = "Добавить работника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Position;
        private System.Windows.Forms.ComboBox Dep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Docnum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Docser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox Patr;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.DateTimePicker Dateofbirth;
        private System.Windows.Forms.TextBox F_name;
        private System.Windows.Forms.Button Cancel;
    }
}