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
    public partial class DepartmentsForm : Form
    {
        DataModel db;
        public DepartmentsForm()
        {
            InitializeComponent();
            try { db = new DataModel(); db.Department.Load(); }
            catch
            {
                MessageBox.Show("Ошибка подключения к базе данных.");
                Application.Exit();
                return;
            }

            DataViewDep.DataSource = db.Department.Local.ToBindingList();
            DataViewDep.Columns[4].Visible = false;
            DataViewDep.Columns[5].Visible = false;
            DataViewDep.Columns[6].Visible = false;
            Department_name.Enabled = false;
            Department_code.Enabled = false;
            Dep.Enabled = false;
            Save.Visible = false;
            Change.Enabled = false;
            Del.Enabled = false;
            
            Cansel.Visible = false;
            var bs = new BindingSource();
            foreach(var dep in db.Department)
            {
                bs.Add(dep.Name);
            }
            Dep.DataSource = bs;
            Dep.SelectedIndex = -1;  
        }

        Point lastPoint;
        private void Panel4_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void Panel4_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataViewDep_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Department_name.Text = DataViewDep.SelectedRows[0].Cells[1].Value.ToString();
            try
            {
                Department_code.Text = DataViewDep.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch
            {
                Department_code.Text = "Нет данных";
            }

            try
            {
                var names = db.Department.Select(x => x.Name).ToList();
                var parent_id = DataViewDep.SelectedRows[0].Cells[3].Value.ToString();
                string parent_name = db.Department
                    .Where(x => x.ID.ToString() == parent_id)
                    .Select(x => x.Name).First().ToString();
                int index = names.IndexOf(parent_name);
                Dep.SelectedIndex = index;
            }
            catch
            {
                Dep.SelectedIndex = -1;
            }
            Change.Enabled = true;
            Del.Enabled = true;
        }
    }
}
