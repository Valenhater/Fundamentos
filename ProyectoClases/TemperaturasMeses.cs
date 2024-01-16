using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class TemperaturasMeses
    {
        public class Mes
        {
            public string Nombre { get; set; }
            public int TemperaturaMaxima { get; set; }
            public int TemperaturaMinima { get; set; }
            public int GetMediaMensual()
            {
                return
                    (this.TemperaturaMaxima + this.TemperaturaMinima) / 2;
            }
        }

    }
}
