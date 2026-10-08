using Proyecto_Final_ProgramaciónII.Eventia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_ProgramaciónII.Eventia.Negocio
{
    internal class clsServicioManejador
    {
        // lista de servicios
        private List<clsServicio> lstServicio = new List<clsServicio>();

        // Agregar
        public void AgregarServicio(clsServicio objServicio)
        {
            lstServicio.Add(objServicio);
        }

        // Consultar
        public List<clsServicio> ConsultarServicios()
        {
            return lstServicio;
        }

        // Modificar
        public void ModificarServicio(int codigo, string nombre, string categoria)
        {
            for (int i = 0; i < lstServicio.Count; i++)
            {
                if (lstServicio[i].Codigo == codigo)
                {
                    // Crear un nuevo objeto con los datos modificados
                    clsServicio objServicio = new clsServicio(codigo, nombre, categoria);
                    lstServicio[i] = objServicio;
                    break;
                }
            }
        }

        // Eliminar
        public void EliminarServicio(int codigo)
        {
            for (int i = 0; i < lstServicio.Count; i++)
            {
                if (lstServicio[i].Codigo == codigo)
                {
                    lstServicio.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
