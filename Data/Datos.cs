using GestionDeUsuarios.Models;
namespace ItemsDeTrabajo.Data
{
    public static class Datos
    {
        public static List<Usuario> empleados = new()
        {
            new(){IdUsuario=1,NombreUsuario="Usuario 1", FechaCreacionUsuario = new DateTime(2025,1,10)},
            new(){IdUsuario=2,NombreUsuario="Usuario 2", FechaCreacionUsuario = new DateTime(2025,1,10)},
            new(){IdUsuario=3,NombreUsuario="Usuario 3", FechaCreacionUsuario = new DateTime(2025,1,10)},
            new(){IdUsuario=4,NombreUsuario="Usuario 4", FechaCreacionUsuario = new DateTime(2025,1,10)},
        };
    }
}