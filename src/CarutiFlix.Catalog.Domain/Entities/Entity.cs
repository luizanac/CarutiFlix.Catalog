namespace CarutiFlix.Catalog.Domain.Entities;

public abstract class Entity
{
	public Guid Id { get; }
	public DateTime CreatedAt { get; private set; }
	public DateTime UpdatedAt { get; private set; }

	protected Entity()
	{
		Id = Guid.NewGuid();
		CreatedAt = DateTime.UtcNow;
		UpdatedAt = DateTime.UtcNow;
	}

	protected bool Equals(Entity other)
	{
		return Id.Equals(other.Id);
	}

	public override bool Equals(object? obj)
	{
		if (ReferenceEquals(null, obj)) return false;
		if (ReferenceEquals(this, obj)) return true;
		return obj.GetType() == this.GetType() && Equals((Entity) obj);
	}

	public override int GetHashCode()
	{
		return Id.GetHashCode();
	}
}