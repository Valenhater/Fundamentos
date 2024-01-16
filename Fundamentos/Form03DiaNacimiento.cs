using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnCalcularDia_Click(object sender, EventArgs e)
        {
            int diaNac = int.Parse(txtDia.Text);
            int mesNac = int.Parse(txtMes.Text);
            int anyoNac = int.Parse(txtAnyo.Text);

            if ( mesNac == 1)
            {
                mesNac = 13;
                anyoNac--;
            }else if ( mesNac == 2)
            {
                mesNac = 14;
                anyoNac--;
            }

            int operacion1 = ((mesNac + 1) * 3) / 5;
            int operacion2 = anyoNac / 4;
            int operacion3 = anyoNac / 100;
            int operacion4 = anyoNac / 400;
            int operacion5 = diaNac + (mesNac * 2) + anyoNac + operacion1 + operacion2 - operacion3 + operacion4 + 2;
            int operacion6 = operacion5 / 7;
            int operacion7 = operacion5 - (operacion6 * 7);

            if (operacion7 == 0)
            {
                this.lblDiaNacimiento.Text = "Cumpliste años un  Sábado";
            }
            else if (operacion7 == 1)
            {
                this.lblDiaNacimiento.Text = "Cumpliste años un  Domingo";
            }
            else if (operacion7 == 2)
            {
                this.lblDiaNacimiento.Text = "Cumpliste años un  Lunes";
            }
            else if (operacion7 == 3)
            {
                this.lblDiaNacimiento.Text = "Cumpliste años un  Martes";
            }
            else if (operacion7 == 4) {
                this.lblDiaNacimiento.Text = "Cumpliste años un  Miercoles";
            }
            else if(operacion7 == 5)
            {
                this.lblDiaNacimiento.Text = "Cumpliste años un  Jueves";
            }else if (operacion7 == 6)
            {
                this.lblDiaNacimiento.Text = "Cumpliste años un  Viernes";
            }

        }
    }
}
