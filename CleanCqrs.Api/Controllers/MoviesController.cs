using CleanCqrs.Api.Commands.Movies;
using CleanCqrs.Api.DTOs.Requests.Movies;
using CleanCqrs.Api.Queries.Movies;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace CleanCqrs.Api.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {

        private readonly ISender _mediator;

        public MoviesController(ISender mediator)
        {
            _mediator = mediator;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new GetAllMoviesQuerie());
            return StatusCode(result.StatusCode, result);
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateMovieRequest request)
        {
            var movieCommand = new CreateMovieCommand(request.Name, request.RealeaseDate);
            var result = await _mediator.Send(movieCommand);
            return StatusCode(result.StatusCode, result);
        }


    }
}

