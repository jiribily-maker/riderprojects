abstract class card
{
    string cislo { get; set; } 
    int hodnota { get; set; }
    string znak {get; set;}

    public virtual void randomcard()
    {
        List<string> cisla = new List<string> {"A","2","3","4","5","6","7","8","9","10","J","Q","K" };
        Random nahoda = new Random();
        // generuje nahodne cislo od nuly do poctu cisel v listu 
        int nahodnyIndex = nahoda.Next(cisla.Count);
        
        string vybraneCislo = cisla[nahodnyIndex]; 
        cislo = vybraneCislo;
    }
}