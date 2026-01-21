// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;

Console.Clear();
string opak = "ano"; 
while (opak == "ano")
{
    Console.Write("zadejte znamku: ");
    string znamka = Console.ReadLine();

    switch (znamka)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("vyborne");
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("chvalitebne");
            break;
        case "3":
            Console.Clear();
            Console.WriteLine("dobre");
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("dostatecne");
            break;
        case "5":
            Console.Clear();
            Console.WriteLine("nedostatecne");
            break;
        case "":
            Console.Clear();
            Console.WriteLine("nebylo zadano cislo");
            break;
        default:
            Console.Clear();
            Console.WriteLine("nebylo zadano cislo");
            break;
    }

    while (true)
    {
        Console.Write("chcete pokracovat? [ano/ne]: ");
        string zad = Console.ReadLine();

        if (zad == "" )
        {
            Console.Clear();
            Console.WriteLine("nebylo nic zadano");
            continue;
        }
        else if (zad == "ano")
        {
            Console.Clear();
            break;
        }
        else if (zad == "ne")
        {
            Console.Clear();
            opak = "ne";
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("zadana spatna hodnota");
            continue;
        }
    }
}               