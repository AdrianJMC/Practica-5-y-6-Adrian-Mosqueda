using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void PonerCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonObtener_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el costo del artículo desde PonerCantidad
                decimal costo = decimal.Parse(PonerCantidad.Text);

                // Obtener la cantidad pagada desde Pago
                decimal cantidadPagada = decimal.Parse(Pago.Text);

                // Calcular el cambio
                decimal cambio = cantidadPagada - costo;

                decimal[] denominaciones = { 100m, 50m, 20m, 10m, 5m, 1m, 0.50m, 0.20m, 0.01m };
                string resultado = $"Cambio a devolver: {cambio:C2}\n\n";

                // Llamar al método recursivo para calcular el cambio
                CalculadorCambio.CalcularCambio(cambio, denominaciones, 0, ref resultado);

                // Mostrar el resultado en el label Resultado
                Resultado.Text = resultado;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Resultado_Click(object sender, EventArgs e)
        {

        }

        private void PagarCon_Click(object sender, EventArgs e)
        {

        }

        private void Pago_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
