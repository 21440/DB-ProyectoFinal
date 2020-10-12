namespace ProyectoB2
{
    partial class ConsultCitaM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultCitaM));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúDeConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaMédicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaCitasMédicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consiultaIngresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaAltasMédicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúDeConsultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúDeConsultasToolStripMenuItem
            // 
            this.menúDeConsultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaPacienteToolStripMenuItem,
            this.consultaMédicosToolStripMenuItem,
            this.consultaHabitacionesToolStripMenuItem,
            this.consultaCitasMédicasToolStripMenuItem,
            this.consiultaIngresosToolStripMenuItem,
            this.consultaAltasMédicaToolStripMenuItem});
            this.menúDeConsultasToolStripMenuItem.Name = "menúDeConsultasToolStripMenuItem";
            this.menúDeConsultasToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.menúDeConsultasToolStripMenuItem.Text = "Menú de Consultas";
            // 
            // consultaPacienteToolStripMenuItem
            // 
            this.consultaPacienteToolStripMenuItem.Name = "consultaPacienteToolStripMenuItem";
            this.consultaPacienteToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.consultaPacienteToolStripMenuItem.Text = "Consulta Pacientes";
            this.consultaPacienteToolStripMenuItem.Click += new System.EventHandler(this.consultaPacienteToolStripMenuItem_Click);
            // 
            // consultaMédicosToolStripMenuItem
            // 
            this.consultaMédicosToolStripMenuItem.Name = "consultaMédicosToolStripMenuItem";
            this.consultaMédicosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.consultaMédicosToolStripMenuItem.Text = "Consulta Médicos";
            this.consultaMédicosToolStripMenuItem.Click += new System.EventHandler(this.consultaMédicosToolStripMenuItem_Click);
            // 
            // consultaHabitacionesToolStripMenuItem
            // 
            this.consultaHabitacionesToolStripMenuItem.Name = "consultaHabitacionesToolStripMenuItem";
            this.consultaHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.consultaHabitacionesToolStripMenuItem.Text = "Consulta Habitaciones";
            this.consultaHabitacionesToolStripMenuItem.Click += new System.EventHandler(this.consultaHabitacionesToolStripMenuItem_Click);
            // 
            // consultaCitasMédicasToolStripMenuItem
            // 
            this.consultaCitasMédicasToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.consultaCitasMédicasToolStripMenuItem.Checked = true;
            this.consultaCitasMédicasToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.consultaCitasMédicasToolStripMenuItem.Name = "consultaCitasMédicasToolStripMenuItem";
            this.consultaCitasMédicasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.consultaCitasMédicasToolStripMenuItem.Text = "Consulta Citas Médicas";
            // 
            // consiultaIngresosToolStripMenuItem
            // 
            this.consiultaIngresosToolStripMenuItem.Name = "consiultaIngresosToolStripMenuItem";
            this.consiultaIngresosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.consiultaIngresosToolStripMenuItem.Text = "Consulta Ingresos";
            this.consiultaIngresosToolStripMenuItem.Click += new System.EventHandler(this.consiultaIngresosToolStripMenuItem_Click);
            // 
            // consultaAltasMédicaToolStripMenuItem
            // 
            this.consultaAltasMédicaToolStripMenuItem.Name = "consultaAltasMédicaToolStripMenuItem";
            this.consultaAltasMédicaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.consultaAltasMédicaToolStripMenuItem.Text = "Consulta Altas Médicas";
            this.consultaAltasMédicaToolStripMenuItem.Click += new System.EventHandler(this.consultaAltasMédicaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONSULTA DE CITAS MÉDICAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consultar y filtrar por:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fecha",
            "Doctor",
            "Paciente"});
            this.comboBox1.Location = new System.Drawing.Point(185, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(312, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(474, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 200);
            this.dataGridView1.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(669, 428);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(119, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Volver al menú principal";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(474, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 9;
            this.button2.Text = "Reporte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(312, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ConsultCitaM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConsultCitaM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control Médico";
            this.Load += new System.EventHandler(this.ConsultCitaM_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúDeConsultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaMédicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaCitasMédicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consiultaIngresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaAltasMédicaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}