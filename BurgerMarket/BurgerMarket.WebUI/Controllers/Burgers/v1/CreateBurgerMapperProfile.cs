using AutoMapper;
using BurgerMarket.Application.Commands.Burgers;

namespace BurgerMarket.WebUI.Controllers.Burgers.v1
{
    public class CreateBurgerMapperProfile : Profile
    {
        public CreateBurgerMapperProfile()
        {
            CreateMap<CreateBurgerCommand, CreateBurgerDto>()
                .ForMember(s=>s.);
        }
    }
}