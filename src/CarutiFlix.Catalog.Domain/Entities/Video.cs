using Dawn;

namespace CarutiFlix.Catalog.Domain.Entities;

public class Video : Entity
{
	public string Title { get; private set; }
	public string Description { get; private set; }
	public string? Rating { get; private set; }
	public int ReleaseYear { get; private set; }
	public bool Opened { get; private set; }
	public float Duration { get; private set; }

	public IList<Category> Categories { get; private set; } = new List<Category>();
	public IList<Genre> Genres { get; private set; } = new List<Genre>();
	public IList<CastMember> CastMem { get; private set; } = new List<CastMember>();
	public IList<VideoFile> VideoFiles { get; private set; } = new List<VideoFile>();

	public Video(string title,
	             string description,
	             int releaseYear,
	             bool opened)
	{
		Title = title;
		Description = description;
		ReleaseYear = releaseYear;
		Opened = opened;
	}

	public Video(string title,
	             string description,
	             string? rating,
	             int releaseYear,
	             bool opened,
	             float duration) : this(title, description, releaseYear, opened)
	{
		Rating = rating;
		Duration = duration;
	}

	public Video(string title,
	             string description,
	             string? rating,
	             int releaseYear,
	             bool opened,
	             float duration,
	             IList<VideoFile> videoFiles) : this(title, description, rating, releaseYear, opened, duration)
	{
		Guard.Argument(videoFiles, nameof(videoFiles)).NotNull();
		VideoFiles = new List<VideoFile>(videoFiles);
	}
}