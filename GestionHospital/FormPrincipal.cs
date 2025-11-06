namespace GestionHospital
{
    public partial class frmPrincipal : Form
    {
        private List<Paciente> listaPacientes = new List<Paciente>();
        public frmPrincipal()
        {
            InitializeComponent();
        }


        // Refrescar el DataGridView con la lista de pacientes
        private void RefrescarGrid()
        {
            dgvPrincipal.DataSource = null;
            dgvPrincipal.DataSource = listaPacientes;
        }


        // Boton de agregar paciente que abrirá un formulario para agregar un nuevo paciente
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form formPaciente = new frmPaciente(listaPacientes, null, this);
            formPaciente.ShowDialog(); // Mostrar el formulario de agregar paciente
        }


        // Boton de editar paciente que abrirá el formulario de agregar pero con los datos del paciente para editar el paciente seleccionado
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.CurrentRow != null) // Verificar si hay una fila seleccionada
            {
                Paciente pacienteSeleccionado = (Paciente)dgvPrincipal.CurrentRow.DataBoundItem; // Obtener el paciente seleccionado
                Form formEditar = new frmPaciente(listaPacientes, pacienteSeleccionado, this); // Abrir el formulario de editar con los datos del paciente seleccionado
                formEditar.ShowDialog(); // Mostrar el formulario de editar
                RefrescarGrid(); // Refrescar el DataGridView para mostrar los cambios
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un paciente para editar.", "Editar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Mensaje de advertencia si no hay una fila seleccionada
            }
        }

        // Boton de eliminar paciente que eliminará el paciente seleccionado de la lista
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.CurrentRow != null) // Verificar si hay una fila seleccionada
            {
                Paciente pacienteSeleccionado = (Paciente)dgvPrincipal.CurrentRow.DataBoundItem; // Obtener el paciente seleccionado
                var resultado = MessageBox.Show($"¿Está seguro de que desea eliminar al paciente {pacienteSeleccionado.Nombre} {pacienteSeleccionado.Apellidos}?", "Eliminar Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Mensaje de confirmación
                if (resultado == DialogResult.Yes) // Si el usuario confirma la eliminación
                {
                    listaPacientes.Remove(pacienteSeleccionado); // Eliminar el paciente de la lista
                }
                RefrescarGrid(); // Refrescar el DataGridView para mostrar los cambios
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un paciente para editar.", "Editar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Mensaje de advertencia si no hay una fila seleccionada


            }
        }

        // Boton que abre el formulario para listar los ingresos del paciente seleccionado
        private void btnListar_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.CurrentRow != null) // Verificar si hay una fila seleccionada
            {
                Paciente pacienteSeleccionado = (Paciente)dgvPrincipal.CurrentRow.DataBoundItem; // Obtener el paciente seleccionado
                Form formListar = new frmIngreso(pacienteSeleccionado); // Abrir el formulario de listar ingresos
                formListar.ShowDialog(); // Mostrar el formulario de listar ingresos
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un paciente para ver sus ingresos.", "Ver Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Mensaje de advertencia si no hay una fila seleccionada
            }
        }



        // ToolStripButtons y ToolStripMenuItems

        // Boton de la barra de herramientas para agregar un paciente
        private void tsbPaciente_Click(object sender, EventArgs e)
        {
            Form formPaciente = new frmPaciente(listaPacientes, null, this);
            formPaciente.ShowDialog();
        }

        // Boton de la barra de herramientas para eliminar un paciente
        private void tsbIngresos_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.CurrentRow != null)
            {
                Paciente pacienteSeleccionado = (Paciente)dgvPrincipal.CurrentRow.DataBoundItem;
                var resultado = MessageBox.Show($"¿Está seguro de que desea eliminar al paciente {pacienteSeleccionado.Nombre} {pacienteSeleccionado.Apellidos}?", "Eliminar Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    listaPacientes.Remove(pacienteSeleccionado);
                }
                RefrescarGrid();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un paciente para editar.", "Editar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }



        // Boton de la barra de herramientas para editar un paciente
        private void tsbEliminarEditar_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.CurrentRow != null)
            {
                Paciente pacienteSeleccionado = (Paciente)dgvPrincipal.CurrentRow.DataBoundItem;
                Form formEditar = new frmPaciente(listaPacientes, pacienteSeleccionado, this);
                formEditar.ShowDialog();
                RefrescarGrid();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un paciente para editar.", "Editar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // Boton de la barra de herramientas para listar los ingresos
        private void tsbIngresos_Click_1(object sender, EventArgs e)
        {
            if (dgvPrincipal.CurrentRow != null) // Verificar si hay una fila seleccionada
            {
                Paciente pacienteSeleccionado = (Paciente)dgvPrincipal.CurrentRow.DataBoundItem; // Obtener el paciente seleccionado
                Form formListar = new frmIngreso(pacienteSeleccionado); // Abrir el formulario de listar ingresos
                formListar.ShowDialog(); // Mostrar el formulario de listar ingresos
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un paciente para ver sus ingresos.", "Ver Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Mensaje de advertencia si no hay una fila seleccionada
            }
        }


        // MenuStrip Items

        private void tlsMnuPaciente_Click(object sender, EventArgs e)
        {
            //En un principio esto iba a tener una utilidad pero por un cambio de idea no se va a usar, como su eliminación puede afectar al funcionamiento del programa se deja así
        }

        private void tlsMnuIngresos_Click(object sender, EventArgs e)
        {
            //En un principio esto iba a tener una utilidad pero por un cambio de idea no se va a usar, como su eliminación puede afectar al funcionamiento del programa se deja así
        }

        // MenuItems del MenuStrip para agregar, eliminar, editar y listar pacientes e ingresos



        //MenuItems de Agregar Paciente
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formPaciente = new frmPaciente(listaPacientes, null,this);
            formPaciente.ShowDialog();
        }


        //MenuItems de Eliminar Paciente
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.CurrentRow != null)
            {
                Paciente pacienteSeleccionado = (Paciente)dgvPrincipal.CurrentRow.DataBoundItem;
                Form formEditar = new frmPaciente(listaPacientes, pacienteSeleccionado,this);
                formEditar.ShowDialog();
                RefrescarGrid();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un paciente para editar.", "Editar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // MenuItems de Editar Paciente
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.CurrentRow != null)
            {
                Paciente pacienteSeleccionado = (Paciente)dgvPrincipal.CurrentRow.DataBoundItem;
                Form formEditar = new frmPaciente(listaPacientes, pacienteSeleccionado, this);
                formEditar.ShowDialog();
                RefrescarGrid();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un paciente para editar.", "Editar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // MenuItems de Listar Ingresos
        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.CurrentRow != null) // Verificar si hay una fila seleccionada
            {
                Paciente pacienteSeleccionado = (Paciente)dgvPrincipal.CurrentRow.DataBoundItem; // Obtener el paciente seleccionado
                Form formListar = new frmIngreso(pacienteSeleccionado); // Abrir el formulario de listar ingresos
                formListar.ShowDialog(); // Mostrar el formulario de listar ingresos
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un paciente para ver sus ingresos.", "Ver Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Mensaje de advertencia si no hay una fila seleccionada
            }
        }

        private void tlsMnuAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta es una aplicación para gestionar un Hotel.\n\n" +
    "Utilice los botones o el menú para agregar, eliminar, buscar o listar ingresos.\n\n" +
    "Desarrollado por E1tr.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tlsMnuSaberMas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Interfaz de Hospital v1.0\n\n" +
               "Desarrollado por E1tr.\n", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ActualizarListaPacientes(List<Paciente> pacientes)
        {
            listaPacientes = pacientes;
            RefrescarGrid();
        }
    }
}
