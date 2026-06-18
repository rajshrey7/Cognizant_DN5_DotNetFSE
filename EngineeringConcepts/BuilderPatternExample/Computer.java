public class Computer {

    private String cpu;
    private int ram;
    private int storage;

    private Computer(Builder builder) {

        this.cpu = builder.cpu;
        this.ram = builder.ram;
        this.storage = builder.storage;
    }

    public void show() {

        System.out.println("CPU     : " + cpu);
        System.out.println("RAM     : " + ram + " GB");
        System.out.println("Storage : " + storage + " GB");
    }

    static class Builder {

        String cpu;
        int ram;
        int storage;

        Builder setCPU(String cpu) {

            this.cpu = cpu;
            return this;
        }

        Builder setRAM(int ram) {

            this.ram = ram;
            return this;
        }

        Builder setStorage(int storage) {

            this.storage = storage;
            return this;
        }

        Computer build() {

            return new Computer(this);
        }
    }
}