class HolubService : IMessageService
{
    public void SendMessage(string target, string message)
    {
        Console.WriteLine($"sending holub to {target}: {message}");
    }
}