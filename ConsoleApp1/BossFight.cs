using RoguelikeGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike
{
    public class BossFight
    {
        public void Fight(Player player)
        {   
            Random rnd = new Random();
            int vrag = rnd.Next(1,5);
            Girl2 girl2 = new Girl2();
            girl2.Draw();
            
            switch (vrag)
            {
                case 1:
                    Skeleton skeleton = new Skeleton();
                    skeleton.Draw();
                    break;
                case 2:
                    Skeleton2 skeleton2 = new Skeleton2();
                    skeleton2.Draw();
                    break;
                case 3:
                    Skeleton3 skeleton3 = new Skeleton3();
                    skeleton3.Draw();
                    break;
                case 4: 
                   Robot robot = new Robot();
                    robot.Draw();
                    break;
            }
            Console.SetCursorPosition(10, Console.WindowHeight - 5);
            Console.WriteLine($"Level:{player.Level}  Gold:{player.Gold}  ХП:{player.XP}/{player.MaxHealth}  Str:{player.Str}/{player.MaxStr}  Arm:{player.arm}/{player.MaxArm}  Exp:{player.Exp}/{player.MaxExp}");
            Dialog dialog = new Dialog();
            dialog.Dialog_FightBoss();
            bool vibor = false;
            while (true)
            {
                var input = Console.ReadKey(true).Key;
                if (input == ConsoleKey.Z)
                    player.XP = player.XP+5;
                    if (player.XP > player.MaxHealth)
                    {
                        if (vibor == false)

                        {
                            player.XP = player.MaxHealth; // Ограничиваем максимальное здоровье
                            Console.SetCursorPosition(10, Console.WindowHeight - 5);
                            Console.WriteLine($"Level:{player.Level}  Gold:{player.Gold}  ХП:{player.XP}/{player.MaxHealth}  Str:{player.Str}/{player.MaxStr}  Arm:{player.arm}/{player.MaxArm}  Exp:{player.Exp}/{player.MaxExp}");
                            Dialog dia = new Dialog();
                            dialog.Dialog_FightBoss1();
                        }
                        vibor = true;

                }
                if (input == ConsoleKey.A)
                    break;
                if (input == ConsoleKey.V)
                {
                    if (vibor == false)

                    {
                        player.arm = player.arm + 5;
                        Console.SetCursorPosition(10, Console.WindowHeight - 5);
                        Console.WriteLine($"Level:{player.Level}  Gold:{player.Gold}  ХП:{player.XP}/{player.MaxHealth}  Str:{player.Str}/{player.MaxStr}  Arm:{player.arm}/{player.MaxArm}  Exp:{player.Exp}/{player.MaxExp}");
                        Dialog dia = new Dialog();
                        dialog.Dialog_FightBoss2();
                    }

                    vibor = true;
                }
            }
            Console.Clear();
            Game nextLevel = new Game();
            nextLevel.Start(player);
        }

    }
}
