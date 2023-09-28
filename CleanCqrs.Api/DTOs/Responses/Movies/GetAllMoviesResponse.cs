using System;
namespace CleanCqrs.Api.DTOs.Responses.Movies
{
	public class GetAllMoviesResponse
	{

		public Guid Id { get; set; }
		public string Name { get; set; }
		public DateTime RealeseDate { get; set; }

	}
}

