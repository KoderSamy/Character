using RoguelikeGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike
{
    internal class Dialog
    {
        public Dialog() { }
        public void Draw()
        {
            Console.SetCursorPosition(10, Console.WindowHeight - 15);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(10, Console.WindowHeight - 14);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, Console.WindowHeight - 13);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, Console.WindowHeight - 12);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, Console.WindowHeight - 11);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, Console.WindowHeight - 10);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, Console.WindowHeight - 9);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");


        }

        public void Dialog_Heart()
        {
            Console.SetCursorPosition(10, Console.WindowHeight - 15);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(10, Console.WindowHeight - 14);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, Console.WindowHeight - 13);
            Console.WriteLine("|                                    Вы нашли сердце! Здоровье восстановлено!                                  |");
            Console.SetCursorPosition(10, Console.WindowHeight - 12);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, Console.WindowHeight - 11);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, Console.WindowHeight - 10);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, Console.WindowHeight - 9);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");



        }

        public void Dialog_Mob()
        {
            Console.SetCursorPosition(10, Console.WindowHeight-15);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(10, Console.WindowHeight - 14);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, Console.WindowHeight - 13);
            Console.WriteLine("|                                       Вы встретились с врагом!                                               |");
            Console.SetCursorPosition(10, Console.WindowHeight - 12);
            Console.WriteLine("|                    Нажмите F, чтобы сразиться! Нажмите O чтобы использовать оружие!                          |");
            Console.SetCursorPosition(10, Console.WindowHeight - 11);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, Console.WindowHeight - 10);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, Console.WindowHeight - 9);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");



        }
        public void Dialog_MobUs()
        {
            Console.SetCursorPosition(10, Console.WindowHeight - 15);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(10, Console.WindowHeight - 14);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, Console.WindowHeight - 13);
            Console.WriteLine("|                              Вы встретились с сильными врагом!                                               |");
            Console.SetCursorPosition(10, Console.WindowHeight - 12);
            Console.WriteLine("|                    Нажмите F, чтобы сразиться! Нажмите O чтобы использовать оружие!                          |");
            Console.SetCursorPosition(10, Console.WindowHeight - 11);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, Console.WindowHeight - 10);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, Console.WindowHeight - 9);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");



        }

        public void Dialog_Boss()
        {
            Console.SetCursorPosition(10, Console.WindowHeight - 15);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(10, Console.WindowHeight - 14);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, Console.WindowHeight - 13);
            Console.WriteLine("|                                  Вы столкнулись с боссом!                                                    |");
            Console.SetCursorPosition(10, Console.WindowHeight - 12);
            Console.WriteLine("|                           Вы дейтвительно хотите сразиться с ним?                                            |");
            Console.SetCursorPosition(10, Console.WindowHeight - 11);
            Console.WriteLine("|                              Если Да, нажмите Y. Если Нет - N.                                               |");
            Console.SetCursorPosition(10, Console.WindowHeight - 10);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, Console.WindowHeight - 9);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");


        }

        public void Dialog_FightBoss()
        {
            Console.SetCursorPosition(10, Console.WindowHeight - 15);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(10, Console.WindowHeight - 14);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, Console.WindowHeight - 13);
            Console.WriteLine("|                                  Это окно битвы с боссом!                                                    |");
            Console.SetCursorPosition(10, Console.WindowHeight - 12);
            Console.WriteLine("|                                 Нажмите A, чтобы аттаковать.                                                 |");
            Console.SetCursorPosition(10, Console.WindowHeight - 11);
            Console.WriteLine("|                            Вы можете использовать зелье или щит.                                             |");
            Console.SetCursorPosition(10, Console.WindowHeight - 10);
            Console.WriteLine("|              Нажмите Z чтобы использовать зелье.  Нажмите V чтобы использовать зелье.                        |");
            Console.SetCursorPosition(10, Console.WindowHeight - 9);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");



        }

        public void Dialog_FightBoss1()
        {
            Console.SetCursorPosition(10, 34);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(10, 35);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, 36);
            Console.WriteLine("|                         Вы выбрали зелье. Ваше здоровье увеличилось на 5.                                    |");
            Console.SetCursorPosition(10, 37);
            Console.WriteLine("|                                Теперь нажмите A, чтобы аттаковать.                                           |");
            Console.SetCursorPosition(10, 38);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, 39);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, 40);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");



        }

        public void Dialog_FightBoss2()
        {
            Console.SetCursorPosition(10, 34);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(10, 35);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, 36);
            Console.WriteLine("|                            Вы выбрали щит. Ваша броня увеличилась на 5.                                      |");
            Console.SetCursorPosition(10, 37);
            Console.WriteLine("|                                Теперь нажмите A, чтобы аттаковать.                                           |");
            Console.SetCursorPosition(10, 38);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, 39);
            Console.WriteLine("|                                                                                                              |");
            Console.SetCursorPosition(10, 40);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");



        }
    }
}
