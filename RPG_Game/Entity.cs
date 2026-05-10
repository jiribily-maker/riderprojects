abstract class Entity
{
    public string name{get;set;}
    public int health {get; set;}
    
    public int level {get; set;}

    public Entity(string name, int health)
    {
        this.name = name;
        this.health = health;
    }
    
    public bool IsAlive
    {
        get { return health > 0; }
    }
    
    abstract public void atack(Entity target);

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0)
        {
            health = 0;
        }
        Console.WriteLine($"{name} obdrželo {damage} poškození. A zbývá mu {health} HP.");
    }
}

interface IHealable
{
    void Heal(int amount);
}

interface IBlockable
{
    bool Block();
}

