using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Servicios.Usuarios
{
    public interface ISvUsuario
    {
        List<Usuario> GetAllUsuarios();
        Usuario GetUsuarioById(int id);
        Usuario AddUsuario(Usuario usuario);
        Usuario UpdateUsuario(Usuario usuario, int id);
        void DeleteUsuario(int id);
    }
}
