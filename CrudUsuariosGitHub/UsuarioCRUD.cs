using CrudUsuariosGitHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudUsuariosGitHub
{
    internal class UsuarioCRUD
    {
        private List<Usuario> listaUsuarios = new List<Usuario>();
        public UsuarioCRUD() 
        {
            Usuario usuarioPrueba = new Usuario("cesarmayta");
            listaUsuarios.Add(usuarioPrueba);
        }

        public void MostrarUsuarios()
        {
            foreach (var usuario in listaUsuarios)
            {
                Console.WriteLine(new string('*', 50));
                usuario.Mostrar();
            }
        }
    }
}
