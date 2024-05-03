using bem_mais_cuidado.API.Data;
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
        private readonly AgendamentoBemMaisCuidadoDbContext _context;
        public AgendamentoController(AgendamentoBemMaisCuidadoDbContext context)
        {
            _context = context;
        }

        // api/agendamentos GET
        [HttpGet]
        public IActionResult BuscarTodos()
        {
            var AgendamentosBemMaisCuidado = _context.AgendamentosBemMaisCuidado.Where(a => !a .estaApagado).ToList();
            
            return Ok(AgendamentosBemMaisCuidado);
        }


        // api/agendamentos/12548651 GET
        [HttpGet("{id}")]
        public IActionResult BuscarPeloId(Guid id)
        {

            var AgendamentoBemMaisCuidado = _context.AgendamentosBemMaisCuidado.SingleOrDefault(a => a.IdAgendamentoBemMaisCuidado == id);

            if (AgendamentoBemMaisCuidado == null)
            {
                return NotFound();
            }
            return Ok(AgendamentoBemMaisCuidado);
        }

        // api/agendamentos/  POST
        [HttpPost]
        public IActionResult Post(AgendamentoBemMaisCuidado agendamentoBemMaisCuidado)
        {
            _context.AgendamentosBemMaisCuidado.Add(agendamentoBemMaisCuidado);

            return CreatedAtAction(nameof(BuscarPeloId), new { id = agendamentoBemMaisCuidado.Id }, agendamentoBemMaisCuidado);
        }

        // api/agendamentos/1246789 PUT
        [HttpPut ("{id}")]
        public IActionResult Editar(Guid id, AgendamentoBemMaisCuidado input)
        {
            var AgendamentoBemMaisCuidado = _context.AgendamentosBemMaisCuidado.SingleOrDefault(a => a.IdAgendamentoBemMaisCuidado == id);

            if (AgendamentoBemMaisCuidado == null)
            {
                return NotFound();
            }

            AgendamentoBemMaisCuidado.Atualizar(input.HorarioInicial, input.HorarioFinal);

            return NoContent();
        }

        // api/agendamentos/1246789 DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id, AgendamentoBemMaisCuidado agendamentoBemMaisCuidado)
        {
            var AgendamentoBemMaisCuidado = _context.AgendamentosBemMaisCuidado.SingleOrDefault(a => a.IdAgendamentoBemMaisCuidado == id);

            if (AgendamentoBemMaisCuidado == null)
            {
                return NotFound();
            }

            AgendamentoBemMaisCuidado.Apagar();

            return NoContent();
        }

    }
}
