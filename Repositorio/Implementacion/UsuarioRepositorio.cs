using GestionDeUsuarios.Data;
using GestionDeUsuarios.Models;
using ItemsDeTrabajo.Repositorio.Interfaz;
using Microsoft.EntityFrameworkCore;

namespace GestionDeUsuarios.Repositorio.Implementacion
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly GestionUsuarioDBContext _gestionUsuarioDBContext;

        public UsuarioRepositorio(GestionUsuarioDBContext gestionUsuarioDBContext)
        {
            _gestionUsuarioDBContext = gestionUsuarioDBContext;
        }

        public async Task<List<Usuario>> srvFindLstUsuario()
        {
            return await _gestionUsuarioDBContext.Usuario.ToListAsync();
        }

        public async Task<Usuario> srvFindByIdUsuario(int idUsuario)
        {
            return await _gestionUsuarioDBContext.Usuario.Where(x => x.IdUsuario == idUsuario).FirstAsync();
        }

        public async Task<int> srvInsertUsuario(Usuario usuario)
        {
            await _gestionUsuarioDBContext.AddAsync(usuario);
            return usuario.IdUsuario;
        }

        public async Task<int> srvUpdateUsuario(Usuario usuario)
        {
            var myLDato = await _gestionUsuarioDBContext.Usuario.Where(x => x.IdUsuario == usuario.IdUsuario).FirstAsync();
            if (myLDato != null)
            {
                _gestionUsuarioDBContext.Usuario.Attach(myLDato).CurrentValues.SetValues(usuario);
                _gestionUsuarioDBContext.ChangeTracker.DetectChanges();
            }
            return usuario.IdUsuario;
        }

        public async Task srvDeleteUsuario(int idUsuario)
        {
            Usuario empleadoHorario = await _gestionUsuarioDBContext.Usuario.Where(x => x.IdUsuario == idUsuario).FirstAsync();

            if (empleadoHorario != null)
                _gestionUsuarioDBContext.Usuario.Remove(empleadoHorario);
        }
    }
}
