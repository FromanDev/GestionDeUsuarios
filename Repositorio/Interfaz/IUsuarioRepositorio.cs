using GestionDeUsuarios.Models;

namespace ItemsDeTrabajo.Repositorio.Interfaz
{
    public interface IUsuarioRepositorio
    {
        Task<List<Usuario>> srvFindLstUsuario();
        Task<Usuario> srvFindByIdUsuario(int idUsuario);
        Task<int> srvInsertUsuario(Usuario usuario);
        Task<int> srvUpdateUsuario(Usuario usuario);
        Task srvDeleteUsuario(int idItem);
    }
}
