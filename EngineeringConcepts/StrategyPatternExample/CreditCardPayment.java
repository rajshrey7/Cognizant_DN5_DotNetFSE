public class CreditCardPayment
        implements PaymentStrategy {

    public void pay(int amount) {

        System.out.println(
                "Amount Paid : " + amount);
    }
}