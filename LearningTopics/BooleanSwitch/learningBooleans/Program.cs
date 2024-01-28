using Spectre.Console;
using System.Formats.Asn1;


AnsiConsole.MarkupLine("[green]Learning Switch Statements and Booleans[/]");
AnsiConsole.MarkupLine("[red]Example:\n[/]");
Console.Write("What is your name: ");
string name = Console.ReadLine();
// Switch: An efficient way of minimizing if else statements into clean code
switch (name)
{
    case "45":
        Console.WriteLine("Youve Entered a number");
        break;  
    case "Yoenis":
        Console.WriteLine("Hello Yoenis");
        break;
    case "Yannah":
        Console.WriteLine("Hello Yannah");
        break;
    default:
        Console.WriteLine(name+" is not a name ");
        break;      
}
AnsiConsole.MarkupLine("[red]\nThis switch case asks for your name\n" +
    "And depending on your answer using switch cases\n" +
    "Displays the appropriate response.[/]");

