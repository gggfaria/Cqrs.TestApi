using AutoMapper;
using CleanCqrs.Api.Commands.Movies;
using CleanCqrs.Api.Domain.Movies;
using CleanCqrs.Api.DTOs.Requests.Movies;
using CleanCqrs.Api.DTOs.Responses.Movies;

namespace CleanCqrs.Api.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, CreateMovieResponse>();
            CreateMap<Movie, GetAllMoviesResponse>();
        }
    }

}