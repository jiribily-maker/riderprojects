// See https://aka.ms/new-console-template for more information

using System.Numerics;

Console.Clear();
while (true)
{
    
        Console.Write("zadejte prvni cislo [pro ukonceni napiste q]:");
        string cislo1 = Console.ReadLine();

        if (cislo1 == "")
        {
            Console.Clear();
            Console.WriteLine("nebylo zadano cislo ");
            continue;
        }
        else if (cislo1 == "q")
        {
            break;
        }
        

        Console.Write("zadejte znamenko [+, -, * , /:");
         string znamenko = Console.ReadLine();

   
        if (znamenko == "")
        { 
            Console.Clear();
            Console.WriteLine("nebylo zadano znamenko ");
            continue;
        }

Console.Write("zadejte druhe cislo:");
    string cislo2 = Console.ReadLine();

    
        if (cislo2 == "")
        { 
            Console.Clear();
            Console.WriteLine("nebylo zadano cislo ");
            continue;
        }

    float cisloj = float.Parse(cislo1);
    float cislod = float.Parse(cislo2);

    Console.WriteLine($"{cisloj} {znamenko} {cislod}");

    switch (znamenko)
    {
        case "+":
            Console.WriteLine(cisloj + cislod);
            break;
        case "-":
            Console.WriteLine(cisloj - cislod);
            break;
        case "*":
            Console.WriteLine(cisloj * cislod);
            break;
        case "/" when cislod == 0:
            Console.WriteLine("nulou nelze delit");
            continue;
        case "/":
            Console.WriteLine(cisloj / cislod);
            Console.WriteLine($"{"zbytek:"}{cisloj % cislod}");
            break;
    }
}
  