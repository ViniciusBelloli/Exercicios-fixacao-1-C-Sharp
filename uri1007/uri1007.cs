﻿using System;

namespace uri1007
{
   class uri1007
   {
      static void Main(string[] args)
      {

         int A, B, C, D, dif;

         A = int.Parse(Console.ReadLine());
         B = int.Parse(Console.ReadLine());
         C = int.Parse(Console.ReadLine());
         D = int.Parse(Console.ReadLine());

         dif = A * B - C * D;

         Console.WriteLine("DIFERENCA = " + dif);
      }
   }
}