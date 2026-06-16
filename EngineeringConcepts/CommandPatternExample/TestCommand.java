public class TestCommand {
    public static void main(String[] args) {

        Light light = new Light();
        RemoteControl r = new RemoteControl();

        r.setCommand(new LightOnCommand(light));
        r.pressButton();

        r.setCommand(new LightOffCommand(light));
        r.pressButton();
    }
}