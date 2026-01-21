
using System.ComponentModel.Design;

Console.Clear();

while (true)
{
    int vys = 1;
    int fakt;
    int mocni;
    
    
    Console.WriteLine("1. vypocet faktorialu");
    Console.WriteLine("2. Vypocet mocniny");
    Console.WriteLine("3. konec");
    
    Console.WriteLine("zadejte operaci: ");
    string oper =  Console.ReadLine();

    if (oper == "1")
    {
        Console.Clear();
        vyber1:
        
        Console.WriteLine("zadejte faktorial: ");
        string fak = Console.ReadLine();
        if (int.TryParse(fak, out fakt))
        {
            for (int i = 1; i <= fakt; i++)
            {
                vys = vys * i;
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("nebylo zadano cislo");
            goto vyber1;
        }

        Console.WriteLine($"vyseldek = {vys}");
        continue;
    }

    if (oper == "2")
    {
        Console.Clear();
        vyber2:
        
        Console.WriteLine("zadejte mocnitele: ");
        string moc = Console.ReadLine();
        Console.WriteLine("zadejte mocninu: ");
        string mocn = Console.ReadLine();

        if (int.TryParse(moc, out int moci) && (int.TryParse(mocn, out mocni)))
        {
            for (int j = 1; j <= mocni; j++)
            {
                vys = vys * moci;
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("nebylo zadano cislo");
            goto vyber2;
        }

        Console.WriteLine($"vyseldek = {vys}");
        continue;
    }

    if (oper == "3")
    {
        Console.Clear();
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("nebyla zadana pozadovana hodnota");
        continue;
    }
}