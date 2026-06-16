public class TestBuilder {

    public static void main(String[] args) {

        Computer pc = new Computer.Builder()
                .setCPU("i7")
                .setRAM(16)
                .build();

        pc.show();
    }
}