// See https://aka.ms/new-console-template for more information
Console.WriteLine("Learning Classes\n" +
    "----------------------------------------------");

Console.WriteLine("You use the class keyword to define a new one\n\n");

Cat cat01 = new Cat();
cat01.name = "Exempt";
cat01.age = 1;
cat01.meow();

class Cat
{
    public string name;
    public int age;
    public void meow()
    {
        Console.WriteLine($"Cat name: {name}\n" +
            $"Cat age: {age}");
    }
}
