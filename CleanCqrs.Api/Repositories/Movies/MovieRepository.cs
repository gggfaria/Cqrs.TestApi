using CleanCqrs.Api.Domain.Movies;

namespace CleanCqrs.Api.Repositories.Movies
{
    public class MovieRepository
    {

        private readonly List<Movie> _moviesList;

        public MovieRepository()
        {
            _moviesList = new List<Movie>
            {
                new Movie("Lord of the Rings Fellowship of the Ring", Guid.NewGuid(), new DateTime(2002,1,1))
            };
        }

        public IList<Movie> GetAll()
        {
            return _moviesList;
        }

        public void Insert(Movie movie)
        {
            _moviesList.Add(movie);
        }

    }
}

