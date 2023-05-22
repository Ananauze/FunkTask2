using System;
using System.Text;

namespace FunkTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            string symbolInBar = "#";
            string emptySymbol = "_";
            int percentsHealth = 75;
            int maxHealth = 20;

            Console.WriteLine("\nПривет! Давай нарисуем твой уровень здоровья!");
            Console.WriteLine("\nДержи братишка, твое здоровье:");

            DrawBar(percentsHealth, maxHealth, symbolInBar, emptySymbol);
            
            Console.ReadLine();
        }

        static void DrawBar(int percentHealth, int maxValue, string symbolInBar, string emptySymbol) 
        {
            string filledBar = "";
            int percents = 100;
            int value = maxValue * percentHealth / percents;

            filledBar = FillBar(0, value, symbolInBar);
             
            Console.Write("[" + filledBar);

            filledBar = FillBar(value, maxValue, emptySymbol);

            Console.Write($"{filledBar}]");
        }

        static string FillBar(int i, int value, string symbol) 
        {
            string temporaryString = "";
            
            for (int j = i; j < value; j++)
            {
                temporaryString += symbol;
            }

            return temporaryString;
        }
    }
}
