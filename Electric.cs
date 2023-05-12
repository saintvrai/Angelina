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
    public partial class Electric : Form
    {
        public Electric()
        {
            InitializeComponent();
        }
        private void Electric_Load(object sender, EventArgs e)
        {
            d1x0.Value = Convert.ToDecimal(Main.CurrentProject.FirstDevice.X0);
            d1y0.Value = Convert.ToDecimal(Main.CurrentProject.FirstDevice.Y0);
            d1z0.Value = Convert.ToDecimal(Main.CurrentProject.FirstDevice.Z0);
            d1x1.Value = Convert.ToDecimal(Main.CurrentProject.FirstDevice.X1);
            d1y1.Value = Convert.ToDecimal(Main.CurrentProject.FirstDevice.Y1);
            d1z1.Value = Convert.ToDecimal(Main.CurrentProject.FirstDevice.Z1);

            d2x0.Value = Convert.ToDecimal(Main.CurrentProject.SecondDevice.X0);
            d2y0.Value = Convert.ToDecimal(Main.CurrentProject.SecondDevice.Y0);
            d2z0.Value = Convert.ToDecimal(Main.CurrentProject.SecondDevice.Z0);
            d2x1.Value = Convert.ToDecimal(Main.CurrentProject.SecondDevice.X1);
            d2y1.Value = Convert.ToDecimal(Main.CurrentProject.SecondDevice.Y1);
            d2z1.Value = Convert.ToDecimal(Main.CurrentProject.SecondDevice.Z1);

            materialResistance.Value = Convert.ToDecimal(Main.CurrentProject.Line.BodyMaterialResistance);
            x1max.Value = Convert.ToDecimal(Main.CurrentProject.Line.X1max);
            x2min.Value = Convert.ToDecimal(Main.CurrentProject.Line.X2min);
            condRadius.Value = Convert.ToDecimal(Main.CurrentProject.Line.ConductorRadius);
            insulRadius.Value = Convert.ToDecimal(Main.CurrentProject.Line.InsulationRadius);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if(Main.CurrentProject.LineId != null)
            {
                Main.CurrentProject.Line = DataBase.EditLine(new Line()
                {
                    LineId = (int)Main.CurrentProject.LineId,
                    BodyMaterialResistance = (int)materialResistance.Value,
                    ConductorRadius = (int)condRadius.Value,
                    InsulationRadius = (int)insulRadius.Value,
                    X1max = (int)x1max.Value,
                    X2min = (int)x2min.Value,
                });
            }

            if (Main.CurrentProject.FirstDeviceId != null)
            {
                Main.CurrentProject.FirstDevice = DataBase.EditDevice(new ElectricDevice()
                {
                    DeviceId = (int)Main.CurrentProject.FirstDeviceId,
                    X0 = (int)d1x0.Value,
                    Y0 = (int)d1y0.Value,
                    Z0 = (int)d1z0.Value,
                    X1 = (int)d1x1.Value,
                    Y1 = (int)d1y1.Value,
                    Z1 = (int)d1z1.Value,
                });
            }

            if (Main.CurrentProject.SecondDeviceId != null)
            {
                Main.CurrentProject.SecondDevice = DataBase.EditDevice(new ElectricDevice()
                {
                    DeviceId = (int)Main.CurrentProject.SecondDeviceId,
                    X0 = (int)d2x0.Value,
                    Y0 = (int)d2y0.Value,
                    Z0 = (int)d2z0.Value,
                    X1 = (int)d2x1.Value,
                    Y1 = (int)d2y1.Value,
                    Z1 = (int)d2z1.Value,
                });
            } 

            Edit edit = new Edit();
            edit.ShowDialog();
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Check(TextBox sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }


            if (e.KeyChar == ',')
            {
                if (sender.Text.IndexOf(',') != -1)
                {

                    e.Handled = true;
                }
                return;
            }

            if (e.KeyChar == '.')
            {
                if (sender.Text.IndexOf('.') != -1)
                {

                    e.Handled = true;
                }
                return;
            }

            e.Handled = true;
        }

		private void d1x0_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
