﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace рпг
{
   public class Log
    {
       public static void Update(List<Character> AllCharacters)
       {
           Console.Clear();

           Console.WriteLine("-------");
           Console.WriteLine("Команда 1");
           Console.WriteLine("HP палладин," + AllCharacters[0].HP);
           Console.WriteLine("-------");
           Console.WriteLine("Команда 1");
           Console.WriteLine("HP Жрец," + AllCharacters[2].HP);
           Console.WriteLine("-------");
           Console.WriteLine("Команда 1");
           Console.WriteLine("HP Шаман," + AllCharacters[4].HP);
           Console.WriteLine("-------");
           Console.WriteLine("Команда 1");
           Console.WriteLine("HP Разбойник," + AllCharacters[6].HP);
           Console.WriteLine("-------");
           Console.WriteLine("Команда 2");
           Console.WriteLine("HP палладин," + AllCharacters[1].HP);
           Console.WriteLine("-------");
           Console.WriteLine("Команда 2");
           Console.WriteLine("HP Жрец," + AllCharacters[3].HP);
           Console.WriteLine("-------");
           Console.WriteLine("Команда 2");
           Console.WriteLine("HP Шаман," + AllCharacters[5].HP);
           Console.WriteLine("-------");
           Console.WriteLine("Команда 2");
           Console.WriteLine("HP Разбойник," + AllCharacters[7].HP);

       }
    }
}
