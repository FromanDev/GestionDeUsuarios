using GestionDeUsuarios.Data;
using GestionDeUsuarios.Models;
using ItemsDeTrabajo.Repositorio.Interfaz;
using ItemsDeTrabajo.Servicios.Interfaz;

namespace ItemsDeTrabajo.Servicios.Implementacion
{
    public class UsuarioServicio : IUsuarioServicio
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly GestionUsuarioDBContext _gestionUsuarioDBContext;


        public UsuarioServicio(IUsuarioRepositorio usuarioRepositorio, GestionUsuarioDBContext gestionUsuarioDBContext)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _gestionUsuarioDBContext = gestionUsuarioDBContext;
        }

        public async Task<List<Usuario>> srvFindLstUsuario()
        {
            return await _usuarioRepositorio.srvFindLstUsuario();
        }

        public async Task<int> srvSaveUsuario(Usuario usuario)
        {
            int lintIdusuario = usuario.IdUsuario;
            int result;
            if (lintIdusuario == 0)
            {
                result = await _usuarioRepositorio.srvInsertUsuario(usuario);
            }
            else
            {
                result = await _usuarioRepositorio.srvUpdateUsuario(usuario);
            }

            return result;
        }

        public async Task<bool> srvDeleteUsuario(Usuario usuario)
        {
            int lintIdusuario = usuario.IdUsuario;
            await _usuarioRepositorio.srvDeleteUsuario(usuario.IdUsuario);
            return await Task.FromResult(true);
        }
    }
}
