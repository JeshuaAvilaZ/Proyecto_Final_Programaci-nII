using Proyecto_Final_ProgramaciónII.Eventia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_ProgramaciónII.Eventia.Negocio
{
    internal class clsTipoEventoManejador
    {
       // lista de los tipos de evento
       private List<clsTipoEvento> lstTipoEvento = new List<clsTipoEvento>();

       // Agregar 
       public void AgregarTipoEvento(clsTipoEvento objTipoEvento)
       {
            lstTipoEvento.Add(objTipoEvento);
       }

        // Consultar
        public List<clsTipoEvento> ConsultarTiposEvento()
        {
            return lstTipoEvento;
        }

        // Modificar

        public void ModificarTipoEvento(int codigo, string nombre)
        {
            for (int i = 0; i < lstTipoEvento.Count; i++)
            {
                if (lstTipoEvento[i].Codigo == codigo)
                {
                    // Crear un nuevo objeto con los datos modificados
                    clsTipoEvento objTipoEvento = new clsTipoEvento(codigo, nombre);
                    lstTipoEvento[i] = objTipoEvento;
                    break;
                }
            }
        }

        // Eliminar

        public void EliminarTipoEvento(int codigo)
        {
            for (int i = 0; i < lstTipoEvento.Count; i++)
            {
                if (lstTipoEvento[i].Codigo == codigo)
                {
                    lstTipoEvento.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
