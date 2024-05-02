using bem_mais_cuidado.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bem_mais_cuidado.API.Controllers
{
    [Route("api/massagem")]
    [ApiController]
    public class MassagemController : ControllerBase
    {
        public IEnumerable<Massagem> Massagens  = new List<Massagem>() {
            new Massagem(1),
            new Massagem(2),
            new Massagem(3),
         };

        // GET api/massagens
        [HttpGet]
        public IEnumerable<Massagem> Get()
        {

            return Massagens;
        }

        [HttpGet("{id}")]
        public Massagem Get(int id)
        {

            return Massagens.FirstOrDefault(mas => mas.Id == id);
        }

        [HttpPost]
        public IEnumerable<Massagem> Post(Massagem massagem) 
        {
            return Massagens.Append<Massagem>(massagem);
        }

        [HttpPut ("{id}")]
        public Massagem Put(int id, Massagem massagem)
        {
            return massagem;
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Meu primeiro método delete";
        }

    }
}
