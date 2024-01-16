using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado: Persona
    {   
        protected int SalarioMinimo { get; set; }

        public override string ToString()
        {
            return this.GetNombreCompleto();
        }

        public int GetDiasVacaciones() //Añadir virtual si queremos usar override en otro clase
        {
            Debug.WriteLine("GetVAcaciones()  Empleado");
            return 22;
        }
        //Modificamos para leer el constructor con parametros de persona
        public Empleado()
        {
            Debug.WriteLine("Constructor VACIO Empleado");
            this.SalarioMinimo = 2000;
        }

        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }
        
        public Empleado (string nombre, string apellidos)
            :base(nombre, apellidos)
        {
            Debug.WriteLine("Constructor 2 parámetros Empleado");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
    }
}
