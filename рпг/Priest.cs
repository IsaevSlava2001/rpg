using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace рпг
{
   public class Priest:Character
    {
       public override string Skill2()
       {
           if (this.MP >= 200)
           {
               target.Hp = (int)(target.Hp * 0.2);
               return "получилось";
           }
           else
           {
               return "Извините. У вас не хватет маны";
           }
       }
       public Priest(int HP, int MP, int damage)
        {
            this.Hp = HP;
            this.MP = MP;
            this.Damage = Damage;
        }
    }
}
