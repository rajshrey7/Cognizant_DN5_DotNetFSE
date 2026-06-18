public class TestObserver {

    public static void main(String[] args) {

        System.out.println("========== OBSERVER PATTERN ==========\n");

        StockMarket stock = new StockMarket();

        stock.register(new MobileApp());
        stock.register(new WebApp());

        System.out.println("Updating Stock Price...\n");

        stock.setPrice(500);

        System.out.println("\nAll observers notified.");

        System.out.println("\n======================================");
    }
}