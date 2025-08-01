using Entity.Model.Global;

namespace Entity.Model.Card
{
    public class Round : ABaseEntity
    {
        public int Number { get; set; }
        public int End { get; set; }
        public int RoomId { get; set; }

        public Room Room { get; set; }
        public IEnumerable<Move> Move { get; set; }
    }

}

