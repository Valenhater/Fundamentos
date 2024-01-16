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
    public partial class Form17SumarBotones : Form
    {
        List<Button> botones;
        int suma;
        public Form17SumarBotones()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            this.suma = 0;

            foreach (Button boton in this.panel1.Controls)//Guardamos los botones del panel aqui
            {
                this.botones.Add(boton);
                boton.Click += SumarNumeros;
            }
        }

        private void btnIniciarApp_Click(object sender, EventArgs e)
        {
            this.suma = 0;
            this.txtSuma.Text = suma.ToString();
            Random random = new Random();

            foreach (Button boton in this.botones)
            {   
                //Randomizamos los numeros y los ponemos en el texto de los botones
                int aleatorio = random.Next(1, 50);
                boton.Text = aleatorio.ToString();
            }

            
            
        }

        private void SumarNumeros(object? sender, EventArgs e)
        {
            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);
            this.suma += numero;
            this.txtSuma.Text = this.suma.ToString();
        }
        
    }
}
