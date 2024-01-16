using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public enum Paises { España, Alemania, Italia, Inglaterra, Noruega }
    public enum TipoGenero { Masculino, Femenino }
    public class Persona
    {


        #region CONSTRUCTORES

        public Persona() 
        {
            Debug.WriteLine("Constructor VACIO persona");
        }
        //La clase persona solo tiene un unico constructor con parametros
        public Persona(string nombre, string apellidos)
        {
            Debug.WriteLine("Constructor 2 parámetros persona");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

        #endregion

        #region Propiedades

        //Propiedad indizada para almacenar descripciones 
        private string[] descripciones =
            new string[3];

        //Propiedad indizada para almacenar descripciones de una persona

        public string this[int index]
        {
            get
            {   
                //Devolvemos la descripcion de una posicion
                return descripciones[index];
            }
            set
            {   
                //Almacenamos en el indice del array la nueva descripcion
                this.descripciones[index] = value;
            }
        }

        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        //Campo propiedad para la edad
        private int _Edad;
        public int Edad
        {
            get {
                return _Edad; 
            }
            set {
               //Necesitamos comprobar el valor que se ha asignado a la propiedad edad            
               if (value <= 0) 
                {
                    //1) Error silencioso
                    //this._Edad = 0;
                    //2)Lanzar una excepcion
                    throw new Exception("La edad no puede ser negativa: "+value);

                }
                else
                {
                    this._Edad = value;
                }
            }
        }

        private TipoGenero _Genero;
        public TipoGenero Genero
        {
            get { 
                return this._Genero;
            }
            set
            {
                //Debemos comprobar los valores de la enumeracion
                if(value != TipoGenero.Masculino && 
                   value != TipoGenero.Femenino)
                {
                    throw new Exception("Valor de genero incorrecto");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }

        public Paises Nacionalidad { get; set; }
        #endregion

        #region METODOS

        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        //SOBRECARGA
        public string GetNombreCompleto(bool orden)
        {
            if (orden == true)
            {
                return this.Apellidos + " " + this.Nombre;
            }
            else
            {
                //Utilizamos el metodo anterior sin parametros
                return this.GetNombreCompleto();
            }
        }

        public void GetNombreCompleto(int num1, int num2)
        { }

        public int GetNombreCompleto (int num1) { return 0; }

        public string GetNombreCompleto(string a, string b)
        {
            return "otro mas";
        }

        public void MetodoParametrosOpcionales
            (int numero1, int numero2 = 444, int numero3 = 0)
        {

        }

        #endregion

    }
}
