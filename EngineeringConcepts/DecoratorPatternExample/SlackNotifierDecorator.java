public class SlackNotifierDecorator extends NotifierDecorator {

    public SlackNotifierDecorator(Notifier notifier){
        super(notifier);
    }

    public void send(String msg){
        notifier.send(msg);
        System.out.println("Slack: " + msg);
    }
}