public class RemoteControl {

    private Command command;

    public void setCommand(
            Command command) {

        this.command = command;
    }

    public void pressButton() {

        System.out.println(
                "Remote Button Pressed");

        command.execute();
    }
}