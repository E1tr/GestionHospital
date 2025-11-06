namespace GestionHospital
{
    partial class frmIngreso
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
            mnuPrincipal = new MenuStrip();
            tlsMnuAyuda = new ToolStripMenuItem();
            tlsMnuSaberMas = new ToolStripMenuItem();
            lblTitulo = new Label();
            panel2 = new Panel();
            cbAlta = new CheckBox();
            btnEditar = new Button();
            btnEliminar = new Button();
            cmbEspecialidad = new ComboBox();
            label6 = new Label();
            numHabitacion = new NumericUpDown();
            label5 = new Label();
            dtpAlta = new DateTimePicker();
            dtpIngreso = new DateTimePicker();
            btnAgregar = new Button();
            lblAgregarIngreso = new Label();
            txtMotivo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            dgvIngresos = new DataGridView();
            editarToolStripMenuItem = new ToolStripMenuItem();
            mnuPrincipal.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHabitacion).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).BeginInit();
            SuspendLayout();
            // 
            // mnuPrincipal
            // 
            mnuPrincipal.BackColor = Color.FromArgb(245, 250, 255);
            mnuPrincipal.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem, tlsMnuAyuda, tlsMnuSaberMas });
            mnuPrincipal.Location = new Point(0, 0);
            mnuPrincipal.Name = "mnuPrincipal";
            mnuPrincipal.Size = new Size(800, 24);
            mnuPrincipal.TabIndex = 10;
            mnuPrincipal.Text = "menuStrip1";
            // 
            // tlsMnuAyuda
            // 
            tlsMnuAyuda.Name = "tlsMnuAyuda";
            tlsMnuAyuda.Size = new Size(53, 20);
            tlsMnuAyuda.Text = "Ayuda";
            tlsMnuAyuda.Click += tlsMnuAyuda_Click;
            // 
            // tlsMnuSaberMas
            // 
            tlsMnuSaberMas.Name = "tlsMnuSaberMas";
            tlsMnuSaberMas.Size = new Size(73, 20);
            tlsMnuSaberMas.Text = "Saber mas";
            tlsMnuSaberMas.Click += tlsMnuSaberMas_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Roboto", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(126, 33);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Ingresos";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(220, 230, 240);
            panel2.Controls.Add(cbAlta);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(cmbEspecialidad);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(numHabitacion);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dtpAlta);
            panel2.Controls.Add(dtpIngreso);
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(lblAgregarIngreso);
            panel2.Controls.Add(txtMotivo);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 384);
            panel2.TabIndex = 12;
            // 
            // cbAlta
            // 
            cbAlta.AutoSize = true;
            cbAlta.Location = new Point(13, 111);
            cbAlta.Name = "cbAlta";
            cbAlta.Size = new Size(140, 19);
            cbAlta.TabIndex = 20;
            cbAlta.Text = "¿Se le ha dado el alta?";
            cbAlta.UseVisualStyleBackColor = true;
            cbAlta.CheckedChanged += cbAlta_CheckedChanged;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(13, 338);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 23);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(137, 338);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 23);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Items.AddRange(new object[] { "Cirugía General", "Traumatología y Cirugía Ortopédica", "Cardiología", "Neumología", "Neurología", "Oncología Médica", "Hematología", "Ginecología y Obstetricia", "Urología", "Nefrología", "Endocrinología ", "Psiquiatría ", "Pediatría ", "Cirugía Vascular", "Cirugía Torácica", "Cirugía Cardiaca", "Cirugía Maxilofacial", "Cirugía Plástica y Reparadora", "Unidad de Cuidados Intensivos (UCI)", "Unidad de Cuidados Intermedios (UCI intermedia)", "Urgencias Hospitalarias " });
            cmbEspecialidad.Location = new Point(13, 302);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(224, 23);
            cmbEspecialidad.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 284);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 15;
            label6.Text = "Especialidad";
            // 
            // numHabitacion
            // 
            numHabitacion.Location = new Point(13, 249);
            numHabitacion.Name = "numHabitacion";
            numHabitacion.Size = new Size(224, 23);
            numHabitacion.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 231);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 12;
            label5.Text = "Habitación";
            // 
            // dtpAlta
            // 
            dtpAlta.CustomFormat = "dd/mm/yyyy hh:mm";
            dtpAlta.Format = DateTimePickerFormat.Custom;
            dtpAlta.Location = new Point(13, 151);
            dtpAlta.Name = "dtpAlta";
            dtpAlta.Size = new Size(224, 23);
            dtpAlta.TabIndex = 11;
            // 
            // dtpIngreso
            // 
            dtpIngreso.CustomFormat = "dd/mm/yyyy  hh:mm";
            dtpIngreso.Format = DateTimePickerFormat.Custom;
            dtpIngreso.Location = new Point(13, 73);
            dtpIngreso.Name = "dtpIngreso";
            dtpIngreso.Size = new Size(224, 23);
            dtpIngreso.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(13, 338);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 23);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // lblAgregarIngreso
            // 
            lblAgregarIngreso.AutoSize = true;
            lblAgregarIngreso.Font = new Font("Roboto", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAgregarIngreso.Location = new Point(13, 18);
            lblAgregarIngreso.Name = "lblAgregarIngreso";
            lblAgregarIngreso.Size = new Size(176, 25);
            lblAgregarIngreso.TabIndex = 9;
            lblAgregarIngreso.Text = "Agregar ingreso";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(13, 195);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(224, 23);
            txtMotivo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 177);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Motivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 133);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha Alta";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 55);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha ingreso";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(235, 235, 235);
            panel1.Controls.Add(dgvIngresos);
            panel1.Location = new Point(292, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 384);
            panel1.TabIndex = 11;
            // 
            // dgvIngresos
            // 
            dgvIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngresos.Location = new Point(19, 18);
            dgvIngresos.Name = "dgvIngresos";
            dgvIngresos.Size = new Size(459, 345);
            dgvIngresos.TabIndex = 1;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // frmIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnuPrincipal);
            Controls.Add(lblTitulo);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmIngreso";
            Text = "frmIngreso";
            mnuPrincipal.ResumeLayout(false);
            mnuPrincipal.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHabitacion).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip mnuPrincipal;
        private ToolStripMenuItem tlsMnuAyuda;
        private ToolStripMenuItem tlsMnuSaberMas;
        private Label lblTitulo;
        private Panel panel2;
        private Button btnAgregar;
        private Label lblAgregarIngreso;
        private TextBox txtMotivo;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private DataGridView dgvIngresos;
        private DateTimePicker dtpIngreso;
        private DateTimePicker dtpAlta;
        private Label label6;
        private NumericUpDown numHabitacion;
        private Label label5;
        private ComboBox cmbEspecialidad;
        private Button btnEliminar;
        private Button btnEditar;
        private CheckBox cbAlta;
        private ToolStripMenuItem editarToolStripMenuItem;
    }
}