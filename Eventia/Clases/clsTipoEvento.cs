using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_ProgramaciónII.Eventia.Entidades
{
    internal class clsTipoEvento
    {
        // Propiedades del tipo de evento
        private int intcodigo;
        private string strnombre = "";

        public int Codigo
        {
            get { return intcodigo; }
        }

        public string Nombre
        {
            get { return strnombre; }
        }

        // Constructor
        public clsTipoEvento(int codigo, string nombre)
        {
            intcodigo = codigo;
            strnombre = nombre;
        }
    }
}
