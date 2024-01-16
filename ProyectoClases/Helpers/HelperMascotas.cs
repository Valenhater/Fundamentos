using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; } 

        public HelperMascotas() 
        {
            this.Mascotas = new List<Mascota>();
        }

        public async Task WriteMascotasAsync(string path) //Si da error el writer o no lo reconoce recuerda en helperfiles o donde estes meterle static
        {
            //Al escribir debemos convertir la coleccion a string
            string data = this.ConvertirMascotasString();
            await HelperFiles.WriteFileAsync(path, data);
        }

        public async Task ReadMascotasAsync(string path)
        {
            //Leemos el fichero que nos han dado
            string data = await HelperFiles.ReadFileAsync(path);
            this.ConvertMascotasList(data);
        }
        //Nosotros en esta clase tenemos un conjunto de mascotas
        //GARFIELD,GATO#PLUTO,PERRO
        //necesitamos convertir un texto a coleccion de objetos
        private string ConvertirMascotasString()
        {
            string data = "";
            foreach ( Mascota mascota in this.Mascotas )
            {
                string temp = mascota.Nombre + "," + mascota.Raza;
                data += temp + "#";
            }
            data = data.Trim('#');
            return data;
        }

        //Tambien tendremos que leer de un fichero las mascotas
        //al leer debemos convertir el string en coleccion
        //GARFIELD,GATO#PLUTO,PERRO
        private void ConvertMascotasList(string data)
        {
            //Limpiar la coleccion de mascotas
            this.Mascotas.Clear();
            //Separamos los datos de cada mascota
            string[] datosMascotas = data.Split('#');
            foreach (string d in datosMascotas)
            {
                //Volvemos a separar por el separador de propiedades
                string[] propiedades = d.Split(",");
                //Instanciamos cada mascota
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }
        }

    }
}
