using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RegistroLoQueSea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void conexionBaseDatos()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=github;";

            // Prepara la conexión
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            // Abre la base de datos
            databaseConnection.Open();
        }

        private void SaveUser(string nombre, string correo, string nombreUsuario, string contrasena, string bio)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=github;";
            var query = string.Format("INSERT INTO usuario (nombre, correo, username, password, bio) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\")", nombre, correo, nombreUsuario, contrasena, bio);
            // Que puede ser traducido con un valor a:
            // INSERT INTO user(`id`, `first_name`, `last_name`, `address`) VALUES (NULL, 'Bruce', 'Wayne', 'Wayne Manor')

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Usuario insertado satisfactoriamente");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnRegistro.BackColor = Color.Turquoise;
        }

        private void btnRegistro_MouseLeave(object sender, EventArgs e)
        {
            btnRegistro.BackColor = Color.White;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Gracias por registrarte!");

            var nombre = txtNombre.Text;
            var correo = txtCorreo.Text;
            var nombreUsuario = txtNombreUsuario.Text;
            var contrasena = txtContrasena.Text;
            var bio = txtBio.Text;

            // Validar los datos

            // Validar para nombre
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre no puede estar vacio.");
                txtNombre.Focus();
                return;
            }

            // Validar para correo
            if (string.IsNullOrEmpty(correo))
            {
                MessageBox.Show("El correo electronico no puede estar vacio.");
                txtCorreo.Focus();
                return;
            }

            // Validar para nombre de usaurio
            if (string.IsNullOrEmpty(nombreUsuario))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacio.");
                txtNombreUsuario.Focus();
                return;
            }

            // Validar para contraseña
            if (string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("La contraseña no puede estar vacia.");
                txtContrasena.Focus();
                return;
            }

            // prepar el query
            // var query = @"INSERT INTO usuario (nombre, correo, username, password, bio) VALUE (\"dfa\", \"\", \"\", \"\", \"\")";

            // Concatenar el gmail.com
            correo += "gmail.com";

            SaveUser(nombre, correo, nombreUsuario, contrasena, bio);

            // Exito
            MessageBox.Show("Usuario registrado");

            // Vaciar el formulario cuando se registre el usuario
            txtNombre.Text = "";
            txtNombreUsuario.Text = "";
            txtBio.Text = "";
            txtContrasena.Text = "";
            txtCorreo.Text = "";

           }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
