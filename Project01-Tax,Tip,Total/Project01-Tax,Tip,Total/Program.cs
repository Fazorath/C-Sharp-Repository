/*
 * Yoenis Hernandez
 * COP 2551
 * 1/19/24
 * Proffesor Montalbano
 * Project 1 Tax/Tip/Total
 */


// Titile
Console.WriteLine("Project 01 - Tax|Tip|Total");
Console.WriteLine();
while (true)
{
double price = 0;

//Prompt aswell as variable assignment
Console.Write("Enter the Total Amount of your purchase: ");
price = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

// Needed Variables
double tax = 0;
double tip = 0;
double total = 0;

// Color so it looks nice
// Assigns the proper math to the proper Variable
// Concantates at the bottom x3
Console.ForegroundColor = ConsoleColor.Green;
tax = (double)(price * 0.15);
Console.WriteLine($"Tax(15%): ${double.Round(tax,4)}");

tip = (double)(price * 0.07);
Console.WriteLine($"Tip(7%): ${double.Round(tip,4)}");

total = (double)(price + tax + tip);
Console.WriteLine($"Total: ${double.Round(total, 4)}");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.White;    
}
// User price Variable
