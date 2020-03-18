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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Employees_button_Click(object sender, EventArgs e)
        {
            Hide();
            if (Application.OpenForms.Count > 1)
            {
                Form form = Application.OpenForms[1];
                form.Show();
            }
            else
            {
                EmployeesForm employees_form = new EmployeesForm();
                employees_form.Show();
            }
           
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
