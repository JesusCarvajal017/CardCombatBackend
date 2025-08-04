using Entity.Model.Card;

namespace Data.Interfaces.Group.Querys
{

    /// <summary>
    /// Interfaz que me define los métodos de consultas comunes
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IQuerysPlayer : IQuerys<Player>
    {
        Task<IEnumerable<Player>> QueryPlayerRoom(int IdRound);
    }
}
