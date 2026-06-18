public class TestStrategy {

    public static void main(String[] args) {

        System.out.println("========== STRATEGY PATTERN ==========\n");

        System.out.println("Payment Method : Credit Card");
        new PaymentContext(
                new CreditCardPayment())
                .execute(1000);

        System.out.println();

        System.out.println("Payment Method : PayPal");
        new PaymentContext(
                new PayPalPayment())
                .execute(2000);

        System.out.println("\n======================================");
    }
}