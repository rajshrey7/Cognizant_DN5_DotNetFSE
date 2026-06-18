public class TestDI {

    public static void main(String[] args) {

        System.out.println("========== DEPENDENCY INJECTION PATTERN ==========\n");

        CustomerRepository repository =
                new CustomerRepositoryImpl();

        CustomerService service =
                new CustomerService(repository);

        System.out.println("Fetching Customer Details...\n");

        service.getCustomer(101);

        System.out.println("\nRepository injected successfully.");

        System.out.println("\n=================================================");
    }
}