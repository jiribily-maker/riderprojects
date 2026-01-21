Console.Clear();

 int[] cisla = new int[10];

 for (int i = 0; i < cisla.Length; i++)
 {
     Console.WriteLine("zadejte cislo: ");
    string hodnota = Console.ReadLine();
    int cislo = int.Parse(hodnota);
    cisla[i] = cislo;
 }

 for (int i = 0; i < (cisla.Length -1); i++)
 {
     Console.Write(cisla[i]);
 }

 int[] cislaopak = new int[cisla.Length];

 for (int i = 0; i < cisla.Length; i++)
 {
     cislaopak[i] = cisla[cisla.Length - 1 - i];
 }

Console.WriteLine("");
 for (int i = 0; i <= cislaopak.Length; i++)
 {
     Console.Write(cislaopak[i]);
 }