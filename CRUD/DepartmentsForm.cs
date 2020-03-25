using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace TestTask
{
    public partial class DepartmentsForm
    {
        private bool changing = false;

        public  void Update_Dep()
        {
            var bs = new BindingSource();
            foreach (var dep in db.Department)
            {
                bs.Add(dep.Name);
            }
            Dep.DataSource = bs;
            Dep.SelectedIndex = -1;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            Add.Enabled = false;
            DataViewDep.Enabled = false;
            Change.Enabled = false;
            Del.Enabled = false;
            Save.Visible = true;
            Department_name.Enabled = true;
            Department_code.Enabled = true;
            Dep.Enabled = true;
            Department_name.Text = "";
            Department_code.Text = "";
            Update_Dep();
            Cansel.Visible = true;
        }


        private void Cansel_Click(object sender, EventArgs e)
        {

            DataViewDep.Enabled = true;
            Save.Visible = false;
            Save.Enabled = true;
            Department_name.Enabled = false;
            Department_code.Enabled = false;
            Dep.Enabled = false;
            Cansel.Visible = false;
            Department_name.Text = "";
            Department_code.Text = "";
            Dep.SelectedIndex = -1;
            Change.Enabled = false;
            Del.Enabled = false;
            Add.Enabled = true;
            return;
        }


        private bool Cyclicity()
        {
            var id = DataViewDep.SelectedRows[0].Cells[0].Value.ToString();
            Department dep = db.Department.Find(Guid.Parse(id));
            var id_parent = db.Department.Where(x => x.Name == Dep.SelectedItem.ToString()).Select(x => x.ID).FirstOrDefault();
            List<Guid?> epoch_id = new List<Guid?> { dep.ID };
            List<Guid> kids = new List<Guid>();
            EmployeesForm.Kids(ref kids, epoch_id, db);
            kids.Add(dep.ID);
            if (kids.Contains(id_parent))
            {
                return true;
            }
            return false;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DataViewDep.Enabled = false;
            if (Department_name.Text.Length < 1)
            {
                MessageBox.Show("Введите имя отдела");
                return;
            }
            if (Department_name.Text.Length > 50)
            {
                MessageBox.Show("Имя отдела не может быть больше 50 символов");
                return;
            }
            if (Department_code.Text.Length > 10)
            {
                MessageBox.Show("Мнемокод не может превышать 10 символов");
                return;
            }

            if (!changing)
            {
                Department department = new Department();
                department.Name = Department_name.Text;
                department.ID = Guid.NewGuid();
                if (Department_code.Text.Length < 1)
                {
                    department.Code = null;
                }
                else
                {
                    department.Code = Department_code.Text;
                }
                if (Dep.SelectedIndex == -1)
                {
                    department.ParentDepartmentID = null;
                }
                else
                {
                    department.ParentDepartmentID = db.Department
                        .Where(x => x.Name == Dep.SelectedItem.ToString()).Select(x => x.ID).First();
                }
                db.Department.Add(department);
                db.SaveChanges();
                DataViewDep.Refresh();
                MessageBox.Show("Департамент добавлен");
            }
            else
            {
                changing = false;
                var id = DataViewDep.SelectedRows[0].Cells[0].Value.ToString();
                Department dep = db.Department.Find(Guid.Parse(id));
                if (Dep.SelectedIndex != -1)
                {
                    if (Cyclicity())
                    {
                        MessageBox.Show("Зацикливание структуры предприятия недопустимо.");
                        Save.Enabled = false;
                        return;
                    }
                    dep.ParentDepartmentID = db.Department
                        .Where(x => x.Name == Dep.SelectedItem.ToString()).Select(x => x.ID).First();
                }
                else
                {
                    dep.ParentDepartmentID = null;
                }

                if (Dep.SelectedIndex == -1)
                {
                    dep.ParentDepartmentID = null;
                }
                else
                {
                    dep.ParentDepartmentID = db.Department
                        .Where(x => x.Name == Dep.SelectedItem.ToString()).Select(x => x.ID).First();
                }
                if (Department_code.Text.Length < 1)
                {
                    dep.Code = null;
                }
                else
                {
                    dep.Code = Department_code.Text;
                }
                dep.Name = Department_name.Text;
                db.SaveChanges();
                DataViewDep.Refresh();
                MessageBox.Show("Департамент изменен");
            }
            Update_Dep();
            Save.Visible = false;
            Cansel.Visible = false;
            Department_name.Enabled = false;
            Department_code.Enabled = false;
            Dep.Enabled = false;
            Change.Enabled = false;
            Del.Enabled = false;
            Add.Enabled = true;
            Department_name.Text = "";
            Department_code.Text = "";
            DataViewDep.Enabled = true;
           
        }

        private void Del_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить департамент?\n\nУдаление департамента приведет к удалению всех его сотрудников.", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                Department department = db.Department.Find(db.Department
                   .Where(x => x.Name == Department_name.Text).Select(x => x.ID).First());
                List<Guid?> epoch_id = new List<Guid?> { department.ID };
                List<Guid> kids = new List<Guid>();
                EmployeesForm.Kids(ref kids, epoch_id, db);
                kids.Add(department.ID);
                foreach(var kid in kids)
                {
                    var employees_to_del = db.Empoyee.Where(x => x.DepartmentID == kid);     /*Удаляются все работники дочерних департаментов + выбранного*/
                    foreach(var employee in employees_to_del)
                    {
                        db.Empoyee.Remove(employee);
                    }
                }
                foreach (var kid in kids)
                {
                    db.Department.Remove(db.Department.Find(kid));   /*Удаляются все дочерние департаменты + выбранный*/
                }
                Department_name.Text = "";
                Department_code.Text = "";
                Change.Enabled = false;
                Del.Enabled = false;
                db.SaveChanges();
                DataViewDep.Refresh();
                MessageBox.Show("Департамент удален.");
                Update_Dep();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            Change.Enabled = false;
            Add.Enabled = false;
            Del.Enabled = false;
            DataViewDep.Enabled = false;
            Save.Visible = true;
            Cansel.Visible = true;
            Department_name.Enabled = true;
            Department_code.Enabled = true;
            Dep.Enabled = true;
            changing = true;
        }
    }
}