namespace Promedio_de_ventas__ADOC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Boton1_Click(object sender, EventArgs e)
        {
            //Validación de entrada de datos
            if (txt1.Text == "")
            {
                MessageBox.Show("Debe ingresar el valor de la primer venta", "Error");
                txt1.Focus();
                return;
            }
            double a;
            try
            {
                a = Convert.ToDouble(txt1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numérico", "Error");
                txt1.Text = "";
                txt1.Focus();
                return;
            }
            if (a <= 0)
            {
                MessageBox.Show("Debe ingresar un valor numérico positivo", "Error");
                txt1.Text = "";
                txt1.Focus();
                return;
            }

            if (txt2.Text == "")
            {
                MessageBox.Show("Debe ingresar el valor de la segunda venta", "Error");
                txt2.Focus();
                return;
            }

            double b;
            try
            {
                b = Convert.ToDouble(txt2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numérico", "Error");
                txt2.Text = "";
                txt2.Focus();
                return;
            }
            if (b <= 0)
            {
                MessageBox.Show("Debe ingresar un valor numérico positivo", "Error");
                txt2.Text = "";
                txt2.Focus();
                return;
            }
            if (txt3.Text == "")
            {
                MessageBox.Show("Debe ingresar el valor de la tercer venta", "Error");
                txt3.Focus();
                return;
            }
            double c;
            try
            {
                c = Convert.ToDouble(txt3.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numérico", "Error");
                txt3.Text = "";
                txt3.Focus();
                return;
            }
            if (c <= 0)
            {
                MessageBox.Show("Debe ingresar un valor numérico positivo", "Error");
                txt3.Text = "";
                txt3.Focus();
                return;
            }
            //Procedimiento
            double prom;
            PromedioVentas(a, b, c, out prom);
            //Resultados
            result.Text = "$" + Math.Round(prom, 2).ToString();
            // Condicion del promedio
            if (prom >= 500)
            {
                MessageBox.Show("Se ha ganado un regalito", "Resultado");
            }
            else
            {
                MessageBox.Show("Lo esperamos pronto", "Resultado");
            }

        }

        private void PromedioVentas(double a, double b, double c, out double prom)
        {
            prom = (a + b + c) / 3;
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            result.Text = "";
            txt1.Focus();
        }
    }
}
