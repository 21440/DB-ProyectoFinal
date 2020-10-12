using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoB2
{
    public partial class RegistroUsuario : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-EQIKN8E\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True");
        public RegistroUsuario()
        {
            InitializeComponent();
        }
        public void registro()
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT Usuario FROM log_in WHERE Usuario='" + txtUsuario.Text + "'", conexion);
                SqlDataReader dreader = comando.ExecuteReader();

                if (dreader.Read())
                {
                    MessageBox.Show("Ya existe un usuario con ese nombre. Intente con otro.");

                }
                else
                {
                    conexion.Close();
                    string query = "INSERT INTO log_in (Nombre, Apellido, Sexo, Usuario, Contraseña) VALUES (@nombre,@apellido,@sexo,@usuario,@contraseña)";
                    conexion.Open();
                    SqlCommand insertar = new SqlCommand(query, conexion);
                    insertar.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    insertar.Parameters.AddWithValue("@apellido", txtApellido.Text);
                    insertar.Parameters.AddWithValue("@sexo", cbSexo.SelectedItem);
                    insertar.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    insertar.Parameters.AddWithValue("@contraseña", txtContraseña.Text);
                    insertar.ExecuteNonQuery();
                    MessageBox.Show("Se ha registrado exitosamente.");

                    txtNombre.Text = string.Empty;
                    txtApellido.Text = string.Empty;
                    txtUsuario.Text = string.Empty;
                    txtContraseña.Text = string.Empty;
                    cbSexo.SelectedIndex = -1;
                }

                conexion.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            registro();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new Login();
            login.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (txtContraseña.PasswordChar == '*')
                {
                    txtContraseña.PasswordChar = '\0';
                }
            }
            else
            {
                txtContraseña.PasswordChar = '*';
            }
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
