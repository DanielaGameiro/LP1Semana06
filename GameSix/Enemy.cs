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
        private static int powerUpCount;

        // Construtor
        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        static Enemy()
        {
            powerUpCount = 0;
        }

        public static int GetPowerUpCount() => powerUpCount;

        public void SetName(string name)
        {
            this.name = name.Trim();
        }

        public string GetName() => name;
        public float GetHealth() => health;
        public float GetShield() => shield;

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

        public void PickupPowerUp(PowerUp powerUp, float gain)
        {
            powerUpCount++;

            if (powerUp == PowerUp.Health)
            {
                health += gain;
                if (health > 100) health = 100;
            }
            else if (powerUp == PowerUp.Shield)
            {
                shield += gain;
                if (shield > 100) shield = 100;
            }
        }
    }
}