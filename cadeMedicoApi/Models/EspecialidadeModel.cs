namespace cadeMedicoApi.Models
{

    public class EspecialidadeModel
    {
        public EspecialidadeModel()
        { }
        public EspecialidadeModel(int id, string nome)
        {
                this.Id = id;
                this.Nome = nome;

         }
        public int Id { get; set; }
        public string Nome { get; set; }

    }
}