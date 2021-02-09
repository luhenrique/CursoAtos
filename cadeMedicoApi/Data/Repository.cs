using System.Linq;
using System.Threading.Tasks;
using cadeMedicoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace cadeMedicoApi.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<MedicoModel[]> GetAllMedicoModelAsync(bool includeMedico = false){

            IQueryable<MedicoModel> query = _context.Medicos;
            if(includeMedico){
                query = query.Include(me => me.MedicoCidade)
                             .ThenInclude(mc => mc.Cidade);
            }
            query = query.AsNoTracking().OrderBy(m => m.Id);
            return await query.ToArrayAsync();

         }

        public async Task<MedicoModel[]> GetMedicoModelByEspecialidadeId(int EspecialidadeId, bool includeEspecialidade){

            IQueryable<MedicoModel> query = _context.Medicos;

            if(includeEspecialidade){
                query = query.Include( me => me.MedicoEspecialidade)
                             .ThenInclude(e => e.Especialidade);
            }

            query = query.AsNoTracking()
                         .OrderBy(medico => medico.Id)
                         .Where(medico => medico.MedicoEspecialidade.Any(me =>
                         me.EspecialidadeId == EspecialidadeId));
            
            return await query.ToArrayAsync();
        }

        public async Task<MedicoModel> GetMedicoModelById(int medicoId, bool includeCidade)
        {
            IQueryable<MedicoModel> query = _context.Medicos;
            if(includeCidade){
                query = query.AsNoTracking()
                        .Include(c => c.MedicoCidade)
                        .ThenInclude(mc => mc.Cidade);
            }
            query = query.AsTracking()
                    .OrderBy(medico => medico.Id)
                    .Where(medico => medico.Id == medicoId);

            return await query.FirstOrDefaultAsync();
        }
    }
}