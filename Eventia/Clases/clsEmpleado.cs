using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_ProgramaciónII.Eventia.Entidades
{
    internal class clsEmpleado
    {
        // Propiedades del empleado
        private int intcodigo;
        private string strnombrecompleto = "";
        private string strusuario = "";
        private string strcontraseña = "";
        private string strrol = "";
        private string strestado = "Activo";

        public int Codigo
        {
            get { return intcodigo; }
        }

        public string NombreCompleto
        {
            get { return strnombrecompleto; }
        }

        public string Usuario
        {
            get { return strusuario; }
        }

        public string Contraseña
        {
            get { return strcontraseña; }
        }

        public string Rol
        {
            get { return strrol; }
        }

        public string Estado
        {
            get { return strestado; }
        }

        // Constructor
        public clsEmpleado(int codigo, string nombrecompleto, string usuario, string contraseña, string rol, string estado)
        {
            intcodigo = codigo;
            strnombrecompleto = nombrecompleto;
            strusuario = usuario;
            strcontraseña = contraseña;
            strrol = rol;
            strestado = estado;
        }

    }
}
