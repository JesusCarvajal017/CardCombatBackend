using Entity.Dtos.Global;

namespace Entity.Dtos.Card
{
    public class MazoPlayerQueryDto : ABaseDto
    {
        public int CardId { get; set; }
        public string CardName { get; set; }
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public bool Use { get; set; }
    }

}

