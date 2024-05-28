using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int id { get; set; }
        public string NombreDeUsuario { get; set; }
        public string Contraseña { get; set; }

        public  int clinicaId { get; set; }

        public Clinica? clinica { get; set; }

        public ExpedienteMedico? expedienteMedico { get; set; }

        public List<Rol>? roles { get; set; }
    }
}
