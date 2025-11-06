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
    public partial class frmIngreso : Form
    {
        private Paciente _paciente; //Inicializo una variable paciente vacía para posteriormente utilizarla
        public frmIngreso(Paciente paciente)
        {
            _paciente = paciente; //Doy el valor a la variable creada anteriormente 
            InitializeComponent();
            dtpAlta.Enabled = false;
            lblTitulo.Text = "Ingresos del paciente: " + _paciente.Nombre + " " + _paciente.Apellidos;
            btnEditar.Visible = false;
            cmbEspecialidad.SelectedItem = 0;

        }

        public void RefrescarGrid() //Está función lo que hace es refrescar la tabla 
        {
            dgvIngresos.DataSource = null;
            dgvIngresos.DataSource = _paciente.Ingresos;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Esto lo que hace es crear un nuevo ingreso
        {
            DateTime? alta = new DateTime();
            if (cbAlta.Checked)
            {
                alta = dtpAlta.Value;
            }
            else
            {
                alta = null;
            }
            Ingreso nuevoIngreso = new Ingreso(
                _paciente.Ingresos.Count + 1,
                dtpIngreso.Value,
                alta,
                txtMotivo.Text,
                numHabitacion.Value.ToString(),
                cmbEspecialidad.SelectedItem?.ToString() ?? "Sin especialidad"
            ); // Se genera una variable aplicando los valores de las herramientas


            _paciente.Ingresos.Add(nuevoIngreso); //Se agrega un ingreso a la lista de ingresos del paciente seleccionado ya sea en el formulario ingreso o en el principal

            RefrescarGrid(); //Llamamos a la función para refrescar el greed

            MessageBox.Show("Ingreso agregado correctamente.", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information); //Informamos de que se a añadido correctamente
            txtMotivo.Clear();
            numHabitacion.Value = 0;
            cmbEspecialidad.SelectedItem = 0;

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
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


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvIngresos.CurrentRow != null) //Comprueba que haya una línea 
            {
                Ingreso ingresoSeleccionado = (Ingreso)dgvIngresos.CurrentRow.DataBoundItem; // Almacenamos la línea en una variable del tipo Ingreso para mas tarde usarla a modo de información
                var resultado = MessageBox.Show($"¿Está seguro de que desea eliminar el ingreso {ingresoSeleccionado.Id} con motivo {ingresoSeleccionado.Motivo}?", "Eliminar Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Mensaje de confirmación
                if (resultado == DialogResult.Yes)//Si en el mensaje de confirmación se le da a Sí se elimina
                {
                    _paciente.Ingresos.Remove(ingresoSeleccionado);
                }
                RefrescarGrid(); //Refrescamos el grid para que se deje de ver en este 
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un paciente para editar.", "Editar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Mensaje de advertencia si no hay una fila seleccionada
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvIngresos.CurrentRow != null)//Comprueba que haya una línea
            {

                Ingreso editarIngreso = (Ingreso)dgvIngresos.CurrentRow.DataBoundItem;
                editarIngreso.Motivo = txtMotivo.Text;
                editarIngreso.FechaIngreso = dtpIngreso.Value;
                if (cbAlta.Checked)
                {
                    editarIngreso.FechaAlta = dtpAlta.Value;
                }
                else
                {
                    editarIngreso.FechaAlta = null;
                }
                editarIngreso.Habitacion = numHabitacion.Value.ToString();
                editarIngreso.Especialidad = cmbEspecialidad.SelectedItem?.ToString() ?? "Sin especialidad";

            }
            RefrescarGrid();
        }

        private void cbAlta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAlta.Checked)
            {
                dtpAlta.Enabled = true;
            }
            else
            {
                dtpAlta.Enabled = false;
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvIngresos.CurrentRow != null)
            {
                btnEditar.Visible = true;
                btnAgregar.Visible = false;
                Ingreso editarIngreso = (Ingreso)dgvIngresos.CurrentRow.DataBoundItem;
                txtMotivo.Text = editarIngreso.Motivo;
                dtpIngreso.Value = editarIngreso.FechaIngreso;
                if (editarIngreso.FechaAlta.HasValue) // Verifica si FechaAlta tiene un valor antes de asignarlo
                {
                    dtpAlta.Value = editarIngreso.FechaAlta.Value;
                }
                numHabitacion.Value = decimal.Parse(editarIngreso.Habitacion);
                cmbEspecialidad.SelectedItem = editarIngreso.Especialidad;

            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEditar.Visible = false;
            btnAgregar.Visible = true;
            txtMotivo.Clear();
            numHabitacion.Value = 0;
            cmbEspecialidad.SelectedItem = 0;
        }
    }
}
