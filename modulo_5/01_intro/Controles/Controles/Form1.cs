﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var seleccionar = comboBox1.SelectedItem;

            if (seleccionar == null)
            {
                MessageBox.Show("Debe seleccionar un elemnto de la lista");
                return;
            }

            // Eleminar
            comboBox1.Items.Remove(seleccionar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var texto = textBox1.Text;

            if (string.IsNullOrEmpty(texto)) 
            {
                MessageBox.Show("Debe escribir un texto");
                return;
            }

            // Agregar
            comboBox1.Items.Add(texto);

            textBox1.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // Mostrar el colorDialog
           // colorDialog1.ShowDialog();

            if (colorDialog1.ShowDialog() == DialogResult.OK) 
            {
                tabPage3.BackColor = colorDialog1.Color;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var texto = textBox3.Text;

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Debe escribir un texto");
                return;
            }

            listBox1.Items.Add(texto);

            textBox3.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var seleccionar = listBox1.SelectedItem;

            if (seleccionar == null)
            {
                MessageBox.Show("Debe seleccionar un elemnto de la lista");
                return;
            }

            // Eleminar
            listBox1.Items.Remove(seleccionar);
        }
    }
}
