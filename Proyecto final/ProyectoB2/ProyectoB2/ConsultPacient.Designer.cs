namespace ProyectoB2
{
    partial class ConsultPacient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultPacient));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúDeConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaCitasMédicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaIngresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaAltasMédicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
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
            this.consulToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.consultaHabitacionesToolStripMenuItem,
            this.consultaCitasMédicasToolStripMenuItem,
            this.consultaIngresosToolStripMenuItem,
            this.consultaAltasMédicasToolStripMenuItem});
            this.menúDeConsultasToolStripMenuItem.Name = "menúDeConsultasToolStripMenuItem";
            this.menúDeConsultasToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.menúDeConsultasToolStripMenuItem.Text = "Menú de Consultas";
            // 
            // consulToolStripMenuItem
            // 
            this.consulToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.consulToolStripMenuItem.Checked = true;
            this.consulToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.consulToolStripMenuItem.Name = "consulToolStripMenuItem";
            this.consulToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.consulToolStripMenuItem.Text = "Consulta Pacientes";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.consultaToolStripMenuItem.Text = "Consulta Médicos";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
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
            this.consultaCitasMédicasToolStripMenuItem.Name = "consultaCitasMédicasToolStripMenuItem";
            this.consultaCitasMédicasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.consultaCitasMédicasToolStripMenuItem.Text = "Consulta Citas Médicas";
            this.consultaCitasMédicasToolStripMenuItem.Click += new System.EventHandler(this.consultaCitasMédicasToolStripMenuItem_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONSULTA DE PACIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consultar y filtrar por: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Paciente",
            "Cédula",
            "Asegurado",
            "No Asegurado"});
            this.comboBox1.Location = new System.Drawing.Point(179, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(321, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(480, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(514, 207);
            this.dataGridView1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(480, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 25);
            this.button2.TabIndex = 7;
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
            this.linkLabel1.TabIndex = 8;
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
            // ConsultPacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConsultPacient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control Médico";
            this.Load += new System.EventHandler(this.ConsultPacient_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúDeConsultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaCitasMédicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaIngresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaAltasMédicasToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}