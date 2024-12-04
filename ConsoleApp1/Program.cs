using RogueLike;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace RoguelikeGame
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // Console.OutputEncoding = Encoding.UTF8;
            // ShowSplashScreen();

            // // // тоторо
            // Totoro miniTotoro = new Totoro();
            // miniTotoro.Draw();

            // // // рыцарь
            // Robot robot = new Robot();
            // robot.Draw();

            // // // перс
            // Girl2 girl = new Girl2();
            // girl.Draw();

            // // // скелет
            // Skeleton skeleton = new Skeleton();
            // skeleton.Draw();

            // // // скелет2
            // Skeleton2 skeleton2 = new Skeleton2();
            // skeleton2.Draw();

            // // // скелет3
            // Skeleton3 skeleton3 = new Skeleton3();
            // skeleton3.Draw();

            // // // скелет4
            // Skeleton4 skeleton4 = new Skeleton4();
            // skeleton4.Draw();

            // // // дед
            // Ded ded = new Ded();
            // ded.Draw();

            // // меню
            // Menu mainMenu = new Menu();
            // mainMenu.ShowMenu();


            Player player = new Player();
            Console.OutputEncoding = Encoding.UTF8;
            ShowSplashScreen();
            Menu menu = new Menu(); 
            menu.ShowMenu(player);


    }
        static void ShowSplashScreen()
        {
            Console.CursorVisible = false;
            Console.Clear();

            Frame frame = new Frame();
            frame.DrawFrame();

            string promptText = "нажмите любую клавишу для продолжения...";
            int promptWidth = promptText.Length;
            int promptLeftPadding = (Console.WindowWidth - promptWidth) / 2;
            int promptTop = (Console.WindowHeight / 2) + 4; // Под рамкой

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(promptLeftPadding, promptTop);
            Console.WriteLine(promptText);
            Console.ResetColor();

            Console.ReadKey();
            Console.Clear();
        }
    }


        public class Game
        {
            Random rnd = new Random();
           // private Player player;
            private Map currentMap;
            private Map DopMap;
            public Game()
            {

            // Генерация случайных значений для ширины и высоты карты
            int initialMapWidth = rnd.Next(10, 21); // Ширина от 10 до 20
            int initialMapHeight = rnd.Next(5, 11); // Высота от 5 до 10?
            //player = new Player();
            int En = rnd.Next(1, 3);
            int vermob = rnd.Next(1, 10);
           
           currentMap = new Map(initialMapWidth, initialMapHeight);
            currentMap.GenerateMap();
            currentMap.SpawnEnemies(En);
            currentMap.PutHeart(1);
            if (vermob <= 3)
            {
                currentMap.SpawnMobs(1);
            }
        }

         public void Start(Player player)
            {
            
            string message = "Игра началась!";
            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;
            Console.SetCursorPosition((consoleWidth - message.Length) / 2, consoleHeight / 2);
            Console.WriteLine(message);
            Console.ReadKey();
            Console.Clear();
            Console.SetCursorPosition(10, Console.WindowHeight - 5);
            Console.WriteLine($"Level:{player.Level}  Gold:{player.Gold}  ХП:{player.XP}/{player.MaxHealth}  Str:{player.Str}/{player.MaxStr}  Arm:{player.arm}/{player.MaxArm}  Exp:{player.Exp}/{player.MaxExp}");
            Dialog dial = new Dialog();
            player.X = 1;
            player.Y = 1;
            dial.Draw();
            player.Check();
            while (currentMap.isFight==false)
            {
                player.Check();

                //Console.Clear();
                if (player.XP == 0) { 
                    Menu menu = new Menu();
                    menu.ShowLose();

                }
                currentMap.DrawMap(player);


                    var input = Console.ReadKey(true).Key;

                    if (input == ConsoleKey.Q)
                        break;
                        
                    

                    player.Move(input, currentMap.GetMap()); // Передаем карту в метод Move
                    currentMap.UpdatePlayerPosition(player);
                    currentMap.MoveEnemies(); // Двигаем врагов

                    if (currentMap.GetMap()[player.X, player.Y] == '+' && input == ConsoleKey.D)
                    {
                        currentMap.CoridorRight(player.X, player.Y, player);
                        Console.Clear();
                        currentMap.DrawMap(player);

                    }

                    if (currentMap.GetMap()[player.X, player.Y] == '+' && input == ConsoleKey.S)
                    {
                        currentMap.CoridorDown(player.X, player.Y, player);
                        Console.Clear();
                        currentMap.DrawMap(player);
                    }

                    if (currentMap.GetMap()[player.X, player.Y] == '+' && input == ConsoleKey.W)
                    {
                        currentMap.CoridorUp(player.X, player.Y, player);
                        Console.Clear();
                        currentMap.DrawMap(player);
                    }

                    Console.SetCursorPosition(10, Console.WindowHeight - 5);
                    Console.WriteLine($"Level:{player.Level}  Gold:{player.Gold}  ХП:{player.XP}/{player.MaxHealth}  Str:{player.Str}/{player.MaxStr}  Arm:{player.arm}/{player.MaxArm}  Exp:{player.Exp}/{player.MaxExp}");
                    Dialog dialog = new Dialog();
                    dialog.Draw();
                }
                
                Console.Clear();
                BossFight bossFight = new BossFight();
                bossFight.Fight(player);
               




        }



        }

    }