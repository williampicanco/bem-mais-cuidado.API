namespace bem_mais_cuidado.API.Entities
{

    public class AgendaBemMaisCuidado : BaseEntity
    {
        public Guid IdAgendaBemMaisCuidao { get; set; }
        public int IdColaborado { get; set; }
        public Guid IdLocalAtividadeBemMaisCuidado { get; set; }
        public Guid IdConfiguracaoAgendaBemMaisCuidado { get; set; }
        public int Mes { get; set; }
        public int DiaDaSemana { get; set; }
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }
        public DateTime HoraAlmocoInicial { get; set; }
        public DateTime HoraAlmocoFinal { get; set; }
        public int DuracaoSessao { get; set; }
        public string Status { get; set; }

    }

}
