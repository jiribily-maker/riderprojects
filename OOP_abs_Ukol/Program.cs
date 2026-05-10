var services = new List<IMessageService>{
    new EmailService(),
    new SmsService(),
    new HolubService()
};
NotificationManager.NotifyAll(services, "Jirka", "co vy tu velice");