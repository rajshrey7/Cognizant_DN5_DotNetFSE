public class SortOrders {

    public static void bubbleSort(Order[] orders) {

        int n = orders.length;

        for(int i = 0; i < n - 1; i++) {

            for(int j = 0; j < n - i - 1; j++) {

                if(orders[j].totalPrice >
                        orders[j + 1].totalPrice) {

                    Order temp = orders[j];
                    orders[j] = orders[j + 1];
                    orders[j + 1] = temp;
                }
            }
        }
    }

    public static int partition(
            Order[] orders,
            int low,
            int high) {

        double pivot =
                orders[high].totalPrice;

        int i = low - 1;

        for(int j = low; j < high; j++) {

            if(orders[j].totalPrice < pivot) {

                i++;

                Order temp = orders[i];
                orders[i] = orders[j];
                orders[j] = temp;
            }
        }

        Order temp = orders[i + 1];
        orders[i + 1] = orders[high];
        orders[high] = temp;

        return i + 1;
    }

    public static void quickSort(
            Order[] orders,
            int low,
            int high) {

        if(low < high) {

            int pi =
                    partition(
                            orders,
                            low,
                            high);

            quickSort(
                    orders,
                    low,
                    pi - 1);

            quickSort(
                    orders,
                    pi + 1,
                    high);
        }
    }

    public static void display(
            Order[] orders) {

        for(Order o : orders) {

            System.out.println(o);
        }
    }

    public static void main(String[] args) {

        Order[] orders = {

            new Order(101,
                    "Rahul",
                    5000),

            new Order(102,
                    "Aman",
                    2000),

            new Order(103,
                    "Shreyansh",
                    8000),

            new Order(104,
                    "Priya",
                    3000)
        };

        System.out.println(
                "===== BUBBLE SORT =====");

        bubbleSort(orders);

        display(orders);

        Order[] orders2 = {

            new Order(101,
                    "Rahul",
                    5000),

            new Order(102,
                    "Aman",
                    2000),

            new Order(103,
                    "Shreyansh",
                    8000),

            new Order(104,
                    "Priya",
                    3000)
        };

        System.out.println(
                "\n===== QUICK SORT =====");

        quickSort(
                orders2,
                0,
                orders2.length - 1);

        display(orders2);

        System.out.println(
                "\n===== TIME COMPLEXITY =====");

        System.out.println(
                "Bubble Sort : O(n^2)");

        System.out.println(
                "Quick Sort : O(n log n)");
    }
}