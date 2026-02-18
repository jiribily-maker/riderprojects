class Enemy
{
    private static int _Next_ID = 1;
    public static double DifficultyMultiplier = 1.0;
    public int ID { get; }
    public string Name{get;set;}
    public double BaseHealth {get; set;}


    public double CurrentHealth
    {
        get
        {
            return BaseHealth *  DifficultyMultiplier; 
        }
    }

    public Enemy(string name,double baseHealth)
    {
        Name = name;
        BaseHealth = baseHealth;
        ID = _Next_ID;
        _Next_ID++;
    }

   public static void SetDifficulty(double difficulty)
    {
        DifficultyMultiplier = difficulty;
    }

    public void Printnfo()
    {
        Console.WriteLine($"Name: {Name} Id: {ID} Health: {CurrentHealth}");
    }
}
    