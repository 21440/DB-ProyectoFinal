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
    public partial class ConsultAltaM : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-EQIKN8E\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True");
        public ConsultAltaM()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form menu = new Menu();
            menu.Show();
        }

        private void consultaPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form consultas = new ConsultPacient();
            consultas.Show();
        }

        private void consultaMédicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form consultas = new ConsultMedicos();
            consultas.Show();
        }

        private void consultaHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form consultas = new ConsultHab();
            consultas.Show();
        }

        private void consultaCitasMédicasToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "Select*from altamed where Fecha_de_Salida='" + dateTimePicker1.Value + "'";
            if (comboBox1.SelectedIndex == 1)
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
                conexion.Close();
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                conexion.Close();
                conexion.Open();
                string query2 = "Select*from altamed where Paciente='" + textBox1.Text + "'";
                SqlCommand comando2 = new SqlCommand(query2, conexion);
                SqlDataAdapter adaptador2 = new SqlDataAdapter();
                adaptador2.SelectCommand = comando2;
                DataTable tabla = new DataTable();
                adaptador2.Fill(tabla);
                dataGridView1.DataSource = tabla;
                conexion.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Visible = false;
                dateTimePicker1.Visible = true;
            }
            else
            {
                textBox1.Visible = true;
                dateTimePicker1.Visible = false;
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
