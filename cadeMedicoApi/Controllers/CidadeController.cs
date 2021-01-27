using System;
using Microsoft.AspNetCore.Mvc;

namespace cadeMedicoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CidadeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAction(){
            try{

                return Ok("Tamo funcionado! :D");
            }
            catch (Exception ex){
                return BadRequest($"Erro:{ex.Message}");
            }
        }
    }
}