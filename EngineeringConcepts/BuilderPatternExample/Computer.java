public class Computer {

    private String cpu;
    private int ram;

    private Computer(Builder builder) {
        this.cpu = builder.cpu;
        this.ram = builder.ram;
    }

    public void show() {
        System.out.println(cpu + " " + ram + "GB");
    }

    static class Builder {
        String cpu;
        int ram;

        Builder setCPU(String cpu) {
            this.cpu = cpu;
            return this;
        }

        Builder setRAM(int ram) {
            this.ram = ram;
            return this;
        }

        Computer build() {
            return new Computer(this);
        }
    }
}