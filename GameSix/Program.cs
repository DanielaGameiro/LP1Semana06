using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis
            int numEnemies;
            Enemy[] enemies;

            // Pedir ao utilizador o número de inimigos
            Console.Write("Number of enemies: ");
            numEnemies = int.Parse(Console.ReadLine());

            // Pedir o utilizador o nome para casa inimigo e guardá-lo num array
            enemies = new Enemy[numEnemies];

            for (int i = 0; i < numEnemies; i++)
            {
                string name;

                Console.Write($"Name of enemy #{i}: ");
                name = Console.ReadLine();

                enemies[i] = new Enemy(name);
            }

            // Imprimir o(s) nome(s)
            foreach (Enemy enemy in enemies)
            {
                Console.WriteLine($">>>{enemy.GetName()}<<<");
            }
        }
    }
}
