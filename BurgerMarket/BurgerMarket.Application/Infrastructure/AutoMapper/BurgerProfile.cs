using AutoMapper;
using BurgerMarket.Application.Commands.Burgers;
using BurgerMarket.Domain.Entities;
namespace BurgerMarket.Application.Infrastructure.AutoMapper
{
    public class BurgerProfile : Profile
    {
        public BurgerProfile()
        {
            CreateMap<CreateBurgerCommand, Domain.Entities.Burger>();
        }
    }
}