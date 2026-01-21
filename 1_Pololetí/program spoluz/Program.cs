string[] spoluz = new string[] {"Vítek", "Radek", "Jakub", "Tom", "Jan"};


while (true)
{
    Console.Clear();
    bool nenalezeno = true;
    string nejdelsi = "";
    int pocet = 0;
    Console.Write("zadejte jmeno ktere chcete hledat [1 pro ukonceni]: ");
    string jmeno = Console.ReadLine();
    
    if (jmeno == "1") break;

    for (int i = 0; i < spoluz.Length; i++)
    {
        if (jmeno == spoluz[i])
        {
            Console.WriteLine("jmeno nalezeno na " + (i + 1) + ". pozici");
            nenalezeno = !nenalezeno;
        }
    }

    if (nenalezeno)
    {
        Console.WriteLine("uzivatel nebyl nalezen.");
    }

    foreach (string s in spoluz)
    {
        if (s.Length > pocet)
        {
            nejdelsi = s;
            pocet = s.Length;
        }
        else if (s.Length == pocet)
        {
            nejdelsi = nejdelsi + ", " + s;
        }
    }
    Console.WriteLine("nejdelsi jmeno v seznamu je: " + nejdelsi);
}