using System.Net;
using AutoMapper;
using CleanCqrs.Api.DTOs.Common;
using CleanCqrs.Api.DTOs.Responses.Movies;
using CleanCqrs.Api.Repositories.Movies;
using MediatR;

namespace CleanCqrs.Api.Queries.Movies
{
    public class GetAllMoviesHandler : IRequestHandler<GetAllMoviesQuerie, BaseResponse<List<GetAllMoviesResponse>>>
    {
        private readonly MovieRepository _repository;
        private readonly IMapper _mapper;

        public GetAllMoviesHandler(MovieRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<BaseResponse<List<GetAllMoviesResponse>>> Handle(GetAllMoviesQuerie query, CancellationToken cancellationToken)
        {
            var listMovies = _repository.GetAll();
            var response = _mapper.Map<List<GetAllMoviesResponse>>(listMovies);
            return Task.FromResult(new BaseResponse<List<GetAllMoviesResponse>>(string.Empty, (int)HttpStatusCode.OK, response));
        }
    }
}

