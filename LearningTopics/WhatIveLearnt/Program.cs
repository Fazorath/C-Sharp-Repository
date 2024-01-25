using Spectre.Console;
using System.Reflection.Metadata;


void introduction()
{
    AnsiConsole.Write(new FigletText("LEARNT IN C#").Color(Color.DarkSeaGreen3).Centered());

    Console.ForegroundColor = ConsoleColor.DarkRed;
    AnsiConsole.Write(new Markup("[DarkSeaGreen3]This will essentially be one big program in where i will write\n" +
         "as time goes on more of the stuff i learn and with examples and stuff while also'\n" +
         "trying to make it look good and sxy[/]").Centered());
    AnsiConsole.Write(new Rule());

}

string userchoice()
{
    string choice = "";
    choice = displayUcerChoices();
    return choice;
 
}

string displayUcerChoices()
{
    // Ask for the user's favorite fruit
    AnsiConsole.Write(new Markup("[DarkSeaGreen3]So far this would [red]be most of what i have learned[/]\n" +
        "Obviously as time goes by it will be updated and made nicer as i get better.\n" +
        "This is also being done with my python rep mainly as a way for practice\n" +
        "And i also [red]quite enjoy doing them..[/]\n[/]").Centered());
    string userselection = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("[DarkSeaGreen3]Please make a selection:[/]")
            .PageSize(10)
            .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
            .AddChoices(new[] {
            "[green]Strings[/]", "[green]Loops[/]", "[green]If Else Statements[/]",
            "[green]Methods[/]", "[green]Spectre[/]", "[green]Todo[/]",
            "[green]Todo[/]", "[green]Todo[/]", "[green]Todo[/]",
            })
            .HighlightStyle("Red"));
    return userselection;

    

}
introduction();
userchoice();


