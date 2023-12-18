namespace Fundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //Solo escribimos aqui
            this.txtNombre.Location = new Point(78, 10);
            //Tenemos propiedades de tipos de datos primitivos
            this.txtNombre.Text = "Soy un texto";
            this.txtNombre.Width = 180;
            //Esto es una excepcion en la norma
            //tener una clase de estructura o final 
            //no se instancia, se utiliza.
            //por ejemplo, la clase color
            this.BackColor = Color.Aquamarine;

        }
    }
}