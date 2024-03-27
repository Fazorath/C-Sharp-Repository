public class PreferredCustomer : Customer
{
    public double PurchaseAmount { get; set; }
    public double DiscountLevel { get; private set; }

    public PreferredCustomer()
    {
        // Default constructor
    }

    // Method to calculate and set the discount level based on purchase amount
    public void SetDiscountLevel()
    {
        if (PurchaseAmount >= 2000)
        {
            DiscountLevel = 0.10; // 10% discount
        }
        else if (PurchaseAmount >= 1500)
        {
            DiscountLevel = 0.07; // 7% discount
        }
        else if (PurchaseAmount >= 1000)
        {
            DiscountLevel = 0.06; // 6% discount
        }
        else if (PurchaseAmount >= 500)
        {
            DiscountLevel = 0.05; // 5% discount
        }
        else
        {
            DiscountLevel = 0.0; // No discount
        }
    }
}
