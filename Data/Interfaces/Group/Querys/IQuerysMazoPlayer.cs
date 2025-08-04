using Entity.Model.Card;

namespace Data.Interfaces.Group.Querys
{

    /// <summary>
    /// Interfaz que me define los métodos de consultas comunes
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IQueryMazoPlayer : IQuerys<MazoPlayer>
    {
        Task<IEnumerable<MazoPlayer>> QueryCardsMazo(int PlayerId);

    }
}
