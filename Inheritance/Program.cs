/*
List<Animal> animals =
[
    new Dog("piškot", "Lablador"),
    new Cat("Micka")
];

foreach (var animal in animals)
{
    animal.Eat();
}

new Cat("micka").EatAndSleep();

class Animal
{
    public Animal(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

     public virtual void Eat()
    {
        Console.WriteLine($"{Name} is eating");
    }
}

class Dog: Animal
{
    public string Breed{get; set;}

    public Dog(string name, string breed) : base(name)
    {
        Breed = breed;
    }

    public override void Eat()
    {
        Console.WriteLine($"Dog named {Name} is eating what a good boyy!!");
    }
    public void Bark()
    {
        Console.WriteLine("Haf Haf!");
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name){}

    public override void Eat()
    {
        Console.WriteLine($"Cat named {Name} is eating what a good girl!");
    }

    public void EatAndSleep()
    {
        base.Eat();
        Console.WriteLine($"Cat named {Name} is sleeping");
    }
}
*/ 
List<Character> characters =
[
    new Warior("Kratos",25,"Sekera"),
    new Mage("Gandalf",12,10),
    new Warior("Herkules",30,"pěsti"),
    
];

foreach (var character in characters)
{
    character.Attack();
}
