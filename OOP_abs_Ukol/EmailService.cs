class EmailService : IMessageService
{
    public void SendMessage(string target, string message)
    {
        Console.WriteLine($"sending Email to {target}: {message}");
    }
}