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
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            int doble = this.GetDobleValor(numero);
            this.lblResultado.Text = doble.ToString();
        }
        //recibimos el parametro wrapper por valor
        int GetDobleValor(int num)
        {
            int doble = num * 2;
            return doble;
        }

        private void btnObjRef_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnDobleRef);
            this.CambiarColor(this.btnDobleValor);
        }

        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.Yellow;
        }

        private void btnDobleRef_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            //Añadir tambien la referencia como en el metodo
            this.GetDobleReferencia(ref numero);
            this.lblResultado.Text = numero.ToString();
        }
        //Para elementos wrapper como int fechas y tal utilizamos el ref, como vemos en el otro boton no funciona sino
        void GetDobleReferencia(ref int num)
        {
            num = num * 2;
        }

        private void Form14Metodos_Load(object sender, EventArgs e)
        {

        }

        private void Form14Metodos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void lblMouse_Click(object sender, EventArgs e)
        {

        }

        private void lblMouse_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblMouse.Text = " X: " + e.X + ", Y: " + e.Y;
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            this.lblResultado.Text = e.KeyChar.ToString();
            if(char.IsDigit(e.KeyChar) == false && e.KeyChar != teclaBorrar) 
            {
                e.Handled = true; 
            }
            
        }
    }
}
