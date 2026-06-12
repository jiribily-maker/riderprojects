using Pokedex;

Console.Clear();
List<Command> commands = CommandRegistry.GetCommands();
var state = new PokedexState();
while (true)
{
    Console.Write("Pokedex>");
    var words = CleanInput(Console.ReadLine().ToLower());
    if (words.Count() == 0)
    {
        continue;
    }

    var command = commands.Find(c => c.Name == words[0]);
    if (command == null)
    {
        Console.WriteLine("No such command");
        continue;
    }

    command.Action(state);
    
}
    
List<string> CleanInput(string? input)
{
    if (input == null)
    {
        return [];
    }
    return input.Split(' ', StringSplitOptions.RemoveEmptyEntries|StringSplitOptions.TrimEntries).ToList();
}

