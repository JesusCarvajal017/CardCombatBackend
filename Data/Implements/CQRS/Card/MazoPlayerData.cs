using Data.Implements.Querys;
using Data.Interfaces.Group.Querys;
using Entity.Context.Main;
using Entity.Model.Card;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Data.Implements.CQRS.Card
{
    public class MazoPlayerData : BaseGenericQuerysData<MazoPlayer>, IQueryMazoPlayer
    {
        protected readonly ILogger<MazoPlayerData> _logger;
        protected readonly AplicationDbContext _dbContext;

        public MazoPlayerData(ILogger<MazoPlayerData> logger, AplicationDbContext dbContext) : base(dbContext, logger)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public override async Task<IEnumerable<MazoPlayer>> QueryAllAsyn()
        {
            try
            {
                var model = await _dbContext.MazoPlayer
                    .Include(ur => ur.Player)
                    .Include(ur => ur.Card)
                    .ToListAsync();

                _logger.LogInformation("Consulta de la enidad {Entity} se realizo exitosamente", typeof(MazoPlayer).Name);
                return model;
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, "Error en la consulta la entidad {Entity}", typeof(MazoPlayer).Name);
                throw;
            }
        }

        public async Task<IEnumerable<MazoPlayer>> QueryCardsMazo(int PlayerId)
        {
            try
            {
                var query = _dbContext.MazoPlayer
                    .Include(ur => ur.Card)
                    .Where(ur => ur.PlayerId == PlayerId);

                var model = await query.ToListAsync();
               
                _logger.LogInformation("Consulta de la enidad {Entity} se realizo exitosamente", typeof(MazoPlayer).Name);
                return model;
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, "Error en la consulta la entidad {Entity}", typeof(MazoPlayer).Name);
                throw;
            }
        }



    }
}
