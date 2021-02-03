namespace cadeMedicoApi.Models
{
    public class CidadeModel
    {
        public CidadeModel()
        {}
        public CidadeModel(int id, string nome, string estado)
        {
            this.Id = id;
            this.Nome = nome;
            this.Estado = estado;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Estado { get; set; }



    }
}