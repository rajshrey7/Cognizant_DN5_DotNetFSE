using System;

class Book
{
    public int BookId;
    public string Title;
    public string Author;

    public Book(int bookId,
                string title,
                string author)
    {
        BookId = bookId;
        Title = title;
        Author = author;
    }

    public override string ToString()
    {
        return $"Book ID: {BookId}, Title: {Title}, Author: {Author}";
    }
}

class Program
{
    static Book LinearSearch(
        Book[] books,
        string title)
    {
        foreach (Book book in books)
        {
            if (book.Title.Equals(
                title,
                StringComparison.OrdinalIgnoreCase))
            {
                return book;
            }
        }

        return null;
    }

    static Book BinarySearch(
        Book[] books,
        string title)
    {
        int left = 0;
        int right = books.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            int result =
                string.Compare(
                    books[mid].Title,
                    title,
                    true);

            if (result == 0)
                return books[mid];

            if (result < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        Book[] books =
        {
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

        Console.WriteLine(
            "===== LINEAR SEARCH =====\n");

        Book linearResult =
            LinearSearch(
                books,
                "Python");

        Console.WriteLine(linearResult);

        Array.Sort(
            books,
            (a, b) =>
            a.Title.CompareTo(
                b.Title));

        Console.WriteLine(
            "\n===== BINARY SEARCH =====\n");

        Book binaryResult =
            BinarySearch(
                books,
                "Python");

        Console.WriteLine(binaryResult);

        Console.WriteLine(
            "\n===== TIME COMPLEXITY =====");

        Console.WriteLine(
            "Linear Search : O(n)");

        Console.WriteLine(
            "Binary Search : O(log n)");
    }
}