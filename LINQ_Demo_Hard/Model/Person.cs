namespace LINQ_Demo_Hard.Model;

public record class Person
{
    public Guid Id { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public DateTime DateOfBirth { get; init; }
}