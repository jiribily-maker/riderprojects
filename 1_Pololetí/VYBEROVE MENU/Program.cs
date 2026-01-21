

using System.Numerics;

int budget = 1000;
string opak = "ano";
string vyber;
int vyberciso = 0;
int vkladciso = 0;

while (opak == "ano")
{
    Console.WriteLine("zacateční budget: 1000kč");
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
                vyber = Console.ReadLine();

                if (int.TryParse(vyber, out vyberciso))
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
            opak = "ne";
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