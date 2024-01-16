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
    public partial class Form11ColeccionesMultiples : Form
    {
        public Form11ColeccionesMultiples()
        {
            InitializeComponent();
            //Cambiamos a seleccion multiple
            this.listElements.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string elem = this.txtElemento.Text;
            this.listElements.Items.Add(elem);
            this.txtElemento.Focus();
            this.txtElemento.SelectAll();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            foreach (int indice in this.listElements.SelectedIndices)
            {
                indices += indice + ",";
            }
            this.lblIndice.Text = indices.Trim(',');
            string items = "";
            foreach (string elem in this.listElements.SelectedItems)
            {
                items += elem + ",";
            }
            this.lblSelected.Text = items.Trim(',');
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.listElements.Items.Clear();
        }

        private void btnElminar_Click(object sender, EventArgs e)
        {   
            //Al eliminar multiples elementos de una coleccion
            //siempre debemos hacerlo del ultimo al primero
            //por el posicionamiento de los indices
               
            int numSeleccionado = this.listElements.SelectedIndices.Count;

            //Recorremos los indices seleccionados
            for(int i = numSeleccionado -1; i >= 0 ; i--) 
            { 
                //Recuperamos cada indice 
                int indice = this.listElements.SelectedIndices[i];
                //Eliminamos cada elemento por su indice de la coleccion
                this.listElements.Items.RemoveAt(indice);
            }
        }
    }
}
