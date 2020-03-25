using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TestTask
{
    public partial class EmployeesForm : Form
    {

        DataModel db;
        public EmployeesForm()
        {
            InitializeComponent();
            try { db = new DataModel(); db.Department.Load(); }
            catch
            {
                MessageBox.Show("Ошибка подключения к базе данных.");
                Application.Exit();
                return;
            }        
           
            var departments = from obj in db.Department.Local
                              select obj.Name;
            Dep_list.Items.Add("Выберите департамент");
            foreach (var i in departments)
            {
                Dep_list.Items.Add(i);
            }
            Dep_list.SelectedIndex = 0;
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            Dispose();
        }

        Point lastPoint;
        private void Panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Dep_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected_dep = Dep_list.SelectedItem.ToString();
            if(selected_dep != "Выберите департамент")
            {
                var id = db.Department.Where(x => x.Name == selected_dep).Select(y => y.ID).First();
                List<Guid?> epoch_id = new List<Guid?> { id};   /*ID предприятий для поиска детей на каждом уровне вложенности*/
                List<Guid> kids = new List<Guid>();
                Kids( ref kids, epoch_id, db);
                kids.Add(id);
                var employees = db.Empoyee.Where(x => kids.Contains(x.DepartmentID));
                DataView.DataSource = employees.ToList();
                DataView.Columns[5].Visible = false;
                DataView.Columns[6].Visible = false;
                DataView.Columns[8].Visible = false;
                DataView.Columns[9].Visible = false;
            }
            else
            {
                DataView.DataSource = null;
            }
        }

        public static int Kids(ref List<Guid> kids, List<Guid?> epochs_id, DataModel db)
        {
            List<Guid?> epochs_kids_id = new List<Guid?>();
            foreach (var kid in db.Department)
            {
                if (epochs_id.Contains(kid.ParentDepartmentID))
                {
                    kids.Add(kid.ID);
                    epochs_kids_id.Add(kid.ID);
                } 
            }
            if (epochs_kids_id.Count() > 0)
            {
                return Kids( ref kids, epochs_kids_id, db);
            }
            else
            {
                return 0;
            }
        }
    } 
}
