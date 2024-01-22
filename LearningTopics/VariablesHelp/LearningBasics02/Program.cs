// See https://aka.ms/new-console-template for more information
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine("LEARNING BASICS 02 - VARIABLES");
Console.WriteLine("------------------------------------------------------------------\n");

Console.Write("What is your Username: ");
string username = Console.ReadLine();
Console.WriteLine("Hello " + username + ", Nice to meet you!");
Console.Write("\n");

/*
int num01;
int num02;

Console.Write("Enter 1st Number -> ");
num01 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter 2nd Number -> ");
num02 = Convert.ToInt32(Console.ReadLine());

int result = num01 + num02;
Console.Write("Result = " + result);
Console.ReadKey();
*/

Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine("Challenge - Find the Average");
Console.WriteLine("------------------------------------------------------------------\n");

int num1;
int num2;
int num3;

Console.Write("Enter num1: ");
Console.ForegroundColor = ConsoleColor.White;
num1 = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Enter num2: ");
Console.ForegroundColor = ConsoleColor.White;
num2 = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Enter num3: ");
Console.ForegroundColor = ConsoleColor.White;
num3 = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.DarkRed;
double average = (num1 + num2 + num3) / 3;
Console.WriteLine("Result: " + average);