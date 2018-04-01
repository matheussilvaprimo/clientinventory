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
            }

            var ret = exception.Data.Count > 0 ?
                new
                {
                    error_code = exception.Data[Constants.ErrorCode].ToString(),
                    message = exception?.Data[Constants.ErrorMessage].ToString() ?? Constants.DefaultInternalErrorMessage
                } : new
                {
                    error_code = "1",
                    message = Constants.DefaultInternalErrorMessage
                };

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;

            return context.Response.WriteAsync(JsonConvert.SerializeObject(ret));
        }
    }
}
