public class TestProxy {

    public static void main(String[] args) {

        System.out.println("========== PROXY PATTERN ==========\n");

        Image img = new ProxyImage("photo.jpg");

        System.out.println("First Access:");
        img.display();

        System.out.println("\nSecond Access:");
        img.display();

        System.out.println("\nImage loaded only once.");

        System.out.println("\n===================================");
    }
}