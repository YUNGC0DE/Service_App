using System;
using System.Windows.Forms;

namespace TestTask
{
    public partial class EmployeesForm
    {
        private void Change_Click(object sender, EventArgs e)
        {
            if (DataView.SelectedRows.Count > 0)
            {
                string id = DataView.SelectedRows[0].Cells[0].Value.ToString();
                string name = DataView.SelectedRows[0].Cells[1].Value.ToString();
                string surname = DataView.SelectedRows[0].Cells[2].Value.ToString();
                string patr;
                try { patr = DataView.SelectedRows[0].Cells[3].Value.ToString(); }
                catch { patr = "Нет данных"; }
                DateTime date = Convert.ToDateTime(DataView.SelectedRows[0].Cells[4].Value);
                string docser;
                try { docser = DataView.SelectedRows[0].Cells[5].Value.ToString(); }
                catch { docser = "Нет данных"; }
                string docnumb;
                try { docnumb = DataView.SelectedRows[0].Cells[6].Value.ToString(); }
                catch { docnumb = "Нет данных"; }
                string position = DataView.SelectedRows[0].Cells[7].Value.ToString();
                string dep_id = DataView.SelectedRows[0].Cells[8].Value.ToString();
                new View_Edit_employeer_form(id, name, surname, patr
                   , date, docser, docnumb, position, dep_id).Show();
                Dispose();
            }
            else
            {
                MessageBox.Show("Выберите сотрудника");
            }
        }

        private void Del_employee_Click(object sender, EventArgs e)
        {
            if (DataView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Удалить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string id = DataView.SelectedRows[0].Cells[0].Value.ToString();
                    Empoyee employee = db.Empoyee.Find(Convert.ToInt32(id));
                    db.Empoyee.Remove(employee);
                    db.SaveChanges();
                    Dep_list.SelectedIndex = 0;
                    MessageBox.Show("Сотрудник удален"); // Выводим сообщение о звершении.
                }
                else if (result == DialogResult.No)
                {
                    return;
                }   
                
            }
            else
            {
                MessageBox.Show("Выберите сотрудника");
            }
        }
        private void Add_employee_Click(object sender, EventArgs e)
        {
            new AddEmployeeForm().Show();
            Dispose();
        }
    }
}
