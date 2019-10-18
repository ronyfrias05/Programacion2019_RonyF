using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show("El numero no puede estar vacio");
                return;
            }

            var numero = Convert.ToInt16(txtNumero.Text);

            if (numero > 0) 
            {
                MessageBox.Show("EL numero es positvo");
            }
            else
            {
                MessageBox.Show("EL numero es negativo");
            }

            if (numero %2== 0)
            {
                MessageBox.Show("EL numero es par");
            }
            else
            {
                MessageBox.Show("EL numero es impar");
            }

            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            var barraR = Convert.ToInt16(barR.Value);
            var barraG = Convert.ToInt16(barG.Value);
            var barraB = Convert.ToInt16(barB.Value);

            this.BackColor = Color.FromArgb(barraR, barraG, barraB);

            progressBar1.Value = barraR;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var colorR = Convert.ToInt16(numR.Value);
            var colorG = Convert.ToInt16(numG.Value);
            var colorB = Convert.ToInt16(numB.Value);

            this.BackColor = Color.FromArgb(colorR, colorG, colorB);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void barG_Scroll(object sender, EventArgs e)
        {
            var barraR = Convert.ToInt16(barR.Value);
            var barraG = Convert.ToInt16(barG.Value);
            var barraB = Convert.ToInt16(barB.Value);

            this.BackColor = Color.FromArgb(barraR, barraG, barraB);

            progressBar2.Value = barraG;

        }

        private void barB_Scroll(object sender, EventArgs e)
        {
            var barraR = Convert.ToInt16(barR.Value);
            var barraG = Convert.ToInt16(barG.Value);
            var barraB = Convert.ToInt16(barB.Value);

            this.BackColor = Color.FromArgb(barraR, barraG, barraB);

            progressBar3.Value = barraB;

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
