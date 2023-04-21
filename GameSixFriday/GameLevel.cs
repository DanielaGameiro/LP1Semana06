using System;

namespace GameSixFriday
{
    public class GameLevel
    {
        // Variáveis
        private Foe[,] foes;
        private int rooms;
        private Difficulty difficulty;

        // Construtor com o nº de rooms e dificuldade do nível
        public GameLevel(int rooms, Difficulty difficulty)
        {
            this.rooms = rooms;
            this.difficulty = difficulty;
            foes = new Foe[rooms, 1];
        }

        public void SetFoeInRoom(int room, Foe foe)
        {
            if (room >= 0 && room < rooms)
            {
                foes[room, 0] = foe;
            }
        }

        public Difficulty GetDifficulty() => difficulty;

        public int GetNumRooms() => rooms;

        public int GetNumFoes()
        {
            int count = 0;
            for (int i = 0; i < foes.GetLength(0); i++)
            {
                if (foes[i, 0] != null)
                {
                    count++;
                }
            }

            return count;
        }

        public void PrintFoes()
        {
            for (int i = 0; i < foes.GetLength(0); i++)
            {
                Foe foe = foes[i, 0];
                if (foe != null)
                    Console.WriteLine($"Room {i}: {foe.GetName()}");
            }
        }
    }
}