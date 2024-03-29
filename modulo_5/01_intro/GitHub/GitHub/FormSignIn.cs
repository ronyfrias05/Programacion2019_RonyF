﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cerramos el FormSignIn
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lamar al formulario FormConfigure
            var formularioFormConfigure = new FormConfigure();

            // Mostrar el formulario
            formularioFormConfigure.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/password_reset");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/login");
        }

        private void btnSignIn_TextChanged(object sender, EventArgs e)
        {
            //var longitudUsername = txtUsername.Text.Length;
            //var longitudPassword = txtPassword.Text.Length;

            //if (longitudUsername > 0 || longitudPassword > 0) {
                //btnSignIn.Enabled = true;
            //}
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            var longitudUsername = txtUsername.Text.Length;
            var longitudPassword = txtPassword.Text.Length;

            if (longitudUsername > 0 && longitudPassword > 0)
            {
                btnSignIn.Enabled = true;
            }
            else
            {
                btnSignIn.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            var longitudUsername = txtUsername.Text.Length;
            var longitudPassword = txtPassword.Text.Length;

            if (longitudUsername > 0 && longitudPassword > 0)
            {
                btnSignIn.Enabled = true;
            }
            else
            {
                btnSignIn.Enabled = false;
            }
        }
    }
}
