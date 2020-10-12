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
    public partial class RegMedicos : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-EQIKN8E\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True");
        public RegMedicos()
        {
            InitializeComponent();
        }

        private void RegMedicos_Load(object sender, EventArgs e)
        {
            string query2 = "select*from medicos";

            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form menu = new Menu();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO medicos (Nombre, Apellido, Exequatur, Especialidad) VALUES (@nombre,@apellido,@exequatur,@especialidad)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@apellido", txtApellido.Text);
            comando.Parameters.AddWithValue("@exequatur", txtExequatur.Text);
            comando.Parameters.AddWithValue("@especialidad", txtEspecialidad.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro de médico añadido exitosamente.");

            string query2 = "select*from medicos";

            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtExequatur.Text = string.Empty;
            txtEspecialidad.Text = string.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE medicos SET Nombre = @nombre, Apellido = @apellido, Exequatur = @exequatur, Especialidad= @especialidad Where Id = @id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@apellido", txtApellido.Text);
            comando.Parameters.AddWithValue("@exequatur", txtExequatur.Text);
            comando.Parameters.AddWithValue("@especialidad", txtEspecialidad.Text);
            comando.Parameters.AddWithValue("@id", txtId.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Los datos han sido actualizados.");
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtExequatur.Text = string.Empty;
            txtEspecialidad.Text = string.Empty;
            txtId.Text = string.Empty;

            string query2 = "select*from medicos";

            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "Delete from medicos where Id= @id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", txtId.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("El registro ha sido eliminado.");
            txtId.Text = string.Empty;

            string query2 = "select*from medicos";

            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form regpaciente = new RegPacientes();
            regpaciente.Show();
        }

        private void habitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form registros = new RegHabitaciones();
            registros.Show();
        }
    }
}
