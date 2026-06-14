public class deck : card
{
    public string finalznak { get; set; }
    public string finalcislo { get; set; }
    
    public int finalhodnota { get; set; }

    //LIST NA UKLADANI AKTUALNICH KARET
    public List<string> MojeKarty { get; set; } = new List<string>();
    public override void randomcard()
    {
        base.randomcard();
        base.randomznak();
        finalcislo = cislo;
        finalznak = symbol;
        
        MojeKarty.Add($"{finalcislo} --- {finalznak}");

        // VÝPOČET HODNOTY
        if (finalcislo == "J" || finalcislo == "Q" || finalcislo == "K")
        {
            finalhodnota += 10;
        }
        else if (finalcislo == "A" && finalhodnota > 10) 
        {
            finalhodnota += 1;
        }
        else if (finalcislo == "A" && finalhodnota <= 10) 
        {
            finalhodnota += 11;
        }
        else
        {
            int cisloint = int.Parse(finalcislo);
            finalhodnota += cisloint;
        }
    }
    
    public int soucet()
    {
        return finalhodnota;
    }
}