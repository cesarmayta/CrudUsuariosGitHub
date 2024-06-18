using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace CrudUsuariosGitHub.Utils
{
    internal class UsuarioUI
    {
        const int ANCHO = 50;
        private UsuarioCRUD crud;
        private MensajeUI mensajeUI = new MensajeUI(ANCHO);

        public UsuarioUI()
        {
            crud = new UsuarioCRUD();
        }

        public void MostrarMenu()
        {
            int opcion = 0;
            while (opcion != 5)
            {
                Console.Clear();
                mensajeUI.mostrarTitulo("CRUD DE USUARIOS GITHUB");
                Console.WriteLine(@"
                    [1] REGISTRAR USUARIO
                    [2] MOSTRAR USUARIOS
                    [3] ACTUALIZAR USUARIOS
                    [4] ELIMINAR USUARIO
                    [5] SALIR
                ");
                this.mensajeUI.mostrarTitulo("INGRESE UN OPCIÓN DEL MENU : ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        crud.RegistrarUsuario();
                        break;
                    case 2:
                        crud.MostrarUsuarios();
                        Console.WriteLine("PRESION UNA TECLA PARA CONTINUAR...");
                        Console.ReadKey();
                        break;
                    case 3:
                        crud.ActualizarUsuario();
                        break;
                    case 4:
                        crud.EliminarUsuario();
                        break;
                }
            }
        }
    }
}
