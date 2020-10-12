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
    public partial class RegPacientes : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-EQIKN8E\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True");
        public string asegurado { get; set; }
        public RegPacientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO pacientes (Nombres, Apellidos, Telefono, Cedula, Asegurado) VALUES (@nombres,@apellidos,@telefono,@cedula,@asegurado)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombres", txtNombres.Text);
            comando.Parameters.AddWithValue("@apellidos", txtApellidos.Text);
            comando.Parameters.AddWithValue("@telefono", textTelefono.Text);
            comando.Parameters.AddWithValue("@cedula", txtCedula.Text);
            comando.Parameters.AddWithValue("@asegurado", asegurado);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro de paciente añadido exitosamente.");

            string query2 = "select*from pacientes";

            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            textTelefono.Text = string.Empty;
            txtCedula.Text = string.Empty;
            chAsegurado.Checked = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form menu = new Menu();
            menu.Show();
        }

        private void médicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form registro = new RegMedicos();
            registro.Show();
        }

        private void habitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form registro = new RegHabitaciones();
            registro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE pacientes SET Nombres = @nombres, Apellidos = @apellidos, Telefono = @telefono, Cedula = @cedula, Asegurado= @asegurado Where Id = @id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombres", txtNombres.Text);
            comando.Parameters.AddWithValue("@apellidos", txtApellidos.Text);
            comando.Parameters.AddWithValue("@telefono", textTelefono.Text);
            comando.Parameters.AddWithValue("@cedula", txtCedula.Text);
            comando.Parameters.AddWithValue("@asegurado", asegurado);
            comando.Parameters.AddWithValue("@id", txtId.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Los datos han sido actualizados.");
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            textTelefono.Text = string.Empty;
            txtCedula.Text = string.Empty;
            chAsegurado.Checked = false;
            txtId.Text = string.Empty;

            string query2 = "select*from pacientes";

            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        private void chAsegurado_CheckedChanged(object sender, EventArgs e)
        {
            if (chAsegurado.Checked == true)
            {
                asegurado = "Sí";
            }
            else if (chAsegurado.Checked == false)
            {
                asegurado = "No";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "Delete from pacientes where Id= @id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", txtId.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("El registro ha sido eliminado.");
            txtId.Text = string.Empty;

            string query2 = "select*from pacientes";

            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        private void RegPacientes_Load(object sender, EventArgs e)
        {
            string query2 = "select*from pacientes";

            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        private void textTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
