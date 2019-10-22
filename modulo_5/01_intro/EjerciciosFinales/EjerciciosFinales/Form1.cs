using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosFinales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // La hipotenusa #1
            if(string.IsNullOrEmpty(valor1.Text) || string.IsNullOrEmpty(valor2.Text))
            {
                MessageBox.Show("Complete las correspondientes casillas, para ver el resultado");
                return;
            }

            var cateto1 = Convert.ToInt16(valor1.Text);
            var cateto2 = Convert.ToInt16(valor2.Text);

            var hipotenusa = Math.Sqrt(cateto1 * cateto1 + cateto2 * cateto2);

            MessageBox.Show("La hipotenusa es" + " " + hipotenusa);

            valor1.Text = "";
            valor2.Text = "";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            // La Notas #2
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            // La distancias #3
        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            // La edad #4
        }

        private void btnSemana_Click(object sender, EventArgs e)
        {
            // La semana #5
        }

        private void btnAno_Click(object sender, EventArgs e)
        {
            // El mes #6
        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            // Numeros pares del 1 al 100 #7
        }
    }
}
