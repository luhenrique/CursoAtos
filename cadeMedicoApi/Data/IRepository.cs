using System.Threading.Tasks;
using cadeMedicoApi.Models;

namespace cadeMedicoApi.Data
{
    //INTERFACE NÃO IMPLEMENTA METODOS, APENAS ASSINATURAS  
    public interface IRepository
    {
         void Add<T>(T entity) where T : class;
         void Update<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveChangesAsync();


        //MEDICO
        Task<MedicoModel[]> GetAllMedicoModelAsync(bool includeMedico);
        Task<MedicoModel[]> GetMedicoModelByEspecialidadeId(int EspecialidadeId, bool includeEspecialidade);
        Task<MedicoModel> GetMedicoModelById(int medicoId, bool includeCidade);
    }
}