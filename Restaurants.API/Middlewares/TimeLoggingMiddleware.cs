
using System.Diagnostics;

namespace Restaurants.API.Middlewares;

public class TimeLoggingMiddleware(ILogger<TimeLoggingMiddleware> logger) : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        var stopwatch = Stopwatch.StartNew();
        await next(context);

        stopwatch.Stop();
        var elapsedTime = stopwatch.Elapsed.TotalSeconds;

        if(elapsedTime > 4)
        {
            logger.LogInformation($"Total time: {elapsedTime}s. HTTP verb: {context.Request.Method}. HTTP path: {context.Request.Path}.");
        }
    }
}
