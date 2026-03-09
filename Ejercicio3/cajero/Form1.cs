using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajero
{
    public partial class Cajero : Form
    {
        // Variables globales para el estado del cajero
        bool retiroRealizado = false;
        string ultimoRecibo = "";

        public Cajero()
        {
            InitializeComponent();
            // Esto asegura que al abrirse, el diseño esté limpio (sin los x7 o 111)
            this.Load += (s, e) => btnLimpiar_Click(null, null);
            this.DoubleBuffered = true;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            // 1. Validaciones de entrada
            if (!int.TryParse(txtMonto.Text, out int monto))
            {
                MessageBox.Show("Por favor, ingrese una cantidad entera válida (solo números).", "Cajero Automático", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (monto <= 0)
            {
                MessageBox.Show("AVISO: La cantidad a retirar debe ser mayor a cero.", "Monto Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (monto > 10000)
            {
                MessageBox.Show("LÍMITE EXCEDIDO: El cajero solo permite retiros hasta $10,000 por transacción.", "Seguridad Bancaria", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // 2. Lógica de Billetes (Desglose mínimo)
            int m = monto;
            int b100 = m / 100; m %= 100;
            int b20 = m / 20; m %= 20;
            int b10 = m / 10; m %= 10;
            int b5 = m / 5; m %= 5;
            int b1 = m;

            // 3. Mostrar resultados en pantalla
            lbl100.Text = "x" + b100;
            lbl20.Text = "x" + b20;
            lbl10.Text = "x" + b10;
            lbl5.Text = "x" + b5;
            lbl1.Text = "x" + b1;
            lblTotalBilletes.Text = (b100 + b20 + b10 + b5 + b1).ToString();

            // 4. Preparar datos para el recibo
            ultimoRecibo = $"--- COMPROBANTE DE RETIRO ---\n\n" +
                           $"TOTAL RETIRADO: ${monto}.00\n" +
                           $"-----------------------------\n" +
                           $"Billetes de $100: {b100}\n" +
                           $"Billetes de $20:  {b20}\n" +
                           $"Billetes de $10:  {b10}\n" +
                           $"Billetes de $5:   {b5}\n" +
                           $"Billetes de $1:   {b1}\n" +
                           $"-----------------------------\n" +
                           $"FECHA: {DateTime.Now.ToShortDateString()}\n" +
                           $"HORA:  {DateTime.Now.ToShortTimeString()}";

            retiroRealizado = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpia el input y los resultados
            txtMonto.Clear();
            lbl100.Text = "x0";
            lbl20.Text = "x0";
            lbl10.Text = "x0";
            lbl5.Text = "x0";
            lbl1.Text = "x0";
            lblTotalBilletes.Text = "0";
            retiroRealizado = false;

            // Elimina cualquier ventana de Recibo o Ayuda que esté abierta en el panel
            LimpiarPopUps();
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            if (!retiroRealizado)
            {
                MessageBox.Show("Realice un retiro para imprimir el recibo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MostrarPopUp("RECIBO ELECTRÓNICO", ultimoRecibo);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string tutorial = "GUÍA DE USO:\n\n" +
                              "1. Use el teclado para ingresar el monto.\n" +
                              "2. Presione 'RETIRAR' para procesar.\n" +
                              "3. Presione 'LIMPIAR' para borrar datos.\n" +
                              "4. El recibo solo está disponible tras un retiro.";
            MostrarPopUp("SOPORTE TÉCNICO", tutorial);
        }

        private void MostrarPopUp(string titulo, string mensaje)
        {
            LimpiarPopUps();

            Panel pnl = new Panel();
            pnl.Name = "pnlMensaje";
            pnl.Size = new Size(panelPantalla.Width - 20, panelPantalla.Height - 20);
            pnl.Location = new Point(10, 10);
            pnl.BackColor = Color.FromArgb(20, 30, 25);
            pnl.BorderStyle = BorderStyle.FixedSingle;

            Label lbl = new Label();
            lbl.Text = titulo + "\n\n" + mensaje + "\n\n[Clic para cerrar]";
            lbl.ForeColor = Color.LimeGreen;
            lbl.Font = new Font("Consolas", 9, FontStyle.Bold);
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Cursor = Cursors.Hand;

            // Al hacer clic en el texto, se cierra el PopUp
            lbl.Click += (s, ev) => { panelPantalla.Controls.Remove(pnl); };

            pnl.Controls.Add(lbl);
            panelPantalla.Controls.Add(pnl);
            pnl.BringToFront();
        }

        private void LimpiarPopUps()
        {
            Control mensaje = panelPantalla.Controls["pnlMensaje"];
            if (mensaje != null)
            {
                panelPantalla.Controls.Remove(mensaje);
            }
        }
    }
}