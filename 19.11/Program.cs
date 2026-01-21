
using System.Data.SqlTypes;

string path = "zaci.txt";
int pocetzaku = 0;
int celkovyvek = 0;
try
{
    StreamReader sr = new StreamReader(path);
    string line = sr.ReadLine();

    while (line != null)
    {
        string[] casti = line.Split(';');
        Console.WriteLine(casti[0] + casti[1]);
        int vek = int.Parse(casti[2]);
        pocetzaku++;
        celkovyvek = celkovyvek + vek;
        line = sr.ReadLine();
    }

    sr.Close();
    int prumervek = celkovyvek / pocetzaku;

    Console.WriteLine(prumervek);

    StreamWriter sw = new StreamWriter(path, true);

    sw.WriteLine("\nCelkovy pocet zaku: " + pocetzaku);
    sw.WriteLine("\n prumerny vek: " + prumervek);
    sw.WriteLine("\n celkovy vek: " + celkovyvek);

    sw.Close();

}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
