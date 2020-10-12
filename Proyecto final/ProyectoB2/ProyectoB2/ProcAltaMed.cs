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
    public partial class ProcAltaMed : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-EQIKN8E\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True");
        public ProcAltaMed()
        {
            InitializeComponent();
        }

        private void citasMédicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form procesos = new ProcCitas();
            procesos.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form menu = new Menu();
            menu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "SELECT Paciente FROM ingresos where id='" + txtId.Text + "'";
            SqlCommand consulta = new SqlCommand(query, conexion);
            SqlDataReader registro = consulta.ExecuteReader();
            if (registro.Read())
            {
                label9.Text = registro["Paciente"].ToString();
                label9.Visible = true;

            }
            conexion.Close();

            conexion.Open();
            string query2 = "SELECT Habitacion FROM ingresos where id='" + txtId.Text + "'";
            SqlCommand consulta2 = new SqlCommand(query2, conexion);
            SqlDataReader registro2 = consulta2.ExecuteReader();
            if (registro2.Read())
            {
                label10.Text = registro2["Habitacion"].ToString();
                label10.Visible = true;
            }
            conexion.Close();

            conexion.Open();
            string query3 = "SELECT Tipo FROM ingresos where id='" + txtId.Text + "'";
            SqlCommand consulta3 = new SqlCommand(query3, conexion);
            SqlDataReader registro3 = consulta3.ExecuteReader();
            if (registro3.Read())
            {
                label11.Text = registro3["Tipo"].ToString();
                label11.Visible = true;
            }
            conexion.Close();

            conexion.Open();
            string query4 = "SELECT Fecha_de_Ingreso FROM ingresos where id='" + txtId.Text + "'";
            SqlCommand consulta4 = new SqlCommand(query4, conexion);
            SqlDataReader registro4 = consulta4.ExecuteReader();
            if (registro4.Read())
            {
                dateTimePicker1.Value = DateTime.Parse(registro4["Fecha_de_Ingreso"].ToString());
            }
            conexion.Close();
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form procesos = new ProcIngresos();
            procesos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO altamed (Paciente, Habitacion, Tipo, Fecha_de_Ingreso, Fecha_de_Salida, Monto) VALUES (@paciente,@habitacion,@tipo,@fechaing,@fechasal,@monto)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@paciente", label9.Text);
            comando.Parameters.AddWithValue("@fechaing", dateTimePicker2.Value);
            comando.Parameters.AddWithValue("@habitacion", label10.Text);
            comando.Parameters.AddWithValue("@tipo", label11.Text);
            comando.Parameters.AddWithValue("@fechasal", dateTimePicker1.Value);
            comando.Parameters.AddWithValue("@monto", label12.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro de Alta Medica guardado correctamente.");

            string query2 = "select*from altamed";

            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
            label9.Visible = false;
            dateTimePicker2.ResetText();
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            dateTimePicker1.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE altamed SET Paciente = @paciente, Fecha_de_Ingreso = @fechaing, Habitacion = @habitacion, Tipo= @tipo, Fecha_de_Salida = @fechasal, Monto = @monto Where Id = @id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@paciente", label9.Text);
            comando.Parameters.AddWithValue("@fechaing", dateTimePicker2.Value);
            comando.Parameters.AddWithValue("@habitacion", label10.Text);
            comando.Parameters.AddWithValue("@tipo", label11.Text);
            comando.Parameters.AddWithValue("@id", txtId.Text);
            comando.Parameters.AddWithValue("@fechasal", dateTimePicker1.Value);
            comando.Parameters.AddWithValue("@monto", label12.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("El registro de alta medica ha sido actualizado.");
            label9.Visible = false;
            dateTimePicker2.ResetText();
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            dateTimePicker1.ResetText();

            string query2 = "select*from altamed";

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
            string query = "Delete from altamed where Id= @id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", txtId.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("El registro de alta medica ha sido eliminado.");
            txtId.Text = string.Empty;

            string query2 = "select*from altamed";

            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        private void ProcAltaMed_Load(object sender, EventArgs e)
        {
            string query2 = "select*from altamed";

            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Habitaciones hab = new Doble();
            DateTime fechainicio = dateTimePicker2.Value.Date;
            DateTime fechasalida = dateTimePicker1.Value.Date;
            TimeSpan tspan = fechainicio - fechasalida;


            if (label11.Text == "Doble")
            {
                hab = new Doble();
                hab.dias = tspan.Days;
                hab.Pago();
                label12.Text = "RD$" + hab.pago + ".00";
                label12.Visible = true;
            }
            else if (label11.Text == "Privada")
            {
                hab = new Privada();
                hab.dias = tspan.Days;
                hab.Pago();
                label12.Text = "RD$" + hab.pago + ".00";
                label12.Visible = true;
            }
            else if (label11.Text == "Suite")
            {
                hab = new Suite();
                hab.dias = tspan.Days;
                hab.Pago();
                label12.Text = "RD$" + hab.pago + ".00";
                label12.Visible = true;
            }

        }
    }
}
