using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final_ProgramaciónII.Eventia.Negocio;

namespace Proyecto_Final_ProgramaciónII.Formularios
{
    public partial class frmEmpleados : Form
    {

        private clsEmpleadoManejador manejador;

        public frmEmpleados()
        {
            InitializeComponent();
            manejador = new clsEmpleadoManejador();
        }

        private void txtNombreServicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }
        private void refrescarGrid()
        {
            dgbMantenimientoEmpleado.DataSource = null;
            dgbMantenimientoEmpleado.DataSource = manejador.ConsultarEmpleados();


        }
        private void limpiarControles()
        {
            txtCodigoEmpleado.Clear();
            txtNombreEmpleado.Clear();
            cmbTipoEmpleado.SelectedIndex = -1;
            rdbActivoEmpleado.Checked = false;
            rdbInactivoEmpleado.Checked = false;
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                int estado = 0;
                if (rdbActivoEmpleado.Checked)
                {
                    estado = 1;
                }
                clsEmpleado EmpleadoTemporal = new clsEmpleado(
                Convert.ToInt32(txtCodigoEmpleado.Text),
                txtNombreEmpleado.Text,
                cmbTipoEmpleado.Text,
                Convert.ToString(estado));
                manejador.AgregarEmpleado(EmpleadoTemporal);
                refrescarGrid();
                limpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el empleado: " + ex.Message);
            }

            refrescarGrid();
            limpiarControles();

        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                int estado = 0;
                if (rdbActivoEmpleado.Checked)
                {
                    estado = 1;
                }
                manejador.ModificarEmpleado(
                    Convert.ToInt32(txtCodigoEmpleado.Text),
                    txtNombreEmpleado.Text,
                    cmbTipoEmpleado.Text,
                    Convert.ToString(estado));
                refrescarGrid();
                limpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el empleado: " + ex.Message);


                limpiarControles();
            }
        }
        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (clsClienteManejador.EliminarEmpleado(Convert.ToInt32(txtCodigoEmpleado.Text)))
            {
                MessageBox.Show("Empleado eliminado correctamente.");
                refrescarGrid();
                limpiarControles();
            }
            else
            {
                MessageBox.Show("No se encontró el empleado con el código proporcionado.");
            }
        }
    }
}
