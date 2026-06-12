using System.Text.Json;

Console.Clear();
 /*
HttpClient client = new HttpClient();
    string jsonstring;
    try
    { 
        jsonstring = await client.GetStringAsync("https://catfact.ninja/fact");
    }
    catch (HttpRequestException)
    {
        Console.WriteLine("pozadavek selhal");
        return;
    }

    Response? r = JsonSerializer.Deserialize<Response>(jsonstring);

    if (r == null)
    {
        Console.WriteLine("nepodarilo se najit fakt");
        return;
    }
    Console.WriteLine(r.fact);
    class Response
    {
        public string? fact { get; set; }
        public int? length { get; set; }
    }
    */

Console.WriteLine("zadejte své jméno: ");
string? jmeno = Console.ReadLine();
while (true)
{
    if (jmeno == null || jmeno == "")
    {
        Console.WriteLine("Nebylo zadano jmeno!");
        continue;
    }
    break;
}

HttpClient client = new HttpClient();
string jsonstring;
try
{
    jsonstring = await client.GetStringAsync($"https://api.agify.io/?name={jmeno}.");
}
catch (HttpRequestException)
{
    Console.WriteLine("pozadavek se nepodarilo poslat");
    return;
}

try
{
    PersonPrediction result = JsonSerializer.Deserialize<PersonPrediction>(jsonstring);


    Console.WriteLine($"jmenu: {result.name} je prumerne {result.age} let.");
}
catch
{
    Console.WriteLine("jmeno nebylo nalezeno");
    return;
}

public class PersonPrediction
 { 
    public string name { get; set; }
     public int age { get; set; }
    public int count { get; set; }
 }