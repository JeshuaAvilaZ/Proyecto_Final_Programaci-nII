using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final_ProgramaciónII.Eventia.Negocio;

namespace Proyecto_Final_ProgramaciónII.Formularios
{
    public partial class frmServicios : Form
    {
        private clsServicioManejador manejador;
        public frmServicios()
        {
            InitializeComponent();
            manejador = new clsServicioManejador();
        }

        private void frmServicios_Load(object sender, EventArgs e)
        {

        }
        private void refrescarGrid()
        {
            dgbMantenimientoServicio.DataSource = null;
            dgbMantenimientoServicio.DataSource = manejador.ConsultarServicios();
        }

        private void limpiarControles()
        {
            txtCodigoServicio.Clear();
            txtNombreServicio.Clear();
            cmbCategoria.SelectedIndex = -1;
            rdbActivoServicio.Checked = false;
            rdbInactivoServicio.Checked = false;
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                int estado = 0;
                if (rdbActivoServicio.Checked)
                {
                    estado = 1;
                }
                clsServicios ServicioTemporal = new clsServicios(
                    Convert.ToInt32(txtCodigoServicio.Text),
                    txtNombreServicio.Text,
                    cmbCategoria.Text,
                    Convert.ToString(estado));
                manejador.AgregarServicio(ServicioTemporal);
                MessageBox.Show("Servicio agregado correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el servicio: " + ex.Message);
            }
            refrescarGrid();
            limpiarControles();
        }
        private void btnModificarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                int estado = 0;
                if (rdbActivoServicio.Checked)
                {
                    estado = 1;
                }
                manejador.ModificarServicio(
                    Convert.ToInt32(txtCodigoServicio.Text),
                    txtNombreServicio.Text,
                    cmbCategoria.Text);
                MessageBox.Show("Servicio modificado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el servicio: " + ex.Message);
            }
            refrescarGrid();
            limpiarControles();
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                manejador.EliminarServicio(Convert.ToInt32(txtCodigoServicio.Text));
                MessageBox.Show("Servicio eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el servicio: " + ex.Message);
            }
            refrescarGrid();
            limpiarControles();
        }

        private void btnLimpiarServicio_Click(object sender, EventArgs e)
        {
            refrescarGrid();
        }
    }
}

