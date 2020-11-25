using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieAPI.DAL.Interfaces;
using MovieAPI.DAL.Repository;
using MovieAPI.DAL.TopTests.DAL;
using MovieAPI.Services.Interfaces;
using MovieAPI.Services.Mapper;
using MovieAPI.Services.Models;
using MovieAPI.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.StartupExtensions
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, string connectionString)
        {
            return services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString)
            .EnableSensitiveDataLogging());
        }
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<iCommentRepository, CommentRepository>();
            services.AddScoped<IMovieRepository, MovieRepository>();
            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IMoviesService, MovieService>();
            services.AddScoped<ICommentService, CommentService>();
            return services;
        }
        public static IServiceCollection AddMappingServices(this IServiceCollection services)
        {
            return services
                .AddSingleton<Profile, MoviesProfile>()
                .AddSingleton<Profile, CommentProfile>()
                .AddSingleton<IConfigurationProvider, AutoMapperConfiguration>(p =>
                    new AutoMapperConfiguration(p.GetServices<Profile>()))
                .AddSingleton<IMapper, Mapper>();
        }
    }
}
