public class TestAdapter {

    public static void main(String[] args) {

        System.out.println("========== ADAPTER PATTERN ==========\n");

        PaymentProcessor processor =
                new PayPalAdapter();

        System.out.println("Processing Payment...\n");

        processor.processPayment(1000);

        System.out.println(
                "\nPayment Completed Successfully.");

        System.out.println(
                "\n=====================================");
    }
}