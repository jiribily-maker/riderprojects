class Program
{
    // Globální proměnné
    static deck balicek_hrac;
    static deck balicek_dealer;

    static void vypis_skore()
    {
        Console.Clear();
        
        // Výpis všech kart dealera
        Console.WriteLine("Dealer cards:");
        foreach (string karta in balicek_dealer.MojeKarty)
        {
            Console.WriteLine($"  {karta}");
        }
        Console.WriteLine($"Soucet dealer: {balicek_dealer.soucet()}");
        Console.WriteLine("____________");
        
        // Výpis všech kart hráče
        Console.WriteLine("Player cards:");
        foreach (string karta in balicek_hrac.MojeKarty)
        {
            Console.WriteLine($"  {karta}");
        }
        Console.WriteLine($"Soucet: {balicek_hrac.soucet()}");
        Console.WriteLine("____________");
    }

    static void Main()
    {
        while (true)
        {
            //NOVÉ KOLO (VYNULOVÁNÍ)
            balicek_hrac = new deck();
            balicek_dealer = new deck();

            Console.Clear();
            
            balicek_dealer.randomcard();
            balicek_hrac.randomcard();

            bool hracHraje = true;
            bool hracPrekrocil = false;
            
            while (hracHraje)
            {
                vypis_skore();
                Console.WriteLine("Hit?[1] or Stay[2]");
                string rozhodnuti = Console.ReadLine();

                if (rozhodnuti == "1")
                {
                    balicek_hrac.randomcard();
                    vypis_skore();

                    if (balicek_hrac.finalhodnota > 21)
                    {
                        Console.WriteLine(" BUST! Dealer vyhrál.");
                        hracHraje = false;
                        hracPrekrocil = true;
                    }
                    else if (balicek_hrac.finalhodnota == 21)
                    {
                        Console.WriteLine("Blackjack! Máš 21.");
                        hracHraje = false; //ABY HRAC STAL A CEKAL NA DEALERA
                    }
                }
                else if (rozhodnuti == "2")
                {
                    hracHraje = false;
                }
            }
            
            if (!hracPrekrocil)
            {
                Console.WriteLine("dealer hraje...");
                Thread.Sleep(1500);

                //DEALER BERE DOKUD NEMA 17
                while (balicek_dealer.soucet() < 17)
                {
                    balicek_dealer.randomcard();
                    vypis_skore();
                    Console.WriteLine("Dealer si líznul kartu...");
                    Thread.Sleep(1500);
                }
                
                vypis_skore();
                Console.WriteLine("===== VÝSLEDEK KOLA =====");

                int skoreHrac = balicek_hrac.soucet();
                int skoreDealer = balicek_dealer.soucet();

                if (skoreDealer > 21)
                {
                    Console.WriteLine("Dealer BUST! Vyhrál jsi!");
                }
                else if (skoreDealer > skoreHrac)
                {
                    Console.WriteLine("Dealer má větší součet. Dealer vyhrál.");
                }
                else if (skoreDealer < skoreHrac)
                {
                    Console.WriteLine("Máš větší součet. Vyhrál jsi!");
                }
                else
                {
                    Console.WriteLine("Remíza! (Push)");
                }
            }
            
            Console.WriteLine("\nChceš hrát další kolo? [napiš 'ano' pro novou hru / cokoliv jiného pro konec]");
            string znovu = Console.ReadLine();
            
            if (znovu != "ano")
            {
                Console.WriteLine("Díky za hru!");
                break; 
            }
        }
    }
}
