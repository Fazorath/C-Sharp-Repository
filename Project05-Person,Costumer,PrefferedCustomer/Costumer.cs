public class Customer : IPerson
{
    // Properties from IPerson interface
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }

    // Mumber and Mailing list properties needed
    public int CustomerNumber { get; set; }
    public bool IsOnMailingList { get; set; }

 
    public Customer()
    {
        // Default constructor
    }

    public override string ToString()
    {
       return  $"Name: {FirstName} {LastName}\n" +
               $"Address: {City}, {State} {ZipCode}\n" +
               $"On Mailing List: {IsOnMailingList}\n" +
               $"Customer Number: {CustomerNumber}\n";
    }
}
