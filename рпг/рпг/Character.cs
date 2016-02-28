using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace рпг
{
    public class Character
    {
        public Character target;
        public int HP;
        public int MP;
        public int Damage;

        public void Attack()
        {
            target.HP -= this.Damage;
        }
    }
    
}
