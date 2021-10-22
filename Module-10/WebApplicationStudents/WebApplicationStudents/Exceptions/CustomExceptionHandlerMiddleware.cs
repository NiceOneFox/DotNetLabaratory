using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Text.Json;
using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace WebApplicationStudents.Exceptions
{
    public class CustomExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomExceptionHandlerMiddleware(RequestDelegate next) =>
            _next = next;

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

        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var statusCode = HttpStatusCode.InternalServerError;
            var result = string.Empty;

            switch (ex)
            {
                case ValidationException validationException:
                    statusCode = HttpStatusCode.BadRequest;
                    result = JsonSerializer.Serialize(validationException.Errors);
                    break;

                case IndexLessThanZeroException lessThanZeroException:
                    statusCode = HttpStatusCode.BadRequest;
                    result = JsonSerializer.Serialize(lessThanZeroException.Message);
                    break;

                default:
                    statusCode = HttpStatusCode.NotFound;
                    break;

            }
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;

            if (result == string.Empty)
            {
                result = JsonSerializer.Serialize(new { error = ex.Message });
            }
            return context.Response.WriteAsync(result);
        }
    }
}
