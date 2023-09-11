using LINQ_Demo_Hard.Model;

var id = Guid.NewGuid();

var person1 = new Person
{
    Guid = id,
    FirstName = "Andrey",
    LastName = "Starinin",
    DateOfBirth = new DateTime(1986, 2, 18)
};

var person2 = new Person
{
    Guid = id,
    FirstName = "Andrey",
    LastName = "Starinin",
    DateOfBirth = new DateTime(1986, 2, 18)
};

//Console.WriteLine($"{person1.Guid}: {person1.LastName} {person1.FirstName}, {person1.DateOfBirth:d}");
//Console.WriteLine($"{person2.Guid}: {person2.LastName} {person2.FirstName}, {person2.DateOfBirth:d}");

Console.WriteLine(person1);
Console.WriteLine(person2);

Console.WriteLine(person1.GetHashCode());
Console.WriteLine(person2.GetHashCode());
Console.WriteLine(person1 == person2);

Console.WriteLine(person1.Equals(person2));