using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWallet.Domain.Commands;
using MyWallet.Domain.Commands.Lancamento;

namespace MyWallet_API.Controllers
{
    [ApiController]
    [Route("v1/Lancamentos")]
    public class LancamentoController : ControllerBase
    {

        [HttpPost]
        [Route("")]
        [AllowAnonymous]
        public IResult PostCriarLancamento([FromServices] IMediator mediator, [FromBody] CriarLancamentoRequest command)
        {
            var res = mediator.Send(command);
            
            return Results.Ok(res);
        }

        [HttpPost]
        [Route("Teste")]
        [AllowAnonymous]
        public IResult Teste([FromServices] IMediator mediator, [FromBody] string command)
        {
            return Results.Ok("Chegou");
        }

       

    }
}

