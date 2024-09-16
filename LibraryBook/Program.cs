using System;

class LibraryBook
{
    private string title;
    private string author;
    private bool available;

    public LibraryBook(string bookTitle, string bookAuthor)
    { 
        title = bookTitle;
        author = bookAuthor;
        available = true; 
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetAuthor()
    {
        return author;
    }

    public bool IsAvailable()
    {
        return available;
    }

    public void SetAvailability(bool bookAvailability)
    {
        available = bookAvailability;
    }

    static void Main(string[] args)
    {
        LibraryBook book = new LibraryBook("The Great Gatsby", "F. Scott Fitzgerald");

        Console.WriteLine("Book Details:");
        Console.WriteLine("Title: " + book.GetTitle());
        Console.WriteLine("Author: " + book.GetAuthor());
        Console.WriteLine("Availability: " + book.IsAvailable());

        book.SetAvailability(false);
        Console.WriteLine("Updated Availability: " + book.IsAvailable());
    }
}