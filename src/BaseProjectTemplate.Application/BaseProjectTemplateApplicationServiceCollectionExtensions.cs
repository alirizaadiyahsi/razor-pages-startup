using BaseProjectTemplate.Application.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace BaseProjectTemplate.Application
{
    public static class BaseProjectTemplateApplicationServiceCollectionExtensions
    {
        public static IServiceCollection AddBaseProjectTemplateApplication(this IServiceCollection services)
        {
            services.AddTransient<IEmailService, EmailService>();

            return services;
        }
    }
}
