using System;

interface INotifier
{
    void Send(string message);
}

class EmailNotifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine(
            "Email Notification : " + message);
    }
}

abstract class NotifierDecorator : INotifier
{
    protected INotifier notifier;

    public NotifierDecorator(INotifier notifier)
    {
        this.notifier = notifier;
    }

    public virtual void Send(string message)
    {
        notifier.Send(message);
    }
}

class SMSNotifierDecorator : NotifierDecorator
{
    public SMSNotifierDecorator(INotifier notifier)
        : base(notifier) { }

    public override void Send(string message)
    {
        base.Send(message);

        Console.WriteLine(
            "SMS Notification   : " + message);
    }
}

class SlackNotifierDecorator : NotifierDecorator
{
    public SlackNotifierDecorator(INotifier notifier)
        : base(notifier) { }

    public override void Send(string message)
    {
        base.Send(message);

        Console.WriteLine(
            "Slack Notification : " + message);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(
            "========== DECORATOR PATTERN ==========\n");

        INotifier notifier =
            new SlackNotifierDecorator(
                new SMSNotifierDecorator(
                    new EmailNotifier()));

        Console.WriteLine(
            "Sending Notification...\n");

        notifier.Send(
            "System Maintenance Tonight");

        Console.WriteLine(
            "\nAll notifications sent successfully.");

        Console.WriteLine(
            "\n=======================================");
    }
}