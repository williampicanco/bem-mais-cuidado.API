namespace bem_mais_cuidado.API.Entities
{
    public class ColaboradorBemMaisCuidado : BaseEntity
    {
        public ColaboradorBemMaisCuidado(Guid idColaboradorBemMaisCuidado, string nomeColaborador, string cpfColaborador, string lotacao, bool ativo)
            : base()
        {
            IdColaboradorBemMaisCuidado = idColaboradorBemMaisCuidado;
            NomeColaborador = nomeColaborador;
            CpfColaborador = cpfColaborador;
            Lotacao = lotacao;
            Ativo = ativo;
         
        }

        public Guid IdColaboradorBemMaisCuidado { get; set; }
        public string NomeColaborador { get; set; }
        public string CpfColaborador { get; set; }
        public string Lotacao { get; set; }
        public Guid IdEmpresaBemMaisCuidado { get; set; }
        public bool Ativo { get; set; }
    }
}
