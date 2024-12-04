using System;

namespace RoguelikeGame
{
    public class Player
    {
        public int XP = 5;
        public int MaxHealth = 5;
        public int arm = 5;
        public int MaxArm = 5;
        public int Level = 1;
        public int Gold = 0;
        public int Str = 3;
        public int MaxStr = 3;
        public int Exp = 0;
        public int MaxExp = 10;


        public int X { get; set; } = 1; // Начальная позиция по X
        public int Y { get; set; } = 1; // Начальная позиция по Y
        public int PreviousX { get; set; } = 1; // Предыдущее положение по X
        public int PreviousY { get; set; } = 1; // Предыдущее положение по Y

        public int newX;
        public int newY;

        public void Check()
        {
            if (Exp > 15 && Exp < 20)
            {
                MaxHealth=10 ;
                MaxExp = 15;
                Level = 2;

            }
            if (Exp > 20 && Exp < 25)
            {
                MaxHealth = 15;
                MaxExp = 20;
                Level = 3;

            }
            if (Exp > 25 && Exp < 30)
            {
                MaxHealth = 20;
                MaxExp = 25 ;
                Level = 4;

            }
            if (Exp > 30 && Exp < 35)
            {
                MaxHealth = 25;
                MaxExp = 30;
                Level = 5;

            }



        }
        public void Move(ConsoleKey key, char[,] map)
        {
            PreviousX = X;
            PreviousY = Y;

            newX = X;
            newY = Y;

            switch (key)
            {
                case ConsoleKey.W: // Вверх
                    newY--;
                    break;
                case ConsoleKey.A: // Влево
                    newX--;
                    break;
                case ConsoleKey.S: // Вниз
                    newY++;
                    break;
                case ConsoleKey.D: // Вправо
                    newX++;
                    break;
            }

            // Проверяем, не выходит ли игрок за пределы карты и не сталкивается ли с стенами или коридорами
            if (map[newX, newY] != '#' )
            {


               X = newX;
               Y = newY;
            }
        }
    }
}
