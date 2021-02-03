namespace cadeMedicoApi.Models
{
    public class MedicoModel
    {

        public MedicoModel() { }


        public MedicoModel(int id, string nome, int especialidade, string crm, string telefone, int cidade)
        {
            this.Id = id;
            this.Nome = nome;
            this.EspecialidadeId = especialidade;
            this.Crm = crm;
            this.Telefone = telefone;
            this.CidadeId = cidade;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EspecialidadeId { get; set; }
        public string Crm { get; set; }
        public string Telefone { get; set; }
        public int CidadeId { get; set; }

    }
}