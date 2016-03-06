using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace рпг
{
    public class Character
    {
        public Character target;
        private int hp;

        public int Hp
        {
            get { return hp; }
            //set { hp = value; }
            set
            {
                if (value < 0)
                { hp = 0; }
                else
                { hp = value; }
            }
        }
        private int mP;

        public int MP
        {
            get { return mP; }
            set {

                if (value < 0)
                { mP = 0; }
                else
                { mP = value; }
            }
        }

        private int damage;

        public int Damage
        {
            get { return damage; }
            set
            {

                if (value < 0)
                {damage = 0; }
                else
                { damage = value; }
            }
        }

        public void Attack()
        {
            target.Hp -= this.Damage;
        }
    }
    
}
