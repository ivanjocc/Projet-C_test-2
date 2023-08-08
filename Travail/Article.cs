// Article.cs

using System;

// Base class Article
public abstract class Article
{
    // Properties common to all articles
    public string Name { get; set; }
    public DateTime PublicationDate { get; set; }

    // Constructor with parameters to initialize common properties
    public Article(string name, DateTime publicationDate)
    {
        Name = name;
        PublicationDate = publicationDate;
    }

    // Method abstract that must be implemented in derived classes
    public abstract void DisplayDetails();
}
