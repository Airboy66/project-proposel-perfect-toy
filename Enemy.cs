using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Proposel___AronKohl
{
    public class Enemy : Player
    {
        public int strength { get; set; }
        public string location { get; set; }

        public void move(int direction)
        {
            throw new NotImplementedException();
        }

        public void attack(Player player)
        {
            throw new NotImplementedException();
        }
    }

    public class Puppet : Enemy
    {
        public Puppet(int location)
        {
            strength = 5;
        }
    }
}
