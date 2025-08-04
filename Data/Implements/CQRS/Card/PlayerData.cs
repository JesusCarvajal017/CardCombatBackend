using Data.Implements.Querys;
using Data.Interfaces.Group.Querys;
using Entity.Context.Main;
using Entity.Model.Card;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Data.Implements.CQRS.Card
{
    public class PlayerData : BaseGenericQuerysData<Player>, IQuerysPlayer
    {
        protected readonly ILogger<PlayerData> _logger;
        protected readonly AplicationDbContext _dbContext;

        public PlayerData(ILogger<PlayerData> logger, AplicationDbContext dbContext) : base(dbContext, logger)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Player>> QueryPlayerRoom(int RoomId)
        {
            try
            {
                var model = await _dbContext.Player
                    .Where(ur=> ur.RoomId == RoomId)
                    .ToListAsync();

                _logger.LogInformation("Consulta de la enidad {Entity} se realizo exitosamente", typeof(Player).Name);
                return model;
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, "Error en la consulta la entidad {Entity}", typeof(Player).Name);
                throw;
            }
        }

       



    }
}
