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
    public partial class Form19Temperaturas : Form
    {
        List<ListBox> lista;
        List<int> temperaturas;
        public Form19Temperaturas()
        {
            InitializeComponent();
            this.lista = new List<ListBox>();
            this.temperaturas = new List<int>();
            foreach (ListBox meses in this.listMeses.Controls)
            {
                lista.Add(meses);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.listMeses.Items.Clear();
            this.temperaturas.Clear();
            Random random = new Random();
            DateTime fecha = DateTime.Parse("01/01/2024");

            for (int i = 0; i <= 12; i++)
            {
                int temp = random.Next(-20, 45);
                this.temperaturas.Add(temp);
                string nombreMes = fecha.ToString("MMMM");
                fecha = fecha.AddMonths(1);
                this.listMeses.Items.Add(nombreMes + ":" + temp);
            }


        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int maxima = 0;
            int minima = 0;
            int media = 0;
            int suma = 0;

            foreach (int temp in this.temperaturas)
            {
                suma += temp;
                maxima = Math.Max(maxima, temp);
                minima = Math.Min(minima, temp);

            }
            media = suma / this.temperaturas.Count;
            this.txtMax.Text = maxima.ToString();
            this.txtMin.Text = minima.ToString();
            this.txtMedia.Text = media.ToString();
        }

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
