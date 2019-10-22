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
            if (string.IsNullOrEmpty(txtNota1.Text) || string.IsNullOrEmpty(txtNota2.Text) || string.IsNullOrEmpty(txtNota3.Text) || string.IsNullOrEmpty(txtNota4.Text))
            {
                MessageBox.Show("Complete las correspondientes casillas, para ver el resultado");
                return;
            }

            var nota1 = Convert.ToInt16(txtNota1.Text);
            var nota2 = Convert.ToInt16(txtNota2.Text);
            var nota3 = Convert.ToInt16(txtNota3.Text);
            var nota4 = Convert.ToInt16(txtNota4.Text);

            var promedio = nota1 + nota2 + nota3 + nota4;

            MessageBox.Show("El promedio es" + " " + promedio / 4);

            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNota4.Text = "";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            // La distancias #3
            if (string.IsNullOrEmpty(txtS.Text) || string.IsNullOrEmpty(txtT.Text))
            {
                MessageBox.Show("Complete las correspondientes casillas, para ver el resultado");
                return;
            }

            var segundos = Convert.ToInt32(txtS.Text);
            var tiempo = Convert.ToInt32(txtT.Text);

            MessageBox.Show("La distancia rrecorida a cualquier lugar es" + " " + segundos * tiempo + " " + "Kilometros");
        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            // La edad #4
            if (string.IsNullOrEmpty(txtAno.Text))
            {
                MessageBox.Show("Complete las correspondientes casillas, para ver el resultado");
                return;
            }

            var anio = Convert.ToInt16(txtAno.Text);
            var resta = 2019 - anio;

            MessageBox.Show("Tu edad es" + " " + resta);
        }

        private void btnSemana_Click(object sender, EventArgs e)
        {
            // La semana #5
            if (string.IsNullOrEmpty(txtDia.Text))
            {
                MessageBox.Show("Complete las correspondientes casillas, para ver el resultado");
                return;
            }

            var diaSemana = Convert.ToInt16(txtDia.Text);
            
            if (diaSemana < 0 || diaSemana >= 8) 
            {
                MessageBox.Show("No intentes lo que no se puede.");
                return;
            }


            if (diaSemana == 1) {
                MessageBox.Show("Ese dia es Domingo.");
            } else if (diaSemana == 2) {
                MessageBox.Show("Ese dia es Lune.");
            } else if (diaSemana == 3) {
                 MessageBox.Show("Ese dia es Marte.");
            } else if (diaSemana == 4) {
                MessageBox.Show("Ese dia es Miercole.");
            } else if (diaSemana == 5) {
                MessageBox.Show("Ese dia es Jueve.");
            } else if (diaSemana == 6) {
                MessageBox.Show("Ese dia es Vierne.");
            } else if (diaSemana == 7) {
                 MessageBox.Show("Ese dia es Sabado.");
            }

            txtDia.Text = "";
        }

        private void btnAno_Click(object sender, EventArgs e)
        {
            // El mes #6
            if (string.IsNullOrEmpty(txtMes.Text))
            {
                MessageBox.Show("Complete las correspondientes casillas, para ver el resultado");
                return;
            }

            var mesAnio = Convert.ToInt16(txtMes.Text);

            if (mesAnio < 0 || mesAnio >= 12)
            {
                MessageBox.Show("No intentes lo que no se puede.");
                return;
            }


            if (mesAnio == 1)
            {
                MessageBox.Show("Ese dia es Enero.");
            }
            else if (mesAnio == 2)
            {
                MessageBox.Show("Ese dia es Febrero.");
            }
            else if (mesAnio == 3)
            {
                MessageBox.Show("Ese dia es Marzo.");
            }
            else if (mesAnio == 4)
            {
                MessageBox.Show("Ese dia es Abril.");
            }
            else if (mesAnio == 5)
            {
                MessageBox.Show("Ese dia es Mayo.");
            }
            else if (mesAnio == 6)
            {
                MessageBox.Show("Ese dia es Junio.");
            }
            else if (mesAnio == 7)
            {
                MessageBox.Show("Ese dia es Julio.");
            }
            else if (mesAnio == 8)
            {
                MessageBox.Show("Ese dia es Agosto.");
            }
            else if (mesAnio == 9)
            {
                MessageBox.Show("Ese dia es Septiembre.");
            }
            else if (mesAnio == 10)
            {
                MessageBox.Show("Ese dia es Octubre.");
            }
            else if (mesAnio == 11)
            {
                MessageBox.Show("Ese dia es Noviembre.");
            }
            else if (mesAnio == 12)
            {
                MessageBox.Show("Ese dia es Diciembre.");
            }
            txtMes.Text = "";
        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            // Numeros pares del 1 al 100 #7
            for (var i = 0; i <= 100; i++) {
            if(i%2 == 0)
            numerosAlCien.Text += i.ToString() + ", ";
            }
           
                btnNumeros.Enabled = false;
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
