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
    
    public partial class ProcIngresos : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-EQIKN8E\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True");
        public ProcIngresos()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form menu = new Menu();
            menu.Show();
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form procesos = new ProcCitas();
            procesos.Show();
        }

        private void altasMédicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form procesos = new ProcAltaMed();
            procesos.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "SELECT Tipo from habitaciones where Numero ='" + cbHab.SelectedItem + "'";
            SqlCommand consulta = new SqlCommand(query, conexion);
            SqlDataReader registro2 = consulta.ExecuteReader();
            if (registro2.Read())
            {
                txtTipo.Text = registro2["Tipo"].ToString();
            }
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO ingresos (Paciente, Habitacion, Tipo, Fecha_de_Ingreso) VALUES (@paciente,@habitacion,@tipo,@fechaing)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@paciente", txtPaciente.Text);
            comando.Parameters.AddWithValue("@fechaing", dateTimePicker1.Value);
            comando.Parameters.AddWithValue("@habitacion", cbHab.SelectedItem);
            comando.Parameters.AddWithValue("@tipo", txtTipo.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Ingreso guardado correctamente.");

            string query2 = "select*from ingresos";

            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
            txtPaciente.Text = string.Empty;
            dateTimePicker1.ResetText();
            cbHab.SelectedIndex = -1;
            txtTipo.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE ingresos SET Paciente = @paciente, Fecha_de_Ingreso = @fechaing, Habitacion = @habitacion, Tipo= @tipo Where Id = @id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@paciente", txtPaciente.Text);
            comando.Parameters.AddWithValue("@fechaing", dateTimePicker1.Value);
            comando.Parameters.AddWithValue("@habitacion", cbHab.SelectedItem);
            comando.Parameters.AddWithValue("@tipo", txtTipo.Text);
            comando.Parameters.AddWithValue("@id", txtId.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("El registro de ingreso ha sido actualizado.");
            txtId.Text = string.Empty;
            txtTipo.Text = string.Empty;
            dateTimePicker1.ResetText();
            txtPaciente.Text = string.Empty;
            cbHab.SelectedIndex = -1;

            string query2 = "select*from ingresos";

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
            string query = "Delete from ingresos where Id= @id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", txtId.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("El registro de ingreso ha sido eliminado.");
            txtId.Text = string.Empty;

            string query2 = "select*from ingresos";

            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        private void ProcIngresos_Load(object sender, EventArgs e)
        {
            string query2 = "select*from ingresos";

            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();

            conexion.Open();
            SqlCommand com = new SqlCommand("SELECT Numero from habitaciones", conexion);
            SqlDataReader registro = com.ExecuteReader();
            while (registro.Read())
            {
                cbHab.Items.Add(registro["Numero"].ToString());
            }
            conexion.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
