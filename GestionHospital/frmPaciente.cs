using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHospital
{
    public partial class frmPaciente : Form
    {
        // Lo que hago aquí es inicializar 3 variables para posteriormente utilizarlas en el formulario
        List<Paciente> pacientes = new List<Paciente>();
        frmPrincipal principal;
        Paciente? paciente = null;
        public frmPaciente(List<Paciente> pacientes, Paciente? paciente, frmPrincipal principal)
        {
            this.pacientes = pacientes;
            // Lo que hago aquí es darle el valor a las variables en base a lo que conviene en el momento
            InitializeComponent();
            this.Load += frmPaciente_Load;
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            // Configuración estable (se ejecuta una sola vez al mostrar el formulario)
            dgvPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaciente.MultiSelect = false;
            dgvPaciente.AutoGenerateColumns = true; // false si defines columnas manualmente
            dgvPaciente.AllowUserToAddRows = false;

            // Asignar DataSource solo una vez aquí (evita hacerlo repetidamente en otros handlers)
            RefrescarGrid();

            // Estado inicial según si venimos a editar o a añadir
            if (paciente != null)
            {
                // Rellenar campos con el paciente pasado y seleccionar su fila
                txtNombre.Text = paciente.Nombre;
                txtApellido.Text = paciente.Apellidos;
                txtEdad.Text = paciente.Edad.ToString();

                btnEditar.Visible = true;
                button1.Visible = false;
            }
            else
            {
                // Preparar formulario para añadir
                txtNombre.Clear();
                txtApellido.Clear();
                txtEdad.Clear();

                btnEditar.Visible = false;
                button1.Visible = true;

            }
        }


        private void RefrescarGrid() // Está funcion es la que se encarga de refrescar el dataGridView
        {
            dgvPaciente.DataSource = null;
            dgvPaciente.DataSource = pacientes;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEdad.Text, out int edad) || edad <= 0)
            {
                MessageBox.Show("Edad inválida. Por favor introduzca un número entero mayor que 0.", "Edad inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Paciente nuevoPaciente = new Paciente(
                    pacientes.Count + 1,
                    txtNombre.Text,
                    txtApellido.Text,
                    edad
                );

                pacientes.Add(nuevoPaciente);
                MessageBox.Show("Paciente agregado correctamente.", "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtApellido.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            this.principal.ActualizarListaPacientes(pacientes);
            RefrescarGrid();
        }

        private void btnAgregarIngreso_Click(object sender, EventArgs e)
        {

            if (dgvPaciente.CurrentRow == null)
            {
                return;
            }
            else
            {
                Paciente pacienteSeleccionado = (Paciente)dgvPaciente.CurrentRow.DataBoundItem;
                Form Ingresos = new frmIngreso(pacienteSeleccionado);
                Ingresos.ShowDialog();
                RefrescarGrid();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Validar que la edad sea un entero válido y mayor que 0.
            if (!int.TryParse(txtEdad.Text, out int edad) || edad <= 0)
            {
                MessageBox.Show("Edad inválida. Por favor introduzca un número entero mayor que 0.", "Edad inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Obliga al usuario a corregir antes de continuar
            }
            if (dgvPaciente.CurrentRow == null)
            {
                return;
            }
            else
            {
                paciente.Nombre = txtNombre.Text;
                paciente.Apellidos = txtApellido.Text;
                paciente.Edad = edad;
            }
            RefrescarGrid();
            principal.ActualizarListaPacientes(pacientes);
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPaciente.CurrentRow != null) // Verificar si hay una fila seleccionada
            {
                Paciente pacienteSeleccionado = (Paciente)dgvPaciente.CurrentRow.DataBoundItem; // Obtener el paciente seleccionado
                var resultado = MessageBox.Show($"¿Está seguro de que desea eliminar al paciente {pacienteSeleccionado.Nombre} {pacienteSeleccionado.Apellidos}?", "Eliminar Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Mensaje de confirmación
                if (resultado == DialogResult.Yes) // Si el usuario confirma la eliminación
                {
                    pacientes.Remove(pacienteSeleccionado); // Eliminar el paciente de la lista
                }
                RefrescarGrid(); // Refrescar el DataGridView para mostrar los cambios
                this.principal.ActualizarListaPacientes(pacientes); // Actualizar la lista de pacientes en el formulario principal
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un paciente para editar.", "Editar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Mensaje de advertencia si no hay una fila seleccionada


            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPaciente.CurrentRow != null) // Verificar si hay una fila seleccionada
            {
                Paciente pacienteSeleccionado = (Paciente)dgvPaciente.CurrentRow.DataBoundItem; // Obtener el paciente seleccionado
                var resultado = MessageBox.Show($"¿Está seguro de que desea eliminar al paciente {pacienteSeleccionado.Nombre} {pacienteSeleccionado.Apellidos}?", "Eliminar Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Mensaje de confirmación
                if (resultado == DialogResult.Yes) // Si el usuario confirma la eliminación
                {
                    pacientes.Remove(pacienteSeleccionado); // Eliminar el paciente de la lista
                }
                RefrescarGrid(); // Refrescar el DataGridView para mostrar los cambios
                this.principal.ActualizarListaPacientes(pacientes); // Actualizar la lista de pacientes en el formulario principal
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un paciente para editar.", "Editar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Mensaje de advertencia si no hay una fila seleccionada


            }
        }

        private void tsbEliminarEditar_Click(object sender, EventArgs e)
        {
            if (dgvPaciente.CurrentRow != null)
            {
                btnEditar.Visible = true;
                button1.Visible = false;
                paciente = (Paciente)dgvPaciente.CurrentRow.DataBoundItem;
                txtNombre.Text = paciente.Nombre;
                txtApellido.Text = paciente.Apellidos;
                txtEdad.Text = paciente.Edad.ToString();
            }
            RefrescarGrid();
            principal.ActualizarListaPacientes(pacientes);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPaciente.CurrentRow != null)
            {
                btnEditar.Visible = true;
                button1.Visible = false;
                paciente = (Paciente)dgvPaciente.CurrentRow.DataBoundItem;
                txtNombre.Text = paciente.Nombre;
                txtApellido.Text = paciente.Apellidos;
                txtEdad.Text = paciente.Edad.ToString();
            }
            RefrescarGrid();
            principal.ActualizarListaPacientes(pacientes);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            btnEditar.Visible = false;
            button1.Visible = true;
            txtApellido.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEditar.Visible = false;
            button1.Visible = true;
            txtApellido.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
        }
    }
}
