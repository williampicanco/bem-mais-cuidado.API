using bem_mais_cuidado.API.Entities;
using bem_mais_cuidado.API.Models;
using Microsoft.EntityFrameworkCore;

namespace bem_mais_cuidado.API.Data
{
    public class AgendamentoBemMaisCuidadoDbContext 
    {
        public List<AgendamentoBemMaisCuidado> AgendamentosBemMaisCuidado { get; set; }

        public AgendamentoBemMaisCuidadoDbContext()
        {
            AgendamentosBemMaisCuidado = new List<AgendamentoBemMaisCuidado>();
        }

    }
}
