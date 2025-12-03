using Microsoft.Extensions.DependencyInjection;
using Project.BLL.Managers.Abstracts;
using Project.BLL.Managers.Concretes;

namespace Project.BLL.DependencyResolvers
{
    public static class ManagerResolver
    {
        public static void AddManagerService(this IServiceCollection services)
        {
            services.AddScoped<IAuthorManager, AuthorManager>();
            services.AddScoped<IBookManager, BookManager>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<ITagManager, TagManager>();
            services.AddScoped<IBookTagManager, BookTagManager>();
        }
    }
}
