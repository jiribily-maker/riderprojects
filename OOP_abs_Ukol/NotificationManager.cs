class NotificationManager
{
    public static void NotifyAll(
        List<IMessageService> services,
        string target,
        string message) 
    {
        foreach (var service in services)
        {
            service.SendMessage(target, message);
        }
    }
}