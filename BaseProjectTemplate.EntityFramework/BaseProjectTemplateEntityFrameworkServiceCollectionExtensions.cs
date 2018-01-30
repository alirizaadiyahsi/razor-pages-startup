using BaseProjectTemplate.EntityFramework.Uow;
using Microsoft.Extensions.DependencyInjection;

namespace BaseProjectTemplate.EntityFramework
{
    public static class BaseProjectTemplateEntityFrameworkServiceCollectionExtensions
    {
        public static IServiceCollection AddBaseProjectTemplateEntityFramework(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}