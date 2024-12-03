using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class Girl2
{
    string resetColor = "\u001b[0m";

    // Стандартные цвета текста
    string black = "\u001b[30m";
    string red = "\u001b[31m";
    string green = "\u001b[32m";
    string yellow = "\u001b[33m";
    string blue = "\u001b[34m";
    string magenta = "\u001b[35m";
    string cyan = "\u001b[36m";
    string white = "\u001b[37m";

    // Стандартные цвета фона
    string blackBackground = "\u001b[40m";
    string redBackground = "\u001b[41m";
    string greenBackground = "\u001b[42m";
    string yellowBackground = "\u001b[43m";
    string blueBackground = "\u001b[44m";
    string magentaBackground = "\u001b[45m";
    string cyanBackground = "\u001b[46m";
    string whiteBackground = "\u001b[47m";
    public void Draw()
    {
        Console.WriteLine($@"{red}                .,-~~~~~,.{resetColor}");
        Console.WriteLine($@"{red}         _.~`\'\J      '-`\{resetColor}");
        Console.WriteLine($@"{red}        ,'      ,  ,  |\  ,\ \{resetColor}");
        Console.WriteLine($@"{red}       i  !~ X _J  u  \-~-\ \ U{resetColor}");
        Console.WriteLine($@"{red}       | | X!,~-~'J   ^`UL ^  J{resetColor}");
        Console.WriteLine($@"{black}    __ {red}|   |  {black}'{blue}0{black}'    '{blue}0{black}' {red}7\,!{resetColor}");
        Console.WriteLine($@"{black}   |  \.{red}| \ {magenta},,,    _    ""{red}^.|{resetColor}");
        Console.WriteLine($@"{black}   |   i.  {red}\ {white}L._  __,,.<i {red}|'J{resetColor}");
        Console.WriteLine($@"{black} _ |  .X  {white},.~{blue}'J\7_y {white}\ {red}| |'J{resetColor}");
        Console.WriteLine($@"{black}|_ i  | {white}^.,  {blue}i  \|> {white}i\{resetColor}");
        Console.WriteLine($@"{black}   |  /    {white}!^   {blue}:u  {white}\ \{resetColor}");
        Console.WriteLine($@"{black}    \,_\    {white}.^.      {white}<~y{resetColor}");
        Console.WriteLine($@"{black}     '-__ {blue}/             !{resetColor}");
        Console.WriteLine($@"{blue}         |!.~|J.,,i|_J~'J{resetColor}");
        Console.WriteLine($@"{white}           \  |   \  |{resetColor}");
        Console.WriteLine($@"{blue}            \_'    \_'{resetColor}");
    }
}