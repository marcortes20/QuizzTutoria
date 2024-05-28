using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Servicios.Clinicas
{
    public interface ISvClinica
    {
        List<Clinica> GetAllClinic();
        Clinica AddClinic(Clinica clinica);
        Clinica UpdateClinic(Clinica clinica, int id);
        void DeleteClinic(int id);
    }
}
