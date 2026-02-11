/*
class Book
{
    public string Author;
    public int Release_Year;
    public int Page_Count;
    public string Name;

    public Book(string Author, int Release_Year, int Page_Count, string Name)
    {
        this.Author=Author;
        this.Release_Year=Release_Year;
        this.Page_Count=Page_Count;
        this.Name=Name;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Author={Author}, Name={Name}");
        Console.WriteLine($"Release year={Release_Year}, Page count={Page_Count}");
    }
}
*/

class Student
{
    public string name;
    public int age;

    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Greet()
    {
        Console.WriteLine($"Hello my name is {name}, and age is {age}");
    }
}