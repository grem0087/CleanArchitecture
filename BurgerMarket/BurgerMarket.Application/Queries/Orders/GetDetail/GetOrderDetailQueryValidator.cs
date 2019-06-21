using FluentValidation;

namespace BurgerMarket.Application.Queries.Orders.GetDetail
{
    public class GetOrderDetailQueryValidator : AbstractValidator<GetOrderDetailQuery>
    {
        public GetOrderDetailQueryValidator()
        {
            RuleFor(v => v.OrderId)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
