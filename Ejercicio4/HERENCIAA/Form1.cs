using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERENCIAA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            if (txtHerencia.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en la Herencia", "Error");
                txtHerencia.Focus();
                return;
            }

            double x;
            try
            {
                x = Convert.ToDouble(txtHerencia.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un valor numérico", "Error");
                txtHerencia.Clear();
                txtHerencia.Focus();
                return;
            }

            
            double j, l, r, abog;
            CalcularDistribucion(x, out j, out l, out r, out abog);

            
            txtJuan.Text = Math.Round(j,2).ToString();
            txtLuis.Text = Math.Round(l, 2).ToString();
            txtRosa.Text = Math.Round(r, 2).ToString();
            txtAbogado.Text = Math.Round(abog, 2).ToString();
        }

        
        private void CalcularDistribucion(double x, out double j, out double l, out double r, out double abog)
        {
            j = x / 3;           
            l = (4 * x) / 9;   
            r = (2 * x) / 9;

            double pagoJuan, pagoLuis, pagoRosa;
            double tercera = x / 3;
            
            //Para Juan
            if (j < tercera)
            {
                pagoJuan = j * 0.03; // Cobra 3%
            }
            else
            {
                pagoJuan = j * 0.05; // Cobra 5%
            }

            // Para Luis
            if (l < tercera)
            {
                pagoLuis = l * 0.03;
            }
            else
            {
                pagoLuis = l * 0.05;
            }

            // Para Rosa
            if (r < tercera)
            {
                pagoRosa = r * 0.03;
            }
            else
            {
                pagoRosa = r * 0.05;
            }

            // Sumamos los tres pagos para el total del abogado
            abog = pagoJuan + pagoLuis + pagoRosa;
        }


        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtHerencia.Text = "";
            txtJuan.Text = "";
            txtLuis.Text = "";
            txtRosa.Text = "";
            txtAbogado.Text = "";
            txtHerencia.Focus();
        }
    }
}

