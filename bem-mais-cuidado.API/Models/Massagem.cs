namespace bem_mais_cuidado.API.Models
{
    public class Massagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Lotacao { get; set; }
        public string Local { get; set; }
        public string status { get; set; }

        public Massagem()
        {
            
        }
        public Massagem(int id)
        {
            Id = id;
        }

    }
}
