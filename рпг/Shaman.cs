using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace рпг
{
   public class Shaman:Character
   {
       //public override string Skill5()
      // {
           
      // }
       public override string Skill4()
       {
           if (this.MP >= 200)
           {
               target.MP = target.MP + (int)(target.MP * 0.6);
               return "получилось";
           }
           else
           {
               return"Извините. У вас не хватает маны";
           }
       }
       public Shaman(int HP, int MP, int damage)
        {
            this.Hp = HP;
            this.MP = MP;
            this.Damage = Damage;
        }
    }
}
