using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProyectoClases;

namespace Fundamentos
{
    public partial class Form20TestingClases : Form
    {
        public Form20TestingClases()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Andres";
            persona.Apellidos = "Leon";
            persona.Edad = 25;
            persona.Nacionalidad = Paises.Alemania;
            persona.Genero = TipoGenero.Femenino; // (TipoGenero)99; <- para comprobar si hay errores entre parentesis el tal y el numero de posicion correcto o incorrecto
            persona.MetodoParametrosOpcionales(77);
            persona.MetodoParametrosOpcionales(88, 99);
            persona.MetodoParametrosOpcionales(1, 2, 3);
            //SOLAMENTE QUEREMOS ENVIAR EL PARAMETRO 1 Y 3
            persona.MetodoParametrosOpcionales(1, numero3: 88);
            persona.GetNombreCompleto();

            persona.Domicilio = new Direccion("Calle Tajamar, 12", "Madrid");
            persona.DomicilioVacaciones = new Direccion("Calle Knekrer", "Barcelona", 12345);
            this.lstDatosClases.Items.Add("Calle: " + persona.Domicilio.Calle);

            persona[0] = "Mondongo";
            persona[1] = "Knekro";

            this.lstDatosClases.Items.Add("Descripcion[0]: " + persona[0]);
            this.lstDatosClases.Items.Add("Descripcion[1]: " + persona[1]);


            this.lstDatosClases.Items.Add(persona.GetNombreCompleto(true));
            this.lstDatosClases.Items.Add(persona.GetNombreCompleto());
            this.lstDatosClases.Items.Add("Edad: " + persona.Edad);
            this.lstDatosClases.Items.Add("Nacionalidad: " + persona.Nacionalidad);
            this.lstDatosClases.Items.Add("Genero: " + persona.Genero);

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.Nombre = "Kuajenkir";
            emp.Apellidos = "Laktcuento";
            this.lstDatosClases.Items.Add(emp.ToString());
            this.lstDatosClases.Items.Add("Salario Minimo Empleado: " + emp.GetSalarioMinimo());
            this.lstDatosClases.Items.Add("Vacaciones Empleado: " + emp.GetDiasVacaciones());
            Director dire = new Director();
            dire.Nombre = "Valentin";
            dire.Apellidos = "Gonzalez";
            this.lstDatosClases.Items.Add("Salario Minimo Director: " + dire.GetSalarioMinimo());
            this.lstDatosClases.Items.Add("Vacaciones Director: " + dire.GetDiasVacaciones());
            this.lstDatosClases.Items.Add(dire.ToString());
            

        }
    }
}
