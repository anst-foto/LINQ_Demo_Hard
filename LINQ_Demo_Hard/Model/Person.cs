namespace LINQ_Demo_Hard.Model;

//public record Person(Guid Guid, string FirstName, string LastName, DateTime DateOfBirth);

public record class Person
{
    public Guid Guid { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public DateTime DateOfBirth { get; init; }
}

/*public class Person : IEquatable<Person>
{
    public Guid Guid { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }

    public override string ToString()
    {
        return $"{this.Guid}: {this.LastName} {this.FirstName}, {this.DateOfBirth:d}";
    }

    public bool Equals(Person? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Guid.Equals(other.Guid) && FirstName == other.FirstName && LastName == other.LastName && DateOfBirth.Equals(other.DateOfBirth);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Person)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Guid, FirstName, LastName, DateOfBirth);
    }

    public static bool operator ==(Person? left, Person? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Person? left, Person? right)
    {
        return !Equals(left, right);
    }
}*/