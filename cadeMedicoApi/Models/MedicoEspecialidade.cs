namespace cadeMedicoApi.Models
{
    public class MedicoEspecialidade
    {
        public MedicoEspecialidade()
        {

        }
        public MedicoEspecialidade(int medicoId, int especialidadeId)
        {
            this.MedicoId = medicoId;
            this.EspecialidadeId = especialidadeId;

        }
        public int MedicoId { get; set; }
        public int EspecialidadeId { get; set; }
        public MedicoModel medico { get; set; }
        public EspecialidadeModel especialidade { get; set; }
    }
}