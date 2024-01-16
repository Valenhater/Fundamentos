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
    public partial class Form16MetodosRelegados : Form
    {
        //Las colecciones suelen declararse a nivel de clase
        //por si necesitamos utilizarlas en multiples metodos
        List<Button> botones;
        int contador;

        public Form16MetodosRelegados()
        {
            InitializeComponent();
            //Queremos incluir todos los botones dentro de una coleccion
            //posteriormente recorrer dicha coleccion y delegar su evento click
            //Dentro de forms tenemos una propiedad llamada controls que contiene
            //todos los controles del formulario, dicha propiedad funciona por containers
            //es decir si tenemos un groupbox, debemos recorrer controls del
            //contenedor groupbox
            this.botones = new List<Button>();
            this.contador = 0;
            //Vamos a recorrer todos los controles del form
            foreach (Control control in this.Controls)
            {   
                //debemos preguntar si vienen botones
                
                if (control is Button)
                {
                    //Almacenamos nuestros botones
                    this.botones.Add((Button)control);
                }
                
            }
            //A continuacion, trabajamos con nuestra coleccion
            //recorremos todos los botones y los asociamos al evento
            foreach (Button boton in botones)
            {
                boton.Click += BotonPulsado;
            }

        }
        void BotonPulsado(object sender, EventArgs e)
        {
            this.contador += 1;
            this.txtContador.Text = "Contador: " + this.contador;
            //Cuando pulsemos un boton quiero cambiar su color
            //sender es el objeto que ha realizado la llamada
            Button boton = (Button)sender;
            boton.BackColor = Color.DarkKhaki;
        }
    }
}
