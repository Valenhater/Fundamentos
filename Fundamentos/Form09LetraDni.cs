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
    public partial class Form09LetraDni : Form
    {
        public Form09LetraDni()
        {
            InitializeComponent();
        }

        private void btnDni_Click(object sender, EventArgs e)
        {
            string dni = this.txtDni.Text;
            //RECUPERAMOS LA LETRA DEL DNI 
            char letraDni = dni[dni.Length - 1];
            //SI LO PENSAMOS CON LETRA... 
            string soloNumeros =
                dni.Substring(0, dni.Length - 1);
            int dniNumber = int.Parse(soloNumeros);
            int resultado =
                (dniNumber - ((dniNumber / 23) * 23));
            string secuenciaLetras = "TRWAGMYFPDXBNJZSQVHLCKET";
            char letraValidacion = secuenciaLetras[resultado];
            if (letraDni == letraValidacion)
            {
                this.lblDNI.Text = "DNI correcto!!!";
            }
            else
            {
                this.lblDNI.Text = "Incorrecto, su letra es " + letraValidacion;
            }
        }
    }
}
