using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy1 = new Enemy("      Loki       ");
            Console.WriteLine(enemy1.GetName());
        }
    }
}
