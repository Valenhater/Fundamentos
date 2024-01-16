using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director: Empleado
    {
        public Director() 
        {
            Debug.WriteLine("Constructor DIRECTOR");
            this.SalarioMinimo = this.SalarioMinimo += 200;
        }

        public new int GetDiasVacaciones() //Con esto indicamos que sobreescribimos el valor de getdiasvacaciones en Empleado, si no tenemos virtual en empleado usamos new
        {   
            //Necesitamos leer primero la clase base para recuperar las vacaciones de un empleado
            int vacaciones = base.GetDiasVacaciones();
            Debug.WriteLine("GetVacaciones() Director");
            return vacaciones + 8;
        }
    }
}
