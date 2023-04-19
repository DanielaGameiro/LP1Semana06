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
            Random random = new Random();

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

                if (random.NextDouble() < 0.5) // 50% de apanhar 20 de shield
                {
                    enemies[i].PickupPowerUp(PowerUp.Shield, 20);
                }
                else
                {
                    enemies[i].TakeDamage(random.Next(100));
                }
            }

            // Imprimir o(s) nome(s)
            foreach (Enemy enemy in enemies)
            {
                Console.WriteLine($">>>{enemy.GetName()}<<< HP={enemy.GetHealth()} SHIELD={enemy.GetShield()}");
            }
        }
    }
}
