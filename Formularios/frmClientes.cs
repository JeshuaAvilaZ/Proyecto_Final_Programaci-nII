using Proyecto_Final_ProgramaciónII.Eventia.Entidades;
using Proyecto_Final_ProgramaciónII.Eventia.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_ProgramaciónII
{
    public partial class frmClientes : Form
    {
        private clsClienteManejador manejador;
        public frmClientes()
        {
            InitializeComponent();
            manejador = new clsClienteManejador();
        }

        // refrescar el datagridview
        private void refrescarGrid()
        {
            dgbMantenimientoCliente.DataSource = null;
            dgbMantenimientoCliente.DataSource = manejador.ConsultarClientes();
            
        }

        // limpiar los controladores
        private void limpiarControles()
        {
           txtCodigoClientes.Clear();
           txtNombreRazónClientes.Clear();
           cmbTipoCliente.SelectedIndex = -1;
           rdbActivoCliente.Checked = false;
           rdbInactivoCliente.Checked = false;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int estado = 0;

                if (rdbActivoCliente.Checked)
                {
                    estado = 1;
                }

                clsClientes ClienteTemporal = new clsClientes(
                Convert.ToInt32(txtCodigoClientes.Text),
                txtNombreRazónClientes.Text,
                cmbTipoCliente.Text,
                Convert.ToString(estado));

                manejador.AgregarCliente(ClienteTemporal);

                MessageBox.Show("Cliente agregado correctamente.");

            } 
            catch (Exception ex)
            {
                MessageBox.Show($"Error al Agregar el Cliente: {ex.Message}");
            }

            refrescarGrid();
            limpiarControles();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            int estado = 0;

            if (rdbActivoCliente.Checked)
            {
                estado = 1;
            }

            bool actualizado = manejador.ModificarCliente(Convert.ToInt32(txtCodigoClientes.Text),
                txtNombreRazónClientes.Text,
                cmbTipoCliente.Text,
                estado
            );

            if (actualizado) 
            {
                MessageBox.Show("Cliente actualizado correctamente.");
                refrescarGrid();
            }

            else
            {
                MessageBox.Show("No se encontró el Cliente con el código proporcionado.");
                refrescarGrid();
            }

            limpiarControles();

        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if(manejador.EliminarCliente(Convert.ToInt32(txtCodigoClientes.Text)))
            {
                MessageBox.Show("Cliente eliminado correctamente.");
                limpiarControles();
            }
            else
            {
                MessageBox.Show("No se encontró el libro con el código proporcionado.");
            }
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            refrescarGrid();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
