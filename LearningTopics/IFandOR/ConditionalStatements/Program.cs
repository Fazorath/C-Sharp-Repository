// See https://aka.ms/new-console-template for more information
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Learning IF ELSE Statements");
Console.Write("------------------------------\n\n");
// If else Statements
/*
Console.WriteLine("Welcome! Tickets are 5$ Please insert Cash..");
int cash = Convert.ToInt32(Console.ReadLine());

if (cash < 5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Thats not enough money..");
}
else if (cash == 5)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Here is your Ticket!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Blue;
    int change = cash - 5;
    Console.Write("Here is your Ticket and " + change + " Dollar(s) in change.");

}
*/

// If else Statements using AND OR  
/*
int age;
int height;

Console.Write("Please input Age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please input Height (cm): ");
height = Convert.ToInt32(Console.ReadLine());

//Using && is AND
//Using || is OR

if (age >= 18 || height > 160)
{
    Console.Write("You can Enter!");
}
else
{
    Console.Write("You dont meet the requirements");
}
*/

//Solving Math problems
/*
Console.Write("Solve Math Problems!\n\n");
// Correct Answers
int correct1 = 69;
int correct2 = 25;
int correct3 = 10;

//Question 1
Console.WriteLine();
Console.WriteLine("Question 1.");
Console.Write("15 + 50 + 4 = ");
int answer1 = Convert.ToInt32(Console.ReadLine());
if (answer1 == correct1)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Correct Answer!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong Answer!");
}

//Question 2
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Question 2.");
Console.Write("15 + 15 - 5 = ");
int answer2 = Convert.ToInt32(Console.ReadLine());
if (answer2 == correct2)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Correct Answer!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong Answer!");
}

//Question 3
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Question 3.");
Console.Write("15 - 6 + 4 = ");
int answer3 = Convert.ToInt32(Console.ReadLine());
if (answer3 == correct3)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Correct Answer!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong Answer!");
}
*/

//Using Switch Cases
/*
Console.Write("input a numbet between 1 and 5: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

switch (num)
{
    case 1:
        Console.WriteLine("one");
        break;
    case 2:
        Console.WriteLine("Two");
        break;
    case 3:
        Console.WriteLine("Three");
        break;
    case 4:
        Console.WriteLine("Four");
        break;
    case 5:
        Console.WriteLine("Five");
        break;
    default:
        Console.WriteLine("Default");
        break;
}
*/