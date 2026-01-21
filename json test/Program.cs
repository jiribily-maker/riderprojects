using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

 public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
}

class Program
{
    static void Main()
    {
        Console.Clear();
        string path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "users.json");
        path = Path.GetFullPath(path);         
        List<User> users = new List<User>();

        
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            Console.WriteLine("Načteno " + users.Count + " uživatelů.");
        }
        else
        {
            Console.WriteLine("Soubor nenalezen, vytvářím nový...");
        }

        
        Console.Write("Zadejte jméno: ");
        string jmeno = Console.ReadLine();

        Console.Write("Zadejte heslo: ");
        string heslo = Console.ReadLine();

        users.Add(new User() { Username = jmeno, Password = heslo });

        
        string newJson = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(path, newJson);

        Console.WriteLine("Uživatel uložen! JSON soubor: " + path);
    }
}