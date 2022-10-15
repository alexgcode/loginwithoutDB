using loginwithoutDB.Models;
using System.Collections.Generic;
using System.Linq;

namespace loginwithoutDB.Data
{
    public class DA_Logica
    {
        public List<Usuario> ListaUsuario()
        {
            return new List<Usuario>
            {
                new Usuario {Nombre= "Jose", Correo = "administrador@gmail.com", Clave="123", Roles = new string[]{ "Administrador" } },
                new Usuario {Nombre= "Juan", Correo = "supervisor@gmail.com", Clave="123", Roles = new string[]{ "Supervisor" } },
                new Usuario {Nombre= "Maria", Correo = "empleado@gmail.com", Clave="123", Roles = new string[]{ "Empleado" } },
                new Usuario {Nombre= "Oscar", Correo = "supervisorempleado@gmail.com", Clave="123", Roles = new string[]{ "Supervisor", "Empleado" } }
            };
        }

        public Usuario ValidarUsuario(string _correo, string _clave)
        {
            return ListaUsuario().Where(item => item.Correo == _correo && item.Clave == _clave).FirstOrDefault();
        }
    }
}
