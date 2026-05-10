
class Enemy : Entity
{
    public Enemy(string name, int health) : base(name, health)
    {
    }

    public override void atack(Entity target)
    {
    }
}

class Goblin : Enemy
{
    public Goblin(string name, int health) : base(name, health)
    {
    }

    public override void atack(Entity target)
    {
        int damage = 8;
        Console.WriteLine($"Goblin{name} útočí a dává poškození {damage}!");
        target.TakeDamage(damage);
    }
}

class Dragon : Enemy
{
    public Dragon(string name, int health) : base(name, health)
    {
    }


    public override void atack(Entity target)
    {
        int damage = 25;
        Console.WriteLine($"Drak{name} chrlí oheň a dává {damage} poškození");
        target.TakeDamage(damage);

    }
}