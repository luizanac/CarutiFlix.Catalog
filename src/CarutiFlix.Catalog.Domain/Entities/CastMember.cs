using Dawn;

namespace CarutiFlix.Catalog.Domain.Entities;

public enum ECastMemberType
{
}

public class CastMember : Entity
{
	public string Name { get; private set; }
	public int Type { get; private set; }

	public CastMember(string name, int type)
	{
		Guard.Argument(name, nameof(name)).NotEmpty();
		Guard.Argument(type, nameof(type)).InRange(1, 2);

		Name = name;
		Type = type;
	}
}