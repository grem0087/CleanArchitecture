using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BurgerMarket.Domain.ValueObjects;

namespace BurgerMarket.Domain.Entities
{
    public class Order
    {
        public Order()
        {
            Products = new HashSet<OrderProduct>();
        }
        
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        
        [MaxLength(256)]
        [Column(TypeName = "nvarchar(24)")]
        public string Descriptions { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; }

        public Address Address { get; set; }
        public Customer Customer { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        
        public ICollection<OrderProduct> Products { get; private set; }
        
        public decimal TotalPrice { get; set; }
    }
}
