
    
    
       Warior warrior =  new Warior("jira",70,"Meč",1);
        List<Enemy> enemies =
        [
            new Goblin("nesta",50),
            new Dragon("mrak",150),
        ];
        
       
   
        foreach (var enemy in enemies)
        {
            while (warrior.IsAlive && enemy.IsAlive)
            {
                warrior.atack(enemy);

                if (enemy.IsAlive)
                {
                    bool wasBlocked = false;

                    if (warrior is IBlockable blockable)
                    {
                        wasBlocked = blockable.Block();
                    }

                    if (!wasBlocked)
                    {
                        enemy.atack(warrior);
                    }
                }
                if(warrior.IsAlive)warrior.LevelUp();
            }
        }
       if(!warrior.IsAlive){
           Console.WriteLine("vyhrál nepřítel");
           Console.WriteLine("_______________________________");
           Console.WriteLine($"přichází mage!!!");
           Console.WriteLine("_______________________________");
       }
       
   Mage mage = new Mage("gandalf", 70, 1,50); 
       
   foreach (var enemy in enemies)
   {
       while (mage.IsAlive && enemy.IsAlive)
       {
           Console.WriteLine($"Chcete útočit za 10 many?[Y/N]");
           string Utok = Console.ReadLine();

           if (Utok== "Y")
           {
               mage.atack(enemy);
           }

           if (enemy.IsAlive)
           {

               enemy.atack(mage);
               if (mage.IsAlive)
               {
                   Console.WriteLine($"máte{mage.health} životů chcete se vyléčit za 20 many[Y/N]");
                   string rozhodnutí = Console.ReadLine();

                   if (rozhodnutí == "Y")
                   {
                       mage.Heal(20);
                   }
               }

           }

           if (mage.IsAlive)
           {
               mage.LevelUp();
           }
           
       }
   }
       
   if(mage.IsAlive || warrior.IsAlive )
   {
       Console.WriteLine("____________");
       Console.WriteLine("vyhrál hráč");
   }
   else
   {
       Console.WriteLine("____________");
       Console.WriteLine("vyhrál nepřítel");

   }