using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using MediatR;

namespace BurgerMarket.Application.Commands.Orders.Create
{
    public class CreateOrderCommand : IRequest<int>
    {
        [Required]
        [MaxLength(28)]
        public string Name { get; set; }
        public string Street { get; set; }
        
        [MaxLength(28)]
        public string City { get; set; }
        public string House { get; set; }
        
        [RegularExpression(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}", ErrorMessage = "Wrong phone number")]
        public string Phone { get; set; }
        
        
        public ICollection<OrderBurgerModel> Burgers { get; set; }
    }
}
