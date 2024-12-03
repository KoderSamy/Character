using System;

public class Menu
{
    public void ShowMenu()
    {
        Console.CursorVisible = false;

        while (true)
        {
            Console.Clear();

            string title = "=== Главное меню ===";
            int titleWidth = title.Length;
            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;
            int titleLeft = (consoleWidth - titleWidth) / 2;
            string horizontalLine = new string('=', consoleWidth);

            Console.WriteLine(horizontalLine);
            Console.SetCursorPosition(titleLeft, Console.CursorTop);
            Console.WriteLine(title);
            Console.WriteLine(horizontalLine);

            string[] menuItems = {
                "  1. Начать игру      ",
                "  2. Продолжить       ",
                "  3. Выход            "
            };

            int menuHeight = menuItems.Length;
            int topPadding = (consoleHeight - menuHeight) / 2 - 2;


            for (int i = 0; i < menuItems.Length; i++)
            {
                int leftPadding = (consoleWidth - menuItems[i].Length) / 2;
                Console.SetCursorPosition(leftPadding, topPadding + i + 3);
                Console.WriteLine(menuItems[i]);
            }

            Console.SetCursorPosition((consoleWidth - "Выберите опцию (1-3): ".Length) / 2, topPadding + menuHeight + 4);
            Console.Write("Выберите опцию (1-3): ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    StartNewGame();
                    break;
                case "2":
                    ContinueGame();
                    break;
                case "3":
                    ExitGame();
                    return;
                case "":
                    break;
                default:
                    string errorMessage = "Неверный ввод. Пожалуйста, выберите 1, 2 или 3.";
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition((Console.WindowWidth - errorMessage.Length) / 2, Console.CursorTop); // Центрируем сообщение об ошибке
                    Console.WriteLine(errorMessage);
                    Console.ResetColor();
                    Console.ReadKey();
                    break;
            }
        }
    }

    private void StartNewGame()
    {
        Console.Clear();
        Game newGame = new Game();
        newGame.Start();
    }

    private void ContinueGame()
    {
        Console.Clear();
        string message = "Продолжаем игру...";
        int consoleWidth = Console.WindowWidth;
        int consoleHeight = Console.WindowHeight;
        Console.SetCursorPosition((consoleWidth - message.Length) / 2, consoleHeight / 2); // Центрирование по горизонтали и вертикали
        Console.WriteLine(message);
        Console.ReadKey();
    }

    private void ExitGame()
    {
        Console.Clear();
        string message = "Выход из игры. Спасибо за игру!";
        int consoleWidth = Console.WindowWidth;
        int consoleHeight = Console.WindowHeight;
        Console.SetCursorPosition((consoleWidth - message.Length) / 2, consoleHeight / 2);
        Console.WriteLine(message);
        Console.ReadKey();
    }
}


// Пример класса Game (замените своей реализацией)
public class Game
{
    public void Start()
    {
        string message = "Игра началась!";
        int consoleWidth = Console.WindowWidth;
        int consoleHeight = Console.WindowHeight;
        Console.SetCursorPosition((consoleWidth - message.Length) / 2, consoleHeight / 2);
        Console.WriteLine(message);
        Console.ReadKey();
    }
}