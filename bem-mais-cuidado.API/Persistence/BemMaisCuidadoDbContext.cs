using bem_mais_cuidado.API.Models;
using Microsoft.EntityFrameworkCore;

namespace bem_mais_cuidado.API.Data
{
    public class BemMaisCuidadoDbContext : DbContext 
    {
        public DbSet<Massagem> Massagens { get; set; }
    }
}
