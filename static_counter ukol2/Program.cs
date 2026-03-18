




Enemy enemy1 = new Enemy("Ork",200);
Enemy enemy2 = new Enemy("Goblin",300);

enemy1.Printnfo();
enemy2.Printnfo();

Enemy.SetDifficulty(3);
Console.WriteLine("Obtížnost změněna!!!");

enemy1.Printnfo();
enemy2.Printnfo();


