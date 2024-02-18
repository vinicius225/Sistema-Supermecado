using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema.Supermecado.Aplication.DTOs;
using Sistema.Supermecado.Aplication.Exepctions;
using Sistema.Supermecado.Aplication.Interfaces;

namespace Sistema.Supermecado.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {
        private readonly IAutenticacaoService _autenticacaoService;
        public AutenticacaoController(IAutenticacaoService autenticacaoService)
        {
            _autenticacaoService = autenticacaoService;
        }


        [HttpPost]
        public async Task<IActionResult> Logar(AutenticacaoPullDTO autenticacao)
        {
            try
            {
                return Ok(await _autenticacaoService.Logar(autenticacao));
            }catch(ExceptionsApp app)
            {
                return BadRequest(app.TipoErro.ToString());
            }
            catch (Exception ex)
            {
                return NotFound ();
            }
        }
    }
}
