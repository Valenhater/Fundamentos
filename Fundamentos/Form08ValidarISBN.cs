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
    public partial class Form08ValidarISBN : Form
    {
        public Form08ValidarISBN()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string textoIBAN = txtISBN.Text;
            int mult = 0;

            if (textoIBAN.Length != 10)
            {
                this.lblValidar.Text = "Número de IBAN incorrecto, exceso o falta de números";
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    int digito = int.Parse(textoIBAN[i].ToString());
                    mult += digito * (i + 1);
                }

                if (mult % 11 != 0)
                {
                    this.lblValidar.Text = "Número de IBAN incorrecto, compruebe que haya introducido bien los números";
                }
                else
                {
                    this.lblValidar.Text = "IBAN Correcto";
                }
            }
        }
    }
}

