using ConsoleApp1;
using System;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // ShowSplashScreen();

            // тоторо
            // Totoro miniTotoro = new Totoro();
            // miniTotoro.Draw();

            // рыцарь
            // Robot robot = new Robot();
            // robot.Draw();

            // // перс
            // Girl2 girl = new Girl2();
            // girl.Draw();

            // // скелет
            // Skeleton skeleton = new Skeleton();
            // skeleton.Draw();

            // скелет2
            // Skeleton2 skeleton2 = new Skeleton2();
            // skeleton2.Draw();

            // скелет3
            // Skeleton3 skeleton3 = new Skeleton3();
            // skeleton3.Draw();

            // скелет4
            // Skeleton4 skeleton4 = new Skeleton4();
            // skeleton4.Draw();

            // дед
            Ded ded = new Ded();
            ded.Draw();

            // меню
            // Menu mainMenu = new Menu();
            // mainMenu.ShowMenu();
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
}