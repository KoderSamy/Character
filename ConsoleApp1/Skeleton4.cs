using System;

public class Skeleton4
{
    string black = "\u001b[30m";
    string red = "\u001b[31m";
    string green = "\u001b[32m";
    string yellow = "\u001b[33m";
    string blue = "\u001b[34m";
    string magenta = "\u001b[35m";
    string cyan = "\u001b[36m";
    string white = "\u001b[37m";
    string reset = "\u001b[0m"; // ANSI escape-код для сброса цвета


    public void Draw()
    {
        Console.WriteLine($@"{white}                              _.--""-._ {reset}");
        Console.WriteLine($"{black} .                   {white}      .\"         \".{reset}");
        Console.WriteLine($"{black} / \\    {red},^.         {black}/(     {white}Y             |{black}      )\\{reset}");
        Console.WriteLine($"{black}/   `---. |--'\\    {black}(  \\__{white}..'--   -   -- {black}-''-.-'  ){reset}");
        Console.WriteLine($"{black}|        :|    `>   {black}'.     {white}l_..-------.._l{black}      .'{reset}");
        Console.WriteLine($"{black}|      __l;__ .'      {black}\"-.__.{white}||_.-'v'-._||{black}`\"----\"{reset}");
        Console.WriteLine($"{black} \\  .-' {red}| |  {white}`              l._       _.'{reset}");
        Console.WriteLine($"{black}  \\/    {red}| |                   {white}l`^^'^^'j{reset}");
        Console.WriteLine($"{red}        | | {white}               _   \\_____/     _{reset}");
        Console.WriteLine($"{red}        j |  {white}             l `--__)-'(__.--' |{reset}");
        Console.WriteLine($"{red}        | |  {white}             | /`---``-----'\"1 |  {black},-----.{reset}");
        Console.WriteLine($"{red}        | |  {white}             )/  `--' '---'   \\{black}'-'  ___  `-.{reset}");
        Console.WriteLine($"{red}        | |  {white}            //  `-'  '`----'  {black}/  ,-'   I`.  \\{reset}");
        Console.WriteLine($"{white}      _ {red}L |{white}_            //  `-.-.'`-----' {black}/  /  |   |  `. \\{reset}");
        Console.WriteLine($"{white}     '._' / \\         _/(   `/   )- ---' {black};  /__.J   L.__.\\ :{reset}");
        Console.WriteLine($"{white}      `._;/7(-.......'  /        ) (     {black}|  |            | |{reset}");
        Console.WriteLine($"{white}      `._;l _'--------_/        )-'/     {black}:  |___.    _._./ ;{reset}");
        Console.WriteLine($@"{red}        | | {white}                .__ )-'\  __  {black}\\  \\  I   1   / /{reset}");
        Console.WriteLine($"{red}        `-'  {white}              /   `-\\-(-'   {black}\\ \\  `.|   | ,' /{reset}");
        Console.WriteLine($"{white}                           \\__  `-'    __/  {black}`-. `---'',-'{reset}");
        Console.WriteLine($"{white}                              )-._.-- (       {black} `-----'{reset}");
        Console.WriteLine($"{white}                             )(  l\\ o ('..-.{reset}");
        Console.WriteLine($"{white}                       _..--' _'-' '--'.-. |{reset}");
        Console.WriteLine($"{white}                __,,-'' _,,-''            \\ \\{reset}");
        Console.WriteLine($"{white}               f'. _,,-'                   \\ \\{reset}");
        Console.WriteLine($"{white}              ()--  |                       \\ \\{reset}");
        Console.WriteLine($"{white}                \\.  |                       /  \\{reset}");
        Console.WriteLine($"{white}                  \\ \\                      |._  |{reset}");
        Console.WriteLine($"{white}                   \\ \\                     |  ()|{reset}");
        Console.WriteLine($"{white}                    \\ \\                     \\  /{reset}");
        Console.WriteLine($"{white}                     ) `-.                   | |{reset}");
        Console.WriteLine($"{white}                    // .__)                  | |{reset}");
        Console.WriteLine($"{white}                 _.//7'                      | |{reset}");
        Console.WriteLine($"{white}               '---'                         j_| `{reset}");
        Console.WriteLine($"{white}                                            (| |{reset}");
        Console.WriteLine($"{white}                                             |  \\{reset}");
        Console.WriteLine($"{white}                                             |lllj{reset}");
        Console.WriteLine($"{white}                                             |||||{reset}");
    }
}