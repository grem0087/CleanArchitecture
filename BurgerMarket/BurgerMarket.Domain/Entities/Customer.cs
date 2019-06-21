using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BurgerMarket.Domain.ValueObjects;

namespace BurgerMarket.Domain.Entities
{
    public class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        public string Id { get; set; }
        
        [Required]
        [MaxLength(28)]
        public string Name { get; set; }
        
        public Address Address { get; set; }
        public string Phone { get; set; }

        public ICollection<Order> Orders { get; private set; }
    }
}
