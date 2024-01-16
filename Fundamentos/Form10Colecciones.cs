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
    public partial class Form10Colecciones : Form
    {
        public Form10Colecciones()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string elem = this.txtElemento.Text;
            this.listElements.Items.Add(elem);

        }

        private void btnElminar_Click(object sender, EventArgs e)
        {
            //Para poder eliminar de una coleccion tenemos dos opciones
            //1) Remove(objeto): Elimina un elemento enviando el objeto
            //2) RemoveAt(indice): Elimina un elemento por su indice
            //RECUPERAMOS EL INDICE SELECCIONADO DEL LISTBOX
            int indice = this.listElements.SelectedIndex;
            this.listElements.Items.RemoveAt(indice);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.listElements.Items.Clear();
        }

        private void listElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.listElements.SelectedIndex != -1)
            {
                this.lblIndice.Text = this.listElements.SelectedIndex.ToString();
                this.lblSelected.Text = this.listElements.SelectedItem.ToString();
            }
        }
    }
}
