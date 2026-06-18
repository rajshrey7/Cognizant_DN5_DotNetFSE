public class TestCommand {

    public static void main(String[] args) {

        System.out.println("========== COMMAND PATTERN ==========\n");

        Light light = new Light();

        RemoteControl remote =
                new RemoteControl();

        System.out.println("Turning Light ON...\n");

        remote.setCommand(
                new LightOnCommand(light));

        remote.pressButton();

        System.out.println("\nTurning Light OFF...\n");

        remote.setCommand(
                new LightOffCommand(light));

        remote.pressButton();

        System.out.println(
                "\n=====================================");
    }
}