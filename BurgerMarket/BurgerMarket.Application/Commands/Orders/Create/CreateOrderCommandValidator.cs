using System.Linq;
using FluentValidation;

namespace BurgerMarket.Application.Commands.Orders.Create
{
    public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValidator()
        {
            RuleFor(x => x.Phone).NotEmpty();
            RuleFor(x => x.Burgers.All(b => b.Quantity > 0));

            RuleFor(x => x.Phone)
                .Matches(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}")
                .WithMessage("Invalid phone number");
            
            RuleFor(x => x.Phone)
                .NotEmpty()
                .When(x=>string.IsNullOrEmpty(x.Street) || string.IsNullOrEmpty(x.House))
                .WithMessage("You should state phone or address");
        }
    }
}
