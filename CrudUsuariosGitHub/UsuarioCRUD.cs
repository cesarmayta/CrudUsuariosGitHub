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

        private Usuario BuscarUsuario(string opcion)
        {
            mensajeUI.mostrarTitulo($" {opcion} USUARIO");
            Console.WriteLine($"INGRESE EL USUARIO A {opcion} : ");
            string usuarioBusqueda = Console.ReadLine();

            Usuario usuario = listaUsuarios.Find(a => a.Username.Equals(usuarioBusqueda, StringComparison.OrdinalIgnoreCase));
            return usuario;
        }

        public void ActualizarUsuario()
        {
            Usuario usuario = this.BuscarUsuario("ACTUALIZAR");
            if(usuario != null)
            {
                Console.WriteLine("NUEVO EMAIL : ");
                string nuevoEmail = Console.ReadLine();
                Console.WriteLine("NUEVA FOTO : ");
                string nuevaFoto = Console.ReadLine();
                Console.WriteLine("NUEVA BIOGRAFIA : ");
                string nuevaBio = Console.ReadLine();
                Console.WriteLine("NUEVA URL : ");
                string nuevaUrl = Console.ReadLine();

                usuario.Email = nuevoEmail;
                usuario.Biografia = nuevaBio;
                usuario.Foto = nuevaFoto;
                usuario.Url = nuevaUrl;

                this.mensajeUI.mostrarMensaje("USUARIO ACTUALIZADO CON EXITO !!!");

            }
            else
            {
                this.mensajeUI.mostrarMensaje("USUARIO NO ENCONTRADO...");
            }
        }

        public void EliminarUsuario()
        {
            Usuario usuarioEliminar = this.BuscarUsuario("ELIMINAR");
            if(usuarioEliminar != null)
            {
                listaUsuarios.Remove(usuarioEliminar);
                this.mensajeUI.mostrarMensaje("ALUMNO ELIMINADO CON EXITO.");
            }
            else
            {
                this.mensajeUI.mostrarMensaje("NO SE ENCONTRO EL USUARIO ...");
            }
        }
    }
}
