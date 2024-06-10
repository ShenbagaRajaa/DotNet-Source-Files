using Microsoft.AspNetCore.Builder;

using Microsoft.AspNetCore.Http;

using Microsoft.Extensions.Logging;

using System.Threading.Tasks;

namespace TypeWrittingBack;

public class ListCSharpCornerArticles
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Category { get; set; }
}

// public class RequestLoggingMiddleware
// {
//     private readonly RequestDelegate _next;
//     private readonly ILogger<RequestLoggingMiddleware> _logger;

//     public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
//     {
//         _next = next;
//         _logger = logger;
//     }

//     public async Task Invoke(HttpContext context)
//     {
//         _logger.LogInformation($"Request: {context.Request.Method} {context.Request.Path}");
//         await _next(context);
//     }
// }