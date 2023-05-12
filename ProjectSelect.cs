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
    public partial class ProjectSelect : Form
    {
        List<Project> projectList;
        public ProjectSelect()
        {
            InitializeComponent();
        }

        private void ProjectSelect_Load(object sender, EventArgs e)
        {
            projectList = DataBase.GetProjects();

            comboBox1.Items.Add("Создать новый проект");
            foreach (var p in projectList)
            {
                comboBox1.Items.Add(p.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                SaveAs saveAs = new SaveAs();
                saveAs.ShowDialog();
            }
            else
            {
                Main.CurrentProject = DataBase.GetProject(projectList[comboBox1.SelectedIndex - 1].ProjectId);
            }
            Close();
        }

    }
}
