using BurgerMarket.Domain.Enums;
using MediatR;

namespace BurgerMarket.Application.Commands.Burgers
{
    public class CreateBurgerCommand: IRequest<int>
    {
        public string Name { get; set; }
        public int BunTypeId { get; set; }
        public string SouseTypeId { get; set; }
        public int MeatTypeId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DiscountType Discount { get; set; }
    }
}