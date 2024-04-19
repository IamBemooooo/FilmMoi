using FilmMoi.Application.DataTransferObj.Films;
using FilmMoi.Application.Interface.ReadOnly;
using FilmMoi.Application.Interface.ReadWrite;
using FilmMoi.Domain.Models;
using FilmMoi.Domain.Models.Entities;
using FilmMoi.Infrastracture.Implement.Repository.ReadOnly;
using FilmMoi.Infrastracture.Implement.Repository.ReadWrite;
using FilmMoi.Infrastructure.Implement.Repository.ReadOnly;
using FilmMoi.Infrastructure.Implement.Repository.ReadWrite;
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
            services.AddTransient<IGenresReadOnlyRepository, GenresReadOnlyRepository>();//required
            services.AddTransient<IReadWriteRepository<Genres>, GenresReadWriteRepository>();//required
            services.AddTransient<IActorsReadOnlyrepository, ActorsReadOnlyRepository>();//required
            services.AddTransient<IReadWriteRepository<Actors>, ActorsReadWriteRepository>();//required
            services.AddTransient<IReadWriteRepository<Films>, FilmsReadWriteRepository>();//required
            services.AddTransient<IReadOnlyRepository<FilmDto,FilmsWithPaginationRequest>, FilmsReadOnlyRepository>();//required
            return services;
        }
    }
}
