public class TestObserver {
    public static void main(String[] args) {

        StockMarket stock = new StockMarket();

        stock.register(new MobileApp());
        stock.register(new WebApp());

        stock.setPrice(500);
    }
}