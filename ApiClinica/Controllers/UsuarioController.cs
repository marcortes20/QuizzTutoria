using Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicios.Clinicas;
using Servicios.Usuarios;

namespace ApiClinica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public readonly ISvUsuario svUsuario;

        public UsuarioController(ISvUsuario svUsuario)
        {
            this.svUsuario = svUsuario;
        }

        [HttpGet]
        public IEnumerable<Usuario> GetAllUsers()
        {
            return svUsuario.GetAllUsuarios();
        }

        [HttpGet("{id}")]
        public Usuario GetUserById(int id)
        {
            return svUsuario.GetUsuarioById(id);
        }

        [HttpPost]
        public Usuario AddUser([FromBody] Usuario user)
        {
            return svUsuario.AddUsuario(user);
        }

        [HttpPut("{id}")]
        public Usuario UpdateUser(int id, [FromBody] Usuario user)
        {
            return svUsuario.UpdateUsuario(user, id);
        }

        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            svUsuario.DeleteUsuario(id);
        }
    }
}