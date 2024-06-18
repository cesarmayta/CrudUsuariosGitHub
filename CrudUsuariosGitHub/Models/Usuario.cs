using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudUsuariosGitHub.Models
{
    internal class Usuario
    {
        //atributos de la clase
        private string username;
        private string foto;
        private string email;
        private string biografia;
        private string url;

        public string Username { get => username; set => username = value; }
        public string Foto { get => foto; set => foto = value; }
        public string Email { get => email; set => email = value; }
        public string Biografia { get => biografia; set => biografia = value; }
        public string Url { get => url; set => url = value; }

        public Usuario(string username) 
        { 
            this.username = username;
        }

        public void Mostrar()
        {
            Console.WriteLine($"USUARIO : {this.username}");
            Console.WriteLine($"EMAIL : {this.email}");
            Console.WriteLine($"FOTO : {this.foto}");
            Console.WriteLine($"BIOGRAFIA : {this.biografia}");
            Console.WriteLine($"URL : {this.url}");
        }
    }
}
