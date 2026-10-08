using Proyecto_Final_ProgramaciónII.Formularios;
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
    public partial class frmEventia : Form
    {
        public frmEventia()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes Mclientes = new frmClientes();
            Mclientes.MdiParent = this;
            Mclientes.Show();
        }

        private void btnSalones_Click(object sender, EventArgs e)
        {
            frmSalones Msalones = new frmSalones();
            Msalones.MdiParent = this;
            Msalones.Show();
        }

        private void btnTipoEvento_Click(object sender, EventArgs e)
        {
            frmTipoEventos Mtipoeventos = new frmTipoEventos();
            Mtipoeventos.MdiParent = this;
            Mtipoeventos.Show();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            frmServicios Mservicios = new frmServicios();
            Mservicios.MdiParent = this;
            Mservicios.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados Mempleados = new frmEmpleados();
            Mempleados.MdiParent = this;
            Mempleados.Show();
        }

        private void pnlPanelPincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
