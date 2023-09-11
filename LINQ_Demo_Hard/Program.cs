using LINQ_Demo_Hard.Model;

var faculties = new List<string> { "SoftDev", "Design" };

var persons = new List<Person>
{
    new()
    {
        Id = Guid.NewGuid(),
        FirstName = "Andrey",
        LastName = "Starinin",
        DateOfBirth = new DateTime(1986, 2, 18)
    },
    new()
    {
        Id = Guid.NewGuid(),
        FirstName = "Dora",
        LastName = "Starinina",
        DateOfBirth = new DateTime(2007, 1, 1)
    }
};

var students = new List<Student>
{
    new()
    {
        Id = Guid.NewGuid(),
        Person = persons.First(p => p is { LastName: "Starinin", FirstName: "Andrey" }),
        Faculty = faculties.Single(f => f == "SoftDev")
    },
    new()
    {
        Id = Guid.NewGuid(),
        Person = persons.First(p => p is { LastName: "Starinina", FirstName: "Dora" }),
        Faculty = faculties.Single(f => f == "Design")
    }
};

foreach (var s in students)
{
    Console.WriteLine(s);
}