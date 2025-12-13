
namespace Project.WebApi
{
    using BLL.DependencyResolvers;
    using MapperResolvers;
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            builder.Services.AddDbContextService();
            builder.Services.AddRepositoryService();
            builder.Services.AddManagerService();
            builder.Services.AddDTOMapperService();
            builder.Services.AddVmMapperService();
            builder.Services.AddCors();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseCors(x => x.AllowAnyHeader().
                               AllowAnyMethod().
                               WithOrigins("http://localhost:4200"));

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
