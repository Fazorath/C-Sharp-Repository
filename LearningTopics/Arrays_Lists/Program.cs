using System.Collections.Generic;
Console.ForegroundColor = ConsoleColor.Green;

// Arrays
/*
//An array with a set size of 5
string[] movies = new string[5];
Console.WriteLine(" Type your 5 favorite movies: \n");
//For loop inputting all 5 movies
for (int i = 0; i < movies.Length; i++)
{
    movies[i] = Console.ReadLine();
}
//Sorts
Console.WriteLine("\nMovies Sorted Alphabetically:");
Array.Sort(movies);
//Displays sorted Movies
for (int i = 0; i < movies.Length; i++)
{
    Console.WriteLine($"{i + 1}. {movies[i]}");
}
*/

// Lists
/*
List<string> shoppinglist = new List<string>();
shoppinglist.Add("Dreams");
shoppinglist.Add("Hella water");
shoppinglist.Add("water water");

for (int i = 0; i < shoppinglist.Count; i++)
{
    Console.WriteLine(shoppinglist[i]);
}

shoppinglist.Remove("Dreams");
Console.WriteLine(" - - - - - - - - - - - - - - - - - -");

for (int i = 0; i < shoppinglist.Count; i++)
{
    Console.WriteLine(shoppinglist[i]);
}
*/

// List/Array CHALLENGE

    int arraysize = 0;
Console.Write("How many students are inside of your classroom: ");
arraysize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Enter the name of the Students: \n");

string[] students = new string[arraysize];

for (int i = 0; i < students.Length; i++)
{
    students[i] = Console.ReadLine();
}
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - \n");
Console.WriteLine("Name of students\n");

Console.ForegroundColor = ConsoleColor.Green;
for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine($"{i+1}. { students[i]}");
}

