using Entity.Model.Global;

namespace Entity.Model.Card
{
    public class MazoPlayer : ABaseEntity
    {
        public int CardId { get; set; }
        public int PlayerId { get; set; }
        public bool Use { get; set; }

        public Player Player { get; set; }
        public Cards Card { get; set; }
    }

}

