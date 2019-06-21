using System.Reflection;
using BurgerMarket.Application.Infrastructure;
using BurgerMarket.Application.Interfaces;
using BurgerMarket.Application.Queries.Burgers.Get;
using BurgerMarket.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BurgerMarket.WebUI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMediator(this IServiceCollection services) =>
            services
                .AddMediatR(typeof(GetBurgerQueryHandler).GetTypeInfo().Assembly)
                .AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestLoggerBehaviour<,>))
                .AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
        
        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<IBurgerMarketDbContext, BurgerMarketDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("BurgerMarketDatabase")));
    }
}