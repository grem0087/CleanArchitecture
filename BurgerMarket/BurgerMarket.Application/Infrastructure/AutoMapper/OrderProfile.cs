using AutoMapper;
using BurgerMarket.Application.Commands.Burgers;

namespace BurgerMarket.Application.Infrastructure.AutoMapper
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<CreateBurgerCommand, Domain.Entities.Burger>();
        }
    }
}