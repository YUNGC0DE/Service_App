using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask
{
    public partial class EmployeesForm : Form
    {

        DataModel db;
        public EmployeesForm()
        {
            db = new DataModel();
            db.Department.Load();
            db.Empoyee.Load();

            InitializeComponent();
            var departments = from obj in db.Department.Local
                              select obj.Name;
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
            Hide();
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
            var id = db.Department.Local.Where(x => x.Name == selected_dep).Select(y => y.ID).First();
            List<Guid> kids = new List<Guid>();
            List<Guid?> epoch_ids = new List<Guid?> { id };      /*ID предприятий для поиска детей на каждом уровне вложенности*/
            Kids(id, ref kids, epoch_ids);
            kids.Add(id);
            var employees = db.Empoyee.Where(x => kids.Contains(x.DepartmentID));
            DataView.DataSource = employees.ToList();
            DataView.Columns[0].Visible = false;
            DataView.Columns[5].Visible = false;
            DataView.Columns[6].Visible = false;
            DataView.Columns[8].Visible = false;
            DataView.Columns[9].Visible = false;

            DataView.AllowUserToAddRows = false;

        }

        private int Kids(Guid id, ref List<Guid> kids, List<Guid?> epochs_id)
        {
            List<Guid?> epochs_kids_id = new List<Guid?>();
            foreach (var kid in db.Department.Local)
            {
                if (epochs_id.Contains(kid.ParentDepartmentID))
                {
                    kids.Add(kid.ID);
                    epochs_kids_id.Add(kid.ID);
                } 
            }
            if (epochs_kids_id.Count() > 0)
            {
                return Kids(id, ref kids, epochs_kids_id);
            }
            else
            {
                return 0;
            }
        }


        private void DataView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            string id = DataView.SelectedRows[0].Cells[0].Value.ToString();
            string name = DataView.SelectedRows[0].Cells[1].Value.ToString();
            string surname = DataView.SelectedRows[0].Cells[2].Value.ToString();
            string patr;
            try { patr = DataView.SelectedRows[0].Cells[3].Value.ToString(); }
            catch {patr = "Нет данных"; }      
            DateTime date = Convert.ToDateTime(DataView.SelectedRows[0].Cells[4].Value);
            string docser;
            try { docser = DataView.SelectedRows[0].Cells[5].Value.ToString(); }
            catch { docser = "Нет данных"; }
            string docnumb;
            try { docnumb = DataView.SelectedRows[0].Cells[6].Value.ToString(); }
            catch { docnumb = "Нет данных"; }
            string position = DataView.SelectedRows[0].Cells[7].Value.ToString();
            string dep_id = DataView.SelectedRows[0].Cells[8].Value.ToString();


            using (var view_Edit_Employeer = new View_Edit_employeer_form(id, name, surname, patr
                , date, docser, docnumb, position, dep_id))
            {
                DialogResult result = view_Edit_Employeer.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;
            }
        }

        private void Del_employee_Click(object sender, EventArgs e)
        {

        }
        private void Add_employee_Click(object sender, EventArgs e)
        {

        }
    } 
}
