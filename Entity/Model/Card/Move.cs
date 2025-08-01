using Entity.Model.Global;

namespace Entity.Model.Card
{
    public class Move : ABaseEntity
    {
        public int CardId { get; set; }
        public int PlayerId { get; set; }
        public int Result { get; set; }
        public int RoundId  { get; set; }

        public Cards Card { get; set; }
        public Player Player { get; set; }
        public Round Round { get; set; }
    }

}

