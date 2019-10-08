using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Acceder al texto del objeto txtNombre
            var nombre = txtNombre.Text;
            // Convertir el texto a numero
            var edad = Convert.ToInt32(txtEdad.Text); 

            // Verificar si es mayor o menor de edad
            if (edad >= 18) 
            {
                // Mayor
                MessageBox.Show("Eres mayor");
            }
            else
            {
                // Menor
                MessageBox.Show("Eres menor");
            };

            MessageBox.Show(nombre);
            MessageBox.Show(edad.ToString());
            MessageBox.Show(nombre + " " + edad);
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
