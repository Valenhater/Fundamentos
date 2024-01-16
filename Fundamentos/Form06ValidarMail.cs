using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Fundamentos
{
    public partial class Form06ValidarMail : Form
    {
        public Form06ValidarMail()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string mail = txtMail.Text;
            int indexArroba = mail.IndexOf('@');
            int indexPunto = mail.LastIndexOf('.');

            if (mail.Contains("@") &&
                !mail.StartsWith("@") &&
                !mail.EndsWith("@") &&
                mail.IndexOf("@") == mail.LastIndexOf("@") &&
                mail.Contains(".") &&
                mail.IndexOf('.', 0, indexArroba) == -1 && mail.IndexOf('.', indexArroba) > indexArroba &&
                indexPunto > 0 && mail.Length - indexPunto >= 3 && mail.Length - indexPunto <= 5)
            {
                this.lblValidar.Text = "Validado correctamente";
            }
            else
            {
                this.lblValidar.Text = "Error de validación";
            }
        }
    }
}
