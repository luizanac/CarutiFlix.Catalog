using Dawn;

namespace CarutiFlix.Catalog.Domain.Entities;

public class Category : Entity
{
	public string Name { get; private set; }

	public Category(string name)
	{
		Guard.Argument(name, nameof(name)).NotEmpty();
		
		Name = name;
	}
}