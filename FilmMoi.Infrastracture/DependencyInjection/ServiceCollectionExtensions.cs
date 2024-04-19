using FilmMoi.Application.Interface.ReadOnly;
using FilmMoi.Application.Interface.ReadWrite;
using FilmMoi.Domain.Models;
using FilmMoi.Domain.Models.Entities;
using FilmMoi.Infrastracture.Implement.Repository.ReadOnly;
using FilmMoi.Infrastracture.Implement.Repository.ReadWrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilmMoi.Infrastracture.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEventBus(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FlimMoiContext>(options =>
            {
                // Configure your DbContext options here
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            //services.AddTransient<ILocalizationService, LocalizationService>();
            //services.AddTransient<IUserReadOnlyRepoisitory, UserReadOnlyRepoisitory>();
            //services.AddTransient<IUserReadWriteRepoisitory, UserReadWriteRepoisitory>();
            //services.AddTransient<IExampleReadOnlyRepository, ExampleReadOnlyRepository>();
            //services.AddTransient<IExampleReadWriteRepository, ExampleReadWriteRepository>();
            services.AddTransient<IGenresReadOnlyRepository, GenresReadOnlyRepository>();//required
            services.AddTransient<IReadWriteRepository<Genres>, GenresReadWriteRepository>();//required
            services.AddTransient<IActorsReadOnlyRepository, ActorsReadOnlyRepository>();//required
            services.AddTransient<IReadWriteRepository<Actors>, ActorsReadWriteRepository>();//required
            return services;
        }
    }
}
