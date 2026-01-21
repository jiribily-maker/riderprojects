// See https://aka.ms/new-console-template for more information
int cisloInt;
bool opak;
opak = true;

while (opak == true)
{
    while (true)
    {
        Console.Clear();
        Console.Write("zadejte cislo: ");
        string cislo = Console.ReadLine();
        if (cislo == "")
        {
            Console.Clear();
            Console.WriteLine("nebylo zadana hodnota");
            continue;
        }

        if (int.TryParse(cislo, out cisloInt))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("nebylo zadano cislo");
            continue;
        }
    }

    if (cisloInt % 3 == 0 && cisloInt % 5 == 0)
    {
        Console.Clear();
        Console.WriteLine("fizzbuzz");
    }
    else if (cisloInt % 3 == 0)
    {
        Console.Clear();
        Console.WriteLine("fizz");
    }
    else if (cisloInt % 5 == 0)
    {
        Console.Clear();
        Console.WriteLine("buzz");
    }
    else
    {
        Console.WriteLine(cisloInt);
    }

    while (true)
    {
        Console.Write("chcete opakovat? [ano/ne] ");
        string op = Console.ReadLine();
        if (op == "ano")
        {
            break;
        }
        if (op == "ne")
        { 
            opak = false;
            break;
        }
        else
        {
            Console.WriteLine("nebyla zadan spravna hodnota");
        }
    }
}    


