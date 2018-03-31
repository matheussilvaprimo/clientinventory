using Infra.Exceptions;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Infra.Aspnet.Middlewares
{
    public class ExceptionHandler
    {
        private readonly RequestDelegate _next;

        public ExceptionHandler(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var code = HttpStatusCode.InternalServerError;

            switch (exception)
            {
                case NotFoundException _:
                    code = HttpStatusCode.NotFound;
                    break;
                case InternalServerException _:
                    code = HttpStatusCode.InternalServerError;
                    break;
                case BusinessException _:
                    code = HttpStatusCode.Conflict;
                    break;
                default:
                    code = HttpStatusCode.InternalServerError;
                    break;
            }

            var result = JsonConvert.SerializeObject(new { error = exception.Message ?? "Internal Server Error." });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;
            return context.Response.WriteAsync(result);
        }
    }
}
