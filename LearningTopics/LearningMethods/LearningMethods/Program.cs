using Spectre.Console;
using Spectre.Console.Cli;

Console.SetWindowSize(150, 100);

void Intro()
{
AnsiConsole.Write(new FigletText("Learning Methods").Centered().Color(Color.Gold3_1));
AnsiConsole.Write(new Markup("\nNow, if i want to use this intro again..\n" +
    "Instead of having to write it all and style it again\n" +
    "I can simply turn it into a function using the [red]'Void 'Name of function' { Whatever is going to Happen }'[/] commands\n" +
    "It Can easily be Brought in later on.").Justify(Justify.Left));
}
void paragraph(string word, string word2)
{
AnsiConsole.Write(new Markup("\n\nWhere methods start to get really interesting\n" +
    "Is when you start to introduce " + word +
    "\nThey allow you to pass information such as " + word2 +
    "\nAnd use and modify its contents.").Justify(Justify.Left));
}
int welcomeCalc()
{
    AnsiConsole.MarkupLine("Welcome to our Calculator Using [bold red]Methods[/]\n");
    AnsiConsole.MarkupLine("[green]What would you like to do[/]");
    AnsiConsole.MarkupLine("[red]\n1. Addition\n" +
        "2. Subtraction\n" +
        "3. Division\n" +
        "4. Multiplication\n[/]");
    AnsiConsole.Markup("[green]Option: [/]");
    int choice = Convert.ToInt32(Console.ReadLine());
    return choice;
}
void calculate(int choiceNMB)
{
    if (choiceNMB == 1)
    {
        AnsiConsole.MarkupLine("[purple]\nChoice: Addition[/]");
        addition();
    }
    else if (choiceNMB == 2)
    {
        AnsiConsole.MarkupLine("[purple]\nChoice: Subtraction[/]");
        subtraction();
      
    }
    else if (choiceNMB == 3)
    {
        AnsiConsole.MarkupLine("[purple]\nChoice: Division[/]");
       division();
    
    }
    else if (choiceNMB == 4)
    {
        AnsiConsole.MarkupLine("[purple]\nChoice: Multiplication[/]");
        multiplication();
        
    }
}
int addition()
{
    int num1 = 0;
    int num2 = 0;
    int result = 0;

    AnsiConsole.Write(new Markup("\n[green]Enter Number 1:[/] "));
    num1 = Convert.ToInt32(Console.ReadLine());
    AnsiConsole.Write(new Markup("[green]Enter Number 2:[/] "));
    num2 = Convert.ToInt32(Console.ReadLine());
    result = num1 + num2;
    AnsiConsole.MarkupInterpolated($"\n[green]Result:[/] [red]{num1} + {num2} = {result}[/]");

    return result;
}
int subtraction()
{
    int num1 = 0;
    int num2 = 0;
    int result = 0;

    AnsiConsole.Write(new Markup("\n[green]Enter Number 1:[/] "));
    num1 = Convert.ToInt32(Console.ReadLine());
    AnsiConsole.Write(new Markup("[green]Enter Number 2:[/] "));
    num2 = Convert.ToInt32(Console.ReadLine());
    result = num1 - num2;
    AnsiConsole.MarkupInterpolated($"\n[green]Result:[/] [red]{num1} - {num2} = {result}[/]");

    return result;
}
double division()
{
    int num1 = 0;
    int num2 = 0;
    double result = 0;

    AnsiConsole.Write(new Markup("\n[green]Enter Number 1:[/] "));
    num1 = Convert.ToInt32(Console.ReadLine());
    AnsiConsole.Write(new Markup("[green]Enter Number 2:[/] "));
    num2 = Convert.ToInt32(Console.ReadLine());
    result = num1 / num2;
    AnsiConsole.MarkupInterpolated($"\n[green]Result:[/] [red]{num1} / {num2} = {result}[/]");

    return result;
}
double multiplication()
{
    int num1 = 0;
    int num2 = 0;
    double result = 0;

    AnsiConsole.Write(new Markup("\n[green]Enter Number 1:[/] "));
    num1 = Convert.ToInt32(Console.ReadLine());
    AnsiConsole.Write(new Markup("[green]Enter Number 2:[/] "));
    num2 = Convert.ToInt32(Console.ReadLine());
    result = num1 * num2;
    AnsiConsole.MarkupInterpolated($"\n[green]Result:[/] [red]{num1} * {num2} = {result}[/]");

    return result;
}



Intro();

//We can also pass variables in place of Strings
//string sneakyword = "Socialism Into the Republic";
//string sneakyword2 = "The are flowers in Antartica";
//paragraph(sneakyword, sneakyword2);

paragraph("Parameters", "Variables and Lists");
calculate(welcomeCalc());

