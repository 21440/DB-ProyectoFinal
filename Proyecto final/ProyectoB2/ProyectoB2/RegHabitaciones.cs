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
    public partial class RegHabitaciones : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-EQIKN8E\\SQLEXPRESS; database=ProyectoFinal; integrated security=true");
        //SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-EQIKN8E\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True");
        
        public int doble = 5000;
        public int privada = 10000;
        public int suite = 15000;
        public RegHabitaciones()
        {
            InitializeComponent();
        }

        private void RegHabitaciones_Load(object sender, EventArgs e)
        {
            string query2 = "select*from habitaciones";

            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        private void médicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form registros = new RegMedicos();
            registros.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form menu = new Menu();
            menu.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form registros = new RegPacientes();
            registros.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO habitaciones (Numero, Tipo, Precio_Por_Dia) VALUES (@numero,@tipo,@precio)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@numero", txtNumero.Text);
            comando.Parameters.AddWithValue("@tipo", cbTipoHab.SelectedItem);
            comando.Parameters.AddWithValue("@precio", txtPrecioxDia.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("El registro ha sido añadido exitosamente.");

            string query2 = "select*from habitaciones";

            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
            txtNumero.Text = string.Empty;
            txtPrecioxDia.Text = string.Empty;
            cbTipoHab.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE habitaciones SET Numero = @numero, Tipo = @tipo, Precio_Por_Dia = @precio Where Id = @id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@numero", txtNumero.Text);
            comando.Parameters.AddWithValue("@tipo", cbTipoHab.SelectedItem);
            comando.Parameters.AddWithValue("@precio", txtPrecioxDia.Text);
            comando.Parameters.AddWithValue("@id", txtId.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Los datos han sido actualizados.");
            txtNumero.Text = string.Empty;
            txtPrecioxDia.Text = string.Empty;
            txtId.Text = string.Empty;
            cbTipoHab.SelectedIndex = -1;

            string query2 = "select*from habitaciones";

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
            string query = "Delete from habitaciones where Id= @id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", txtId.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("El registro ha sido eliminado.");
            txtId.Text = string.Empty;

            string query2 = "select*from habitaciones";

            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando2;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        private void cbTipoHab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoHab.SelectedIndex == 0)
            {
                txtPrecioxDia.Text = Convert.ToString(doble);
            }
            else if (cbTipoHab.SelectedIndex == 1)
            {
                txtPrecioxDia.Text = Convert.ToString(privada);
            }
            else if (cbTipoHab.SelectedIndex == 2)
            {
                txtPrecioxDia.Text = Convert.ToString(suite);
            }
        }
    }
}
