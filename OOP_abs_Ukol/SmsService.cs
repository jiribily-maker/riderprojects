class SmsService : IMessageService
{
    public void SendMessage(string target, string message)
    {
        Console.WriteLine($"sending SMS to {target}: {message}");
    }
}