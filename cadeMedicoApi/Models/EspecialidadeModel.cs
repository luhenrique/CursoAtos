namespace cadeMedicoApi.Models
{

    public class EspecialidadeModel
    {
        public EspecialidadeModel()
        { }
        public EspecialidadeModel(int id, string nome, MedicoModel medico)
        {
            this.Id = id;
            this.Nome = nome;
            this.Medico = medico;

        }
        public int Id { get; set; }
        public string Nome { get; set; }

        public MedicoModel Medico { get; set; }
    }
}