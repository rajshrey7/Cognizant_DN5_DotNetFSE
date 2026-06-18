public class TestBuilder {

    public static void main(String[] args) {

        System.out.println("========== BUILDER PATTERN ==========\n");

        Computer pc = new Computer.Builder()
                .setCPU("Intel i7")
                .setRAM(16)
                .setStorage(512)
                .build();

        System.out.println("Computer Built Successfully\n");

        pc.show();

        System.out.println("\n=====================================");
    }
}