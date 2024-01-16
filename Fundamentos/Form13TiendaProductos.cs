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
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();
            //Cambiamos a seleccion multiple
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string producto = this.txtProducto.Text;
            this.lstTienda.Items.Add(producto);
            this.txtProducto.Focus();
            this.txtProducto.SelectAll();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


            if (this.lstProductos.Items.Count >= 1)
            {
                int indiceProducto = this.lstProductos.SelectedIndex;
                this.lstProductos.Items.RemoveAt(indiceProducto);
            }
            //Al eliminar multiples elementos de una coleccion
            //siempre debemos hacerlo del ultimo al primero
            //por el posicionamiento de los indices

            int tiendaSeleccionado = this.lstTienda.SelectedIndices.Count;

            //Recorremos los indices seleccionados
            for (int i = tiendaSeleccionado - 1; i >= 0; i--)
            {
                //Recuperamos cada indice 
                int indice = this.lstTienda.SelectedIndices[i];
                //Eliminamos cada elemento por su indice de la coleccion
                this.lstTienda.Items.RemoveAt(indice);
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.lstTienda.SelectedIndex != -1)
            {
                int indiceSeleccionado = this.lstTienda.SelectedIndex;
                this.lstTienda.Items[indiceSeleccionado] =
                    this.txtProducto.Text;
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccionado_Click(object sender, EventArgs e)
        {
            int tiendaSeleccionado = this.lstTienda.SelectedIndices.Count;

            //Recorremos los indices seleccionados
            for (int i = tiendaSeleccionado - 1; i >= 0; i--)
            {
                //Recuperamos cada indice 
                int indice = this.lstTienda.SelectedIndices[i];
                string textoProd = this.lstTienda.Items[indice].ToString();
                //Eliminamos cada elemento por su indice de la coleccion
                this.lstTienda.Items.RemoveAt(indice);
                this.lstProductos.Items.Add(textoProd);
            }
        }

        private void btnMovertodos_Click(object sender, EventArgs e)
        {
            foreach (string producto in this.lstTienda.Items)
            {
                this.lstProductos.Items.Add(producto);
            }
            this.lstTienda.Items.Clear();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int indice = this.lstProductos.SelectedIndex;
            string producto = this.lstProductos.SelectedItem.ToString();
            this.lstProductos.Items.RemoveAt(indice);
            this.lstProductos.Items.Insert(indice - 1, producto);
            this.lstProductos.SelectedIndex = indice - 1;
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int indice = this.lstProductos.SelectedIndex;
            string producto = this.lstProductos.SelectedItem.ToString();
            this.lstProductos.Items.RemoveAt(indice);
            this.lstProductos.Items.Insert(indice + 1, producto);
            this.lstProductos.SelectedIndex = indice + 1;
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.lstProductos.SelectedIndex;
            if ( indice == 0 ) 
            {
                this.btnSubir.Enabled = false;
            }
            else
            {
                this.btnSubir.Enabled = true;
            }
            if ( indice == this.lstProductos.Items.Count - 1 )
            {
                this.btnBajar.Enabled = false;
            }
            else
            {
                this.btnBajar.Enabled = true;
            }
        }
    }
}
