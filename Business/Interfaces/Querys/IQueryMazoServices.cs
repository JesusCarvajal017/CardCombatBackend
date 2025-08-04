using Entity.Dtos.Card;
using Entity.Model.Card;

namespace Business.Interfaces.Querys
{
    public interface IQueryMazoServices : IQueryServices<MazoPlayer, MazoPlayerQueryDto>
    {
        Task<IEnumerable<MazoPlayerQueryDto>> GetByAllCardsService(int id);
    }
}
