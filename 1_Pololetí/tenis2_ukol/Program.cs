
string playerA_body = "0";
string playerB_body = "0";
int playerA_sety = 0;
int playerB_sety = 0;
int playerA_gamy = 0;
int playerB_gamy = 0;

void WriteScore()
{
    Console.WriteLine($"Hrac1 body: {playerA_body}");
    Console.WriteLine($"Hrac2 body: {playerB_body}");
    Console.WriteLine($"Hrac1 gamy: {playerA_gamy}");
    Console.WriteLine($"Hrac2 gamy: {playerB_gamy}");
    Console.WriteLine($"Hrac1 sety: {playerA_sety}");
    Console.WriteLine($"Hrac2 sety: {playerB_sety}");
}

while (true)
{
    Console.Clear();
    WriteScore();
    Console.WriteLine();
    Console.WriteLine("Jaký hráč dal bod?  [a/b]");
    string point =  Console.ReadLine();
    switch (point)
    {
        case "a":
        {
            switch (playerA_body)
            {
                case "0": playerA_body = "15"; break;
                case "15": playerA_body = "30"; break;
                case "30": playerA_body = "40"; break;
                case ("40"):
                {
                    if (playerB_body == "40")
                    {
                        playerA_body = "A";
                        break;
                    }
                    else if (playerB_body == "A")
                    {
                        playerA_body = "40";
                        playerB_body = "40";
                        break;
                    }
                    else
                    {
                        playerA_body = "0";
                        playerA_gamy = playerA_gamy + 1;
                        playerB_body = "0";
                        break;
                    }
                    break;
                }
                case "A":
                { 
                    playerA_body = "0";
                    playerA_gamy = playerA_gamy + 1;
                    playerB_body = "0";
                    break;
                    
                }
            }
            break;
            
        }
        case "b":
        {
            switch (playerB_body)
            {
                case "0": playerB_body = "15"; break;
                case "15": playerB_body = "30"; break;
                case "30": playerB_body = "40"; break;
                case ("40"):
                {
                    if (playerA_body == "40")
                    {
                        playerB_body = "A";
                        playerA_body = "40";
                        break;
                    }
                    else if (playerA_body == "A")
                    {
                        playerB_body = "40";
                        playerA_body = "40";
                        break;
                    }
                    else
                    {
                        playerB_body = "0";
                        playerB_gamy = playerB_gamy + 1;
                        playerA_body = "0";
                        break;
                    }
                    break;
                }
                case "A":
                { 
                    playerB_body = "0";
                    playerB_gamy = playerB_gamy + 1;
                    playerA_body = "0";
                    break;
                    
                }
            }
            break;

            
        }
    }

    if (playerA_gamy == 6)
    {
        playerA_sety = playerA_sety + 1;
        playerA_gamy = 0;
    }
    else if (playerB_gamy == 6)
    {
        playerB_sety = playerB_sety + 1;
        playerB_gamy = 0;
    }

    if (playerA_sety == 2)
    {
        Console.Clear();
        Console.WriteLine("Vyhrál hráč [A]!!");
        Console.WriteLine("chcete hrát znovu? [a/n] ");
        string opak =  Console.ReadLine();
        if (opak == "n") break;
        else 
        {
             playerA_body = "0";
             playerB_body = "0";
             playerA_sety = 0;
             playerB_sety = 0;
             playerA_gamy = 0;
             playerB_gamy = 0;
        }
    }
    if  (playerB_sety == 2)
    {
        Console.Clear();
        Console.WriteLine("Vyhrál hráč [B]!!");
        Console.WriteLine("chcete hrát znovu? [a/n] ");
        string opak =  Console.ReadLine();
        if (opak == "n") break;
        else 
        {
            playerA_body = "0";
            playerB_body = "0";
            playerA_sety = 0;
            playerB_sety = 0;
            playerA_gamy = 0;
            playerB_gamy = 0;
        }
    }
}

