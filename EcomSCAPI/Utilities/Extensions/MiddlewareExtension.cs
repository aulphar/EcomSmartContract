using EcomSCAPI.Utilities.Middleware;

namespace EcomSCAPI.Utilities.Extensions
{
    public static class MiddlewareExtension
    {
        public static IApplicationBuilder UseExceptionMiddleware(
            this IApplicationBuilder app)
        {
            return app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
