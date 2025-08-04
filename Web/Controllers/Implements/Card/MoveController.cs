using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Card;
using Entity.Model.Card;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Card
{
    public class MoveController
       : GenericController<
       Move,
       MoveDto,
       MoveDto>
    {
        protected readonly IQueryCardRoundServices _services;

        public MoveController(
            IQueryCardRoundServices q,
            ICommandService<Move, MoveDto> c)
          : base(q, c) 
        {
            _services = q;
        }


        [HttpGet("RondaCartas/{id}")]
        public async Task<IActionResult> GetCardRound(int id)
        {
            var dataMove = await _services.GetCardsRound(id);
            Console.WriteLine(dataMove.Count());

            return Ok(dataMove);
        }
    }

}
