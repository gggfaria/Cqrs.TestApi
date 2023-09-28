using System.Net;
using AutoMapper;
using CleanCqrs.Api.Domain.Movies;
using CleanCqrs.Api.DTOs.Common;
using CleanCqrs.Api.DTOs.Responses.Movies;
using CleanCqrs.Api.Repositories.Movies;
using MediatR;

namespace CleanCqrs.Api.Commands.Movies
{
    public class CreateMovieCommandHandler : IRequestHandler<CreateMovieCommand, BaseResponse<CreateMovieResponse>>
    {
        private readonly MovieRepository _repository;
        private readonly IMapper _mapper;

        public CreateMovieCommandHandler(MovieRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<BaseResponse<CreateMovieResponse>> Handle(CreateMovieCommand command, CancellationToken cancellationToken)
        {
            var movie = new Movie(command.Name, command.Id, command.RealeseDate);
            _repository.Insert(movie);
            var createdMovie = _mapper.Map<CreateMovieResponse>(movie);
            return Task.FromResult(new BaseResponse<CreateMovieResponse>("Ok", (int)HttpStatusCode.Created, createdMovie));
        }

    }
}

