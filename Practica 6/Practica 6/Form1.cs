using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void LabelNumeroDiscos_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxNumeroDiscos_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonResolver_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroDeDiscos = int.Parse(TextBoxNumeroDiscos.Text);
                string resultado = "";

                TorresDeHanoi.Resolver(numeroDeDiscos, 'A', 'C', 'B', ref resultado);

                TextBoxResultado.Text = resultado;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido de discos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InstruccionResultado_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
