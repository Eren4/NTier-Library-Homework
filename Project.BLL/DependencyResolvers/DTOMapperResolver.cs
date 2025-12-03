using Microsoft.Extensions.DependencyInjection;
using Project.BLL.MappingProfiles;

namespace Project.BLL.DependencyResolvers
{
    public static class DTOMapperResolver
    {
        public static void AddDTOMapperService(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DTOMappingProfile));
        }
    }
}
