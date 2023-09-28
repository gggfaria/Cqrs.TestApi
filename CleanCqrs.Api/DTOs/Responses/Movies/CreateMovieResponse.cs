using System;
namespace CleanCqrs.Api.DTOs.Responses.Movies
{
    public class CreateMovieResponse
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}

