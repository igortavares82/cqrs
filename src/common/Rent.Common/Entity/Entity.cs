namespace Rent.Common.Entity;

using System;

public class Entity
{
    public Entity()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.Now;
        IsEnabled = true;
    }

    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsEnabled { get; set; }
    
    public void Enable() => IsEnabled = true;
    public void Disable() => IsEnabled = false;
}
