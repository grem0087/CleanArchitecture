using FluentValidation;

namespace BurgerMarket.Application.Commands.Orders.Delete
{
    public class DeleteOrderCommandValidator : AbstractValidator<DeleteOrderCommand>
    {
        public DeleteOrderCommandValidator()
        {
            RuleFor(v => v.OrderId)
                .NotNull()
                .GreaterThan(0);
        }
    }
}
