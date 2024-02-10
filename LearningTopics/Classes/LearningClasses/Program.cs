// See https://aka.ms/new-console-template for more information
Console.WriteLine("Learning Classes\n" +
    "----------------------------------------------");

Console.WriteLine("You use the class keyword to define a new one\n");

// Test Cat Class
/*
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
*/


// 2 different Instances of the wizard class using parameters and a constructor.
Wizard Wizard01 = new Wizard("Voldemort","Avada");
Wizard01.CastSpell();

Wizard Wizard2 = new Wizard("Yannah","Avada");
Wizard2.CastSpell();






class Wizard
{
    public string name;
    public string favoritespell;
    public string description;
    public int spellslots;
    public float experience;

    public Wizard(string _name, string _favoritespell)
    {
        name = _name;
        favoritespell = _favoritespell;
        spellslots = 2;
        experience = 0;

    }


    public void CastSpell()
    {
        if (spellslots > 0)
        {
            Console.WriteLine("\n"+name + " Casts " + favoritespell);
            spellslots--;
            experience += 0.3f;
            
        } else
        {
            Console.WriteLine(name +" is out of spell slots");
        }

    }
    public void Meditate()
    {
        Console.WriteLine(name + " Mediates to regain spell slots");
        spellslots = 2;
    }
}