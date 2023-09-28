using CleanCqrs.Api.DTOs.Common;
using CleanCqrs.Api.DTOs.Responses.Movies;
using MediatR;

namespace CleanCqrs.Api.Queries.Movies
{
    public record GetAllMoviesQuerie() : IRequest<BaseResponse<List<GetAllMoviesResponse>>>;
}

