using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike
{
    public class Frame
    {
        public void DrawFrame(string innerText = "")
        {
            string[] frameLines = {
                "  .-----------------------------------------------------------------.",
                " /  .-.                                                         .-.  \\",
                "|  /   \\                                                       /   \\  |",
                "| |\\_.  |                                                     |    /| |",
                "|\\|  | /|                  Глубины Забвенья                   |\\  | |/|",
                "| `---' |                                                     | `---' |",
                "|       |                                                     |       |",
                "|       |-----------------------------------------------------|       |",
                "\\       |                                                     |       /",
                " \\     /                                                       \\     /",
                "  `---'                                                         `---'"
            };

            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;
            int frameWidth = frameLines[0].Length;
            int frameHeight = frameLines.Length; // frameHeight теперь меньше


            int leftPadding = (consoleWidth - frameWidth) / 2;
            int topPadding = (consoleHeight - frameHeight) / 2;


            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < frameLines.Length; i++) // Обратите внимание: цикл теперь короче
            {
                Console.SetCursorPosition(leftPadding, i + topPadding);
                Console.WriteLine(frameLines[i]);
            }

            Console.ResetColor();
        }
    }
}
