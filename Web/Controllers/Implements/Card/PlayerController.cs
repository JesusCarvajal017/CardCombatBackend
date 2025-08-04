using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Card;
using Entity.Model.Card;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Design.Internal;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Card
{
    public class PlayerController
       : GenericController<
       Player,
       PlayerDto,
       PlayerDto>
    {

        protected readonly IQueryPlayerServices _services;

        public PlayerController(
            IQueryPlayerServices q,
            ICommandService<Player, PlayerDto> c)
          : base(q, c) {
            _services = q;
        }


        [HttpGet("PlayersRoom/{id}")]
        public async Task<IActionResult> GetCardRound(int id)
        {
            var dataMove = await _services.GetPlayersRoom(id);


            return Ok(dataMove);
        }
    }

}
