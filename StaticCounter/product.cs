using System.Runtime.CompilerServices;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    private static int _ProductCount = 0;
    private static double _totalValue = 0;

    public Product(double price,  string name)
    {
        Name = name;
        Price = price;
        _totalValue += price;
        _ProductCount++;
        
    }

    public static void PrintSummary()
    {
        Console.WriteLine($"Celkem produktu {_ProductCount}. Celkova hodnota skladu {_totalValue}");
    }
    
}