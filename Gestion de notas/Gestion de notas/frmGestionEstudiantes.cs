using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace Gestion_de_notas
{
    public partial class frmGestionEstudiantes : Form
    {

        private readonly EstudiantesService estudianteBLL;
        public frmGestionEstudiantes()
        {
            InitializeComponent();
            estudianteBLL = new EstudiantesService();
        }

        private void btnInsertarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                Estudiante estudiante = new Estudiante
                {
                    IDEstudiante = txtDocumento.Text,
                    nombreCompleto = txtNombreEstudiante.Text,
                    fechaNacimiento = dtpFechaNacimientoEstudiante.Value,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                    Correo = txtCorreo.Text,
                    IDGrado = txtGrado.Text,
                    IDUsuario = txtUsuario.Text 
                };

                if (estudianteBLL.AddEstudiante(estudiante))
                {
                    MessageBox.Show("Estudiante insertado correctamente.");
                    CargarEstudiantes();
                }
                else
                {
                    MessageBox.Show("Error al insertar estudiante.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnModificarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                Estudiante estudiante = new Estudiante
                {
                    IDEstudiante = txtDocumento.Text,
                    nombreCompleto = txtNombreEstudiante.Text,
                    fechaNacimiento = dtpFechaNacimientoEstudiante.Value,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                    Correo = txtCorreo.Text,
                    IDGrado = txtGrado.Text,
                    IDUsuario = txtUsuario.Text
                };

                if (estudianteBLL.UpdateEstudiante(estudiante))
                {
                    MessageBox.Show("Estudiante modificado correctamente.");
                    CargarEstudiantes();
                }
                else
                {
                    MessageBox.Show("Error al modificar estudiante.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                if (estudianteBLL.DeleteEstudiante(txtDocumento.Text))
                {
                    MessageBox.Show("Estudiante eliminado correctamente.");
                    CargarEstudiantes();
                }
                else
                {
                    MessageBox.Show("Error al eliminar estudiante.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                var estudiante = estudianteBLL.GetEstudianteById(txtBuscarEstudiante.Text);
                if (estudiante != null)
                {
                    txtDocumento.Text = estudiante.IDEstudiante;
                    txtNombreEstudiante.Text = estudiante.nombreCompleto;
                    dtpFechaNacimientoEstudiante.Value = estudiante.fechaNacimiento;
                    txtDireccion.Text = estudiante.Direccion;
                    txtCorreo.Text = estudiante.Correo;
                    txtGrado.Text = estudiante.IDGrado;
                }
                else
                {
                    MessageBox.Show("Estudiante no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CargarEstudiantes()
        {
            try
            {
                // Obtener la lista de estudiantes desde la BLL
                var estudiantes = estudianteBLL.GetAllEstudiantes();

                // Limpiar el DataGridView antes de volver a cargar los datos
                dataGridViewEstudiantes.Rows.Clear();

                // Iterar a través de la lista de estudiantes y agregarlos al DataGridView
                foreach (var estudiante in estudiantes)
                {
                    // Crear una fila nueva para el DataGridView
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridViewEstudiantes);

                    // Llenar la fila con los datos del estudiante
                    row.Cells[0].Value = estudiante.IDEstudiante;
                    row.Cells[1].Value = estudiante.nombreCompleto;
                    row.Cells[2].Value = estudiante.fechaNacimiento.ToString("dd/MM/yyyy");
                    row.Cells[3].Value = estudiante.Direccion;
                    row.Cells[4].Value = estudiante.Correo;
                    row.Cells[5].Value = estudiante.IDGrado;

                    // Agregar la fila al DataGridView
                    dataGridViewEstudiantes.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar estudiantes: {ex.Message}");
            }
        }
    }
}
