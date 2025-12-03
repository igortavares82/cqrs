namespace Rent.Command.Model.Aggregates.User;

using Rent.Common.Entity;

public class User : Entity, IAggregateRoot
{
    public User(string name, string email, string driveLicense) : base()
    {
        Name = name;
        Email = email;
        DriveLicense = driveLicense;
    }

    public string Name { get; set; }
    public string Email { get; set; }
    public string DriveLicense { get; set; }
}