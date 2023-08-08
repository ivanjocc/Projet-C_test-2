// Livre.cs

using System;

// Book class (derived from Article and implements IAffichable)
public class Livre : Article, IAffichable
{
    // Additional properties specific to a Book
    public string Author { get; set; }

    // Default constructor
    public Livre() : base("", DateTime.MinValue)
    {
        // Initialize the additional properties specific to a book
        Author = "";
    }

    // Constructor with parameters to initialize Book properties
    public Livre(string name, string author, DateTime publicationDate) : base(name, publicationDate)
    {
        Author = author;
    }

    // Implement the DisplayDetails method from Article
    public override void DisplayDetails()
    {
        // Code to display the details of the book
        Console.WriteLine("Book Details:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Publication Date: " + PublicationDate.ToString("yyyy-MM-dd"));
    }
}
