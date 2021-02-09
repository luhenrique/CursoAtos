namespace cadeMedicoApi.Models
{
    public class MedicoEspecialidade
    {
        public MedicoEspecialidade()
        {  }
        public MedicoEspecialidade(int MedicoId, int EspecialidadeId)
        {
            this.MedicoId = MedicoId;
            this.EspecialidadeId = EspecialidadeId;
        }
        public int MedicoId { get; set; }
        public int EspecialidadeId { get; set; }
        public MedicoModel Medico { get; set; }
        public EspecialidadeModel Especialidade { get; set; }
    }
}