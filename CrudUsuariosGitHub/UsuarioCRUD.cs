using CrudUsuariosGitHub.Models;
using CrudUsuariosGitHub.Utils;
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
        private MensajeUI mensajeUI = new MensajeUI(50);
        public UsuarioCRUD() 
        {
            Usuario usuarioPrueba = new Usuario("cesarmayta");
            listaUsuarios.Add(usuarioPrueba);
        }

        public void MostrarUsuarios()
        {
            mensajeUI.mostrarTitulo("RELACIÓN DE USUARIOS DE GITHUB");
            foreach (var usuario in listaUsuarios)
            {
                Console.WriteLine(new string('*', 50));
                usuario.Mostrar();
            }
        }

        public void RegistrarUsuario()
        {
            this.mensajeUI.mostrarTitulo("REGISTRO DE NUEVO USUARIO");
            Console.WriteLine("USERNAME : ");
            string username = Console.ReadLine();
            Console.WriteLine("EMAIL :");
            string email = Console.ReadLine();
            Console.WriteLine("FOTO : ");
            string foto = Console.ReadLine();
            Console.WriteLine("BIOGRAFIA : ");
            string bio = Console.ReadLine();
            Console.WriteLine("URL : ");
            string url = Console.ReadLine();

            Usuario nuevoUsuario = new Usuario(username);
            nuevoUsuario.Email = email;
            nuevoUsuario.Foto = foto;
            nuevoUsuario.Biografia = bio;
            nuevoUsuario.Url = url;

            listaUsuarios.Add(nuevoUsuario);
            this.mensajeUI.mostrarMensaje("ALUMNO REGISTRADO CON EXITO !!");

        }
    }
}
