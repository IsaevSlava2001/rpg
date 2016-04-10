using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace рпг
{
    public class Rogue:Character
    {
        public override string Skill3()
        {
            if (this.MP >= 150)
            {
                this.Damage = this.Damage + (int)(this.Damage * 0.4);
                return "получилось";
            }
            else
            {
                return "Извините. у вас не хватает маны";
            }
        }
        public Rogue(int HP, int MP, int damage)
        {
            this.Hp = HP;
            this.MP = MP;
            this.Damage = Damage;
        }
    }
}
