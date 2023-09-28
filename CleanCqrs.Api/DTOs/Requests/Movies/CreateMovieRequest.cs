using System.ComponentModel.DataAnnotations;

namespace CleanCqrs.Api.DTOs.Requests.Movies
{
    public class CreateMovieRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime RealeaseDate { get; set; }
    }
}

