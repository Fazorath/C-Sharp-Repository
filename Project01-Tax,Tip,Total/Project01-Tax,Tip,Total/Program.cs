/*
 * Yoenis Hernandez
 * COP 2551
 * 1/19/24
 * Proffesor Montalbano
 * Project 1 Tax/Tip/Total
 * Updated to Use Methods 1/24/24 
 */


// Variables Needed
double price = 0;
double tax = 0;
double tip = 0;
double total = 0;



void displayTitle()
{
    Console.WriteLine("Project 01 - Tax|Tip|Total");
    Console.WriteLine();
}
double purchasePrice()
{
    Console.Write("Enter the Total Amount of your purchase: ");
    price = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();
    return price;

}
double taxes()
{
    Console.ForegroundColor = ConsoleColor.Green;
    tax = (double)(price * 0.15);
    Console.WriteLine($"Tax(15%): ${double.Round(tax, 4)}");
    return tax;

}
double tipcalculate()
{
        tip = (double)(price * 0.07);
        Console.WriteLine($"Tip(7%): ${double.Round(tip,4)}");
        return tip;
}
double totalCalc()
{
        total = (double)(price + tax + tip);
        Console.WriteLine($"Total: ${double.Round(total, 4)}");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;  
        return total;
}



// Updated to Use Methods 1/24/24 
displayTitle();
purchasePrice();
taxes();
tipcalculate();
totalCalc();