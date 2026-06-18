import java.util.Arrays;
import java.util.Comparator;

public class SearchEngine {

    public static Product linearSearch(
            Product[] products,
            String name) {

        for(Product p : products) {

            if(p.productName.equalsIgnoreCase(name))
                return p;
        }

        return null;
    }

    public static Product binarySearch(
            Product[] products,
            String name) {

        int left = 0;
        int right = products.length - 1;

        while(left <= right) {

            int mid = (left + right) / 2;

            int result =
                products[mid].productName
                .compareToIgnoreCase(name);

            if(result == 0)
                return products[mid];

            if(result < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    public static void main(String[] args) {

        Product[] products = {

            new Product(101,
                    "Laptop",
                    "Electronics"),

            new Product(102,
                    "Mouse",
                    "Electronics"),

            new Product(103,
                    "Keyboard",
                    "Electronics"),

            new Product(104,
                    "Monitor",
                    "Electronics")
        };

        System.out.println(
                "===== LINEAR SEARCH =====");

        Product p1 =
                linearSearch(products,
                        "Mouse");

        System.out.println(p1);

        Arrays.sort(products,
                Comparator.comparing(
                        p -> p.productName));

        System.out.println(
                "\n===== BINARY SEARCH =====");

        Product p2 =
                binarySearch(products,
                        "Mouse");

        System.out.println(p2);

        System.out.println(
                "\n===== TIME COMPLEXITY =====");

        System.out.println(
                "Linear Search : O(n)");

        System.out.println(
                "Binary Search : O(log n)");
    }
}