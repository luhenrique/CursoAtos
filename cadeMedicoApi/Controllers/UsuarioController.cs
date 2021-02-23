using System;
using System.Threading.Tasks;
using cadeMedicoApi.Data;
using cadeMedicoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace cadeMedicoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IRepository _repo;
        public UsuarioController(IRepository repo){
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get(){

            try{
                var result = await _repo.GetAllUsuarioModelAsync();
                return Ok(result);
            }catch(Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

    }
}
