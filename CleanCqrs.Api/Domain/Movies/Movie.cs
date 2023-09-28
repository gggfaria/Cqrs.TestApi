namespace CleanCqrs.Api.Domain.Movies
{
    public class Movie
    {

        public Movie(string name, Guid id, DateTime releaseDate)
        {
            Name = name;
            Id = id;
            ReleaseDate = releaseDate;
        }

        public string Name { get; private set; }
        public Guid Id { get; private set; }
        public DateTime ReleaseDate { get; private set; }
    }

}

