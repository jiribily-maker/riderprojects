/*
try
{
    string? input = Console.ReadLine();
    int divider = int.Parse(input ?? "");
    int result = 10 / divider;
    Console.WriteLine(result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Pokusili jsme se delit nulou");
}
catch (FormatException)
{
    Console.WriteLine("Pokusili jsme se zadat text");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


int age;
while (true)
{
    try
    {
        Console.WriteLine("zadejte vek");
        age= int.Parse(Console.ReadLine());
        break;
    }
    catch (FormatException e) {Console.WriteLine(e.Message);}
}
Console.WriteLine($"zadali jste vek: {age}");


bool succes = int.TryParse(Console.ReadLine(), out int number);

if (!succes)
{
    Console.WriteLine("spatny vstup");
}
else
{
    Console.WriteLine("zadane cislo" + number);
}


int age;
while (true)
{
    Console.WriteLine("zadejte vek:");
    if (int.TryParse(Console.ReadLine(), out age))
    {
        break;
    }
    Console.WriteLine("spatny prevod");
}
Console.WriteLine("zadali jste " + age);

while (true)
{
    Console.WriteLine("zadejte 1. cislo:");
    string text1 = Console.ReadLine();
    Console.WriteLine("zadejte 2. cislo:");
    string text2 = Console.ReadLine();
    
    if (int.TryParse(text1, out int a) && int.TryParse(text2, out int b))
    {
        try
        {
            int vysledek = a / b;
            Console.WriteLine($"vysledek: {vysledek}");
            break;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("pokousis se delit nulou!!");
        }
    }
    else
    {
        Console.WriteLine("nezadal si cislo!");
    }
}
*/
Console.Clear();

int cislo1 = prevod("Zadej první číslo: ");
int cislo2 = prevod("Zadej druhe číslo: ");
calculator kalkulacka = new calculator();
int vysledek = kalkulacka.divide(cislo1, cislo2);
Console.WriteLine($"vysledek: {vysledek}");
int prevod(string vyzva)
{
    while (true)
    {
        Console.Write(vyzva);
        if (int.TryParse(Console.ReadLine(), out int cislo))
        {
            return cislo;
        }
        Console.WriteLine("nezadal si cislo!!");
    }

}

class calculator
{
    public int  divide(int a,int b)
    {
        try
        {
            int vysledek = a / b;
            return vysledek;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
            return 0;
        }
    }
}

