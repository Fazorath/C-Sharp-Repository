/*
 * Yoenis Hernandez
 * COP 2551
 * 1/19/24
 * Proffesor Montalbano
 * Project 1 Tax/Tip/Total
 * Updated to Use Methods 1/23/24 
 */


// Variables Needed
double price = 0;
double tax = 0;
double tip = 0;
double total = 0;


// Method/Function for displaying the title
void displayTitle()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Project 01 - Tax|Tip|Total");
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine();
}

// Method/Function for Displaying and returning the input Purchaseprice
double purchasePrice()
{
    Console.Write("Enter the Total Amount of your purchase: ");
    price = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();
    return price;

}

// Calculates and displays the amount paid in taxes
/*
double taxes()
{
    Console.ForegroundColor = ConsoleColor.Green;
    tax = (double)(price * 0.15);
    Console.WriteLine($"Tax(15%): ${double.Round(tax, 4)}");
    return tax;

}
*/
double taxes()
{
    Console.ForegroundColor = ConsoleColor.Green;
    tax = (double)(price * 0.15);
    // Much nicer than the previous version shown above in comments
    Console.WriteLine($"Tax(15%): {tax.ToString("C")}");
    return tax;

}

// Calculates and displays the amount paid in taxes
double tipcalculate()
{
        tip = (double)(price * 0.07);
        Console.WriteLine($"Tip(7%): {tip.ToString("C")}");
        
    return tip;
}

// Calculates the total price after adding all the previous variables(price + tax + tip)
double totalCalc()
{
        total = (double)(price + tax + tip);
        Console.WriteLine($"Total: {total.ToString("C")}");
        Console.ForegroundColor = ConsoleColor.White;  
        return total;
}



// Updated to Use Methods 1/24/24 
displayTitle();
purchasePrice();
taxes();
tipcalculate();
totalCalc();
