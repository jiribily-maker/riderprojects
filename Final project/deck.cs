public class deck : card
{
    public string finalznak { get; set; }
    public string finalcislo { get; set; }

    public override void randomcard()
    {
        base.randomcard();
        finalcislo = cislo;
    }

    public override void randomznak()
    {
        base.randomznak();
        finalznak = symbol;
    }
    
}
    