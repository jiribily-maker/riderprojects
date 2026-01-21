/*
  string veta = "dnes je velmi hezky.";
  
  Console.WriteLine(veta.ToUpper());
  Console.WriteLine(veta.ToLower());
  
  Console.WriteLine(veta.Trim());
  Console.WriteLine(veta);
  
  
  Console.WriteLine(veta.Contains("je"));
  Console.WriteLine(veta.IndexOf("dnes"));
  
  Console.WriteLine(veta.StartsWith("dnes"));
  
  Console.WriteLine(veta.EndsWith("."));
  
  Console.WriteLine("zadejte jmeno a prijmeni: ");
  string jmeno = Console.ReadLine();
  
  jmeno = jmeno.Trim();
  Console.WriteLine(jmeno.Length);
  Console.WriteLine(jmeno.ToUpper());
  Console.WriteLine(jmeno.ToLower().Contains("jan"));
  Console.WriteLine(jmeno[0]);
  Console.WriteLine(jmeno[jmeno.Length - 1]);
  
  
  string datum = "2025-11-11T16:00";
  string rok = datum.Substring(0,4);
  string cas = datum.Substring(11);
  string den =  datum.Substring(5,5);
  
  //Console.WriteLine($"rok:{rok}  cas:{cas}  den:{den}");
  
  string text = "cena 100kc, doprava: 50kc";
  string opraveno = text.Replace("kc", "czk");
  Console.WriteLine(opraveno);
  
  string csvRadek = "pavel;novak;30;praha";
  string[] casti = csvRadek.Split(";");
  Console.WriteLine(casti[0]);
  Console.WriteLine(casti[2]);
  
  string veta = "dnes je krasny den";
  string[] slova = veta.Split(" ");
  Console.WriteLine(slova.Length);

  
  
  Console.WriteLine("napiste jmeno a prijmeni: ");
  string jmeno = Console.ReadLine();
  jmeno = jmeno.Trim();
  Console.WriteLine(jmeno.IndexOf(" "));
  string[] casti = jmeno.Split(' ');
  string prvnips = casti[0].Substring(0, 1).ToUpper();
  char druhe = casti[1][0];
  string pis = druhe.ToString().ToUpper();
  string slov = casti[1].Substring(1, casti[1].Length - 1);
 
 Console.WriteLine(prvnips + "." + pis + slov);
*/


using System.Data.Common;
using System.Net.Security;

if (File.Exists("data.txt)"));
{
    StreamReader sr = new StreamReader("data.txt");
    string line =  sr.ReadLine();

    while (line != null)
    {
        Console.WriteLine(line);
        line = sr.ReadLine();
    }
    sr.Close();

    StreamWriter sw = new StreamWriter("data.txt",  true);
    sw.WriteLine("\nHello World!");
    

    for (int i = 0; i < 10; i++)
    {
        sw.WriteLine(i);
    }
    sw.Close();
    
}