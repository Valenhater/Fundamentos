using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Helpers
{
    public class HelperFiles
    {
        //Necesitamos dos metodos: Leer y escribir
        //Cuando utilizamos async / await con metodos personalizados, se utiliza la clase task
        //Si es un void: Task
        //Si es un return: Task<Clase>

        public static async Task<string> ReadFileAsync(string path) 
        { 
            FileInfo file = new FileInfo(path);
            using (TextReader reader = file.OpenText())
            {
                string data = await reader.ReadToEndAsync();
                reader.Close();
                return data;
            }
        }

        public static async Task WriteFileAsync(string path, string data) //Al ser un voiud asincrono usamos async y Task en vez de void
        {
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(data);
                await writer.FlushAsync();
                writer.Close();
            }
        }
    }
}
