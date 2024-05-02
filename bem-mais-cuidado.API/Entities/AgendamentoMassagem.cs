using bem_mais_cuidado.API.Enums;

namespace bem_mais_cuidado.API.Entities
{
    public class AgendamentoMassagem : BaseEntity
    {
        public AgendamentoMassagem(string nomeColaborador, string lotacao, string horario, int responsavelCriacao)
            : base()
        {
            NomeColaborador = nomeColaborador; 
            Lotacao = lotacao;
            Horario = horario;
            ResponsavelCriacao = responsavelCriacao;
        }

        public int IdAgendamentoMassagem { get; private set; }
        public string NomeColaborador { get; private set; }
        public string Lotacao { get; private set; }
        public Local Local { get; private set; }
        public string Horario { get; private set; }
        public int ResponsavelCriacao { get; private set; }
        public Usuario Usuario { get; private set; } // prop. de navegação
        public StatusAgendamentoMassagem Status { get; private set; }


    }
}
