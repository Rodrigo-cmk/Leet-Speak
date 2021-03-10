using System;

namespace Leet_Speak
{
    class Program
    {
        static void Main(string[] args)
        {




         Console.WriteLine();             
         Console.WriteLine();
         Console.ForegroundColor = ConsoleColor .Green;
         Console.WriteLine("----- Tradutor Leet Speak -----");
         Console.WriteLine("Por favor digite algo...");
         Console.ForegroundColor = ConsoleColor .White;
         Console.WriteLine();             
         Console.WriteLine();

         string traducao;

         Console.Write("-->  "); traducao = Console.ReadLine().Replace ("A","4").Replace("a","4") .Replace("E","3").Replace("e","3") .Replace("I","1") .Replace("i","1") .Replace("L","1") .Replace("l","1") .Replace("O","0") .Replace("o","0") .Replace("T","7") .Replace("t","7") .Replace("S","5") .Replace("s","5"); 
         
         Console.ForegroundColor = ConsoleColor .Green;
         Console.WriteLine("Tradução:");
         Console.ForegroundColor = ConsoleColor .White;
         Console.Write("-->  "); Console.Write(traducao);

         Console.WriteLine();             
         Console.WriteLine();












        }
    }
}
