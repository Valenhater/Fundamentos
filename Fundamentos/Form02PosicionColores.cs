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
    public partial class Form02PosicionColores : Form
    {
        public Form02PosicionColores()
        {
            InitializeComponent();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int posVertical = int.Parse(this.txtVertical.Text);
            int posHorizontal = int.Parse(this.txtHorizontal.Text);

            this.btnPosicion.Location = new Point(posVertical, posHorizontal);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(this.txtRojo.Text);
            int verde = int.Parse(this.txtVerde.Text);
            int azul = int.Parse(this.txtAzul.Text);
            MessageBox.Show("Hola","titulo del mensaje", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
            this.BackColor = Color.FromArgb(rojo, verde, azul);
        }
    }
}
