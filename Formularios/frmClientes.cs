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
                // Convertir el código de texto a número
                int codigo = Convert.ToInt32(txtCodigoClientes.Text);

                // Obtener el nombre
                string nombre = txtNombreRazónClientes.Text;

                // Obtener el tipo de cliente
                string tipoCliente = cmbTipoCliente.Text;

                // Obtener el estado
                string estado = "Inactivo";

               
                if (rdbActivoCliente.Checked)
                {
                    estado = "Activo";
                }

                // Crear el objeto cliente
                clsClientes ClienteTemporal = new clsClientes(
                    codigo,
                    nombre,
                    tipoCliente,
                    estado);

                // Agregar el cliente al manejador
                manejador.AgregarCliente(ClienteTemporal);

                // Mostrar los datos en el DataGridView
                refrescarGrid();

                // Limpiar los controles
                limpiarControles();

                MessageBox.Show("Cliente agregado correctamente.");
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"Error al Agregar el Cliente: {ex.Message}");
            }
        }
    }
}
