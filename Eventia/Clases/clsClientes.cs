using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_ProgramaciónII.Eventia.Entidades
{
    internal class clsClientes
    {
        //propiedades del cliente
        private int intcodigo;
        private string strnombre = "";
        private string strtipocliente = "Persona";
        private string strestado = "Activo";

        public int Codigo 
        { 
            get{ return intcodigo; } 
        }
        public string Nombre 
        {   
            get{ return strnombre; } 
        }
        public string TipoCliente 
        { 
            get{ return strtipocliente; } 
        }
        public string Estado 
        { 
            get{ return strestado; } 
        }

        // constructor 

        public clsClientes(int codigo, string nombre, string tipoCliente, string estado)
        {
            intcodigo = codigo;
            strnombre = nombre;
            strtipocliente = tipoCliente;
            strestado = estado;
        }


    }
}
