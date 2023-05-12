using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Data;

namespace UI
{
    public partial class Form1 : Form
    {
        string Title = "Рабочее пространство";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (DataContext db = new DataContext())
            {
                db.Database.Initialize(false);
            }
            Main.ProjectChanged += HandleProjectChanged;
            HandleProjectChanged();
        }

        private void HandleProjectChanged()
        {
            if (Main.CurrentProject != null)
            {
                Text = $"{Title}: {Main.CurrentProject.Name}";
            }
            else
            {
                Text = Title;
            }
            UpdateMenuStrip();
        }

        private void UpdateMenuStrip()
        {
            if(Main.CurrentProject == null)
            {
                menuStrip1.Items[1].Enabled = false;
                menuStrip1.Items[2].Enabled = false;
                ProjectSave.Enabled = false;
                SaveAs.Enabled = false;
                Print.Enabled = false;
                DeleteProject.Enabled = false;
            }
            else
            {
                menuStrip1.Items[1].Enabled = true;
                menuStrip1.Items[2].Enabled = true;
                ProjectSave.Enabled = true;
                SaveAs.Enabled = true;
                Print.Enabled = true;
                DeleteProject.Enabled = true;
            }
        }

        private void ProjectOpen_Click(object sender, EventArgs e)
        {
            ProjectSelect projectSelect = new ProjectSelect();
            projectSelect.ShowDialog();

        }
        private void ProjectSave_Click(object sender, EventArgs e)
        {
            ProjectSave projectSave = new ProjectSave();
            projectSave.ShowDialog();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            Print print = new Print();
            print.ShowDialog();
        }

        private void DeleteProject_Click(object sender, EventArgs e)
        {
            if (Main.CurrentProject == null) return;
            DialogResult res = MessageBox.Show(
                "Вы действительно хотите этот удалить проект?",
                "Предупреждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (res == DialogResult.Yes)
            {
                DataBase.DeleteProject(Main.CurrentProject.ProjectId);
                DeleteProject deleteProject = new DeleteProject();
                deleteProject.ShowDialog();
                Main.CurrentProject = null;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if(Main.CurrentProject != null) { Main.CurrentProject = null; }
            else Close();
        }

        private void ExternalImpulse_Click(object sender, EventArgs e)
        {
            ExternalImpulse externalImpulse = new ExternalImpulse();
            externalImpulse.ShowDialog();
        }

        private void Environment_Click(object sender, EventArgs e)
        {
            Enviroment enviroment = new Enviroment();
            enviroment.ShowDialog();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            HelpP help = new HelpP();
            help.Show();
        }

        private void About_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            //Run run = new Run();
            //run.Show();
            var proc = new Process();
            proc.EnableRaisingEvents = true;
            proc.Exited += (s, ev) => MessageBox.Show(
                "Проектная процедура завершила работу." +
				"Испытание не пройдено",
                "Готово!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
             );

            string path = $@"{System.Environment.CurrentDirectory}\CST";

            string cmdLine = $@"{path}\bpla\Plane_macro.vbs";      // BPLA
            //string cmdLine = $@"{path}\copter\COPTER_macro.vbs";    // COPTER

            proc.StartInfo = new ProcessStartInfo("wscript", cmdLine);
            proc.Start();
        }


        private void Electric_Click(object sender, EventArgs e)
        {
            Electric electric = new Electric();
            electric.ShowDialog();
        }
        
        private void SaveAs_Click(object sender, EventArgs e)
        {
            SaveAs saveas  = new SaveAs();
            saveas.ShowDialog();  
        }
    }
}
