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

namespace Proyecto_Final_ProgramaciónII
{
    public partial class frmSalones : Form
    {
        private clsSalonManejador manejador;
        public frmSalones()
        {
            InitializeComponent();
            manejador = new clsSalonManejador();
        }

        private void rdbInactivo_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void refrescarGrid()
        {
            dgbMantenimientoSalones.DataSource = null;
            dgbMantenimientoSalones.DataSource = manejador.ConsultarSalones();
        }

        private void limpiarControles()
        {
            txtCodigoSalones.Clear();
            txtNombreSalones.Clear();
            cmbTipoSalon.SelectedIndex = -1;
            rdbActivo.Checked = false;
            rdbInactivo.Checked = false;
        }

        private void btnAgregarSalon_Click(object sender, EventArgs e)
        {
            try
            {
                int estado = 0;
                if (rdbActivo.Checked)
                {
                    estado = 1;
                }
                clsSalones SalonTemporal = new clsSalones(
                    Convert.ToInt32(txtCodigoSalones.Text),
                    txtNombreSalones.Text,
                    cmbTipoSalon.Text,
                    Convert.ToString(estado));
                manejador.AgregarSalon(SalonTemporal);
                refrescarGrid();
                limpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el salón: " + ex.Message);
            }
            limpiarControles();
        }

        private void btnModificarSalon_Click(object sender, EventArgs e)
        {
            int estado = 0;
            if (rdbActivo.Checked)
            {
                estado = 1;
            }

            bool actualizado = manejador.ModificarSalon(Convert.ToInt32(txtCodigoSalones.Text),
                txtNombreSalones.Text,
                cmbTipoSalon.Text,
                estado
            );
            if (actualizado)
            {
                MessageBox.Show("Salón actualizado correctamente.");
                refrescarGrid();
            }
            else
            {
                MessageBox.Show("No se encontró el salón con el código especificado.");
            }
            limpiarControles();

        }

        private void btnEliminarSalon_Click(object sender, EventArgs e)
        {
            if (manejador.EliminarSalon(Convert.ToInt32(txtCodigoSalones.Text)))
            {
                MessageBox.Show("Salón eliminado correctamente.");
                refrescarGrid();
                limpiarControles();
            }
            else
            {
                MessageBox.Show("No se encontró el salón con el código proporcionado.");
            }
        }

        private void btnLimpiarSalon_Click(object sender, EventArgs e)
        {
            refrescarGrid();
        }
    }
}
