namespace LINQ_Demo_Hard.Model;

public record class Student
{
    public Guid Id { get; init; }
    public Person Person { get; init; }
    public string Faculty { get; init; }
}