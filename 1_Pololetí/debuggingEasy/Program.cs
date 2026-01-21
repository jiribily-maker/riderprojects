//2.1 Úkol 1 - Oprav funkci
void Greet()
{
    Console.WriteLine("Ahoj!");
}
Greet();
Greet();
Greet();



//2.2 Úkol 2 - Doplň podmínky
    Console.Write("Zadej číslo: ");
int number = int.Parse(Console.ReadLine());
if (number > 0)
{
    Console.WriteLine("Kladné číslo");
}
else if (number < 0)
{
    Console.WriteLine("Záporné číslo");
}
else Console.WriteLine("Nula");


//2.3 Úkol 3 - Oprav cyklus while

int i = 1;
while (i < 6)
{
    Console.WriteLine(i);
    i++;
}


//2.4 Úkol 4 - Funkce s parametrem

void PrintText(string text)
{
    Console.WriteLine(text);
}
PrintText("Programování je zábava");


//2.5 Úkol 5 - Oprava cyklu for

for (int z = 0; z < 5; z++)
{
    Console.Write("*");
}