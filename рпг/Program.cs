using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace рпг
{
    class Program
    {
        
         static Character Palladin1 = new Palladin(800, 400, 80);
          static  Character Palladin2 = new Palladin(800, 400, 80);
           static Character Priest1 = new Priest(400, 900, 30);
           static Character Priest2 = new Priest(400, 900, 30);
           static Character Shaman1 = new Shaman(500, 700, 50);
           static Character Shaman2 = new Shaman(500, 700, 50);
           static Character Rogue1 = new Rogue(360, 500, 100);
           static Character Rogue2 = new Rogue(360, 500, 100);
          static List<Character> AllCharacters = new List<Character>();
        static void Main(string[] args)
        {
           
            
            AllCharacters.Add(Palladin1);
            AllCharacters.Add(Palladin2);
            AllCharacters.Add(Priest1);
            AllCharacters.Add(Priest2);
            AllCharacters.Add(Shaman1);
            AllCharacters.Add(Shaman2);
            AllCharacters.Add(Rogue1);
            AllCharacters.Add(Rogue2);
            
            //while(Palladin1.HP!=0)
            //{    if (Palladin1.HP==0)
            //{
            Console.WriteLine("Кем будете бить?\n1:Палладин\n2:Жрец\n3:Шаман\n4:Разбойник");
            string a = Console.ReadLine();
            switch (a)
            {
                case "1":
                    Console.Clear();
                    Check(Palladin1);
                   
                    break;
                case "2":
                     Console.Clear();
                     Check(Priest1);
                   
                    break;
                case "3":
                     Console.Clear();
                    Check(Shaman1);
                    
                    break;
                case "4":
                     Console.Clear();
                    Check(Rogue1);
                   
                    break;

            }
            
            Console.ReadLine();
        }
        static void Check(Character Agressor)
        {
            Console.WriteLine("Кого будете бить?\n1:Палладин\n2:Жрец\n3:Шаман\n4:Разбойник");
            string b = Console.ReadLine();
            switch (b)
            {
                case "1":
                    Console.Clear();
                    Agressor.target = Palladin2;
                    Agressor.Attack();
                    Log.Update(AllCharacters);
                    Player2();

                    break;
                case "2":
                    Console.Clear();
                     Agressor.target = Priest2;
                    Agressor.Attack();
                    Log.Update(AllCharacters);
                    Player2();

                    break;
                case "3":
                    Console.Clear();
                     Agressor.target = Shaman2;
                    Agressor.Attack();
                    Log.Update(AllCharacters);
                    Player2();

                    break;
                case "4":
                    Console.Clear();
                     Agressor.target = Rogue2;
                    Agressor.Attack();
                    Log.Update(AllCharacters);
                    Player2();

                    break;

            }

        }

         static void Player2()
        {
            Console.WriteLine("Кем будете бить?\n1:Палладин\n2:Жрец\n3:Шаман\n4:Разбойник");
            string a = Console.ReadLine();
            switch (a)
            {
                case "1":
                    Console.Clear();
                    Check2(Palladin2);

                    break;
                case "2":
                    Console.Clear();
                    Check2(Priest2);

                    break;
                case "3":
                    Console.Clear();
                    Check2(Shaman2);

                    break;
                case "4":
                    Console.Clear();
                    Check2(Rogue2);

                    break;

            }

            Console.ReadLine();
        }
         static void Check2(Character Agressor)
         {
             Console.WriteLine("Кого будете бить?\n1:Палладин\n2:Жрец\n3:Шаман\n4:Разбойник");
             string b = Console.ReadLine();
             switch (b)
             {
                 case "1":
                     Console.Clear();
                     Agressor.target = Palladin1;
                     Agressor.Attack();
                     Log.Update(AllCharacters);
                     

                     break;
                 case "2":
                     Console.Clear();
                     Agressor.target = Priest1;
                     Agressor.Attack();
                     Log.Update(AllCharacters);
                     

                     break;
                 case "3":
                     Console.Clear();
                     Agressor.target = Shaman1;
                     Agressor.Attack();
                     Log.Update(AllCharacters);
                     

                     break;
                 case "4":
                     Console.Clear();
                     Agressor.target = Rogue1;
                     Agressor.Attack();
                     Log.Update(AllCharacters);
                     

                     break;

             }

        }
    }

       

        }
    


