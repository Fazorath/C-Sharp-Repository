// See https://aka.ms/new-console-template for more information

// Changes to How the TERMINAL looks
Console.Title = "SkyNet";
Console.ForegroundColor = ConsoleColor.Green;

// Writes to the terminal
Console.Write("There was once a bear that ate...");
// Changes Terminal color to White
Console.ForegroundColor = ConsoleColor.White;
// Reads input
Console.ReadLine();
// Changes Terminal color back to Green
Console.ForegroundColor = ConsoleColor.Green;

Console.Write("This bear lives inside of a Valley Called..");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Green;

Console.Write("He chose to drive a ...");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Green;

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("He died in a car crash..");