// See https://aka.ms/new-console-template for more information
//vaha (kg) / (vyska [m] * vyska [m] )

using System.Numerics;
Console.Clear();

Console.Write("zadejte vysku v (cm)");
string vyska = Console.ReadLine();

Console.Write("zadejte vahu (kg)" );
string vaha = Console.ReadLine();

float vahafl =  float.Parse(vaha);
float vyskafl =  float.Parse(vyska);

float vyskam = vyskafl / 100f;
float vysledek = vyskam * vyskam;
vysledek = vahafl / vysledek;

if (vysledek >= 18.5 && vysledek < 25)
{
    Console.WriteLine("normální");
}
else if (vysledek >= 25 && vysledek < 30)
{
    Console.WriteLine("nadváha");
}
else if (vysledek >= 30)
{
    Console.WriteLine("obezita");
}
else
{
   Console.WriteLine("podváha"); 
}