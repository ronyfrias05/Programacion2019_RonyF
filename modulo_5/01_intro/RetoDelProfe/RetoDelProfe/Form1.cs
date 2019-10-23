using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetoDelProfe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) 
            {
                MessageBox.Show("Escriba el polindromo :v");
                return;
            }
            
            var cajita = textBox1.Text;

            //MessageBox.Show("Es un pólindromo");

           string cadenasinespacios = this.textBox1.Text.Replace(" ", "");
            string cadenainversa = null;
                for (int i = cadenasinespacios.Length - 1 ; i >= 0; i--)
            {
            cadenainversa += cadenasinespacios.Substring(i,1);
            }
            if (cadenasinespacios == cadenainversa)
            {
            this.textBox2.Text = "Palíndromo";
            }
            else
            {
            this.textBox2.Text = "No es palíndromo";
            }
            }
           
            
        }
    }

