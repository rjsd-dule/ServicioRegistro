using FluentValidation.Results;
using ProyectUTP.Aplication.Models.Identity;

namespace ProyectUTP.Infrastructure.Services.FunctionResponse
{
    public class FunctionResponse
    {
        public T ServerError<T>(string Param) where T : ResponseMessage, new()
        {
            return new T
            {
                Message = Param,
                StatusCode = 500,
                IsError = true
            };
        }

        public T NotFoundResponse<T>(string ParamMessage, int ParamCode, bool TF) where T : ResponseMessage, new()
        {
            return new T
            {
                Message = ParamMessage,
                StatusCode = ParamCode,
                IsError = TF
            };
        }

        public T BadRequest<T>(string errorMessage) where T : ResponseMessage, new()
        {
            return new T
            {
                Message = errorMessage,
                StatusCode = 400,
                IsError = true
            };
        }

        public T BadRequest<T>(IEnumerable<ValidationFailure> errors) where T : ResponseMessage, new()
        {
            var errorMessages = errors.Select(e => $"{e.PropertyName}: {e.ErrorMessage}");
            return BadRequest<T>(string.Join(", ", errorMessages));
        }
    }
}
