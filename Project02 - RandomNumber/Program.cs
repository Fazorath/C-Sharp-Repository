// Yoenis Hernandez 
// Started 2/4/24
// Finished 2/6/24
// Project 2 Random Number Generator


// Everything needed to call the Program.
Title();
StartGuesser();



// Functions that run the madness

//Title Function that i messed around with to center in the terminal(big SHOULD work on all terminals)
void Title()
{
    string title = "Welcome to my Random Number Guesser\n";
    int padding = (Console.WindowWidth - title.Length) / 2; // Centering Purposes
    
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(title.PadLeft(padding + title.Length));
    Console.ForegroundColor = ConsoleColor.White;
}

// Returns a random number between 1 and 100 using the Random Built in Class.
int randomnumber()
{
    Random rnd = new Random(); // Random number as shown in book
    int randnum = rnd.Next(0, 100); // initialized into int variable
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("\nHere is your random Number: ** ");// returns random integers >= 0 and 100
    //Console.WriteLine(randnum);
    return randnum;
}

    // Asks the user to guess their number which is assigned to an integer, parsed, and then returned
int userguess()
{
    int guess = 0; // User guess
    Console.Write("\nPlease guess what the number generated is: ");


    guess = int.Parse(Console.ReadLine()); // Converting string to int
    return guess;

}

// Plays a single round of the guesser. Includes a try and a catch for when people are funny.
// and a while loop that determines whether the user guessed within the given parameters and their respective outputs.
void PlayoneRound()
{
    int number = randomnumber(); // new random number
    int attempts = 0; // clean attempts
    try // Kept pressing enter on accident so put in FormatException handling.
    {
        while (true)
        {
            int answer = userguess(); // user guesses            attempts++;

            if (answer == number) // if right
            {
                Console.WriteLine("Congratulations you got the correct Answer\n\n" +
                                  "It took you: " + attempts + " Attempt(s)\n" +
                                  "------------------------------------------------");
                break;
            }
            else if (answer > number) // if too high
            {
                attempts++;
                Console.WriteLine("Too High. Try Again");
            }
            else if (answer < number) // if too low
            {
                attempts++;
                Console.WriteLine("Too Low. Try Again");
            }
        }

        }
    catch (FormatException) // Tada the catch
    {

        Console.ForegroundColor= ConsoleColor.Blue;
        Console.WriteLine("\nInput wasn't in the correct format SmartyPants :| \n");
    }
}

    // Another while loop lol that calls <playoneRound()> function and when finished prompts user if they wants to play again.
    // Plus..
void StartGuesser()
{
    bool play = true;
    while (play)
    {
        PlayoneRound();

        // Would you like to play again ?
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Would you like to play again? (Y/N): ");
        Console.ForegroundColor = ConsoleColor.Red;
        string playAgain = Console.ReadLine().ToUpper();
        Console.Write("------------------------------------------------\n");

        // Aything other than Y prompts this
        if (playAgain != "Y")
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            // Yay binary
            string binary = "01010010 01101001 01100011 01101011 00100000 01110010 01101111 01101100 01101100\n01100101 01100100 00100000 01101101 01100001 01111001 01100010 01100101 00101110 ";
            Console.WriteLine(binary);
            Thread.Sleep(3000); // Messing around with this so included it :)
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.White;
            play = false;
        }
    }
}
