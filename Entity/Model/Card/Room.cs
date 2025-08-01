using Entity.Model.Global;

namespace Entity.Model.Card
{
    public class Room : ABaseEntity
    {
        public int UserId { get; set; }
        public int AmountPlayer { get; set; }
        public string End { get; set; }

        public User User { get; set; }
        public IEnumerable<Player> Players { get; set; }
        public IEnumerable<Move> Rounds { get; set; }

    }

}

