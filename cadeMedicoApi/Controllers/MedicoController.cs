using System;
using Microsoft.AspNetCore.Mvc;

namespace cadeMedicoApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MedicoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAction(){
            try{ //Bloco protegido, caso ocorra algum problema 
                    //o programa é desviado para catch

                  return Ok("Tamo funcionando");  

            }catch (Exception ex){
                return BadRequest($"Erro: {ex.Message}");
            }
        }
        
    }
}