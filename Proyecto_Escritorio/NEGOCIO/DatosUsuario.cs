using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escritorio.DATOS;

namespace Proyecto_Escritorio.NEGOCIO
{
    public static class DatosUsuario
    {
        private static int idUser;
        private static String firstName;
        private static String lastName;
        private static String carg;
        private static String correo;
        private static String user;
        private static String password;
        private static string cedula;

        
        public static int IdUser { get => idUser; set => idUser = value; }
        public static string FirstName { get => firstName; set => firstName = value; }
        public static string LastName { get => lastName; set => lastName = value; }
        public static string Carg { get => carg; set => carg = value; }
        public static string Correo { get => correo; set => correo = value; }
        public static string User { get => user; set => user = value; }
        public static string Password { get => password; set => password = value; }
        public static string Cedula { get => cedula; set => cedula = value; }
    }
}
