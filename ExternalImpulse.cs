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
    public partial class ExternalImpulse : Form
    {
        public ExternalImpulse()
        {
            InitializeComponent();
        }
        private void ExternalImpulse_Load(object sender, EventArgs e)
        {
            if(Main.CurrentProject.ExternalEffect != null)
            {
                FieldStrength.Value = Main.CurrentProject.ExternalEffect.FieldStrength;
                ImpulseDuration.Value = Main.CurrentProject.ExternalEffect.ImpulseDuration;
                ImpulseAmp.Value = Main.CurrentProject.ExternalEffect.ImpulseAmp;
                ImpulseStrength.Value = Main.CurrentProject.ExternalEffect.ImpulseStrength;
                IncreaseTime.Value = Main.CurrentProject.ExternalEffect.IncreaseTime;
                DecreaseTime.Value = Main.CurrentProject.ExternalEffect.DecreaseTime;
                Duration.Value = Main.CurrentProject.ExternalEffect.Duration;
                Frequency.Value = Convert.ToDecimal(Main.CurrentProject.ExternalEffect.Frequency);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (Main.CurrentProject.EffectId != null)
            {
                Main.CurrentProject.ExternalEffect = DataBase.EditEffect(new Data.ExternalEffect()
                {
                    EffectId = (int)Main.CurrentProject.EffectId,
                    FieldStrength = (int)FieldStrength.Value,
                    ImpulseDuration = (int)ImpulseDuration.Value,
                    ImpulseAmp = (int)ImpulseAmp.Value,
                    ImpulseStrength = (int)ImpulseStrength.Value,
                    IncreaseTime = (int)IncreaseTime.Value,
                    DecreaseTime = (int)DecreaseTime.Value,
                    Duration = (int)Duration.Value,
                    Frequency = (double)Frequency.Value,
                });
                Edit edit = new Edit();
                edit.ShowDialog();
                Close();
            }
        }

		private void Duration_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
