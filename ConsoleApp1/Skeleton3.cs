using System;

public class Skeleton3
{
    string red = "\u001b[31m"; // ANSI escape-код для красного цвета
    string reset = "\u001b[0m"; // ANSI escape-код для сброса цвета

    public void Draw()
    {
        Console.WriteLine($"{red}         .            )        ){reset}");
        Console.WriteLine($"{red}                  (  (|              .{reset}");
        Console.WriteLine($@"{red}              )   )\/ ( ( ({reset}");
        Console.WriteLine($@"{red}      *  (   ((  /     ))\))  (  )    ){reset}");
        Console.WriteLine($@"{red}    (     \   )\(          |  ))( )  (|{reset}");
        Console.WriteLine($@"{red}    >)     ))/   |          )/  \((  ) \{reset}");
        Console.WriteLine($@"{red}    (     (      .        -.     V )/   )(    ({reset}");
        Console.WriteLine($@"{red}     \   /     .   \            .       \))   )){reset}");
        Console.WriteLine($"{red}       )(      (  | |   )            .    (  /{reset}");
        Console.WriteLine($@"{red}      )(    ,'))     \ /          \( `.    ){reset}");
        Console.WriteLine($@"{red}      (\>  ,'/__      ))            __`.  /{reset}");
        Console.WriteLine($@"{red}     ( \   | /  ___   ( \/     ___   \ | ( ({reset}");
        Console.WriteLine($@"{red}      \.)  |/  /   \__      __/   \   \|  )){reset}");
        Console.WriteLine($@"{red}     .  \. |>  \      | __ |      /   <|  /{reset}");
        Console.WriteLine($@"{red}          )/    \____/ :..: \____/     \ <{reset}");
        Console.WriteLine($@"{red}   )   \ (|__  .      / ;: \          __| )  ({reset}");
        Console.WriteLine($@"{red}  ((    )\)  ~--_     --  --      _--~    /  )){reset}");
        Console.WriteLine($@"{red}   \    (    |  ||               ||  |   (  /{reset}");
        Console.WriteLine($@"{red}         \.  |  ||_             _||  |  /{reset}");
        Console.WriteLine($"{red}           > :  |  ~V+-I_I_I-+V~  |  : (.{reset}");
        Console.WriteLine($@"{red}          (  \:  T\   _     _   /T  : ./{reset}");
        Console.WriteLine($@"{red}           \  :    T^T T-+-T T^T    ;<{reset}");
        Console.WriteLine($@"{red}            \..`_       -+-       _'  ){reset}");
        Console.WriteLine($"{red}               . `--=.._____..=--'. ./          {reset}");
    }
}