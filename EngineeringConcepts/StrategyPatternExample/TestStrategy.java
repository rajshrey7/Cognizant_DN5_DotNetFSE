public class TestStrategy {
    public static void main(String[] args) {

        new PaymentContext(
            new CreditCardPayment()).execute(1000);

        new PaymentContext(
            new PayPalPayment()).execute(2000);
    }
}