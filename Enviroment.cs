using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Proposel___AronKohl
{
    public abstract class Enviroment
    {
        public string Name { get; set; }
        
        public string Description { get; set; }

        public string Interact { get; set; }

        public abstract void Inter(Player player);
    }

    public class Room : Enviroment
    {
        public override void Inter(Player player)
        {

        }
    }

    public class Puzzle : Enviroment
    {
        public override void Inter(Player player)
        {

        }
    }
}
