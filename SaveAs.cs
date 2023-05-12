using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Data;

namespace UI
{
    public partial class SaveAs : Form
    {
        public SaveAs()
        {
            InitializeComponent();
        }
        private void SaveAs_Load(object sender, EventArgs e)
        {
            textBox1.Text = Main.CurrentProject != null ? Main.CurrentProject.Name : "";
            Ok.Enabled = textBox1.Text.Length != 0;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if(Main.CurrentProject != null)
            {
                Project newP = Main.CurrentProject;
                newP.Name = textBox1.Text;
                DataBase.EditProject(newP);
            }
            else
            {
                Main.CurrentProject = DataBase.CreateProject(textBox1.Text);
            }
            ProjectSave projectSave = new ProjectSave();
            projectSave.ShowDialog();
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Ok.Enabled = textBox1.Text.Length != 0;
        }
    }
}
