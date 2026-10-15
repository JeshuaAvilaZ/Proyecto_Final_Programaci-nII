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

namespace Proyecto_Final_ProgramaciónII
{
    public partial class frmTipoEventos : Form
    {
        private clsTipoEventoManejador manejador;
        public frmTipoEventos()
        {
            InitializeComponent();
            manejador = new clsTipoEventoManejador();
        }

        private void refrescarGrid()
        {
            dgbMantenimientoTipoEvento.DataSource = null;
            dgbMantenimientoTipoEvento.DataSource = manejador.ConsultarTipoEventos();
        }

        private void limpiarControles()
        {
            txtCodigoTipoEvento.Clear();
            txtNombreTipoEvento.Clear();
            rdbActivoTipoEvento.Checked = false;
            rdbInactivoTipoEvento.Checked = false;
        }

        private void btnAgregarTipoEvento_Click(object sender, EventArgs e)
        {
            try
            {
                int estado = 0;
                if (rdbActivoTipoEvento.Checked)
                {
                    estado = 1;
                }
                clsTipoEvento TipoEventoTemporal = new clsTipoEvento(
                    Convert.ToInt32(txtCodigoTipoEvento.Text),
                    txtNombreTipoEvento.Text,
                    Convert.ToString(estado));
                manejador.AgregarTipoEvento(TipoEventoTemporal);
                MessageBox.Show("Tipo de evento agregado correctamente.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el tipo de evento: " + ex.Message);
            }
            refrescarGrid();
            limpiarControles();
        }

        private void btnModificarTipoEvento_Click(object sender, EventArgs e)
        {
            try
            {
                int estado = 0;
                if (rdbActivoTipoEvento.Checked)
                {
                    estado = 1;
                }
                clsTipoEvento TipoEventoTemporal = new clsTipoEvento(
                    Convert.ToInt32(txtCodigoTipoEvento.Text),
                    txtNombreTipoEvento.Text,
                    Convert.ToString(estado));
                manejador.ModificarTipoEvento(TipoEventoTemporal);
                MessageBox.Show("Tipo de evento modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el tipo de evento: " + ex.Message);
            }
            refrescarGrid();
            limpiarControles();
        }

        private void btnEliminarTipoEvento_Click(object sender, EventArgs e)
        {
            if (manejador.EliminarTipoEvento(Convert.ToInt32(txtCodigoTipoEvento.Text)))
            {
                MessageBox.Show("Tipo de evento eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("No se encontró el tipo de evento.");
            }
        }

            private void btnLimpiar_Click(object sender, EventArgs e)
            {
                refrescarGrid();
        }

        private void frmTipoEventos_Load(object sender, EventArgs e)
        {

        }
    }
}
