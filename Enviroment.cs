using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Enviroment : Form
    {
        public Enviroment()
        {
            InitializeComponent();
        }
        private void Enviroment_Load(object sender, EventArgs e)
        {
            if(Main.CurrentProject.Experiment != null)
            {
                MaxFrequency.Value = (decimal)Main.CurrentProject.Experiment.MaxFrequency;
                SourceX.Value = Main.CurrentProject.Experiment.SourceX;
                SourceY.Value = Main.CurrentProject.Experiment.SourceY;
                SourceZ.Value = Main.CurrentProject.Experiment.SourceZ;
                VectorX.Value = Main.CurrentProject.Experiment.VectorX;
                VectorY.Value = Main.CurrentProject.Experiment.VectorY;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (Main.CurrentProject.ExperimentId != null)
            {
                Main.CurrentProject.Experiment = DataBase.EditExperiment(new Data.Experiment()
                {
                    ExperimentId = (int)Main.CurrentProject.ExperimentId,
                    MaxFrequency = (double)MaxFrequency.Value,
                    SourceX = (int)SourceX.Value,
                    SourceY = (int)SourceY.Value,
                    SourceZ = (int)SourceZ.Value,
                    VectorX = (int)VectorX.Value,
                    VectorY = (int)VectorY.Value
                });
                Edit edit = new Edit();
                edit.ShowDialog();
                Close();
            }
        }
	}
}
