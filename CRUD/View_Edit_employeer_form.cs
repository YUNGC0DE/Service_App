using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TestTask
{
    public partial class View_Edit_employeer_form : Form
    {
        public View_Edit_employeer_form(string id, string f_name,
            string surname, string patr, 
            DateTime date, string docser,
            string docnumb, string position, string depid)
        {
            
            InitializeComponent();
            
            ID.Text = id;
            ID.ReadOnly = true ;
            F_name.Text = f_name;
            F_name.ReadOnly = true;
            Surname.Text = surname;
            Surname.ReadOnly = true;
            Patr.Text = patr;
            Patr.ReadOnly = true;
            Dateofbirth.Value = date;
            DateTime now = DateTime.Today;
            int age = now.Year - date.Year;
            if (date > now.AddYears(-age)) age--;       /* Исправлен возраст */
            Age.Text = Convert.ToString(age);
            Age.ReadOnly = true;
            Docser.Text = docser;
            Docser.ReadOnly = true;
            Docnum.Text = docnumb;
            Docnum.ReadOnly = true;
            Position.Text = position;
            Position.ReadOnly = true;
            using (DataModel db = new DataModel())
            {
                Dep.DataSource = db.Department.Where(x=>x.ID.ToString() == depid).Select(x => x.Name).ToList();
            }
            Dep.SelectedIndex = 0;
            Dep.Enabled = false;
            Dep_id.Text = depid;
            Dep_id.ReadOnly = true;
            Save.Enabled = false;
        }

        private void Change_Click(object sender, EventArgs e)
        {
            Save.Enabled = true;
            Change.Enabled = false;
            F_name.ReadOnly = false;         
            Surname.ReadOnly = false;          
            Patr.ReadOnly = false;
            Docser.ReadOnly = false;
            Docnum.ReadOnly = false;
            Dep.Enabled = true;
            Position.ReadOnly = false;
            Dateofbirth.Enabled = true;
            using (DataModel db = new DataModel())
            {
                var names = db.Department.Select(x => x.Name).ToList();
                int index = names.IndexOf(Dep.SelectedItem.ToString());
                Dep.DataSource = names;
                Dep.SelectedIndex = index;
            }
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
            if(Docser.Text.Length > 4)
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

            if(Dateofbirth.Value > DateTime.Now)
            {
                MessageBox.Show("Некорректная дата рождения");
                return;
            }
            using (DataModel db = new DataModel())
             {
                Empoyee employee = db.Empoyee.Find(Convert.ToInt32(ID.Text));
                employee.FirstName = F_name.Text;
                employee.SurName = Surname.Text;
                employee.Patronymic = Patr.Text;
                employee.Position = Position.Text;
                employee.DateOfBirth = Dateofbirth.Value;
                employee.DocNumber = Docnum.Text;
                employee.DocSeries = Docser.Text;
                employee.DepartmentID = db.Department.Where(x => x.Name == Dep.SelectedItem.ToString()).Select(x => x.ID).First();
                MessageBox.Show("Данные успешно изменены");
                Dep_id.Text = employee.DepartmentID.ToString();
                DateTime now = DateTime.Today;
                int age = now.Year - Dateofbirth.Value.Year;
                if (Dateofbirth.Value > now.AddYears(-age)) age--;       /* Исправлен возраст */
                Age.Text = Convert.ToString(age);
                db.SaveChanges();
                Save.Enabled = false;
                Change.Enabled = true;
            }
            F_name.ReadOnly = true;
            Surname.ReadOnly = true;
            Patr.ReadOnly = true;
            Age.ReadOnly = true;
            Position.ReadOnly = true;
            Docser.ReadOnly = true;
            Docnum.ReadOnly = true;
            Dateofbirth.Enabled = false;
            Dep.Enabled = false;

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            new EmployeesForm().Show();
            Dispose();
        }
    }
}
