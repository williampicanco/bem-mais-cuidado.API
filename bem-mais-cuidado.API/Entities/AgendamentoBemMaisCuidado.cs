using bem_mais_cuidado.API.Enums;

namespace bem_mais_cuidado.API.Entities
{
    public class AgendamentoBemMaisCuidado : BaseEntity
    {
        public AgendamentoBemMaisCuidado()
        {
            estaApagado = false;
        }
        public Guid IdAgendamentoBemMaisCuidado { get; set; }
        public Guid IdAgendaBemMaisCuidado { get; set; }
        public DateTime HorarioInicial { get; set; }
        public DateTime HorarioFinal { get; set; }
        public Guid IdColaboradorBemMaisCuidado { get; set; }
        public bool Ativo { get; set; }
        public bool estaApagado { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public int ResponsavelCriacao { get; set; }
        public int ResponsavelAtualizacao { get; set; }
        public Usuario Usuario { get; set; } // prop. de navegação
        //public StatusAgendamentoMassagem Status { get; set; }

        public void Atualizar(DateTime horarioInicial, DateTime horarioFinal ) 
        {
            HorarioInicial = horarioInicial;
            HorarioFinal = horarioFinal;
        }

        public void Apagar()
        {
            estaApagado = true;
        }
    }
}
