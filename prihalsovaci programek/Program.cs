using System.Data;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text.Json;

public class User
{
 public string password {get;set;}
 public string username {get;set;}
 public decimal Budget {get;set;}
}
public class Program
{
  static List<User> users = new List<User>();
  static string vyber2;
  static string PrihJmeno;
  static string PrihHeslo;
  static decimal budget;
  private static User prihlasenyUser;
  static void Main()
  {
    string path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "users.json");
    path = Path.GetFullPath(path);         
    List<User> users = new List<User>();
    
    vyberMenu:
    
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
    Console.Clear();
    do
    {
      Console.WriteLine("1. prihlaseni");
      Console.WriteLine(" 2. registrace");
      Console.WriteLine("3. ukonceni");

      string vyber = Console.ReadLine();

      switch (vyber)
      {
        case "1":
        {
          Console.Clear();
          vyber2 = "pr";
          break;
        }
        case "2":
        {
          Console.Clear();
          vyber2 = "rg";
          break;
        }
        case "3":
        {
          Environment.Exit(0);
          vyber2 = "";
          break;
        }
        default:
        {
          Console.Clear();
          Console.WriteLine("nebyla zadana pozadovana hodnota");
          vyber2 = "";
          break;
        }
      }
    } while (vyber2 == "");

    if (vyber2 == "pr")
    {
      for (int x = 0 ; x < 4; x++)
      {
        Console.Clear();
        Console.WriteLine("zadejte prihlasovaci jmeno: ");
        string PrihJmeno = Console.ReadLine();
        Console.WriteLine("zadejte prihlasovaci heslo");
        string PrihHeslo = Console.ReadLine();

        foreach (var user in users)
        {
          if (user.username == PrihJmeno && user.password == PrihHeslo)
          {
            Console.WriteLine($"jste prihlaseni jako {user.username} mate budget {user.Budget}");
            Thread.Sleep(2000);
            budget = user.Budget;
            prihlasenyUser = user;
            goto vyberMenuBank;
          }
        }
        Console.WriteLine("spatne jmeno nebo heslo");
        Thread.Sleep(2000);
      } 
      Console.WriteLine("moc pokusu o prihlaseni");
      Thread.Sleep(2000);
      goto vyberMenu;
    }
    if (vyber2 == "rg")
    {
      rgWhile:
      Console.Clear();
      Console.WriteLine("zadejte jmeno: ");
      string RegJmeno = Console.ReadLine();
      Console.WriteLine("zadejte heslo: ");
      string RegHeslo = Console.ReadLine();

      foreach (var user in users)
      {
        if (user.username == RegJmeno)
        {
          Console.WriteLine("jmeno je obsazeno zadejte jine");
          Thread.Sleep(2000);
          goto rgWhile;
        }
      }

      users.Add(new User { password = RegHeslo, username = RegJmeno, Budget = 100});
      
      string newJson = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
      File.WriteAllText(path, newJson);
      
      Console.WriteLine("uzivatel pridan");
      Thread.Sleep(2000);
      goto vyberMenu;
    }
    
    vyberMenuBank: ;
    
    string opak = "ano";
    string vyber1;
    int vyberciso = 0;
    int vkladciso = 0;

while (opak == "ano")
{
    Console.WriteLine("zacateční budget : " + budget);
    Console.WriteLine("1. výběr peněz");
    Console.WriteLine("2. vklad peněz");
    Console.WriteLine("3. zobrazit zůstatek");
    Console.WriteLine("zadejte číslo operace kterou chcete udělat: ");
    string zadano = Console.ReadLine();

    switch (zadano)
    {
        case "1":
            Console.Clear();
            while (true)
            {
                
                Console.Write("kolik peněz chcete vybrat? ");
                vyber1 = Console.ReadLine();

                if (int.TryParse(vyber1, out vyberciso))
                {
                    if (vyberciso <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("nelze vybrat zaporne cislo");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("nebylo zadano cislo");
                    continue;
                }
            }

            if (budget < vyberciso)
            {
                Console.WriteLine("nedostatecne finance");
                Console.WriteLine("");
                continue;
            }
            else
            {
                budget = budget - vyberciso;
                prihlasenyUser.Budget = budget;
                string NewJson = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(path, NewJson);
                break;
            }
        
        case "2":
            Console.Clear();
            while (true)
            {
                
                Console.Write("kolik peněz chcete vložit? ");
                string vklad = Console.ReadLine();
                
                if (int.TryParse(vklad, out vkladciso))
                {
                    if (vkladciso <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("nelze vlozit zaporne cislo");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("nebylo zadano cislo");
                    continue;
                }
            }
                
            budget = budget + vkladciso;
            prihlasenyUser.Budget = budget;
          string  NewJson1 = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, NewJson1);
            break;
        
        case "3":
            Console.Clear();
            Console.WriteLine($"zůstatek: {budget}");
            break;
        default:
            Console.Clear();
            Console.WriteLine("nebylo zadano cislo");
            continue;
    }

    while (true)
    {
        Console.Write("chcete opakovat? [ano/ne]: ");
        string otaz = Console.ReadLine();
        if (otaz == "ne")
        {
            Console.Clear();
            goto vyberMenu;
            break;
        }
        else if (otaz == "ano")
        {
            Console.Clear();
            opak = "ano";
            break;
        }
        else
        {
            Console.WriteLine("zadana spatna hodnota");
            continue;
        }
    }
}
  }
} 
