using Entidades;
using Microsoft.EntityFrameworkCore;
using Servicios.MyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.ExpedientesMedicos
{
    public class SvExpedienteMedico : ISvExpedienteMedico
    {
        private MyContext _myDbContext = default!;

        public SvExpedienteMedico()
        {
            _myDbContext = new MyContext();
        }

        public List<ExpedienteMedico> GetAllExpedientesMedicos()
        {
            return _myDbContext.ExpedientesMedico.Include(x=>x.usuario).ToList();
        }

        public ExpedienteMedico GetExpedienteMedicoById(int id)
        {
            return _myDbContext.ExpedientesMedico.Include(x => x.usuario).FirstOrDefault(e => e.Id == id);
        }

        public ExpedienteMedico AddExpedienteMedico(ExpedienteMedico expedienteMedico)
        {
            _myDbContext.ExpedientesMedico.Add(expedienteMedico);
            _myDbContext.SaveChanges();
            return expedienteMedico;
        }

        public ExpedienteMedico UpdateExpedienteMedico(ExpedienteMedico expedienteMedico, int id)
        {
            var expedienteActualizar = _myDbContext.ExpedientesMedico.Find(id);

            if (expedienteActualizar is not null)
            {
                expedienteActualizar.HistorialClinico = expedienteMedico.HistorialClinico;
                expedienteActualizar.Alergias = expedienteMedico.Alergias;
                expedienteActualizar.GrupoSanguineo = expedienteMedico.GrupoSanguineo;
                expedienteActualizar.usuarioId = expedienteMedico.usuarioId;
           

                _myDbContext.ExpedientesMedico.Update(expedienteActualizar);
                _myDbContext.SaveChanges();
            }

            return expedienteActualizar;
        }

        public void DeleteExpedienteMedico(int id)
        {
            var expedienteEliminar = _myDbContext.ExpedientesMedico.Find(id);
            if (expedienteEliminar != null)
            {
                _myDbContext.ExpedientesMedico.Remove(expedienteEliminar);
                _myDbContext.SaveChanges();
            }
        }
    }
}
