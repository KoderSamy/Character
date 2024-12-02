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

            // тоторо
            Totoro miniTotoro = new Totoro();
            miniTotoro.Draw();

            // рыцарь
            Robot robot = new Robot();
            robot.Draw();

            // перс
            Girl2 girl = new Girl2();
            girl.Draw();

            // скелет
            Skeleton skeleton = new Skeleton();
            skeleton.Draw();

            // скелет2
            Skeleton2 skeleton2 = new Skeleton2();
            skeleton2.Draw();

            // скелет3
            Skeleton3 skeleton3 = new Skeleton3();
            skeleton3.Draw();

            // скелет4
            Skeleton4 skeleton4 = new Skeleton4();
            skeleton4.Draw();
        }
    }
}