namespace ProyectoB2
{
    partial class ConsultHab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultHab));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúDeConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaMédicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaCiitasMédicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaIngresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaAltasMédicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONSULTA DE HABITACIONES";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúDeConsultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúDeConsultasToolStripMenuItem
            // 
            this.menúDeConsultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaPacientesToolStripMenuItem,
            this.consultaMédicosToolStripMenuItem,
            this.consultaHabitacionesToolStripMenuItem,
            this.consultaCiitasMédicasToolStripMenuItem,
            this.consultaIngresosToolStripMenuItem,
            this.consultaAltasMédicasToolStripMenuItem});
            this.menúDeConsultasToolStripMenuItem.Name = "menúDeConsultasToolStripMenuItem";
            this.menúDeConsultasToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.menúDeConsultasToolStripMenuItem.Text = "Menú de Consultas";
            // 
            // consultaPacientesToolStripMenuItem
            // 
            this.consultaPacientesToolStripMenuItem.Name = "consultaPacientesToolStripMenuItem";
            this.consultaPacientesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.consultaPacientesToolStripMenuItem.Text = "Consulta Pacientes";
            this.consultaPacientesToolStripMenuItem.Click += new System.EventHandler(this.consultaPacientesToolStripMenuItem_Click);
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
            this.consultaHabitacionesToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.consultaHabitacionesToolStripMenuItem.Checked = true;
            this.consultaHabitacionesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.consultaHabitacionesToolStripMenuItem.Name = "consultaHabitacionesToolStripMenuItem";
            this.consultaHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.consultaHabitacionesToolStripMenuItem.Text = "Consulta Habitaciones";
            // 
            // consultaCiitasMédicasToolStripMenuItem
            // 
            this.consultaCiitasMédicasToolStripMenuItem.Name = "consultaCiitasMédicasToolStripMenuItem";
            this.consultaCiitasMédicasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.consultaCiitasMédicasToolStripMenuItem.Text = "Consulta Citas Médicas";
            this.consultaCiitasMédicasToolStripMenuItem.Click += new System.EventHandler(this.consultaCiitasMédicasToolStripMenuItem_Click);
            // 
            // consultaIngresosToolStripMenuItem
            // 
            this.consultaIngresosToolStripMenuItem.Name = "consultaIngresosToolStripMenuItem";
            this.consultaIngresosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.consultaIngresosToolStripMenuItem.Text = "Consulta Ingresos";
            this.consultaIngresosToolStripMenuItem.Click += new System.EventHandler(this.consultaIngresosToolStripMenuItem_Click);
            // 
            // consultaAltasMédicasToolStripMenuItem
            // 
            this.consultaAltasMédicasToolStripMenuItem.Name = "consultaAltasMédicasToolStripMenuItem";
            this.consultaAltasMédicasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.consultaAltasMédicasToolStripMenuItem.Text = "Consulta Altas Médicas";
            this.consultaAltasMédicasToolStripMenuItem.Click += new System.EventHandler(this.consultaAltasMédicasToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consultar y filtrar por tipo:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Doble",
            "Privada",
            "Suite",
            "Numero"});
            this.comboBox1.Location = new System.Drawing.Point(213, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(361, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 219);
            this.dataGridView1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(496, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reporte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(669, 428);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(119, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Volver al menú principal";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(428, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ConsultHab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConsultHab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control Médico";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúDeConsultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaMédicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaCiitasMédicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaIngresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaAltasMédicasToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox textBox1;
    }
}