// Auteur.cs

using System;

// Author class
public class Auteur
{
    // Properties of the Author
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Nationality { get; set; }

    // Default constructor with default values
    public Auteur()
    {
        FirstName = "";
        LastName = "";
        DateOfBirth = DateTime.MinValue;
        Nationality = "";
    }

    // Constructor with parameters to initialize Author properties
    public Auteur(string firstName, string lastName, DateTime dateOfBirth, string nationality)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Nationality = nationality;
    }

    // Method to display the details of the Author
    public void DisplayDetails()
    {
        Console.WriteLine("Author Details:");
        Console.WriteLine("Name: " + FirstName + " " + LastName);
        Console.WriteLine("Date of Birth: " + DateOfBirth.ToString("yyyy-MM-dd"));
        Console.WriteLine("Nationality: " + Nationality);
    }
}
