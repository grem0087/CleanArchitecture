using System;
using AutoMapper;
using BurgerMarket.Application.Commands.Burgers;
using BurgerMarket.Domain.Entities;
using BurgerMarket.Domain.Enums;

namespace BurgerMarket.Application.Infrastructure.AutoMapper
{
    using AutoMapper;
    
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<CreateBurgerCommand, Burger>()
                .ForMember( dest => dest.Description, opt => opt.MapFrom(src => src.Description) )
                .ForMember(dest => dest.Price, 
                    opt => opt.MapFrom( src  => GetPrice(src.Discount, src.Price)));
        }

        private decimal GetPrice(DiscountType discountType, decimal firstPrice)
        {
            switch (discountType)
            {
                case DiscountType.Minimal:
                    return firstPrice * 0.1m;
                
                case  DiscountType.Maximum:
                    return firstPrice * 0.5m;
                
                case  DiscountType.Avarage:
                    return firstPrice * 0.3m;
                
                default: throw new NotImplementedException($"DiscountType {discountType} unknown.");
            }
        }
    }
}