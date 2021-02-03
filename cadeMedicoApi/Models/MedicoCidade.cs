namespace cadeMedicoApi.Models
{
    public class MedicoCidade
    {
        public MedicoCidade()
        {}
        public MedicoCidade(int medicoId, int cidadeId, MedicoModel medico, CidadeModel cidade)
        {
            this.MedicoId = medicoId;
            this.CidadeId = cidadeId;
            this.Medico = medico;
            this.Cidade = cidade;

        }
        public int MedicoId { get; set; }
        public int CidadeId { get; set; }
        public MedicoModel Medico { get; set; }
        public CidadeModel Cidade { get; set; }
    }
}