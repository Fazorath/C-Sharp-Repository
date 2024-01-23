using Spectre.Console;

AnsiConsole.Write(new FigletText("Learning Spectre\n\n").Color(Color.Red).Centered());



AnsiConsole.MarkupLine("\n[bold]First things first.. Prompts..[/]");
var prompttitle = new Rule("[red]PROMPTS AND ASK[/]");
prompttitle.Justification = Justify.Center;
AnsiConsole.Write(prompttitle);
Console.WriteLine("Prompts and Asks allow us to create a section which we can edit\n" +
    "and the user can have a seamless input experience,\n" +
    "we start this off by creating a variable.\n");

Console.ForegroundColor = ConsoleColor.Red;
AnsiConsole.WriteLine("var name = AnsiConsole.Ask<string>(\"What's your [green]name[/]?\")\n");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Here is what our Example looks like:");

var name = AnsiConsole.Ask<string>("What's your [red]name[/]?");
var password = AnsiConsole.Prompt(new TextPrompt<string>("Enter your [red]Password[/]: ")
    .PromptStyle("red")
    .Secret());
Console.ForegroundColor= ConsoleColor.DarkGreen;
if (name != "Brandon")
{
Console.WriteLine($"\nUsername: {name}\nPassword: {password}");
Console.WriteLine();
Console.WriteLine();
}
if (name =="Brandon")
{
    Console.WriteLine("\nNah Because you really thought you were on some goat shit\n" +
        "well guess what lil boy\n" +
        "You are..\n" +
        "\nI Love you Lil Man");
    Console.WriteLine($"\nUsername: {name}\nPassword: {password}\n");
    
}




Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Press Enter to move on..\n");


Console.ReadKey();
Console.ForegroundColor = ConsoleColor.White;
AnsiConsole.MarkupLine("\n[bold]Next were going to be talking about...[/]"); 
var progressbar_title = new Rule("[red]PROGRESS BARS[/]");
progressbar_title.Justification = Justify.Center;
AnsiConsole.Write(progressbar_title);
AnsiConsole.MarkupLine("Progress bars are a very aesthetic way of showing\n" +
    "well.. [red]Progress[/]. It can be edited in many ways and even included other things\n" +
    "Which arent shown in our example.");


// Asynchronous
await AnsiConsole.Progress()
    .Columns(new ProgressColumn[]
    {
        new TaskDescriptionColumn(),    // Task description
        new ProgressBarColumn(),        // Progress bar
        new PercentageColumn(),         // Percentage
        new RemainingTimeColumn(),      // Remaining time
        new SpinnerColumn(),            // Spinner
    })
    .StartAsync(async ctx =>
    {
        // Define tasks
        var task1 = ctx.AddTask("[green]Breaking Backs[/]");
        var task2 = ctx.AddTask("[green]Folding the space time continium[/]");
        var task3 = ctx.AddTask("[red]Crazy statements are my Forte[/]");

        while (!ctx.IsFinished)
        {
            // Simulate some work
            await Task.Delay(2500);
       

            // Increment
            task1.Increment(9.7);
            task2.Increment(7.3);
            task3.Increment(17);
  
        }
    });
