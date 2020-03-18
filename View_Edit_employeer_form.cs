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
            int age = (int)(DateTime.Now - date).TotalDays / 365;
            Age.Text = Convert.ToString(age);
            Age.ReadOnly = true;
            Docser.Text = docser;
            Docser.ReadOnly = true;
            Docnum.Text = docnumb;
            Docnum.ReadOnly = true;
            Dep.Text = position;
            Dep.ReadOnly = true;
            Dep_id.Text = depid;
            Dep_id.ReadOnly = true;
        }

        private void Change_Click(object sender, EventArgs e)
        {
            F_name.ReadOnly = false;         
            Surname.ReadOnly = false;          
            Patr.ReadOnly = false;
            Docser.ReadOnly = false;
            Docnum.ReadOnly = false;
            Dep.ReadOnly = false;
            Dep_id.ReadOnly = true;  /*разрбраться с этим 8*/
        }
    }
}
