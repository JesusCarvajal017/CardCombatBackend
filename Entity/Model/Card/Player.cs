using Entity.Model.Global;

namespace Entity.Model.Card
{
    public class Player : ABaseEntity
    {
        public string Name { get; set; }
        public int RoomId { get; set; }

        public Room Room { get; set; }
        public IEnumerable<MazoPlayer> MazoPlayer { get; set; }
        public IEnumerable<Move> Move { get; set; }
    }

}

