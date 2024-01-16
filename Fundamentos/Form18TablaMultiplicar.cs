using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fundamentos
{
    public partial class Form18TablaMultiplicar : Form
    {
        List<TextBox> lista;

        public Form18TablaMultiplicar()
        {
            InitializeComponent();
            this.lista = new List<TextBox>();


            foreach (TextBox resultados in this.panel1.Controls)
            {
                this.lista.Add(resultados);

            }
        }

        private void btnMostrarTabla_Click(object sender, EventArgs e)
        {

            int numero = int.Parse(txtNum.Text);
            for (int i = 0; i < this.lista.Count; i++)
            {
                int resultado = numero * (i + 1);
                this.lista[i].Text = resultado.ToString();
            }
            //Este metodo nos permite darle la vuelta a nuestra coleccion
            this.lista.Reverse();
        }
    }
}
