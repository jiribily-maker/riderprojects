class Mage : Character, IHealable
{
    int manaPoints {get; set;}
    public Mage(string name, int health, int level,int mana) : base(name, health, level)
    {
        manaPoints = mana;
    }

    public override void atack(Entity target)
    {
        int damage = manaPoints / 2;
        if (manaPoints > 10)
        {
            manaPoints = manaPoints - 10;
            Console.WriteLine($"Magič {name} sesílá kouzlo za {damage} poškození a zbývá mu {manaPoints} many.");
            target.TakeDamage(damage);
        }
        else if (manaPoints < 10) Console.WriteLine($"hráč{name} nemá dost many!!");
    }

    public void Heal(int amount)
    {
        if(manaPoints < 20 ) Console.WriteLine($"hráč{name}nemá dost many!!");
        else
        {
            if (maxHealth == health)
            {
                Console.WriteLine($"hráč{name} má plné životy");
            }
            else
            {
                health += amount;
                Console.WriteLine($"hráč{name} se vyléčil a zbývá mu {health} životů ");
                manaPoints = manaPoints - 20;
            }
        }
    }
    
    public override void LevelUp()
    {
        base.LevelUp();
        Console.WriteLine($"hrác{name} postoupil na level {base.level}");
    }
}
    
