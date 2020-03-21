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
    public partial class StructureForm : Form
    {
        DataModel db;
        public StructureForm()
        {
            try { db = new DataModel(); db.Department.Load(); }
            catch
            {
                MessageBox.Show("Ошибка подключения к базе данных.");
                Application.Exit();
                return;
            }
            InitializeComponent();
            var source = db.Department.ToList();
            var top_layer_ids = db.Department.Where(x => x.ParentDepartmentID == null).Select(x => x.ID).ToList();
            for(int i=0; i < top_layer_ids.Count(); i++)
            {
                TreeNode parentNode = new TreeNode(db.Department.Where(x => x.ParentDepartmentID == null).Select(x => x.Name).ToList()[i]);
                Tree.Nodes.Add(parentNode);
                CreateTreeView(source, top_layer_ids[i], parentNode);
            }
            
        }

        private void CreateTreeView(List<Department> source, Guid? parentID, TreeNode parentNode)
        {
            List<Department> newSource = source.Where(a => a.ParentDepartmentID.Equals(parentID)).ToList();
            foreach (var i in newSource)
            {
                TreeNode newnode = new TreeNode(i.Name);
                if (parentNode == null)
                {
                    Tree.Nodes.Add(newnode);
                }
                else
                {
                    parentNode.Nodes.Add(newnode);
                }
                CreateTreeView(source, i.ID, newnode);
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Dispose();
        }

        Point lastPoint;

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
