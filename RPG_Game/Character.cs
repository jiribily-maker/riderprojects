abstract class Character : Entity
{ 
    public  int maxHealth { get; set; }
    public int level { get; set; }

    public Character(string name, int health, int level) : base(name, health)
    {
        maxHealth = health;
        
    }
    public virtual void LevelUp()
    {
        level++;
    }
}