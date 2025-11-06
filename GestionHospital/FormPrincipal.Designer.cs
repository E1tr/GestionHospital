namespace GestionHospital
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            tlsPrincipal = new ToolStrip();
            tsbAgregar = new ToolStripButton();
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
            btnListar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            lblTitulo = new Label();
            panel2 = new Panel();
            dgvPrincipal = new DataGridView();
            tlsPrincipal.SuspendLayout();
            mnuPrincipal.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).BeginInit();
            SuspendLayout();
            // 
            // tlsPrincipal
            // 
            tlsPrincipal.BackColor = Color.FromArgb(245, 250, 255);
            tlsPrincipal.Items.AddRange(new ToolStripItem[] { tsbAgregar, tsbEliminar, tsbEliminarEditar, tsbIngresos });
            tlsPrincipal.Location = new Point(0, 24);
            tlsPrincipal.Name = "tlsPrincipal";
            tlsPrincipal.Size = new Size(800, 25);
            tlsPrincipal.TabIndex = 1;
            tlsPrincipal.Text = "toolStrip1";
            // 
            // tsbAgregar
            // 
            tsbAgregar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAgregar.Image = (Image)resources.GetObject("tsbAgregar.Image");
            tsbAgregar.ImageTransparentColor = Color.Magenta;
            tsbAgregar.Name = "tsbAgregar";
            tsbAgregar.Size = new Size(23, 22);
            tsbAgregar.Text = "toolStripButton1";
            tsbAgregar.Click += tsbPaciente_Click;
            // 
            // tsbEliminar
            // 
            tsbEliminar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEliminar.Image = (Image)resources.GetObject("tsbEliminar.Image");
            tsbEliminar.ImageTransparentColor = Color.Magenta;
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(23, 22);
            tsbEliminar.Text = "toolStripButton2";
            tsbEliminar.Click += tsbIngresos_Click;
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
            tsbIngresos.Click += tsbIngresos_Click_1;
            // 
            // mnuPrincipal
            // 
            mnuPrincipal.BackColor = Color.FromArgb(245, 250, 255);
            mnuPrincipal.Items.AddRange(new ToolStripItem[] { tlsMnuHopital, tlsMnuAyuda, tlsMnuSaberMas });
            mnuPrincipal.Location = new Point(0, 0);
            mnuPrincipal.Name = "mnuPrincipal";
            mnuPrincipal.Size = new Size(800, 24);
            mnuPrincipal.TabIndex = 2;
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
            tlsMnuPaciente.Size = new Size(119, 22);
            tlsMnuPaciente.Text = "Paciente";
            tlsMnuPaciente.Click += tlsMnuPaciente_Click;
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(117, 22);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(117, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(117, 22);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // tlsMnuIngresos
            // 
            tlsMnuIngresos.DropDownItems.AddRange(new ToolStripItem[] { listarToolStripMenuItem });
            tlsMnuIngresos.Name = "tlsMnuIngresos";
            tlsMnuIngresos.Size = new Size(119, 22);
            tlsMnuIngresos.Text = "Ingresos";
            tlsMnuIngresos.Click += tlsMnuIngresos_Click;
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(102, 22);
            listarToolStripMenuItem.Text = "Listar";
            listarToolStripMenuItem.Click += listarToolStripMenuItem_Click;
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
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(220, 230, 240);
            panel1.Controls.Add(btnListar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnAgregar);
            panel1.Location = new Point(12, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 100);
            panel1.TabIndex = 3;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.FromArgb(230, 230, 230);
            btnListar.FlatStyle = FlatStyle.Flat;
            btnListar.Location = new Point(643, 28);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(102, 41);
            btnListar.TabIndex = 3;
            btnListar.Text = "Listar Ingresos";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(200, 220, 255);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(441, 28);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(102, 41);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 200, 200);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(211, 28);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(102, 41);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(200, 255, 200);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(14, 28);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(102, 41);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Roboto", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 58);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(125, 25);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Bienvenido";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(235, 235, 235);
            panel2.Controls.Add(dgvPrincipal);
            panel2.Location = new Point(12, 202);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 295);
            panel2.TabIndex = 4;
            // 
            // dgvPrincipal
            // 
            dgvPrincipal.BackgroundColor = SystemColors.ActiveBorder;
            dgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrincipal.Location = new Point(14, 16);
            dgvPrincipal.Name = "dgvPrincipal";
            dgvPrincipal.Size = new Size(746, 264);
            dgvPrincipal.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 240, 255);
            ClientSize = new Size(800, 509);
            Controls.Add(panel2);
            Controls.Add(lblTitulo);
            Controls.Add(panel1);
            Controls.Add(tlsPrincipal);
            Controls.Add(mnuPrincipal);
            MainMenuStrip = mnuPrincipal;
            Name = "frmPrincipal";
            Text = "3.";
            tlsPrincipal.ResumeLayout(false);
            tlsPrincipal.PerformLayout();
            mnuPrincipal.ResumeLayout(false);
            mnuPrincipal.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip tlsPrincipal;
        private ToolStripButton tsbAgregar;
        private ToolStripButton tsbEliminar;
        private MenuStrip mnuPrincipal;
        private ToolStripMenuItem tlsMnuHopital;
        private ToolStripMenuItem tlsMnuPaciente;
        private ToolStripMenuItem tlsMnuIngresos;
        private ToolStripMenuItem tlsMnuAyuda;
        private ToolStripMenuItem tlsMnuSaberMas;
        private Panel panel1;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnListar;
        private Label lblTitulo;
        private Panel panel2;
        private DataGridView dgvPrincipal;
        private ToolStripButton tsbEliminarEditar;
        private ToolStripButton tsbIngresos;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
    }
}
