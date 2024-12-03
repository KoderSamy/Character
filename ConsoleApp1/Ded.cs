using System;

public class Ded
{
    // Define colors
    string resetColor = "\u001b[0m";
    string gray = "\u001b[90m";
    string darkGray = "\u001b[37m";
    string white = "\u001b[97m";  // Brighter white for belly
    string black = "\u001b[30m";
    string lightGray = "\u001b[37m";
    string red = "\u001b[31m";
    string green = "\u001b[32m";
    string yellow = "\u001b[33m";
    string blue = "\u001b[34m";
    string magenta = "\u001b[35m";

    public void Draw()
    {
        Console.WriteLine($"{white}              _,._      {resetColor}");
        Console.WriteLine($"{yellow}  .||,   {white}    /_ _\\     {resetColor}");
        Console.WriteLine($"{yellow} \\.`',/ {white}     |{gray}'L'{white}| |    {resetColor}");
        Console.WriteLine($"{yellow} = ,. =   {white}   | {red}-{white} | L    {resetColor}");
        Console.WriteLine($"{yellow} / {gray}||{yellow} \\ {blue}   ,-'\"/,'`.   {resetColor}");
        Console.WriteLine($"{gray}   || {blue}    ,'   `,,. `.  {resetColor}");
        Console.WriteLine($"{gray}   ||{blue}____,' , ,;' \\| |  {resetColor}");
        Console.WriteLine($"{white}  (3{blue}|\\    _/|/'   _| |  {resetColor}");
        Console.WriteLine($"{gray}   ||{blue}/,-''  | >-'' _,\\ {resetColor}");
        Console.WriteLine($"{gray}   ||{blue}'      ==\\ ,-'  ,' {resetColor}");
        Console.WriteLine($"{gray}   ||  {blue}     |  {white}V \\ {blue},|   {resetColor}");
        Console.WriteLine($"{gray}   || {blue}      |    |` |   {resetColor}"); // White belly starts here
        Console.WriteLine($"{gray}   || {blue}      |    |   \\  {resetColor}");
        Console.WriteLine($"{gray}   || {blue}      |    \\    \\ {resetColor}");
        Console.WriteLine($"{gray}   || {blue}      |     |    \\ {resetColor}");
        Console.WriteLine($"{gray}   || {blue}      |      \\_,-' {resetColor}"); // Back to gray
        Console.WriteLine($"{gray}   || {blue}      |___,,--\"\\_\\{resetColor}");
        Console.WriteLine($"{gray}   || {blue}        |_|  {green} ccc/{resetColor}");
        Console.WriteLine($"{gray}   ||     {green}   ccc/       {resetColor}");
        Console.WriteLine($"{gray}   ||                 {resetColor}");


    }
}