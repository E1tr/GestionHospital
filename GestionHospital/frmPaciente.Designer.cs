namespace GestionHospital
{
    partial class frmPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaciente));
            tlsPrincipal = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            tsbEliminar = new ToolStripButton();
            tsbEliminarEditar = new ToolStripButton();
            tsbIngresos = new ToolStripButton();
            mnuPrincipal = new MenuStrip();
            tlsMnuHopital = new ToolStripMenuItem();
            tlsMnuPaciente = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            tlsMnuIngresos = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            tlsMnuAyuda = new ToolStripMenuItem();
            tlsMnuSaberMas = new ToolStripMenuItem();
            panel1 = new Panel();
            dgvPaciente = new DataGridView();
            panel2 = new Panel();
            btnEditar = new Button();
            button1 = new Button();
            label4 = new Label();
            txtEdad = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            lblTitulo = new Label();
            btnAgregarIngreso = new Button();
            tlsPrincipal.SuspendLayout();
            mnuPrincipal.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tlsPrincipal
            // 
            tlsPrincipal.BackColor = Color.FromArgb(245, 250, 255);
            tlsPrincipal.Items.AddRange(new ToolStripItem[] { toolStripButton1, tsbEliminar, tsbEliminarEditar, tsbIngresos });
            tlsPrincipal.Location = new Point(0, 24);
            tlsPrincipal.Name = "tlsPrincipal";
            tlsPrincipal.Size = new Size(800, 25);
            tlsPrincipal.TabIndex = 3;
            tlsPrincipal.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // tsbEliminar
            // 
            tsbEliminar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEliminar.Image = (Image)resources.GetObject("tsbEliminar.Image");
            tsbEliminar.ImageTransparentColor = Color.Magenta;
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(23, 22);
            tsbEliminar.Text = "toolStripButton2";
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // tsbEliminarEditar
            // 
            tsbEliminarEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEliminarEditar.Image = (Image)resources.GetObject("tsbEliminarEditar.Image");
            tsbEliminarEditar.ImageTransparentColor = Color.Magenta;
            tsbEliminarEditar.Name = "tsbEliminarEditar";
            tsbEliminarEditar.Size = new Size(23, 22);
            tsbEliminarEditar.Text = "toolStripButton1";
            tsbEliminarEditar.Click += tsbEliminarEditar_Click;
            // 
            // tsbIngresos
            // 
            tsbIngresos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbIngresos.Image = (Image)resources.GetObject("tsbIngresos.Image");
            tsbIngresos.ImageTransparentColor = Color.Magenta;
            tsbIngresos.Name = "tsbIngresos";
            tsbIngresos.Size = new Size(23, 22);
            tsbIngresos.Text = "toolStripButton2";
            // 
            // mnuPrincipal
            // 
            mnuPrincipal.BackColor = Color.FromArgb(245, 250, 255);
            mnuPrincipal.Items.AddRange(new ToolStripItem[] { tlsMnuHopital, tlsMnuAyuda, tlsMnuSaberMas });
            mnuPrincipal.Location = new Point(0, 0);
            mnuPrincipal.Name = "mnuPrincipal";
            mnuPrincipal.Size = new Size(800, 24);
            mnuPrincipal.TabIndex = 4;
            mnuPrincipal.Text = "menuStrip1";
            // 
            // tlsMnuHopital
            // 
            tlsMnuHopital.DropDownItems.AddRange(new ToolStripItem[] { tlsMnuPaciente, tlsMnuIngresos });
            tlsMnuHopital.Name = "tlsMnuHopital";
            tlsMnuHopital.Size = new Size(63, 20);
            tlsMnuHopital.Text = "Hospital";
            // 
            // tlsMnuPaciente
            // 
            tlsMnuPaciente.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, eliminarToolStripMenuItem, editarToolStripMenuItem });
            tlsMnuPaciente.Name = "tlsMnuPaciente";
            tlsMnuPaciente.Size = new Size(180, 22);
            tlsMnuPaciente.Text = "Paciente";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(180, 22);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(180, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(180, 22);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // tlsMnuIngresos
            // 
            tlsMnuIngresos.DropDownItems.AddRange(new ToolStripItem[] { listarToolStripMenuItem });
            tlsMnuIngresos.Name = "tlsMnuIngresos";
            tlsMnuIngresos.Size = new Size(180, 22);
            tlsMnuIngresos.Text = "Ingresos";
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(102, 22);
            listarToolStripMenuItem.Text = "Listar";
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(235, 235, 235);
            panel1.Controls.Add(dgvPaciente);
            panel1.Location = new Point(292, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 336);
            panel1.TabIndex = 5;
            // 
            // dgvPaciente
            // 
            dgvPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaciente.Location = new Point(19, 18);
            dgvPaciente.Name = "dgvPaciente";
            dgvPaciente.Size = new Size(459, 299);
            dgvPaciente.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(220, 230, 240);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtEdad);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtApellido);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 336);
            panel2.TabIndex = 6;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(71, 283);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 23);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Actualizar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(71, 283);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 9;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 18);
            label4.Name = "label4";
            label4.Size = new Size(188, 25);
            label4.TabIndex = 9;
            label4.Text = "Agregar Paciente";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(13, 224);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(224, 23);
            txtEdad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 206);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "Edad";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(13, 144);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(224, 23);
            txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 126);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(13, 77);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(224, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 59);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Roboto", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 63);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(113, 25);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Pacientes";
            // 
            // btnAgregarIngreso
            // 
            btnAgregarIngreso.Location = new Point(661, 63);
            btnAgregarIngreso.Name = "btnAgregarIngreso";
            btnAgregarIngreso.Size = new Size(100, 23);
            btnAgregarIngreso.TabIndex = 8;
            btnAgregarIngreso.Text = "Agregar Ingreso";
            btnAgregarIngreso.UseVisualStyleBackColor = true;
            btnAgregarIngreso.Click += btnAgregarIngreso_Click;
            // 
            // frmPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 240, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregarIngreso);
            Controls.Add(lblTitulo);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tlsPrincipal);
            Controls.Add(mnuPrincipal);
            Name = "frmPaciente";
            Text = "frmPaciente";
            tlsPrincipal.ResumeLayout(false);
            tlsPrincipal.PerformLayout();
            mnuPrincipal.ResumeLayout(false);
            mnuPrincipal.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip tlsPrincipal;
        private ToolStripButton tsbEliminar;
        private ToolStripButton tsbEliminarEditar;
        private ToolStripButton tsbIngresos;
        private MenuStrip mnuPrincipal;
        private ToolStripMenuItem tlsMnuHopital;
        private ToolStripMenuItem tlsMnuPaciente;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem tlsMnuIngresos;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem tlsMnuAyuda;
        private ToolStripMenuItem tlsMnuSaberMas;
        private Panel panel1;
        private DataGridView dgvPaciente;
        private Panel panel2;
        private Label label1;
        private Label lblTitulo;
        private Button btnAgregarIngreso;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label2;
        private Button button1;
        private Label label4;
        private TextBox txtEdad;
        private Label label3;
        private Button btnEditar;
        private ToolStripButton toolStripButton1;
        private ToolStripMenuItem agregarToolStripMenuItem;
    }
}