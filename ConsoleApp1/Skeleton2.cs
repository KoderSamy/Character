using System;

public class Skeleton2
{
    string white = "\u001b[37m"; // ANSI escape-код для белого цвета
    string resetColor = "\u001b[0m"; // ANSI escape-код для сброса цвета

    public void Draw()
    {
        Console.WriteLine($"{white}            _,.-------------.._{resetColor}");
        Console.WriteLine($"{white}         ,-'        j          `-.{resetColor}");
        Console.WriteLine($"{white}       ,'        .-'               `.{resetColor}");
        Console.WriteLine($"{white}      /          |                   '{resetColor}");
        Console.WriteLine($"{white}     /         ,-'                    `{resetColor}");
        Console.WriteLine($@"{white}    .         j                         \{resetColor}");
        Console.WriteLine($@"{white}   .          |                          \{resetColor}");
        Console.WriteLine($"{white}   : ._       |   _....._                 .{resetColor}");
        Console.WriteLine($"{white}   |   -.     L-''       `.               :{resetColor}");
        Console.WriteLine($@"{white}   | `.  \  .'             `.             |{resetColor}");
        Console.WriteLine($@"{white}  /.\  `, Y'                 :           ,|{resetColor}");
        Console.WriteLine($@"{white} /.  :  | \                  |         ,' |{resetColor}");
        Console.WriteLine($"{white}\\.    \" :  `\\                |      ,--   |{resetColor}");
        Console.WriteLine($@"{white} \    .'     '-..___,..      |    _/      :{resetColor}");
        Console.WriteLine($@"{white}  \  `.      ___   ...._     '-../        '{resetColor}");
        Console.WriteLine($@"{white}.-'    \    /| \_/ | | |      ,'         /{resetColor}");
        Console.WriteLine($"{white}|       `--' |    '' |'|     /         .'{resetColor}");
        Console.WriteLine($"{white}|            |      /. |    /       _,'{resetColor}");
        Console.WriteLine($"{white}|-.-.....__..|     Y-dp`...:...--'''{resetColor}");
        Console.WriteLine($"{white}|_|_|_L.L.T._/     |{resetColor}");
        Console.WriteLine($"{white}\\_|_|_L.T-''/      |{resetColor}");
        Console.WriteLine($"{white} |                /{resetColor}");
        Console.WriteLine($"{white}/             _.-'{resetColor}");
        Console.WriteLine($"{white}:         _..'{resetColor}");
        Console.WriteLine($@"{white}\__...--''{resetColor}");
    }
}