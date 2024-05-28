using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Servicios.MyDbContext;


namespace Servicios.Clinicas
{
    public class SvClinica : ISvClinica
    {
        private MyContext myDbContext= default!; 
        public SvClinica()
        {
            myDbContext = new MyContext();
        }
        public Clinica AddClinic(Clinica clinica)
        {
            myDbContext.Clinica.Add(clinica);
            myDbContext.SaveChanges();
           return clinica;
        }

        public void DeleteClinic(int id)
        {
           Clinica clinicaEliminar =  myDbContext.Clinica.Find(id);
            if (clinicaEliminar != null)
            {
                myDbContext.Clinica.Remove(clinicaEliminar);
                myDbContext.SaveChanges();
            }
            
        }

        public List<Clinica> GetAllClinic()
        {
            return myDbContext.Clinica.Include(x=> x.usiarios).ThenInclude(x=>x.expedienteMedico).ToList();
        }

        public Clinica UpdateClinic(Clinica clinica, int id)
        {

            Clinica clinicaActualizar = myDbContext.Clinica.Find(id);

            if (clinicaActualizar is not null)
            {
                clinicaActualizar.Nombre = clinica.Nombre;
          
                myDbContext.Clinica.Update(clinicaActualizar);
                myDbContext.SaveChanges();

            }
            return clinicaActualizar;
        }
    }
}
