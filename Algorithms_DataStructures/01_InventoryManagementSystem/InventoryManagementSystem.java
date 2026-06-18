import java.util.HashMap;

public class InventoryManagementSystem {

    static HashMap<Integer, Product> inventory =
            new HashMap<>();

    public static void addProduct(Product p) {

        inventory.put(p.productId, p);
        System.out.println("Product Added: " + p.productName);
    }

    public static void updateProduct(int id,
                                     int quantity) {

        if (inventory.containsKey(id)) {

            inventory.get(id).quantity = quantity;
            System.out.println("Product Updated Successfully");
        }
    }

    public static void deleteProduct(int id) {

        inventory.remove(id);
        System.out.println("Product Deleted Successfully");
    }

    public static void displayProducts() {

        for (Product p : inventory.values()) {
            System.out.println(p);
        }
    }

    public static void main(String[] args) {

        System.out.println("===== ADD PRODUCTS =====");

        addProduct(new Product(
                101,
                "Laptop",
                10,
                50000));

        addProduct(new Product(
                102,
                "Mouse",
                20,
                500));

        System.out.println("\n===== CURRENT INVENTORY =====");
        displayProducts();

        System.out.println("\n===== UPDATE PRODUCT =====");
        updateProduct(101, 15);

        System.out.println("\n===== INVENTORY AFTER UPDATE =====");
        displayProducts();

        System.out.println("\n===== DELETE PRODUCT =====");
        deleteProduct(102);

        System.out.println("\n===== FINAL INVENTORY =====");
        displayProducts();

        System.out.println("\nTime Complexity:");
        System.out.println("Add    -> O(1)");
        System.out.println("Update -> O(1)");
        System.out.println("Delete -> O(1)");
    }
}