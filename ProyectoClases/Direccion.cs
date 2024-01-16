using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }
        //Creamos un constructor vacio
        public Direccion()
        {
            Debug.WriteLine("Constructor DIRECCION sin parámetros");
        }

        public Direccion(string calle, string ciudad)
        {   
            //Aqui iniciamos los parametros que nos ha indicado el programador
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Constructor DIRECCION 2 parámetros");
        }
        public Direccion (string calle,string ciudad, int cp)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = cp;
            Debug.WriteLine("Constructor DIRECCION 3 parámetros");
        }
        
    }
}
