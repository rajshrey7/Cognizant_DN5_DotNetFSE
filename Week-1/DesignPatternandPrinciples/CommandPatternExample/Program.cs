using System;

interface ICommand
{
    void Execute();
}

class Light
{
    public void On()
    {
        Console.WriteLine("Light ON");
    }

    public void Off()
    {
        Console.WriteLine("Light OFF");
    }
}

class LightOnCommand : ICommand
{
    private Light light;

    public LightOnCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
        light.On();
    }
}

class LightOffCommand : ICommand
{
    private Light light;

    public LightOffCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
        light.Off();
    }
}

class RemoteControl
{
    private ICommand command;

    public void SetCommand(ICommand command)
    {
        this.command = command;
    }

    public void PressButton()
    {
        Console.WriteLine(
            "Remote Button Pressed");

        command.Execute();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(
            "========== COMMAND PATTERN ==========\n");

        Light light = new Light();

        RemoteControl remote =
            new RemoteControl();

        Console.WriteLine(
            "Turning Light ON...\n");

        remote.SetCommand(
            new LightOnCommand(light));

        remote.PressButton();

        Console.WriteLine(
            "\nTurning Light OFF...\n");

        remote.SetCommand(
            new LightOffCommand(light));

        remote.PressButton();

        Console.WriteLine(
            "\n=====================================");
    }
}