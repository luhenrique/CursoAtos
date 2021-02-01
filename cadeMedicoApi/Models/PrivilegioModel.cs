namespace cadeMedicoApi.Models
{
    public class PrivilegioModel
    {
        public PrivilegioModel(){ }
        public PrivilegioModel(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}