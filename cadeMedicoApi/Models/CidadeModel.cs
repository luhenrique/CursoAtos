namespace cadeMedicoApi.Models
{
    public class CidadeModel
    {
        public CidadeModel()
        {}
        public CidadeModel(int id, int nome, int estado)
        {
            this.id = id;
            this.nome = nome;
            this.estado = estado;

        }
        public int id { get; set; }
        public int nome { get; set; }
        public int estado { get; set; }



    }
}