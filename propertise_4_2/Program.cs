Console.Clear();
/*
Car car = new Car();
car.Year = 2025;
Console.WriteLine(car.Year);

class Car
{
    public int Year
    { 
        get;
        set;
    }
      
}
*/

// Ukol 1
/*
Person person1 = new Person("Adam");
Console.WriteLine(person1.GetInfo());
Person person2 = new Person("Petr", 17);
Console.WriteLine(person2.GetInfo());
public class Person
{
    public string Name;
    public int Age;

    public Person(string name)
    {
        this.Name = name;
        this.Age = 0;
    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public string GetInfo()
    {
        return $"{Name} is {Age} years old";
    }
}

//Ukol 2

Product product = new Product();
product.Name = "kolo";
product.Price = 1200;
Console.WriteLine($"{product.Name}: ${product.Price}");
public class Product
{
    
    private string _name;
    private int _price;

    public string Name
    {
        get{  return _name; }
        set{_name=value;}

    }

    public int Price
    {
        get { return _price; }
        set
        {
            if (value > 0) _price = value;
        }
    }
}
*/

Person person = new Person("David", 23, "david.marek@academicschool.cz");

public class Person
{
    public string Name
    {
        get;
        set;
    }

    public int Age
    {
        get;
        set;
    }

    public string Email
    {
        get;
        set;
    }
    public Person(string name, int age, string email)
    {
        Name = name;
        Age = age;
        Email = email;
    }
    
}