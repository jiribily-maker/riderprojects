using Pokedex.Api;

namespace Pokedex;

public static class CommandRegistry
{
    
    public static Task Exit(PokedexState state) 
    {
        Console.WriteLine("Exiting...");
        Environment.Exit(0);
        return Task.CompletedTask;
    }

    public static Task Help(PokedexState state)
    {
       
        foreach (var x in GetCommands())
        {
            Console.WriteLine(x.Name + ": " + x.Description);
        }
        return Task.CompletedTask;
    }

    public static Task Ls(PokedexState state)
    {
        DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
        foreach (var polozka in di.GetFileSystemInfos())
        {
            string typ = (polozka.Attributes & FileAttributes.Directory) == FileAttributes.Directory ? "[DIR]" : "[FILE]";
            Console.WriteLine($"{typ} {polozka.Name,-30} {polozka.LastWriteTime}");
        }
        return Task.CompletedTask;
    }

 
    public static async Task Map(PokedexState state)
    {
        
        var page = await state.Api.GetLocationAreasAsync(state.NextLocationsUrl);
        
      
        state.NextLocationsUrl = page.next;
        state.PreviousLocationsUrl = page.previous;
        
        foreach (var loc in page.Results)
        {
            Console.WriteLine(loc.Name);
        }
    }
    
    public static async Task MapB(PokedexState state)
    {
        if (state.PreviousLocationsUrl == null)
        {
            Console.WriteLine("Error: Jsi na první stránce, není kam se vrátit.");
            return;
        }

        var page = await state.Api.GetLocationAreasAsync(state.PreviousLocationsUrl);
        
        state.NextLocationsUrl = page.next;
        state.PreviousLocationsUrl = page.previous;

        foreach (var loc in page.Results)
        {
            Console.WriteLine(loc.Name);
        }
    }

    public static List<Command> GetCommands()
    {
        return
        [
            new Command("exit", "exits the app", Exit),
            new Command("help", "Shows help", Help),
            new Command("ls", "Lists files in directory", Ls),
            new Command("map", "Shows next 20 location areas", Map),
            new Command("mapb","Show previous locations",MapB),
        ];
    }
}