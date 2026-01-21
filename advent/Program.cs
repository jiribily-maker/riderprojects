string filename = "input.txt";
if (!File.Exists(filename))
{
    Console.WriteLine($"File {filename} does not exist.");
    return;
}
// Pokud soubor existuje tak jeho řádky načtu do proměnné `lines`
string[] lines = File.ReadAllLines(filename);

var numsA = new List<int>();
var numsB = new List<int>();

foreach (string line in lines)
{
    // Tento kód rozdělí daný řádek, jako rozdělovač používá mezeru
    // jsou zde nastaveny option, které zabrání tomu, 
    // že by nám v array zbyly nějaké prázdné písmena
    string[] numStrings = line.Split(' ', options: StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

    if (numStrings.Length != 2)
    {
        Console.WriteLine("File format is not valid.");
        return;
    }

    // Do Listu čísel přidám levé (index 0) a pravé (index 1) číslo
    numsA.Add(int.Parse(numStrings[0]));
    numsB.Add(int.Parse(numStrings[1]));
    // INFO: Nyní máte array numStrings se dvěma položkami
    // a můžete s ním dále pracovat
}
numsA.Sort();
numsB.Sort();
int vysledek = 0;
int final = 0;
for ( int cis1 = 0; cis1 < numsA.Count; cis1++)
{
vysledek = Math.Abs(numsA[cis1] - numsB[cis1]);
final += vysledek;
} 
Console.WriteLine(final);
int pocet = 0;
int vysled = 0;
for (int ciso1 = 0; ciso1 < numsA.Count; ciso1++)
{
    pocet = 0;
    for (int ciso2 = 0; ciso2 < numsB.Count; ciso2++)
    {
        if (numsA[ciso1] == numsB[ciso2])
        { 
            pocet++;
        }
    }
    vysled += numsA[ciso1] * pocet;
}

Console.WriteLine(vysled);
