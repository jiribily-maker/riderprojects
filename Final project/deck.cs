public class deck : card
{
    public string finalznak { get; set; }
    public string finalcislo { get; set; }
    
    public int finalhodnota { get; set; }

    public override void randomcard()
    {
        base.randomcard();
        base.randomznak();
        finalcislo = cislo;
        finalznak = symbol;
        
        Console.WriteLine($"{finalznak} --- {finalcislo}");
    }
    

    public int soucet()
    {
        if (finalcislo == "J" || finalcislo == "Q" || finalcislo == "K")
        {
            finalhodnota += 10;
        }

        else if (finalcislo == "A" & finalhodnota > 10)
        {
            finalhodnota += 1;
        }
        else if (finalcislo == "A" & finalhodnota <= 10)
        {
        
            finalhodnota += 11;
        }
        else
        {
          int cisloint = int.Parse(finalcislo);
            finalhodnota += cisloint;
        }
        Console.WriteLine(finalhodnota);
        return finalhodnota;
    }
    
}
    