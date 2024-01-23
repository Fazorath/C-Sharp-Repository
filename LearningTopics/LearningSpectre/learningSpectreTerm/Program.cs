using Spectre.Console;

AnsiConsole.Write(new FigletText("Learning Spectre\n\n").Color(Color.Green));



AnsiConsole.Write("\n\nFirst up we have..\n");
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
Console.WriteLine($"\nUsername: {name}\nPassword: {password}");
Console.WriteLine();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Press Enter to move on..\n");


Console.ReadKey();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"Now we are going to be messing with...");
var progressbar_title = new Rule("[red]PROGRESS BARS[/]");
progressbar_title.Justification = Justify.Center;
AnsiConsole.Write(progressbar_title);


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
        var task1 = ctx.AddTask("[green]Reticulating splines[/]");
        var task2 = ctx.AddTask("[green]Folding space[/]");

        while (!ctx.IsFinished)
        {
            // Simulate some work
            await Task.Delay(4300);

            // Increment
            task1.Increment(9.7);
            task2.Increment(7.3);
        }
    });
