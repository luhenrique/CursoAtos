namespace cadeMedicoApi.Models
{
    public class MedicoModel
    {

        public MedicoModel() { }


        public MedicoModel(int id, string nome, string especialidade, string crm, string telefone)
        {
            this.id = id;
            this.nome = nome;
            this.especialidade = especialidade;
            this.crm = crm;
            this.telefone = telefone;

        }
        public int id { get; set; }
        public string nome { get; set; }
        public string especialidade { get; set; }
        public string crm { get; set; }
        public string telefone { get; set; }

    }
}