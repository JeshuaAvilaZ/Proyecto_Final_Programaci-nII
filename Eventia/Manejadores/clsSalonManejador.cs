using Proyecto_Final_ProgramaciónII.Eventia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_ProgramaciónII.Eventia.Negocio
{
    internal class clsSalonManejador
    {
        // lista de salones
        private List<clsSalon   > lstSalones = new List<clsSalon>();

        // Agregar salon 

        public void AgregarSalon(clsSalon objsalon)
        {
            lstSalones.Add(objsalon);
        }

        // Consultar salon

        public List<clsSalon> ConsultarSalones()
        {
            return lstSalones;
        }

        // Modificar salon

        public void ModificarSalon(int codigo, string nombre, string ubicacion, int capacidad, string estado)
        {
            for (int i = 0; i < lstSalones.Count; i++)
            {
                if (lstSalones[i].Codigo == codigo)
                {
                    // Crear un nuevo objeto con los datos modificados
                    clsSalon objsalon = new clsSalon(codigo, nombre, ubicacion, capacidad, estado);
                    lstSalones[i] = objsalon;
                    break;
                }
            }
        }

        // Eliminar salon

        public void EliminarSalon(int codigo)
        {
            for (int i = 0; i < lstSalones.Count; i++)
            {
                if (lstSalones[i].Codigo == codigo)
                {
                    lstSalones.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
