using System.Collections.Generic;

namespace cadeMedicoApi.Models
{
    public class MedicoModel
    {

        public MedicoModel() { }


        public MedicoModel(int id, string nome, string crm, string telefone)
        {
            this.Id = id;
            this.Nome = nome;
            this.Crm = crm;
            this.Telefone = telefone;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Crm { get; set; }
        public string Telefone { get; set; }

        public IEnumerable<MedicoCidade> MedicoCidade { get; set; }
        public IEnumerable<MedicoEspecialidade> MedicoEspecialidade{get; set;}

    }
}