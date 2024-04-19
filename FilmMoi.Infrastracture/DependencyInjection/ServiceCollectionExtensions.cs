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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            #region DependencyInjection ReadOnly
            services.AddTransient<IGenresReadOnlyRepository, GenresReadOnlyRepository>();
            services.AddTransient<IReadOnlyRepository<FilmDto,FilmsWithPaginationRequest>, FilmsReadOnlyRepository>();

            #endregion

            #region DependencyInjection ReadWrite
            services.AddTransient<IReadWriteRepository<Genres>, GenresReadWriteRepository>();
            services.AddTransient<IReadWriteRepository<Films>, FilmsReadWriteRepository>();
            #endregion

            return services;
        }
    }
}
