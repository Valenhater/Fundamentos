using ProyectoClases.Helpers;
using ProyectoClases.Models;
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
    public partial class Form24ListaCompra : Form
    {
        HelperListaCompra helper;
        public Form24ListaCompra()
        {
            InitializeComponent();
            this.helper = new HelperListaCompra();
        }

        private void DIbujarListaCompra()
        {
            this.lstCompra.Items.Clear();
            foreach (ListaCompra lista in this.helper.ListaCompras)
            {
                this.lstCompra.Items.Add(lista.Nombre);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
