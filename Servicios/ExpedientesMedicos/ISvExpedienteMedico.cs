using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.ExpedientesMedicos
{
    public interface ISvExpedienteMedico
    {
        List<ExpedienteMedico> GetAllExpedientesMedicos();
        ExpedienteMedico GetExpedienteMedicoById(int id);
        ExpedienteMedico AddExpedienteMedico(ExpedienteMedico expedienteMedico);
        ExpedienteMedico UpdateExpedienteMedico(ExpedienteMedico expedienteMedico, int id);
        void DeleteExpedienteMedico(int id);
    }
}
