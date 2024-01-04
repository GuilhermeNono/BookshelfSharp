using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using FluentValidation;

namespace Bookshelf.API.Middlewares
{
    public class ErrorHandlerMiddleware(ILogger<ErrorHandlerMiddleware> logger) : IMiddleware
    {
        private HttpResponse? _response;
        private readonly ErrorResult _errorResult = new();

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception error)
            {
                _response = context.Response;
                _response.ContentType = "application/json";
                _errorResult.Message = error?.Message ?? "Não foi possível capturar a mensagem de erro";
                
                await CatchErrorResponse(error);

                var result = JsonSerializer.Serialize(_errorResult, new JsonSerializerOptions
                {
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });

                await _response.WriteAsync(result);
            }
        }
        
        private Task CatchErrorResponse(Exception error)
        {
            switch (error)
            {
                case ArgumentException e:
                    logger.LogError("Houve um erro com a requisição: {e}", e);
                    _response!.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;
                case ValidationException e:
                    logger.LogError("Ocorreu um erro de validação na aplicação: {e}", e);
                    _response!.StatusCode = (int)HttpStatusCode.BadRequest;
                    _errorResult.Message = "Erros de validação:";
                    _errorResult.Details = e.Errors.Select(e => new ErrorDetail
                        { Code = e.PropertyName, Message = e.ErrorMessage });
                    break;
                case ApplicationException e:
                    logger.LogError("Ocorreu um erro Interno na aplicação : {StackTrace}", e.StackTrace);
                    _response!.StatusCode = (int)HttpStatusCode.InternalServerError;
                    break;
                case TimeoutException e:
                    logger.LogError("Ocorreu um erro de Timeout na aplicação : {StackTrace}", e.StackTrace);
                    _response!.StatusCode = (int)HttpStatusCode.InternalServerError;
                    break;
                default:
                    logger.LogError("{Message}", error?.Message);
                    _response!.StatusCode = (int) HttpStatusCode.InternalServerError;
                    break;
            }

            return Task.CompletedTask;
        }
    }
    
    

    public class ErrorDetail
    {
        public string Code { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
    }

    public class ErrorResult
    {
        public string Message { get; set; } = string.Empty;
        public IEnumerable<ErrorDetail>? Details { get; set; }
    }
}