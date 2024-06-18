namespace CrudUsuariosGitHub.Models
{
    class Program
    {
        static void Main()
        {
            Usuario usuario = new Usuario("josevega");
            UsuarioCRUD crud = new UsuarioCRUD();
            crud.MostrarUsuarios();
            crud.RegistrarUsuario();
            crud.MostrarUsuarios();
        }
    }
}