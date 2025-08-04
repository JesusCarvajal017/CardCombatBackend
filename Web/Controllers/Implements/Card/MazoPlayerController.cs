using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Card;
using Entity.Model.Card;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Card
{
    public class MazoPlayerController
       : GenericController<
       MazoPlayer,
       MazoPlayerQueryDto,
       MazoPlayerDto>
    {

        protected readonly IQueryMazoServices _services;

        public MazoPlayerController(
            IQueryMazoServices q,
            ICommandService<MazoPlayer, MazoPlayerDto> c)
          : base(q, c) {
            _services = q;
        }


        [HttpGet("cartasJugador/{id}")]
        public async Task<IActionResult> GetAllCardsId(int id)
        {
            var dataMove = await _services.GetByAllCardsService(id);
            return Ok(dataMove);
        }


    }

}
