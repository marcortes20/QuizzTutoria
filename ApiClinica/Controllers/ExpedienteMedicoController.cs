using Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicios.ExpedientesMedicos;

namespace ApiClinica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpedienteMedicoController : ControllerBase
    {
        public readonly ISvExpedienteMedico svExpediente;

        public ExpedienteMedicoController(ISvExpedienteMedico svExpediente)
        {
            this.svExpediente = svExpediente;
        }

        [HttpGet]
        public IEnumerable<ExpedienteMedico> GetAllExpedientes()
        {
            return svExpediente.GetAllExpedientesMedicos();
        }

        [HttpGet("{id}")]
        public ExpedienteMedico GetExpedienteById(int id)
        {
            return svExpediente.GetExpedienteMedicoById(id);
           
        }

        [HttpPost]
        public ExpedienteMedico AddExpediente([FromBody] ExpedienteMedico expediente)
        {
            return svExpediente.AddExpedienteMedico(expediente);
            
        }

        [HttpPut("{id}")]
        public ExpedienteMedico UpdateExpediente(int id, [FromBody] ExpedienteMedico expediente)
        {
            return svExpediente.UpdateExpedienteMedico(expediente, id);

        }

        [HttpDelete("{id}")]
        public void DeleteExpediente(int id)
        {
          
            svExpediente.DeleteExpedienteMedico(id);
         
        }
    }
}