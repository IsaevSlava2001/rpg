using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace рпг
{
    public class Palladin:Character
    {
        public override string Skill1()
        {
            if (this.MP >= 100)
            {
                target.Damage = target.Damage - (int)(target.Damage * 0.3);
                this.MP=this.MP-100;
                return "получилось";
            }
            else
            {
                return "Извините. У вас не хватает маны";
            }
        }
        public Palladin(int HP, int MP, int Damage)
        {
            this.Hp = HP;
            this.MP = MP;
            this.Damage = Damage;
        }
    }
}
