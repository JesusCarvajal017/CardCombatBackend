using Entity.Model.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Card
{
    public class User : ABaseEntity
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public IEnumerable<Room> Rooms { get; set; }
    }   
}
