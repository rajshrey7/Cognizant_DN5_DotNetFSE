public class TestDecorator {

    public static void main(String[] args) {

        System.out.println("========== DECORATOR PATTERN ==========\n");

        Notifier notifier =
                new SlackNotifierDecorator(
                        new SMSNotifierDecorator(
                                new EmailNotifier()));

        System.out.println("Sending Notification...\n");

        notifier.send("System Maintenance Tonight");

        System.out.println(
                "\nAll notifications sent successfully.");

        System.out.println(
                "\n=======================================");
    }
}