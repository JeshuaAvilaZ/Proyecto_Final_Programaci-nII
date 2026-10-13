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
        private string strnombre;
        private string strtipocliente;
        private int intEstado;

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
        public int Estado 
        { 
            get{ return intEstado; } 
        }

        // constructor 

        public clsClientes(int pintcodigo, string pstrnombre, string pstrtipoCliente, string pintestado)
        {
            this.intcodigo = pintcodigo;
            this.strnombre = pstrnombre;
            this.strtipocliente = pstrtipoCliente;
            this.intEstado = 1;
        }



        // Actualizar
        public void Actualizar(int pintcodigo, string pstrnombre, string pstrtipoCliente, int pintEstado)
        {
            this.intcodigo = pintcodigo;
            this.strnombre = pstrnombre;
            this.strtipocliente = pstrtipoCliente;
            this.intEstado = pintEstado;
        }


    }
}
