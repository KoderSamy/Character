using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Totoro
    {
        string resetColor = "\u001b[0m";
        string blue = "\u001b[34m";
        string yellow = "\u001b[33m";
        string black = "\u001b[30m";
        public void Draw()
        {
            Console.WriteLine($"{blue}            ,.  ,.{resetColor}");
            Console.WriteLine($"{blue}            ||  ||{resetColor}");
            Console.WriteLine($"{blue}           ,''--''. {resetColor}");
            Console.WriteLine($"{blue}          : {yellow}({black}.{yellow})({yellow}{black}.{yellow}) {blue}:{resetColor}");
            Console.WriteLine($"{blue}         ,'        `.{resetColor}");
            Console.WriteLine($"{blue}         :          :{resetColor}");
            Console.WriteLine($"{blue}         :          :{resetColor}");
            Console.WriteLine($"{blue}   -ctr- `._m____m_,' {resetColor}");
        }
    }
}