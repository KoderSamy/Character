using System;

namespace ConsoleApp1
{
    public class Skeleton
    {
        string resetColor = "\u001b[0m";
        string white = "\u001b[37m";
        public void Draw()
        {
            Console.WriteLine($"{white}      .-.{resetColor}");
            Console.WriteLine($"{white}     (o.o){resetColor}");
            Console.WriteLine($"{white}      |=|{resetColor}");
            Console.WriteLine($"{white}     __|_{resetColor}");
            Console.WriteLine($"{white}   //.=|=.\\\\{resetColor}");
            Console.WriteLine($"{white}  // .=|=. \\\\{resetColor}");
            Console.WriteLine($"{white}  \\\\ .=|=. //{resetColor}");
            Console.WriteLine($"{white}   \\\\(_=_)//{resetColor}");
            Console.WriteLine($"{white}    (:| |:){resetColor}");
            Console.WriteLine($"{white}     || ||{resetColor}");
            Console.WriteLine($"{white}     () (){resetColor}");
            Console.WriteLine($"{white}     || ||{resetColor}");
            Console.WriteLine($"{white}     || ||{resetColor}");
            Console.WriteLine($"{white}    ==' '=={resetColor}");
        }
    }
}