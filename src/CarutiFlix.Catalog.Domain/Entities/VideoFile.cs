namespace CarutiFlix.Catalog.Domain.Entities;

public class VideoFile : Entity
{
	public string Title { get; private set; }
	public float Duration { get; private set; }
	public string? Url { get; private set; }

	public VideoFile(string title, float duration)
	{
		Title = title;
		Duration = duration;
	}

	public VideoFile(string title, float duration, string url)
			: this(title, duration)
	{
		Url = url;
	}
}