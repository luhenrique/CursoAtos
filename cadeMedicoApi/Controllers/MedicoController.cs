using System;
using System.Threading.Tasks;
using cadeMedicoApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace cadeMedicoApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class MedicoController : ControllerBase
    {
        private readonly IRepository _repo;

        public MedicoController(IRepository repo){
            _repo = repo;   
        }
        
        [HttpGet]
        public async Task<IActionResult> Get(){
            try{
                var result = await _repo.GetAllMedicoModelAsync(true);
                return Ok(result);
            }
            catch (Exception ex){
                return BadRequest($"Erro: {ex.Message}");
            }
        }
        [HttpGet("{MedicoId}")]
        public async Task<IActionResult> getByMedicoId(int MedicoId){
            try{
                var result = await  _repo.GetMedicoModelById(MedicoId, true);
                return Ok(result);
            }
            catch(Exception ex){
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("{especialidade/especialidadeId}")]
        public async Task<IActionResult> GetByEspecialidadeId(int especialidadeId){
            try{
                var result = await _repo.GetMedicoModelByEspecialidadeId(especialidadeId, true);
                return Ok(result);
            }
            catch(Exception ex){
                return BadRequest($"Erro: {ex.Message}");
            }
        }
    }
}