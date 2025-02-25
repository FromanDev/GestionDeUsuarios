using GestionDeUsuarios.Models;
using ItemsDeTrabajo.Servicios.Interfaz;
using Microsoft.AspNetCore.Mvc;

namespace ItemsDeTrabajo.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioServicio _usuarioServicio;

        public UsuarioController(IUsuarioServicio usuarioServicio)
        {
            _usuarioServicio = usuarioServicio;
        }

        [HttpGet("srvFindLstUsuario")]
        public async Task<IActionResult> srvFindLstUsuario()
        {
            return Ok(await _usuarioServicio.srvFindLstUsuario());
        }

        [HttpPost("srvSaveUsuario")]
        public async Task<IActionResult> srvSaveUsuario([FromBody] Usuario usuario)
        {
            return Ok(await _usuarioServicio.srvSaveUsuario(usuario));
        }

        [HttpPost("srvDeleteUsuario")]
        public async Task<IActionResult> srvDeleteUsuario([FromBody] Usuario usuario)
        {
            return Ok(await _usuarioServicio.srvDeleteUsuario(usuario));
        }
    }
}