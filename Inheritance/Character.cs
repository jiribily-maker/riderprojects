class Character
{
    public Character(string name, int level)
    {
        Name = name;
        Level = level;
    }
    
    public string Name { get; set; }
    public int Level { get; set; }

    public virtual void Attack()
    {
        Console.WriteLine($"{Name} útočí!!");
    }
}

class Warior : Character
{
    public string Weapon {get; set;}
    public Warior(string name, int level, string weapon) : base(name, level)
    {
        Weapon = weapon;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} útočí zbraní {Weapon}!!");
    }
}

class Mage : Character
{
    public int ManaPoints {get; set;}
    public Mage(string name, int level,int manapoints) : base(name, level)
    {
        ManaPoints = manapoints;
    }

    public override void Attack()
    {
        if (ManaPoints > 0)
        {
            Console.WriteLine($"{Name} sesílá kouzlo!! A Zbývá mu {ManaPoints} many!!");
            ManaPoints--;
        }
        else
        {
            Console.WriteLine($"{Name} nemá manu a umírá!!");
        }
    }
}