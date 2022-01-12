using System.Collections.ObjectModel;
using Dawn;

namespace CarutiFlix.Catalog.Domain.Entities;

public class Genre : Entity
{
	public string Name { get; private set; }
	public IList<Category> Categories { get; private set; } = new List<Category>();

	public Genre(string name)
	{
		Guard.Argument(name, nameof(name)).NotEmpty();

		Name = name;
	}
}