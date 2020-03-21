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

        private List<Guid> kids = new List<Guid>();
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
                if (Dep.SelectedItem.ToString() ==  db.Department.Where(x=>x.ID == dep.ID).Select(x=>x.Name).First())
                {
                    MessageBox.Show("Отдел не может быть своим же родительским отделом");
                    Save.Enabled = false;
                    return;
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
            DialogResult result = MessageBox.Show("Удалить департамент?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Department department = db.Department.Find(db.Department
                   .Where(x => x.Name == Department_name.Text).Select(x => x.ID).First());
                if(db.Empoyee.Where(x=>x.DepartmentID == department.ID).ToList().Count<1)
                {
                    foreach (var dep in db.Department)
                    {
                        if (dep.ParentDepartmentID == department.ID)
                        {
                            MessageBox.Show("Невозможно удалить департамент, имеющий вложенные отделы.");
                            return;
                        }
                    }

                    db.Department.Remove(department);
                    Department_name.Text = "";
                    Department_code.Text = "";
                    Change.Enabled = false;
                    Del.Enabled = false;
                    db.SaveChanges();
                    DataViewDep.Refresh();
                    MessageBox.Show("Департамент удален.");
                    Update_Dep();
                }
                else
                {
                    MessageBox.Show("Невозможно удалить департамент, имеющий сотрудников.");
                    return;
                }
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