public class TestLogger {

    public static void main(String[] args) {

        System.out.println("========== SINGLETON PATTERN ==========\n");

        Logger logger1 = Logger.getInstance();
        Logger logger2 = Logger.getInstance();

        System.out.println();

        logger1.log("First Message");
        logger2.log("Second Message");

        System.out.println("\nVerification:");

        if (logger1 == logger2) {

            System.out.println("Both objects reference the SAME instance.");
        }
        else {

            System.out.println("Different instances created.");
        }

        System.out.println("\n=======================================");
    }
}