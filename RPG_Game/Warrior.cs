class Warior : Character, IBlockable
{
    public string WeponName { get; set; }
    
    public Warior(string name, int health,string weponname,int level) : base(name, health, level)
    {
        WeponName = weponname;
    }

    public override void atack(Entity target)
    {
        int Damage = base.level * 8;
        target.TakeDamage(Damage);
    }

    public bool Block()
    {
        int chance = Random.Shared.Next(100);
        if (chance <= 40)
        {
            Console.WriteLine($"{name} zablokovalo útok");
            return true;
        }
        else
        {
         return false;    
        }
    }

    public override void LevelUp()
    {
        base.LevelUp();
        Console.WriteLine($"hrác{name} postoupil na level {base.level}");
    }
}