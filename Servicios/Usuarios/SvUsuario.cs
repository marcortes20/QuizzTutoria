using Entidades;
using Microsoft.EntityFrameworkCore;
using Servicios.MyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Usuarios
{
    public class SvUsuario: ISvUsuario
    {
        private  MyContext _myDbContext = default!;

        public SvUsuario()
        {
            _myDbContext = new MyContext();
        }

        public List<Usuario> GetAllUsuarios()
        {
            return _myDbContext.Usuario.ToList();
        }

        public Usuario GetUsuarioById(int id)
        {
            return _myDbContext.Usuario.Find(id);
                              
        }

        public Usuario AddUsuario(Usuario usuario)
        {
            _myDbContext.Usuario.Add(usuario);
            _myDbContext.SaveChanges();
            return usuario;
        }

        public Usuario UpdateUsuario(Usuario usuario, int id)
        {
            var usuarioActualizar = _myDbContext.Usuario.Find(id);

            if (usuarioActualizar is not null)
            {
                usuarioActualizar.NombreDeUsuario = usuario.NombreDeUsuario;
                usuarioActualizar.Contraseña = usuario.Contraseña;
                usuarioActualizar.clinicaId = usuario.clinicaId;
                usuarioActualizar.clinica = usuario.clinica;


                _myDbContext.Usuario.Update(usuarioActualizar);
                _myDbContext.SaveChanges();
            }

            return usuarioActualizar;
        }

        public void DeleteUsuario(int id)
        {
            var usuarioEliminar = _myDbContext.Usuario.Find(id);
            if (usuarioEliminar != null)
            {
                _myDbContext.Usuario.Remove(usuarioEliminar);
                _myDbContext.SaveChanges();
            }
        }
    }
}