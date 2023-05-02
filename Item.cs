using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Proposel___AronKohl
{
    public interface IUsable
    {
        void Use();
    }
    public class Item : IUsable
    {
        string name { get; set; }
        string description { get; set; }
        string type { get; set; }

        public virtual void Use()
        {
            
        }
    }

    public class HealthItem : Item
    {
        public int HealingAmount { get; set; }

        public override void Use()
        {

        }
    }

    public class attackItem : Item
    {
        public int damage { get; set; }

        public override void Use()
        {

        }
    }
}
