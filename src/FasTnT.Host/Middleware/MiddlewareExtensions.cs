﻿using Microsoft.AspNetCore.Builder;

namespace FasTnT.Host.Middleware
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionHandlingMiddleware(this IApplicationBuilder builder, bool isDevelopment = false) => builder.UseMiddleware<ExceptionHandlingMiddleware>(isDevelopment);
        public static IApplicationBuilder UseOkStatusCode(this IApplicationBuilder builder) => builder.UseMiddleware<HttpStatusCodeHandlingMiddleware>();
        public static IApplicationBuilder UseHttpSynchronousIO(this IApplicationBuilder builder) => builder.UseMiddleware<HttpSynchronousIOMiddleware>();
        public static IApplicationBuilder UseRequestBodyLogger(this IApplicationBuilder builder) => builder.UseMiddleware<HttpRequestBodyLoggerMiddleware>();
    }
}
