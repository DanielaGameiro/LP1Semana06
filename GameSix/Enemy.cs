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

        public string GetName() => name;

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }
    }
}