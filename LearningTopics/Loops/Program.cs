// See https://aka.ms/new-console-template for more information
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Learning Loops");

// FOR LOOP
/*
Console.WriteLine("How many numbers: ");
int count = Convert.ToInt32(Console.ReadLine());

for  (int i = 1; i <= count; i++)
{
    double result = Math.Pow(2, i);
    Console.WriteLine(result);
}
*/

// WHILE LOOP
/*
Random numbergen = new Random();

int roll = 0;
int attempts = 0;

Console.WriteLine("Press enter to Roll.");
 
while (roll != 6)
{
    Console.ReadKey();
    roll = numbergen.Next(1,7);
    Console.WriteLine($"You rolled: " + roll);
    attempts++;
}

Console.WriteLine($"It took you {attempts} attempts");
*/

// 2 DICE ROLL CHALLENGE
Random random = new Random();

Console.WriteLine("Press Enter to Roll the Dice.");
Console.WriteLine();

int dice1roll = 0;
int dice2roll = 1;
int attempts = 0;

while (dice1roll != dice2roll)
{
    Console.ReadKey();

    dice1roll = random.Next(1, 7);
    dice2roll = random.Next(1, 7);
    Console.WriteLine($"Dice1 Roll: {dice1roll}\nDice2 Roll: {dice2roll}\n");
    attempts++;
}
Console.ForegroundColor= ConsoleColor.Green;
Console.WriteLine($"It took you {attempts} attempts to roll two of a kind.");