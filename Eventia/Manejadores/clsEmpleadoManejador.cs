using Proyecto_Final_ProgramaciónII.Eventia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_ProgramaciónII.Eventia.Negocio
{
    internal class clsEmpleadoManejador
    {
        // lista de empleados
        private List<clsEmpleado> lstEmpleado = new List<clsEmpleado>();

        // Agregar
        public void AgregarEmpleado(clsEmpleado objEmpleado)
        {
            lstEmpleado.Add(objEmpleado);
        }

        // consultar
        public List<clsEmpleado> ConsultarEmpleados()
        {
            return lstEmpleado;
        }

        // Modificar
        public void ModificarEmpleado(int codigo, string NombreCompleto, string Usuario, string contraseña, string rol, string estado)
        {
            for (int i = 0; i < lstEmpleado.Count; i++)
            {
                if (lstEmpleado[i].Codigo == codigo)
                {
                    // Crear un nuevo objeto con los datos modificados
                    clsEmpleado objEmpleado = new clsEmpleado(codigo, NombreCompleto, Usuario, contraseña, rol, estado);
                    lstEmpleado[i] = objEmpleado;
                    break;
                }
            }
        }

        // Eliminar
        public void EliminarEmpleado(int codigo)
        {
            for (int i = 0; i < lstEmpleado.Count; i++)
            {
                if (lstEmpleado[i].Codigo == codigo)
                {
                    lstEmpleado.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
