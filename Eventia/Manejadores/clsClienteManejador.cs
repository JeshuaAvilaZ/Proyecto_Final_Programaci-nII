using Proyecto_Final_ProgramaciónII.Eventia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_ProgramaciónII.Eventia.Negocio
{
    internal class clsClienteManejador
    {
        // Lista de clientes
        private List<clsClientes> lstClientes = new List<clsClientes>();

        // AGREGAR
        public void AgregarCliente(clsClientes objCliente)
        {
            lstClientes.Add(objCliente);
        }

        // CONSULTAR
        public List<clsClientes> ConsultarClientes()
        {
            return lstClientes;
        }

        public clsClientes buscarCliente(int codigo)
        {
            return lstClientes.FirstOrDefault(L => L.Codigo == codigo);
        }

        // MODIFICAR
        public bool ModificarCliente(int codigo, string nombre, string tipoCliente, int estado)
        {
            clsClientes CLienteTemp = buscarCliente(codigo);

            if (CLienteTemp == null)
            {
                return false;
            }

            CLienteTemp.Actualizar(codigo, nombre, tipoCliente, estado);
            return true;
        }

        // ELIMINAR
        public bool EliminarCliente(int codigo)
        {
            clsClientes CLienteTemp = buscarCliente(codigo);

            if ( CLienteTemp == null)
            {
                return false;
            }
            lstClientes.Remove(CLienteTemp);
            return true;
        }
    }
}
