using GestionDeUsuarios.Models;

namespace ItemsDeTrabajo.Servicios.Interfaz
{
    public interface IUsuarioServicio
    {
        Task<List<Usuario>> srvFindLstUsuario();
        Task<int> srvSaveUsuario(Usuario usuario);
        Task<bool> srvDeleteUsuario(Usuario usuario);
    }
}