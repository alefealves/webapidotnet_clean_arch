namespace Domain.Entities;

public class Customer
{
    public Customer(string name, string email, string document)
    {
        Name = name;
        Email = email;
        Document = document;
    }

    public String Name { get; private set; }
    public String Email { get; private set; } 
    public String Document { get; private set; }
}