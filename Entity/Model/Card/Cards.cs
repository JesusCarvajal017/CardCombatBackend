using Entity.Model.Global;

namespace Entity.Model.Card
{
    public class Cards : ABaseEntity
    {
        public string Name { get; set; }
        public int Legenday { get; set; }
        public double Focer { get; set; }
        public double Speed { get; set; }
        public double Endurace { get; set; }
        public double SpecialPower { get; set; }
        public double Technique { get; set; }
        public double Brutality { get; set; }

        public IEnumerable<Move>  Move { get; set; }
        public IEnumerable<MazoPlayer>  MazoPlayer { get; set; }

    }

}

