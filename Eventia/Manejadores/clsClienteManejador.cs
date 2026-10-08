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

        // MODIFICAR
        public void ModificarCliente(int codigo, string nombre, string tipoCliente, string estado)
        {
            for (int i = 0; i < lstClientes.Count; i++)
            {
                if (lstClientes[i].Codigo == codigo)
                {
                    // Crear un nuevo objeto con los datos modificados
                    clsClientes objCliente = new clsClientes (codigo, nombre, tipoCliente, estado);

                    lstClientes[i] = objCliente;

                    break;
                }
            }
        }

        // ELIMINAR
        public void EliminarCliente(int codigo)
        {
            for (int i = 0; i < lstClientes.Count; i++)
            {
                if (lstClientes[i].Codigo == codigo)
                {
                    lstClientes.RemoveAt(i);

                    break;
                }
            }
        }
    }
}
