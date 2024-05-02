namespace bem_mais_cuidado.API.Entities
{
    public class Local
    {
    // ID_LOCAL_ATIVIDADE_BEM_MAIS_CUIDADO UNIQUEIDENTIFIER PRIMARY KEY NOT NULL DEFAULT NEWID(),
	// DESC_LOCAL_ATIVIDADE_BEM_MAIS_CUIDADO VARCHAR(255) NOT NULL,
    // ATIVO BIT NOT NULL, 
        public int IdLocalMassagem { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}
