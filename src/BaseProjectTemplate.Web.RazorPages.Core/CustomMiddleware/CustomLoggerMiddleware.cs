using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace BaseProjectTemplate.Web.Core.CustomMiddleware
{
    /// <summary>
    /// A custom Exception Handler Middleware.
    /// </summary>
    public sealed class BaseProjectTemplateExceptionHandler
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public BaseProjectTemplateExceptionHandler(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<BaseProjectTemplateExceptionHandler>();
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.GetType().Name);
                throw;
            }
        }
    }
}