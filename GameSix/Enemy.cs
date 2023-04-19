using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSix
{
    public class Enemy // class Foe
    {
        // Variáveis
        private string name;
        private float health;
        private float shield;

        // Construtor
        public Enemy(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }
    }
}