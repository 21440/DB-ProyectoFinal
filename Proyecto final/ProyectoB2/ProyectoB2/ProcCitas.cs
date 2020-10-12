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
    public partial class ProcCitas : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-EQIKN8E\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True");
        public ProcCitas()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form procesos = new ProcIngresos();
            procesos.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form menu = new Menu();
            menu.Show();
        }

        private void altasMédicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form procesos = new ProcAltaMed();
            procesos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO citas (Paciente, Fecha, Hora, Doctor) VALUES (@paciente,@fecha,@hora,@doctor)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@paciente", txtPaciente.Text);
            comando.Parameters.AddWithValue("@fecha", dateTimePicker1.Value);
            comando.Parameters.AddWithValue("@hora", txtHora.Text + " " + comboBox1.SelectedItem);
            comando.Parameters.AddWithValue("@doctor", cbDoctores.SelectedItem);
            comando.ExecuteNonQuery();
            MessageBox.Show("Cita guardada exitosamente.");

            string query2 = "select*from citas";

            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
            txtPaciente.Text = string.Empty;
            txtHora.Text = string.Empty;
            cbDoctores.SelectedIndex = -1;
            dateTimePicker1.ResetText();
            comboBox1.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE citas SET Paciente = @paciente, Fecha = @fecha, Hora = @hora, Doctor= @doctor Where Id = @id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@paciente", txtPaciente.Text);
            comando.Parameters.AddWithValue("@fecha", dateTimePicker1.Value);
            comando.Parameters.AddWithValue("@hora", txtHora.Text + " " + comboBox1.SelectedItem);
            comando.Parameters.AddWithValue("@doctor", cbDoctores.SelectedItem);
            comando.Parameters.AddWithValue("@id", txtId.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("La cita ha sido actualizada.");
            txtPaciente.Text = string.Empty;
            txtHora.Text = string.Empty;
            dateTimePicker1.ResetText();
            txtId.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            cbDoctores.SelectedIndex = -1;

            string query2 = "select*from citas";

            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        private void ProcCitas_Load(object sender, EventArgs e)
        {
            string query2 = "select*from citas";

            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();

            conexion.Open();
            SqlCommand com = new SqlCommand("SELECT Nombre + ' ' + Apellido as Doctor from medicos", conexion);
            SqlDataReader registro = com.ExecuteReader();
            while (registro.Read())
            {
                cbDoctores.Items.Add(registro["Doctor"].ToString());
            }
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "Delete from citas where Id= @id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", txtId.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("La cita ha sido eliminada.");
            txtId.Text = string.Empty;

            string query2 = "select*from citas";

            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }
    }
}
