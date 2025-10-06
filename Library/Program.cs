using System;

class Book
{
    string Title;
    string Author;
    string ISBN;

    void displayinfo()
    {

        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Author Name: {Author}");
        Console.WriteLine($"Books ISBN: {ISBN}");
        Console.WriteLine($"");
    }
    static void Main(string[] args)
    {
        Book book = new Book();
        book.Title = "The Idiot";
        book.Author = "Fyodor dostoevsky";
        book.ISBN = "17384444";

        Book bok = new Book();
        bok.Title = "the genius";
        bok.Author = "Taylor Mcgaughey";
        bok.ISBN = "12112500";

        bok.displayinfo();
        book.displayinfo();

    }
}