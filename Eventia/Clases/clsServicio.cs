using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_ProgramaciónII.Eventia.Entidades
{
    internal class clsServicio
    {
        // Propiedades del servicio
        private int intcodigo;
        private string strnombre = "";
        private string strcategoria = "";

        public int Codigo
        {
            get { return intcodigo; }
        }

        public string Nombre
        {
            get { return strnombre; }
        }

        public string Categoria
        {
            get { return strcategoria; }
        }

        // Constructor
        public clsServicio(int codigo, string nombre, string categoria)
        {
            intcodigo = codigo;
            strnombre = nombre;
            strcategoria = categoria;
        }

        public void Actualizar(int codigo, string nombre, string categoria)
        {
            intcodigo = codigo;
            strnombre = nombre;
            strcategoria = categoria;
        }
    }
}
