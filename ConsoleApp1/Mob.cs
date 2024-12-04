using System;

namespace RoguelikeGame
{
    public class Mob
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Mob(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(char[,] map)
        {
            Random rnd = new Random();
            int direction = rnd.Next(4); // 0 - вверх, 1 - вниз, 2 - влево, 3 - вправо

            int newX = X;
            int newY = Y;

            switch (direction)
            {
                case 0: // Вверх
                    newY--;
                    break;
                case 1: // Вниз
                    newY++;
                    break;
                case 2: // Влево
                    newX--;
                    break;
                case 3: // Вправо
                    newX++;
                    break;
            }

            // Проверяем, не выходит ли враг за пределы карты и не сталкивается ли со стенами
            if (map[newX, newY] != '#' && map[newX, newY] != '+')
            {
                X = newX;
                Y = newY;
            }


        }
    }
}
