using bem_mais_cuidado.API.Enums;

namespace bem_mais_cuidado.API.Entities
{
    /// <summary>
    /// ** AGENDAMENTO DE MASSAGENS
    /// </summary>
    public class AgendamentoBemMaisCuidado : BaseEntity
    {
        public AgendamentoBemMaisCuidado()
        {
            IsDeleted = false;
        }
        public Guid IdAgendamentoBemMaisCuidado { get; set; }
        public Guid IdAgendaBemMaisCuidado { get; set; }
        public DateTime HorarioInicial { get; set; }
        public DateTime HorarioFinal { get; set; }
        public Guid IdColaboradorBemMaisCuidado { get; set; }
        public bool Ativo { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public int ResponsavelCriacao { get; set; }
        public int ResponsavelAtualizacao { get; set; }
        public string Titulo { get; set; } // adicionado a mais 

        //public StatusAgendamentoMassagem Status { get; set; } --> talvez precise

        public void Atualizar(DateTime horarioInicial, DateTime horarioFinal, string titulo) 
        {
            HorarioInicial = horarioInicial;
            HorarioFinal = horarioFinal;
            Titulo = titulo;
        }

        public void Apagar()
        {
            IsDeleted = true;
        }
    }
}
