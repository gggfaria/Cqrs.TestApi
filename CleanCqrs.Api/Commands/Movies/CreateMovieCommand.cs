using CleanCqrs.Api.DTOs.Common;
using CleanCqrs.Api.DTOs.Responses.Movies;
using MediatR;

namespace CleanCqrs.Api.Commands.Movies;

public class CreateMovieCommand
    : IRequest<BaseResponse<CreateMovieResponse>>
{
    public CreateMovieCommand(string name, DateTime realeseDate)
    {
        Id = Guid.NewGuid();
        Name = name;
        RealeseDate = realeseDate;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime RealeseDate { get; set; }
}
