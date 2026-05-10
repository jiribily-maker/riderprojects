using System.Data;

public static class CommandRegistry
{
    public static void Exit()
    {
        Console.WriteLine("Exiting...");
        Environment.Exit(0);
    }

    public static void Help()
    {
        foreach (var x in GetCommands())
        {
            Console.WriteLine(x.Name + ": " + x.Description);
        }
    }

    public static void Ls()
    {
        DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
        foreach (var polozka in di.GetFileSystemInfos())
        {
            string typ = (polozka.Attributes & FileAttributes.Directory) == FileAttributes.Directory ? "[DIR]" : "[FILE]";
    
            Console.WriteLine($"{typ} {polozka.Name,-30} {polozka.LastWriteTime}");
        }
        
    }
    
    

    public static List<Command> GetCommands()
    {
        return
        [
            new Command("exit", "exits the app", Exit),
            new Command("help", "Shows  help", Help),
            new Command("ls", "Lists files in directory", Ls),
        ];
    }
}