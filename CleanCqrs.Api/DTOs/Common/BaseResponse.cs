namespace CleanCqrs.Api.DTOs.Common
{
    public class BaseResponse<TEntity>
    {
        public BaseResponse(string message, int statusCode, TEntity entity)
        {
            Message = message;
            StatusCode = statusCode;
            Entity = entity;
        }

        public string Message { get; set; }
        public int StatusCode { get; set; }
        public TEntity Entity { get; set; }
    }
}

