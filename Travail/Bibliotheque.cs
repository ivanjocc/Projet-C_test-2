// Biblioteque.cs

using System;
using System.Collections.Generic;
using System.Linq;

public class Biblioteque
{
    // Lists to store books and authorized persons
    private List<Livre> books;
    private List<Personne> authorizedPeople;
    private Dictionary<Livre, Personne?> borrowedBooks;

    public Biblioteque()
    {
        // Initialize the lists when the Biblioteque object is created
        books = new List<Livre>();
        authorizedPeople = new List<Personne>();
        borrowedBooks = new Dictionary<Livre, Personne?>();
    }

    // Method to add a new book to the library
    public void AddBook(Livre book)
    {
        books.Add(book);
    }

    // Method to remove a book from the library
    public void RemoveBook(Livre book)
    {
        books.Remove(book);
    }

    // Method to add a new authorized person to the library
    public void AddAuthorizedPerson(Personne person)
    {
        authorizedPeople.Add(person);
    }

    // Method to remove an authorized person from the library
    public void RemoveAuthorizedPerson(Personne person)
    {
        authorizedPeople.Remove(person);
    }

    // Method to get the list of books in the library
    public List<Livre> GetBooks()
    {
        return books;
    }

    //public bool BorrowBook(Livre book, Personne? person)
    //{
    //    if (books.Contains(book) && (person == null || authorizedPeople.Contains(person)))
    //    {
    //        if (!borrowedBooks.ContainsKey(book))
    //        {
    //            borrowedBooks.Add(book, person);
    //            return true;
    //        }
    //    }

    //    return false;
    //}

    public bool BorrowBook(Livre book, Personne person)
    {
        if (!books.Contains(book))
            return false;

        if (borrowedBooks.ContainsKey(book))
            return false; // Book is already borrowed

        borrowedBooks.Add(book, person);
        return true;
    }

    //public bool ReturnBook(Livre book)
    //{
    //    if (borrowedBooks.ContainsKey(book))
    //    {
    //        borrowedBooks.Remove(book);
    //        return true;
    //    }

    //    return false;
    //}

    public bool ReturnBook(Livre book)
    {
        if (!borrowedBooks.ContainsKey(book))
            return false; // Book is not borrowed

        borrowedBooks.Remove(book);
        return true;
    }

    // Method to get the list of authorized persons in the library
    public List<Personne> GetAuthorizedPersons()
    {
        return authorizedPeople;
    }

    public List<Livre> GetAvailableBooks()
    {
        return books;
    }

    public List<Personne> GetAuthorizedPeople()
    {
        return authorizedPeople;
    }

    // Explicitly convert nullable reference types to non-nullable
    public Dictionary<Livre, Personne> GetBorrowedBooks()
    {
        Dictionary<Livre, Personne> borrowedBooksNonNullable = new Dictionary<Livre, Personne>();
        foreach (var kvp in borrowedBooks)
        {
            borrowedBooksNonNullable.Add(kvp.Key, kvp.Value!);
        }
        return borrowedBooksNonNullable;
    }
}
