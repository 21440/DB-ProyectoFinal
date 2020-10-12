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
    public partial class ConsultHab : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-EQIKN8E\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True");
        public ConsultHab()
        {
            InitializeComponent();
        }

        private void consultaPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form consultas = new ConsultPacient();
            consultas.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form menu = new Menu();
            menu.Show();
        }

        private void consultaMédicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form consultas = new ConsultMedicos();
            consultas.Show();
        }

        private void consultaCiitasMédicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form consultas = new ConsultCitaM();
            consultas.Show();
        }

        private void consultaIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form consultas = new ConsultIngresos();
            consultas.Show();
        }

        private void consultaAltasMédicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form consultas = new ConsultAltaM();
            consultas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Select*from habitaciones where Tipo= 'Doble'";
            if (comboBox1.SelectedIndex == 0)
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
                conexion.Close();
            }
            else if (comboBox1.SelectedIndex == 1)
            {

                conexion.Open();
                string query2 = "Select*from habitaciones where Tipo= 'Privada'";
                SqlCommand comando2 = new SqlCommand(query2, conexion);
                SqlDataAdapter adaptador2 = new SqlDataAdapter();
                adaptador2.SelectCommand = comando2;
                DataTable tabla2 = new DataTable();
                adaptador2.Fill(tabla2);
                dataGridView1.DataSource = tabla2;
                conexion.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {

                conexion.Open();
                string query3 = "Select*from habitaciones where Tipo= 'Suite'";
                SqlCommand comando3 = new SqlCommand(query3, conexion);
                SqlDataAdapter adaptador3 = new SqlDataAdapter();
                adaptador3.SelectCommand = comando3;
                DataTable tabla3 = new DataTable();
                adaptador3.Fill(tabla3);
                dataGridView1.DataSource = tabla3;
                conexion.Close();
            }
            else if (comboBox1.SelectedIndex == 3)
            {

                conexion.Open();
                string query4 = "Select*from habitaciones where Numero= '" + textBox1.Text + "'";
                SqlCommand comando4 = new SqlCommand(query4, conexion);
                SqlDataAdapter adaptador4 = new SqlDataAdapter();
                adaptador4.SelectCommand = comando4;
                DataTable tabla4 = new DataTable();
                adaptador4.Fill(tabla4);
                dataGridView1.DataSource = tabla4;
                conexion.Close();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap obj = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(obj, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(obj, 250, 300);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 3)
            {

                textBox1.Visible = true;

            }
            else
            {
                textBox1.Visible = false;
            }
        }
    }
}
