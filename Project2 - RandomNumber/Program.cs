// Yoenis Hernandez 
// Started 2/4/24
// Finished 2/6/24
// Project 2 Random Number Generator


// Functions that run the madness
Title();
CheckAnswer();



void Title()
    //Title Function
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Welcome to my Random Number Guesser\n");
    Console.ForegroundColor = ConsoleColor.White;
}
int randomnumber()
    // Returns a random number between 1 and 100 using the Random Built in Class.
{
   Random rnd = new Random(); // Random number as shown in book
    int randnum = rnd.Next(0, 100); // initialized into int variable
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("\nHere is your random Number: ** ");// returns random integers >= 0 and 100
    //Console.WriteLine(randnum);
   return randnum;
}
int userguess()
{
    int guess = 0; // User guess
    Console.Write("\nPlease guess what the number generated is: ");
    guess = Convert.ToInt32(Console.ReadLine()); // Converting string to int
    return guess;

}
void CheckAnswer()
{
    bool play = true;
    while (play)
    {
        int number = randomnumber(); // new random number
        int attempts = 0; // clean attempts

        while (true)
        {
            int answer = userguess(); // user guesses
            attempts++;

            if (answer == number) // if right
            {
                Console.WriteLine("Congratulations you got the correct Answer\n\n" +
                                  "It took you: " + attempts + " Attempt(s)\n" +
                                  "------------------------------------------------");
                break;
            }
            else if (answer > number) // if too high
            {
                Console.WriteLine("Too High. Try Again");
            }
            else // if too low
            {
                Console.WriteLine("Too Low. Try Again");
            }
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Would you like to play again? (Y/N): ");
        Console.ForegroundColor = ConsoleColor.Red;
        string playAgain = Console.ReadLine().ToUpper(); // added upper to make sure input is standard across

        if (playAgain != "Y")
        {
            play = false;
        }
    }
}