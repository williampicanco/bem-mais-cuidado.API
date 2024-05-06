using bem_mais_cuidado.API.Persistence;
using bem_mais_cuidado.API.Entities;
using bem_mais_cuidado.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bem_mais_cuidado.API.Controllers
{
    [Route("api/agendamentos")]
    [ApiController]
    public class AgendamentoController : ControllerBase
    {
        //** variável que só atualiza dentro do contrutor do controller.
        //** Injeção de Dependência
        private readonly MassoterapiaBemMaisCuidadoDbContext _context;
        public AgendamentoController(MassoterapiaBemMaisCuidadoDbContext context)
        {
            _context = context;
        }

        // api/agendamentos?search=casa&Date=2027-05-04
        //[HttpGet]
        //public IActionResult Get(string search, DateTime dataInicial, DateTime dataFinal) 
        //{
        //    //** Os Agendamentos que não tenham reservas que estão sendo passados no parâmetro. Elinam as agendamentos que tenham reservas conflitando.

        //    //var agendasDisponiveis = _context
        //    //    .Agendamentos
        //    //    .Where(ag =>
        //    //        ag.Titulo.Contains(search) &&
        //    //        !ag.IdAgendamentoBemMaisCuidado.Any(agend =>
        //    //        (dataInicial >= agend.DataIncio && dataInicial <= agend.DataFinal) //** dt inical não pode estar em um intervalo de reservas OU
        //    //        (dataFinal >= agend.DataInicio && dataFinal <= agend.DataFinal) || //** dt final também não pode estar em um período de reservas atual
        //    //        (dataInicial <= agend.DataInicio && dataFinal >= agend.DataFinal)) //** dt incial é menor  que alguma dt incial de alguma reservba e a dt final seja maior que a dt final. Ela pode estar Antes ou Depois.
        //    //        && !ag.IsDeleted);                                                 //** não esteja deletado

        //    //    return Ok(agendasDisponiveis);
        //    return Ok();
        //}

        //GET api/agendamentos/12548651 
       


        //GET api/agendamentos 
        [HttpGet]
        public IActionResult GetAll()
        {
            var Agendamentos = _context.Agendamentos.Where(a => !a.IsDeleted).ToList();
            
            return Ok(Agendamentos);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var agendamento = _context.Agendamentos
                .SingleOrDefault(a => a.IdAgendamentoBemMaisCuidado == id);

            if (agendamento == null)
            {
                return NotFound();
            }
            return Ok(agendamento);
        }

        //POST api/agendamentos
        [HttpPost]
        public IActionResult Post(AgendamentoBemMaisCuidado agendamentoBemMaisCuidado)
        {
            _context.Agendamentos.Add(agendamentoBemMaisCuidado);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = agendamentoBemMaisCuidado.Id }, agendamentoBemMaisCuidado);
        }

        //PUT api/agendamentos/1246789 
        [HttpPut("{id}")]
        public IActionResult Editar(Guid id, AgendamentoBemMaisCuidado input)
        {
            var agendamento = _context.Agendamentos.SingleOrDefault(a => a.IdAgendamentoBemMaisCuidado == id);

            if (agendamento == null)
            {
                return NotFound();
            }

            agendamento.Atualizar(input.HorarioInicial, input.HorarioFinal, input.Titulo);

            _context.Agendamentos.Update(agendamento);
            _context.SaveChanges();

            return NoContent();
        }

        // api/agendamentos/1246789 DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id, AgendamentoBemMaisCuidado agendamentoBemMaisCuidado)
        {
            var agendamento = _context.Agendamentos.SingleOrDefault(a => a.IdAgendamentoBemMaisCuidado == id);

            if (agendamento == null)
            {
                return NotFound();
            }

            agendamento.Apagar();

            _context.SaveChanges();

            return NoContent();
        }

    }
}
