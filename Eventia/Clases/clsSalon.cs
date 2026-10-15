using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_ProgramaciónII.Eventia.Entidades
{
    internal class clsSalon
    {
        // Propiedades del salón
        private int intcodigo;
        private string strnombre = "";
        private string strubicacion = "";
        private int intcapacidad;
        private string strestado = "Disponible";

        public int Codigo
        {
            get { return intcodigo; }
        }

        public string Nombre
        {
            get { return strnombre; }
        }

        public string Ubicacion
        {
            get { return strubicacion; }
        }

        public int Capacidad
        {
            get { return intcapacidad; }
        }

        public string Estado
        {
            get { return strestado; }
        }

        // Constructor
        public clsSalon(int codigo, string nombre, string ubicacion, int capacidad, string estado)   
        {
            intcodigo = codigo;
            strnombre = nombre;
            strubicacion = ubicacion;
            intcapacidad = capacidad;
            strestado = estado;
        }

    
    }
}
