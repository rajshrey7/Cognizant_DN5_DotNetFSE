import java.util.Arrays;
import java.util.Comparator;

public class LibraryManagementSystem {

    public static Book linearSearch(
            Book[] books,
            String title) {

        for(Book book : books) {

            if(book.title.equalsIgnoreCase(title))
                return book;
        }

        return null;
    }

    public static Book binarySearch(
            Book[] books,
            String title) {

        int left = 0;
        int right = books.length - 1;

        while(left <= right) {

            int mid = (left + right) / 2;

            int result =
                    books[mid].title
                    .compareToIgnoreCase(title);

            if(result == 0)
                return books[mid];

            if(result < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    public static void main(String[] args) {

        Book[] books = {

            new Book(
                    101,
                    "Java",
                    "James Gosling"),

            new Book(
                    102,
                    "Python",
                    "Guido Van Rossum"),

            new Book(
                    103,
                    "C Programming",
                    "Dennis Ritchie"),

            new Book(
                    104,
                    "Data Structures",
                    "Mark Allen")
        };

        System.out.println(
                "===== LINEAR SEARCH =====");

        System.out.println(
                linearSearch(
                        books,
                        "Python"));

        Arrays.sort(
                books,
                Comparator.comparing(
                        b -> b.title));

        System.out.println(
                "\n===== BINARY SEARCH =====");

        System.out.println(
                binarySearch(
                        books,
                        "Python"));

        System.out.println(
                "\n===== TIME COMPLEXITY =====");

        System.out.println(
                "Linear Search : O(n)");

        System.out.println(
                "Binary Search : O(log n)");
    }
}