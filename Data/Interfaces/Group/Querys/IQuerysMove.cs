using Entity.Model.Card;

namespace Data.Interfaces.Group.Querys
{

    /// <summary>
    /// Interfaz que me define los métodos de consultas comunes
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IQuerysMove : IQuerys<Move>
    {
        Task<IEnumerable<Move>> QueryMoveRound(int IdRound);
    }
}
