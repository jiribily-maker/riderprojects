// See https://aka.ms/new-console-template for more information


/*do
{
    string s = Console.ReadLine();

    if (s == "konect")
    {
        break;
    }

} while (true);

Console.WriteLine("Program skoncil");

Console.Clear();
int sum = 0;

Console.Write("zadejte do kolika chcete pocitat: ");
string target = Console.ReadLine();
int targeti = int.Parse(target);

for (int i = 1 ;i <=targeti ;i++ )
{
   sum += i;
}
Console.WriteLine($"suma cisel od 0-{target} = {sum}");
*/

using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;


Console.Clear();

/*
    Console.Write("zadejte prvni cislo: ");
    string cis1 = Console.ReadLine();
    Console.Write("zadejte druhe cislo: ");
    string cis2 = Console.ReadLine();

   int start = int.Parse(cis1);
   int end = int.Parse(cis2);
    
for (int i = start; i <= end; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i} sude");
    }
    else
    {
        Console.WriteLine($"{i} liche");
    }
}

Random random = new Random();
int target = random.Next(1, 11);
for (int i = 0; i < 3; i++)
{
    Console.Write("hadej cislo od 1-10: ");
   string cislo = Console.ReadLine();
   int cisloi = int.Parse(cislo);

   if (cisloi == target)
   {
       Console.WriteLine("spravne uhodnuto!!!");
       break;
   }
   
    Console.WriteLine("nespravne cislo");
    if (cisloi < target)
    { 
        Console.WriteLine("spravne cislo je vetsi jak zadane");
    }
    else
    {
        Console.WriteLine("spravne cislo je mensi jak zadane"); 
    }
   
    
   
}
Console.WriteLine("spravne cislo bylo: " + target);
*/
int size = 7;

for (int i = 0; i < size; i++)
{ 
    for (int j = 0; i >= j ; j++)
    {
        Console.Write(j + 1);

    }
    Console.WriteLine();
}