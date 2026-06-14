public abstract class card
{
    public string cislo { get; set; } 
  public   string symbol {get; set;}
    protected Random nahoda = new Random();
    public virtual  void randomcard()
    {
        List<string> cisla = new List<string> {"A","2","3","4","5","6","7","8","9","10","J","Q","K" };
        
        
        // generuje nahodne cislo od nuly do poctu cisel v listu 
        int nahodnyIndex = nahoda.Next(cisla.Count);
        string vybraneCislo = cisla[nahodnyIndex]; 
        cislo = vybraneCislo;
    }

    public virtual void randomznak()
    {
        List<string> znak = new List<string> { "srdce", "káry", "piky", "kříže" };
       int  nahIndex2 = nahoda.Next(znak.Count);
       string vybranyznak = znak[nahIndex2];
       symbol = vybranyznak;
    }
}