using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {      
            InitializeComponent();
            using(DataModel db = new DataModel())
            {
                Dep.DataSource = db.Department.Select(x => x.Name).ToList();
                Dep.SelectedIndex = 0;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            new EmployeesForm().Show();
            Dispose();
        }

        private void Save_Click(object sender, EventArgs e)
        {

            if (F_name.Text.Length < 1)
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (F_name.Text.Length > 50)
            {
                MessageBox.Show("Имя не должно превышать 50 символов");
                return;
            }
            if (Surname.Text.Length < 1)
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            if (Surname.Text.Length > 50)
            {
                MessageBox.Show("Фамилия не должна привышать 50 символов");
                return;
            }
            if (Position.Text.Length < 1)
            {
                MessageBox.Show("Введите должность");
                return;
            }
            if (Position.Text.Length > 50)
            {
                MessageBox.Show("Должность не может превышать 50 символов");
                return;
            }
            if (Docser.Text.Length > 4)
            {
                MessageBox.Show("Серия паспорта не может быть больше 4 символов");
                return;
            }
            if (Docnum.Text.Length > 6)
            {
                MessageBox.Show("Номер паспорта не может быть больше 6 символов");
                return;
            }
            if (Patr.Text.Length > 50)
            {
                MessageBox.Show("Отчество не может быть больше 50 символов");
                return;
            }
            string firstName = F_name.Text;
            string surname = Surname.Text;
            string patr = Patr.Text;
            DateTime dateofbirth = Dateofbirth.Value.Date;
            string dep_name = Dep.SelectedItem.ToString();
            string position = Position.Text;
            string docser = Docser.Text;
            string docnum = Docnum.Text;
            using (DataModel db = new DataModel())
            {
                Guid department_Id = db.Department.Where(x => x.Name == dep_name).Select(x => x.ID).First();
                Empoyee employee = new Empoyee();
                employee.DepartmentID = department_Id;
                employee.FirstName = firstName;
                employee.SurName = surname;
                employee.Patronymic = patr;
                employee.DateOfBirth = dateofbirth;
                employee.Position = position;
                employee.DocSeries = docser;
                employee.DocNumber = docnum;
                db.Empoyee.Add(employee);
                db.SaveChanges();
                MessageBox.Show("Сотрудник добавлен");
            }
        }
    }
}
