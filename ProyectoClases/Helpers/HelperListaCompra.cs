using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Helpers
{
    public class HelperListaCompra
    {
        public List<ListaCompra> ListaCompras { get; set; }

        public HelperListaCompra()
        {
            this.ListaCompras = new List<ListaCompra>();
        }

        public async Task WriteListaCompra(string path)
        {
            //Convertimos la coleccion a string
            string data = this.ConvertirListaString();
            await HelperFiles.WriteFileAsync(path, data);
        }

        public async Task ReadListaCompra(string path)
        {
            string data = await HelperFiles.ReadFileAsync(path);
            this.ConvertirListaList(data);
        }
        private string ConvertirListaString()
        {
            string data = "";
            foreach (ListaCompra listacompra in this.ListaCompras)
            {
                string temp = listacompra.Nombre + "," + listacompra.Cantidad;
                data += temp + "@";
            }
            data = data.Trim('#');
            return data;
        }

        private void ConvertirListaList(string data)
        {
            this.ListaCompras.Clear();
            string[] datosLista = data.Split('@');
            foreach(string d in datosLista)
            {
                string[] propiedades = d.Split(",");
                ListaCompra listaCompra = new ListaCompra();
                listaCompra.Nombre = propiedades[0];
                listaCompra.Cantidad = propiedades[1];
                this.ListaCompras.Add(listaCompra);
            }

        }

    }
}
