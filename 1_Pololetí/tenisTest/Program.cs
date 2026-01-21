while (true)
{
    int A_body = 0;
    int B_body = 0;
    int A_sety = 0;
    int B_sety = 0;
    int A_gemy = 0;
    int B_gemy = 0;
    bool vyhrál =  true;
    string advant_A = "";
    string advant_B = "";
    string vyh = "";


    void vypiskore()
    {
        Console.WriteLine($"Body: {A_body}-{B_body}");
        Console.WriteLine($"Gemy: {A_gemy}-{B_gemy}");
        Console.WriteLine($"Sety: {A_sety}-{B_sety}");
    }

    

    while (vyhrál)
    {
        vypiskore();
        Console.WriteLine("Kdo vyhrál [a/b]: ");
        string Vyhra_Hrac= Console.ReadLine();
        switch (Vyhra_Hrac)
        {
            case "a":
                Console.Clear();
                if (A_body == 0 || A_body == 15)
                {
                    A_body = A_body + 15;
                    break;
                }

                if (A_body == 30)
                {
                    A_body = 40;
                    break;
                }

                if (A_body == 40 && B_body == 40)
                {
                    if (advant_A == "A")
                    {
                        A_gemy = A_gemy + 1;
                        A_body = 0;
                        B_body = 0;
                        break;
                    }
                    Console.WriteLine($"Body: A-{B_body}");
                    advant_A = "A";
                    advant_B = "";
                    break;
                }
                else if (A_body == 40 && B_body != 40)
                {
                    A_gemy = A_gemy + 1;
                    A_body = 0;
                    B_body = 0;
                }

                if (A_gemy == 6)
                {
                    A_sety = A_sety + 1;
                    A_gemy = 0;
                    B_gemy = 0;
                }

                if (A_sety == 2)
                {
                    
                    vyhrál = false;
                    vyh = "A";
                }break;
            
            case "b":
                Console.Clear();
                if (B_body == 0 || B_body == 15)
                {
                    B_body = B_body + 15;
                    break;
                }

                if (B_body == 30)
                {
                    B_body = 40;
                    break;
                }
                if (A_body == 40 && B_body == 40)
                {
                    if (advant_B == "A")
                    {
                        B_gemy = B_gemy + 1;
                        A_body = 0;
                        B_body = 0;
                        break;
                    }
                    Console.WriteLine($"Body: {A_body}-A");
                    advant_A = "";
                    advant_B = "A";
                }
                else if (B_body == 40  && A_body != 40)
                {
                    B_gemy = B_gemy + 1;
                    A_body = 0;
                    B_body = 0;
                }

                if (B_gemy == 6)
                {
                    B_sety = B_sety + 1;
                    B_gemy = 0;
                    A_gemy = 0;
                }

                if (B_sety == 2)
                {
                    vypiskore();
                    vyhrál = false;
                    vyh = "B";
                    break;

                }
                break;
            default:
                Console.WriteLine("Špatný vstup");
                break;
        }
        
        
    }

    if (vyh == "A")
    {
        Console.WriteLine("vyhrál hráč A");
    }
    else
    {
        Console.WriteLine("vyhral hrac B");
    }
    
    Console.WriteLine("chcete hrat znovu? [y/n] ");
    string opak =  Console.ReadLine();
    if (opak == "y")
    {
        continue;
    }
    else if (opak == "n")
    {
        break;
    }
}a