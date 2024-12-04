using RogueLike;
using System;
using System.Collections.Generic;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RoguelikeGame
{
    public class Map
    {
        private Random rnd = new Random();
        public int Width { get; private set; } // Ширина карты
        public int Height { get; private set; } // Высота карты
        private char[,] map;
        private char[,] result;
        private int KolKomnat = 0;
        private int KolHeart = 0;
        public bool isFight = false; 

   
        public List<Enemy> Enemies { get; private set; } // Список врагов
        public List<Mob> Mobs { get; private set; } // Список врагов
        public List<Heart> Hearts { get; private set; }

        public List<MiniBoss> MiniBosses { get; private set; }


        public Map(int width, int height)
        {
            Width = width;
            Height = height;
            map = new char[Width, Height];
            Enemies = new List<Enemy>();
            Hearts = new List<Heart>();
            Mobs = new List<Mob>();
            MiniBosses = new List<MiniBoss>();
        }

        

        public void GenerateMap()
         {
             // Заполняем карту стенами и коридорами
             for (int x = 0; x < Width; x++)
             {
                 for (int y = 0; y < Height; y++)
                 {
                     if (x == 0 || x == Width - 1 || y == 0 || y == Height - 1)
                     {
                         map[x, y] = '#'; // Стены
                     }
                     else
                     {
                         map[x, y] = '.'; // Пустые клетки
                     }
                 }
             }

             // Установка коридоров 
            
             int PlusRight = rnd.Next(1, Height - 4);
             map[Width - 1, PlusRight] = '+'; // Правый коридор
            
             int PlusDown = rnd.Next(1, Width - 1);
             map[PlusDown, Height - 1] = '+'; // Нижний коридор
            
             KolKomnat += 1;
         }

        public void GenerateNewMap(char[,] Array1, bool LeftUp, bool Up)
        {
            // Заполняем карту стенами и коридорами
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    if (x == 0 || x == Width - 1 || y == 0 || y == Height - 1)
                    {
                        Array1[x, y] = '#'; // Стены
                    }
                    else
                    {
                        Array1[x, y] = '.'; // Пустые клетки
                    }
                }
            }
            int PlusRight = rnd.Next(1, Height - 1);
            int PlusUp = rnd.Next(1, Width - 1);
            int PlusDown = rnd.Next(1, Width - 1);
            int PlusLeft = rnd.Next(1, Height - 1);
            if (KolKomnat < 6)
            {
                
                // Установка коридоров в каждом окне
                if (LeftUp)
                {
                    Array1[Width - 1, PlusRight] = '+'; // Правый коридор
                    if ((Console.CursorTop - 20) > 0) 
                    {
                        Array1[PlusUp , 0] = '+'; // Верхний коридор
                    }

                        if ((Console.CursorTop + Height + 4) < (25))
                    {
                        Array1[PlusDown, Height - 1] = '+'; // Нижний коридор
                    }

                }
                else
                {
                    if (Up)
                    {
                        Array1[0, PlusLeft] = '+'; // Левый коридор
                        //Array1[Width - 1, PlusRight] = '+'; // Правый коридор
                        if ((Console.CursorTop+Height+4) < 25)
                        {
                            Array1[PlusDown, Height - 1] = '+'; // Нижний коридор
                        }
                    }
                    else
                    {
                        //Array1[0, PlusLeft] = '+'; // Левый коридор
                        Array1[Width - 1, PlusRight] = '+'; // Правый коридор
                        if ((Console.CursorTop + Height + 4) < (25))
                        {
                            Array1[PlusDown, Height - 1] = '+'; // Нижний коридор
                        }
                    }                   
                }
            }
        }


        public void SpawnEnemies(int count)
        {
            for (int i = 0; i < count; i++)
            {
                int x, y;
                do
                {
                    x = rnd.Next(1, Width - 1);
                    y = rnd.Next(1, Height - 1);
                } while (map[x, y] != '.'); 

                Enemies.Add(new Enemy(x, y));
            }
        }

        public void SpawnMobs(int count)
        {
            for (int i = 0; i < count; i++)
            {
                int x, y;
                do
                {
                    x = rnd.Next(1, Width - 1);
                    y = rnd.Next(1, Height - 1);
                } while (map[x, y] != '.'); 

                Mobs.Add(new Mob(x, y));
            }
        }



        public void PutHeart(int count)
        {
            for (int i = 0; i < count; i++)
            {
                int x, y;
                do
                {
                    x = rnd.Next(1, Width - 1);
                    y = rnd.Next(1, Height - 1);
                } while (map[x, y] != '.');

                Hearts.Add(new Heart(x, y));
            }
        }

        

        public void CoridorRight(int x, int y,Player player)
        {
            for (int i = 0; i < map.GetLength(0); i++)
                for (int j = 0; j < map.GetLength(1); j++)
                    if (map[i, j] == '+')
                    {
                        map[i, j] = '#';
                    }
            KolKomnat += 1;
            
            int initialMapWidth = rnd.Next(10, 21); // Ширина от 10 до 20
            int initialMapHeight = rnd.Next(5, 11); // Высота от 5 до 10

           
            Width = initialMapWidth;
            Height = initialMapHeight;
            char[,] newArray = new char[map.GetLength(0) + 3 + Width+1, map.GetLength(1)+ Height];
            // Копируем элементы из старого массива в новый массив
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    newArray[i, j] = map[i, j];
                }
            }

            for (int i = 1; i <= 3; i++)
            {
                newArray[x + i, y - 1] = '#';
                newArray[x + i, y] = '.';
                newArray[x + i, y + 1] = '#';
            }
            newArray[x, y] = '.';
            
            
            char[,] Array1;


            Array1 = new char[Width, Height];
            GenerateNewMap(Array1, true, false);

            for (int i = 0; i < newArray.GetLength(0) ; i++)
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                    if (newArray[i, j] == '\0')
                    {
                        newArray[i, j] = ' ';
                    }
                   
                }
            }

            
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++) 
                {
                    newArray[x+4+i, y-1+j] = Array1[i,j];
                }
            }
            newArray[x + 4 , y ] ='.';

            RandomHeart();
            if (KolHeart == 1)
            {
                Hearts.Add(new Heart(x + 7, y));
            }

            int En = rnd.Next(1,3);

            for (int i = 1; i <= En; i++)
            {
                Enemies.Add(new Enemy(x + 8 + i, y+i));
            }

            int vermob = rnd.Next(1, 10);
            if (vermob <= 3)
            {
                Mobs.Add(new Mob(x + 6, y));
            }
           
            map = CleanMap(newArray);
                      
            DrawMap(player);
            ChekKolKomn();
            if (KolKomnat == 6)
            {
                MiniBosses.Add(new MiniBoss(x  + 6, y));
            }
        }

        public static char[,] CleanMap(char[,] arr)
        {
            int width = arr.GetLength(0);
            int height = arr.GetLength(1);
            int minX = width, minY = height, maxX = -1, maxY = -1;

            // Находим границы, где находятся не пустые символы
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (arr[x, y] != ' ') // Предполагаем, что пустой символ - это пробел
                    {
                        if (x < minX) minX = x;
                        if (x > maxX) maxX = x;
                        if (y < minY) minY = y;
                        if (y > maxY) maxY = y;
                    }
                }
            }

            // Если не найдено ни одного символа, возвращаем пустой массив
            if (maxX == -1 || maxY == -1)
            {
                return new char[0, 0];
            }

            // Создаем новый массив с уменьшенными размерами
            int newWidth = maxX - minX + 1;
            int newHeight = maxY - minY + 1;
            char[,] Map = new char[newWidth, newHeight];

            // Копируем данные в новый массив
            for (int x = 0; x < newWidth; x++)
            {
                for (int y = 0; y < newHeight; y++)
                {
                    Map[x, y] = arr[minX + x, minY + y];
                }
            }

            return Map;
        }

        public void RandomHeart()
        {


            int verheart = rnd.Next(1, 10);
            if (verheart > 3)
            {
                KolHeart = 1;
            }
            
        }
        
        public void ChekKolKomn()
        {
            if (KolKomnat == 6)
            {
                // Проходим по всем элементам массива
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        // Если текущий элемент равен целевому, заменяем его
                        if (map[i, j] == '+')
                        {
                            map[i, j] = '#';
                        }
                    }
                }
            }
            
        }

        public void CoridorDown(int x, int y, Player player)
        {   for (int i = 0;i < map.GetLength(0); i++)
                for (int j = 0;j < map.GetLength(1); j++)
                    if (map[i,j] == '+')
                    {
                        map[i, j] = '#';
                    }

            KolKomnat += 1;
            int initialMapWidth = rnd.Next(5, 20); // Ширина от 10 до 20
            int initialMapHeight = rnd.Next(5, 10); // Высота от 5 до 10
            Width = initialMapWidth;
            Height = initialMapHeight;
            char[,] newArray = new char[map.GetLength(0) + Width-2, map.GetLength(1) +3+ Height];

         

            // Копируем элементы из старого массива в новый массив
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    newArray[i, j] = map[i, j];
                }
            }
            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                    if (newArray[i, j] == '\0')
                    {
                        newArray[i, j] = ' ';
                    }

                }
            }

            for (int i = 1; i <= 3; i++)
            {
                newArray[x+1, y + i] = '#';
                newArray[x , y + i] = '.';
                newArray[x-1, y + i] = '#';
            }
           
            newArray[x, y] = '.';


            char[,] Array1;


            Array1 = new char[Width, Height];
            GenerateNewMap(Array1,false,false);

            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                    if (newArray[i, j] == '\0')
                    {
                        newArray[i, j] = ' ';
                    }

                }
            }

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {   
                    newArray[x-1+ i, y + 4+j] = Array1[i, j];
                }
            }
            newArray[x, y+4] = '.';

            RandomHeart();
            if (KolHeart == 1)
            {
                Hearts.Add(new Heart(x + 1, y+6));
            }
            KolHeart = 0;

            int En = rnd.Next(1, 3);

            for (int i = 1; i <= En; i++)
            {
                Enemies.Add(new Enemy(x + i, y + 5+i));
            }
            int vermob = rnd.Next(1, 10);
            if (vermob <= 3)
            {
                Mobs.Add(new Mob(x, y +6));
            }
            map = CleanMap(newArray);
            //map = new char[newArray.GetLength(0), newArray.GetLength(1)];
            //Array.Copy(newArray, map, newArray.Length);
            ChekKolKomn();
            if (KolKomnat == 6)
            {
                MiniBosses.Add(new MiniBoss(x , y + 6));
            }

        }

        public void CoridorUp(int x, int y, Player player)
        {
            KolKomnat += 1;
            int initialMapWidth = rnd.Next(5, 10); // Ширина от 10 до 20
            int initialMapHeight = rnd.Next(6, 8); // Высота от 5 до 10
            Width = initialMapWidth;
            Height = initialMapHeight;
            char[,] newArray = new char[map.GetLength(0), map.GetLength(1)];



            // Копируем элементы из старого массива в новый массив
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    newArray[i, j] = map[i, j];
                }
            }
            

            for (int i = 1; i <= 3; i++)
            {
                newArray[x + 1, y - i] = '#';
                newArray[x, y - i] = '.';
                newArray[x - 1, y - i] = '#';
            }

            newArray[x, y] = '.';


            char[,] Array1;


            Array1 = new char[Width, Height];
            GenerateNewMap(Array1, false, true);

            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                    if (newArray[i, j] == '\0')
                    {
                        newArray[i, j] = ' ';
                    }

                }
            }

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    newArray[x + 1 - i, y - 4 - j] = Array1[i, j];
                }
            }
            newArray[x, y - 4] = '.';


            if (KolHeart == 1)
            {
                Hearts.Add(new Heart(x-1, y - 6));
            }
            KolHeart = 0;

            int En = rnd.Next(1, 3);

            for (int i = 1; i <= En; i++)
            {
                Enemies.Add(new Enemy(x-i, y - 6+i));
            }
            int vermob = rnd.Next(1, 10);
            if (vermob <= 3)
            {
                Mobs.Add(new Mob(x , y - 5));
            }

          
            map = CleanMap(newArray);
            ChekKolKomn();

            if (KolKomnat == 6)
            {
                MiniBosses.Add(new MiniBoss(x, y -6));
            }

        }
        /*  public void DrawMap(Player player)
          {
              // Вычисляем смещение для центрирования карты
              int offsetX = (Console.WindowWidth - Width) /2;
              int offsetY = (Console.WindowHeight - Height) / 2;

              // Получаем размеры консоли
              int consoleWidth = Console.WindowWidth - 5;
              int consoleHeight = Console.WindowHeight - 5;

              for (int y = 0; y < map.GetLength(1); y++)
              {
                  if (y< consoleHeight)
                  {
                      Console.SetCursorPosition(10, y); // Устанавливаем позицию курсора
                      for (int x = 0; x < map.GetLength(0); x++)

                      {


                              if (x == player.X && y == player.Y)
                          {
                              Console.ForegroundColor = ConsoleColor.Blue;
                              Console.Write('@'); // Символ игрока
                              Console.ResetColor();
                          }
                          else
                          {
                              bool isEnemy = false;
                              foreach (var enemy in Enemies)
                              {
                                  if (enemy.X == x && enemy.Y == y)
                                  {
                                      Console.Write('E'); // Символ врага
                                      isEnemy = true;
                                      break;
                                  }


                              }
                              bool isHeart = false;
                              foreach (var heart in Hearts)
                                  {
                                      if (heart.X == x && heart.Y == y)
                                      {
                                          Console.ForegroundColor = ConsoleColor.Red;
                                          Console.Write('&'); // Символ сердца
                                          Console.ResetColor();
                                          isHeart = true;
                                          break;
                                      }
                                  }
                              if (!isEnemy && !isHeart)
                              {
                                  if (map[x, y] == '#') {
                                      Console.ForegroundColor = ConsoleColor.DarkGray;
                                  }
                                  if (map[x, y] == '+')
                                  {   Console.ForegroundColor = ConsoleColor.DarkYellow;
                                     // Console.BackgroundColor = ConsoleColor.Blue;
                                  }

                                  Console.Write(map[x, y]);
                                  Console.ResetColor();
                              }
                          }
                      }
                  }


              }
          } */

        public void DrawMap(Player player)
        {
            // Вычисляем смещение для центрирования карты
            int offsetX = (Console.WindowWidth - Width) / 2;
            int offsetY = (Console.WindowHeight - Height) / 2;

            // Получаем размеры консоли
            int consoleWidth = Console.WindowWidth - 5;
            int consoleHeight = Console.WindowHeight - 5;

            for (int y = 0; y < map.GetLength(1); y++)
            {
                if (y < consoleHeight)
                {
                    Console.SetCursorPosition(10, y); // Устанавливаем позицию курсора
                    for (int x = 0; x < map.GetLength(0); x++)
                    {
                        if (x == player.X && y == player.Y)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write('@'); // Символ игрока
                            Console.ResetColor();
                        }
                        else
                        {
                            bool isEnemy = false;
                            foreach (var enemy in Enemies)
                            {
                                if (enemy.X == x && enemy.Y == y)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write('E'); // Символ врага
                                    Console.ResetColor();
                                    isEnemy = true;
                                    break;
                                }
                            }
                            bool isMob = false;
                            foreach (var mob in Mobs)
                            {
                                if (mob.X == x && mob.Y == y)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.Write('M'); // Символ врага
                                    Console.ResetColor();
                                    isEnemy = true;
                                    break;
                                }
                            }
                            bool isMiniBoss = false;
                            foreach (var mini in MiniBosses)
                            {
                                if (mini.X == x && mini.Y == y)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write('Б'); // Символ врага
                                    Console.ResetColor();
                                    isEnemy = true;
                                    break;
                                }
                            }
                            bool isHeart = false;
                            foreach (var heart in Hearts)
                            {
                                if (heart.X == x && heart.Y == y)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write('&'); // Символ сердца, ну должен был быть, но он не отображается :(
                                    Console.ResetColor();
                                    isHeart = true;
                                    break;
                                }
                            }
                            if (!isEnemy && !isHeart)
                            {
                                if (map[x, y] == '#')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                }
                                if (map[x, y] == '+')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                }

                                Console.Write(map[x, y]);
                                Console.ResetColor();
                            }
                        }
                    }
                }
            }
        }


        public void CheckCollisions(Player player)
        {
            // Проверка столкновения с врагами
            for (int i = Enemies.Count - 1; i >= 0; i--) // Проходим в обратном порядке, чтобы избежать проблем с индексами
            {
                var enemy = Enemies[i];
                if (player.X == enemy.X && player.Y == enemy.Y)
                {
                    Dialog dialog = new Dialog();
                    dialog.Dialog_Mob();
                    while (true)
                    {
                        var input = Console.ReadKey(true).Key;

                        if ((input == ConsoleKey.F)|| (input == ConsoleKey.O))
                            break;
                        Thread.Sleep(1);
                        

                    }
                    int zoloto = rnd.Next(1, 5);
                    player.XP -= 1;
                    player.Exp++;
                    player.Gold = player.Gold + zoloto;
                    map[enemy.X, enemy.Y] = '.'; // Заменяем символ врага на пустую клетку
                    Enemies.RemoveAt(i); // Удаляем врага из списка
                    Console.Clear();
                    DrawMap(player);
                }
            }

            for (int i = Mobs.Count - 1; i >= 0; i--) // Проходим в обратном порядке, чтобы избежать проблем с индексами
            {
                var mob = Mobs[i];
                if (player.X  == mob.X && player.Y == mob.Y) 
                {
                    Dialog dialog = new Dialog();
                    dialog.Dialog_MobUs();
                    while (true)
                    {
                        var input = Console.ReadKey(true).Key;

                        if ((input == ConsoleKey.F) || (input == ConsoleKey.O))
                            break;
                        Thread.Sleep(1);


                    }
                    int zoloto = rnd.Next(5, 10);
                    player.Gold = player.Gold + zoloto;
                    player.XP -= 2;
                    player.Exp+=2;

                    map[mob.X, mob.Y] = '.'; // Заменяем символ врага на пустую клетку
                    Mobs.RemoveAt(i); // Удаляем врага из списка
                    Console.Clear();
                    DrawMap(player);
                }
            }

            // Проверка столкновения с сердцами
            foreach (var heart in Hearts)
            {
                if (player.X == heart.X && player.Y == heart.Y)
                {
                    
                    player.XP = player.MaxHealth; 
                    if (player.XP > player.MaxHealth)
                    {
                        player.XP = player.MaxHealth; // Ограничиваем максимальное здоровье

                    }
                    
                  
                    // Удаляем сердце с карты
                    map[heart.X, heart.Y] = '.'; // Заменяем символ сердца на пустую клетку
                    Hearts.Remove(heart); // Удаляем сердце из списка
                    
                    Console.Clear();
                    
                    DrawMap(player);
                    Dialog dialog = new Dialog();
                    dialog.Dialog_Heart();
                    Thread.Sleep(500);

                    break; // Выходим из цикла, так как сердце больше не существует
                    
                }
            }

            foreach (var mini in MiniBosses)
            {
                if (player.X == mini.X && player.Y == mini.Y)
                {
                    Dialog dialog = new Dialog();
                    dialog.Dialog_Boss();
                    while (true)
                    {
                        var input = Console.ReadKey(true).Key;

                        if (input == ConsoleKey.Y) {
                            Thread.Sleep(1);
                            Console.Clear();
                            isFight = true;
                            break;
                        }
                               
                        if (input == ConsoleKey.N)
                        {
                            break;
                        }


                    }


                    
                    
                }
            }
        }
        public void UpdatePlayerPosition(Player player)
        {
            // Удаляем старое положение игрока
            map[player.PreviousX, player.PreviousY] = (player.PreviousX == 0 || player.PreviousX == Width - 1 || player.PreviousY == 0 || player.PreviousY == Height - 1) ? '.' : '.';
            CheckCollisions(player);

        }

        public char[,] GetMap()
        {
            return map;
        }

        public void MoveEnemies()
        {
            foreach (var enemy in Enemies)
            {
                enemy.Move(map);
                
            }
            foreach (var mob in Mobs)
            {
                mob.Move(map);

            }
        }

    }
}
