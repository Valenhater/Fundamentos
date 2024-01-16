using System;
using System.Collections;
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
    public partial class Form15ArrayList : Form
    {
        public Form15ArrayList()
        {
            InitializeComponent();

            //El diseñador nos ayuda a crear metodos delegados
            //this.button1.Click += MetodoRelegado;

            //Declaramos una coleccion generica
            List<Button> botones = new List<Button>();
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            //Accedemos a las propiedades del objeto
            botones[1].BackColor = Color.Yellow;
            //Tenemos errores en compilacion 
            //botones.Add(this.textBox1);


            //Coleccion no tipada
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            //Añadimos un texbox a la coleccion
            coleccion.Add(this.textBox1);

            //Si intentamos acceder a las propiedades no podremos
            //Debemos realizar el casting para poder aplicar sus propiedades
            ((Button)coleccion[0]).Text = "Soy un boton";
            //Mediante la abstraccion podemos recorrer todos los elementos de una coleccion utilizando
            //una clase en comun
            //foreach (Button boton in coleccion)
            //{
            //    boton.BackColor = Color.Yellow;
            // }
            //Si tenemos objetos que no sean de la linea directa 
            //Debemos encontrar su familia en comun mediante abstraccion
            foreach (Control control in coleccion)
            {
                control.BackColor = Color.Yellow;
                //Dentro de la abstraccion podemos convertir 
                //a su clase base para aplicar sus propiedades o metodos
                //deseamos utilizar el metodo Paste() del control texbox
                //preguntamos por la clase del objeto
                if (control is TextBox)
                {
                    //Realizamos un casting para aplicar sobre el objeto
                    ((TextBox)control).Paste();
                  
                }
            }
        }

        private void MetodoRelegado(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
