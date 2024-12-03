using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class Robot
{
    public void Draw()
    {

        string reset = "\u001b[0m";
        string red = "\u001b[31m";
        string green = "\u001b[32m";
        string yellow = "\u001b[33m";
        string blue = "\u001b[34m";
        string magenta = "\u001b[35m";
        string white = "\u001b[37m";

        Console.WriteLine($@"{white}|\             {red}//{reset}");
        Console.WriteLine($@"{white} \\           {yellow}_{magenta}!{yellow}_{reset}");
        Console.WriteLine($@"{white}  \\         {yellow}/___\{reset}");
        Console.WriteLine($@"{white}   \\        {yellow}[{blue}+++{yellow}]{reset}");
        Console.WriteLine($@"{white}    \\    {yellow}_ _\{blue}^^^{yellow}/_ _{reset}");
        Console.WriteLine($@"{white}     \\/ {yellow}(    '-'  ( ){reset}");
        Console.WriteLine($@"{white}     /{yellow}( \/ | {red}{{&}}   {yellow}/\ \{reset}");
        Console.WriteLine($@"{yellow}       \__/ \     / _> ){reset}");
        Console.WriteLine($@"{yellow}             >{blue}:::;{white}-'`""'-.{reset}");
        Console.WriteLine($@"{yellow}            /{blue}:::{white}/         \{reset}");
        Console.WriteLine($@"{yellow}           /  /|{white}|   {red}{{&}}   {white}|{reset}");
        Console.WriteLine($@"{yellow}          (  / ({white}\         /{reset}");
        Console.WriteLine($@"{yellow}          / /   \{white}'-.___.-'{reset}");
        Console.WriteLine($@"{yellow}        _/ /     \ \{reset}");
        Console.WriteLine($@"{yellow}       /___|    /___|{reset}");
    }
}